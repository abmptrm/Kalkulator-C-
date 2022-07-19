using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelajarGui_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 Dan Angka 2 Harus Di Isi Terlebih Dahulu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 Dan Angka 2 Harus Di Isi Terlebih Dahulu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int a, b, c;
            a = int.Parse(this.textBox1.Text);
            b = int.Parse(this.textBox2.Text);
            c = a + b;
            this.label5.Text = Convert.ToDecimal(c).ToString("#,##0,00");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 Dan Angka 2 Harus Di Isi Terlebih Dahulu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int a, b, c;
            a = int.Parse(this.textBox1.Text);
            b = int.Parse(this.textBox2.Text);
            c = a * b;
            this.label5.Text = Convert.ToDecimal(c).ToString("#,##0,00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 Dan Angka 2 Harus Di Isi Terlebih Dahulu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int a, b, c;
            a = int.Parse(this.textBox1.Text);
            b = int.Parse(this.textBox2.Text);
            c = a - b;
            this.label5.Text = Convert.ToDecimal(c).ToString("#,##0,00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 Dan Angka 2 Harus Di Isi Terlebih Dahulu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int a, b, c;
            a = int.Parse(this.textBox1.Text);
            b = int.Parse(this.textBox2.Text);
            c = a / b;
            this.label5.Text = Convert.ToDecimal(c).ToString("#,##0,00");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 Dan Angka 2 Harus Di Isi Terlebih Dahulu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
        
            int a, b, c;
            a = int.Parse(this.textBox1.Text);
            b = int.Parse(this.textBox2.Text);
            c = a % b;
            this.label5.Text = Convert.ToDecimal(c).ToString("#,##0,00");
        }
    }
    
}
