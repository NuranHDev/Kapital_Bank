using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapital_Bank
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        decimal balans = 100;

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 back = new Form2();
            back.ShowDialog();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = $"Balans:{balans.ToString()}  AZN";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            decimal mebleg = Convert.ToDecimal(textBox1.Text);
            if (mebleg > balans)
            {
                label5.Text = "Balansınızda kifayət qədər məbləğ yoxdur";
            }
            else
            {
                balans = balans - mebleg;
                label5.Text = "Əməliyyat uğurla icra olundu";
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
