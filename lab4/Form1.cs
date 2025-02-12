using lab4.Domain;

namespace lab4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine()
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };
            MessageBox.Show(myBook.GetInfo());
        }
        private void buttonShowBookList_Click(object sender, EventArgs e)
        {
            Book[] books = {
               new Magazine() { Title = "Sports Illustrated", Author = "Editorial Board", IssueNumber = 98 },
                new Ebook() { Title = "Digital Marketing 101", Author = "Lisa Green"},
                new TextBook() { Title = "Software Design", Author = "Andrew Bell", Subject = "Computer Science" },
                new Audiobook() { Title = "The Art of War", Author = "Sun Tzu", Narrator = "Morgan Freeman", Duration = 200 }
            };

            listBox1.Items.Clear();
            foreach (var book in books)
            {
                listBox1.Items.Add(book.GetInfo());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
