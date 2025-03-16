using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public async Task<List<string>> GetBooksAsync()
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author)
                    .Select(b => $"{b.BookID}: {b.Title} by {b.Author.Name}")
                    .ToListAsync();

                return books;
            }
        }

        public async Task<bool> UpdateBookAndAuthorAsync(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books
                    .Include(b => b.Author)
                    .FirstOrDefaultAsync(b => b.BookID == bookId);

                if (book == null) return false;

                book.Title = newTitle;
                book.Author.Name = newAuthorName;
                return await context.SaveChangesAsync() > 0;
            }
        }

        public async Task<bool> DeleteBookAsync(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FindAsync(bookId);
                if (book == null) return false;

                context.Books.Remove(book);
                return await context.SaveChangesAsync() > 0;
            }
        }

        public async Task<List<string>> SearchBooksByTitleAsync(string title)
        {
            using (var context = new BookstoreContext())
            {
                return await context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.Contains(title))
                    .Select(b => $"{b.BookID}: {b.Title} by {b.Author.Name}")
                    .ToListAsync();
            }
        }

        private void ClearTextBoxes()
        {
            txtAuthorName.Clear();
            txtBookTitle.Clear();
            txtBookID.Clear();
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var books = await GetBooksAsync();

            ListBoxBooks.DataSource = books;
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);

                await context.SaveChangesAsync();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(bookTitle, authorName);

            MessageBox.Show("Book and Author saved successfully!");
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid numeric Book ID");
                return;
            }

            var newTitle = txtBookTitle.Text;
            var newAuthorName = txtAuthorName.Text;

            var updated = await UpdateBookAndAuthorAsync(bookId, newTitle, newAuthorName);
            if (updated)
            {
                MessageBox.Show("Book updated successfully!");
                ClearTextBoxes();
                var updatedBooks = await GetBooksAsync();
                ListBoxBooks.DataSource = null;
                ListBoxBooks.DataSource = updatedBooks;
            }
            else
            {
                MessageBox.Show("No book found with ID: " + bookId);
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid numeric Book ID");
                return;
            }

            var deleted = await DeleteBookAsync(bookId);
            if (deleted)
            {
                MessageBox.Show("Book deleted successfully!");
                ClearTextBoxes();
                var updatedBooks = await GetBooksAsync();
                ListBoxBooks.DataSource = null;
                ListBoxBooks.DataSource = updatedBooks;
            }
            else
            {
                MessageBox.Show("No book found with ID: " + bookId);
            }
        }

        private async void btnSearchBook_Click(object sender, EventArgs e)
        {
            var title = txtBookTitle.Text;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter the book title to search.");
                return;
            }

            var booksWithAuthors = await SearchBooksByTitleAsync(title);
            if (booksWithAuthors.Any())
            {
                ListBoxBooks.DataSource = booksWithAuthors;
            }
            else
            {
                MessageBox.Show("No books found for the specified title.");
                ListBoxBooks.DataSource = null;
            }
        }
    }
}
