namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFactorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        public int RecursiveFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            int a = 0, b = 1, fib = 0;

            for (int i = 2; i <= n; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
            }
            return b;
        }

        public double RecursivePower(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return x * RecursivePower(x, n - 1);
            }
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial: {result}";
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFibonacciInput.Text, out int n) && n >= 0)
            {
                int result = RecursiveFibonacci(n);
                lblFibonacciResult.Text = $"Fibonacci({n}): {result}";
            }
            else
            {
                MessageBox.Show("Please enter a non-negative integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {

            double baseValue = double.Parse(txtBaseInput.Text);
            int exponent = int.Parse(txtExponentInput.Text);
            double result = RecursivePower(baseValue, exponent);
            lblPowerResult.Text = $"{baseValue}^{exponent}: {result}";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
