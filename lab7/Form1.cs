using Microsoft.EntityFrameworkCore;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int pageSize = 10;
        private int currentPage = 1;

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

        public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .OrderBy(b => b.BookID)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();

                return books;
            }
        }

        public async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Authors.Add(author);
                    context.Books.Add(book);

                    await context.SaveChangesAsync();

                    MessageBox.Show("Book and Author saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public async Task ExportBooksAsync(string filePath)
        {
            var books = await GetBooksByPageAsync(currentPage);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book);
                }
            }
        }

        private async Task ImportBooksAsync(List<Book> books)
        {
            using (var context = new BookstoreContext())
            {
                try
                {
                    foreach (var book in books)
                    {
                        await context.Authors.AddAsync(book.Author);
                        await context.Books.AddAsync(book);
                        await context.SaveChangesAsync();
                    }
                    MessageBox.Show("Books imported successfuly!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}");
                }
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

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                var books = await GetBooksByPageAsync(currentPage);
                listBoxBooks.DataSource = books;
                lblPageNumber.Text = $"Page {currentPage}";
            }

        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookWithHandlingAsync(bookTitle, authorName);
        }

        private async void btnExportBooks_Click(object sender, EventArgs e)
        {

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Save Book List"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBooksAsync(filePath);
                MessageBox.Show("Books exported successfully!");
            }

        }


        private async void btnImportBooks_Click(object sender, EventArgs e)
        {
            var books = new List<Book>();
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Import Book List"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    var line = string.Empty;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        var elements = line.Split(" by ");
                        var newAuthor = new Author()
                        {
                            Name = elements[1]
                        };
                        var newBook = new Book()
                        {
                            Title = elements[0],
                            Author = newAuthor
                        };
                        books.Add(newBook);
                    }
                    await ImportBooksAsync(books);
                }
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
                listBoxBooks.DataSource = booksWithAuthors;
            }
            else
            {
                MessageBox.Show("No books found for the specified title.");
                listBoxBooks.DataSource = null;
            }

        }
    }
}
