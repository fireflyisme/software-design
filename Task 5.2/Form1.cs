namespace Task_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 3, 1, 4, 2 };

            listBoxResults.Items.Clear();
            listBoxResults.Items.Add("Original array:");
            PrintArray(numbers);
            BubbleSortDescending(numbers);
            listBoxResults.Items.Add("Sorted array in descending order:");
            PrintArray(numbers);
        }

        private void BubbleSortDescending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        private void PrintArray(int[] arr)
        {
            foreach (int number in arr)
            {
                listBoxResults.Items.Add(number);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
