namespace Practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = num1 + num2;
            label3.Text = "Sum = " + sum;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int num2 = int.Parse(this.num2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}