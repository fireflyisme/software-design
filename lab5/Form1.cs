using Microsoft.EntityFrameworkCore;
using System;

namespace lab5
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

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(book => book.Author)
                    .Select(book => $"{book.Title} by {book.Author.Name} - Id: {book.BookID}")
                    .ToList();

                return booksWithAuthors;
            }
        }

        public bool UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books
                    .Include(b => b.Author)
                    .FirstOrDefault(b => b.BookID == bookId);

                if (book == null) return false;

                book.Title = newTitle;
                book.Author.Name = newAuthorName;
                return context.SaveChanges() > 0;
            }
        }

        public bool DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book == null) return false;

                context.Books.Remove(book);
                return context.SaveChanges() > 0;
            }
        }

        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Select(b => $"{b.Title} by {b.Author.Name} - Id: {b.BookID}")
                    .ToList();
            }
        }

        private void ClearTextBoxes()
        {
            txtAuthorName.Clear();
            txtBookTitle.Clear();
            txtBookID.Clear();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text;
            string bookTitle = txtBookTitle.Text;

            if (string.IsNullOrWhiteSpace(authorName) || string.IsNullOrWhiteSpace(bookTitle))
            {
                MessageBox.Show("Please enter both the author's name and the book title.");
                return;
            }

            try
            {
                AddAuthorWithBook(authorName, bookTitle);
                MessageBox.Show("Book added successfully!");
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Error: {ex.InnerException.Message}";
                }
                MessageBox.Show(errorMessage);
            }
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books_authors = GetBooksWithAuthors();
            listBoxBooks.DataSource = books_authors;
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid numeric Book ID");
                return;
            }

            try
            {
                bool updated = UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
                if (updated)
                {
                    MessageBox.Show("Book updated successfully!");
                    ClearTextBoxes();
                    var updatedBooks = GetBooksWithAuthors();
                    listBoxBooks.DataSource = null;
                    listBoxBooks.DataSource = updatedBooks;
                }
                else
                {
                    MessageBox.Show("No book found with ID: " + bookId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid numeric Book ID");
                return;
            }

            try
            {
                bool deleted = DeleteBook(bookId);
                if (deleted)
                {
                    MessageBox.Show("Book deleted successfully!");
                    ClearTextBoxes();
                    // Force refresh the list
                    var updatedBooks = GetBooksWithAuthors();
                    listBoxBooks.DataSource = null;
                    listBoxBooks.DataSource = updatedBooks;
                }
                else
                {
                    MessageBox.Show("No book found with ID: " + bookId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text;

            if (string.IsNullOrWhiteSpace(authorName))
            {
                MessageBox.Show("Please enter the author's name to search.");
                return;
            }

            try
            {
                var booksWithAuthors = SearchBooksByAuthor(authorName);
                if (booksWithAuthors.Any())
                {
                    listBoxBooks.DataSource = booksWithAuthors;
                }
                else
                {
                    MessageBox.Show("No books found for the specified author.");
                    listBoxBooks.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching books: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }
    }
}
