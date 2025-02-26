namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0, result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            num1 = Double.Parse(text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            num2 = Double.Parse(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = num1 + num2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = num1 - num2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = num1 * num2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num2 != 0) result = num1 / num2;
            else MessageBox.Show("被除数不应为0");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"计算结果为{result}");
        }
    }
}
