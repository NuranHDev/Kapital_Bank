namespace Kapital_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pin = { 9900, 7788, 6677, 4455 };

            int input = Convert.ToInt16(textBox1.Text);
            if (input == pin[0])
            {
                Form2 next = new Form2();
                next.Show();

            }
            else
            {
                label5.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}