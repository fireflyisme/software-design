namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public string? Title { get; set; }
            public string? Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }
        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title}\t\tby {Author}\t   Issue: {IssueNumber}\n";

            }
        }
        public class Ebook : Book
        {
            public string? Platform { get; set; }
            public override string GetInfo()
            {
                return $"{Title}\tby {Author}\t   Platform: {Platform}\n";
            }
        }
        public class TextBook : Book
        {
            public string? Subject { get; set; }
            public override string GetInfo()
            {
                return $"{Title}\t\tby {Author}\t   Subject: {Subject}\n";
            }
        }
        public class Audiobook : Book
        {
            public string? Narrator { get; set; }
            public int Duration { get; set; }
            public override string GetInfo()
            {
                return $"{Title}\t\tby: {Narrator}\t   Duration: {Duration} minutes\n";
            }
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
                new Ebook() { Title = "Digital Marketing 101", Author = "Lisa Green", Platform = "Google Books" },
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
