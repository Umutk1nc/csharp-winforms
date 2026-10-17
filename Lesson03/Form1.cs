namespace Lesson03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            char operation = Convert.ToChar(comboBox1.SelectedItem);
            double result = 0;
            if (!int.TryParse(maskedTextBox1.Text, out int firstNumber) ||!int.TryParse(maskedTextBox2.Text, out int secondNumber))
            {
                MessageBox.Show("Enter both numbers.");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Select an operation.");
                return;
            }
            if (operation == '+')
            {
                result=sum(firstNumber, secondNumber);
            }
            else if (operation == '-')
            {
                result=difference(firstNumber, secondNumber);
            }
            else if (operation == '*')
            {
                result=product(firstNumber, secondNumber);
            }
            else if (operation == '/')
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("Cannot divide by zero.");
                    return;
                }
                else
                {
                    result=divide(firstNumber, secondNumber);
                }

            }
            listBox1.Items.Add($"{firstNumber} {operation} {secondNumber} = {result}");
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int sum(int number1, int number2) { return number1 + number2; }
        int difference(int number1, int number2) { return number1 - number2; }

        int product(int number1, int number2) { return number1 * number2; }
        double divide(int number1, int number2) { return (double)number1 / number2; }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void resultGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
