using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_PBKK
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

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(
                  "Nilai tidak boleh kosong!",
                  "Error",
                  MessageBoxButtons.OK
                );
            }
            else
            {
                double nilai1 = double.Parse(textBox1.Text);
                double nilai2 = double.Parse(textBox2.Text);
                double hasil;
                hasil = nilai1 + nilai2;
                textBox3.Text = hasil.ToString();
            }

        }

        private void substact_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(
                  "Nilai tidak boleh kosong!",
                  "Error",
                  MessageBoxButtons.OK
                );
            }
            else
            {
                double nilai1 = double.Parse(textBox1.Text);
                double nilai2 = double.Parse(textBox2.Text);
                double hasil;
                hasil = nilai1 - nilai2;
                textBox3.Text = hasil.ToString();
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(
                  "Nilai tidak boleh kosong!",
                  "Error",
                  MessageBoxButtons.OK
                );
            }
            else
            {
                double nilai1 = double.Parse(textBox1.Text);
                double nilai2 = double.Parse(textBox2.Text);
                double hasil;
                hasil = nilai1 * nilai2;
                textBox3.Text = hasil.ToString();
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(
                  "Nilai tidak boleh kosong!",
                  "Error",
                  MessageBoxButtons.OK
                );
            }
            else
            {
                double nilai1 = double.Parse(textBox1.Text);
                double nilai2 = double.Parse(textBox2.Text);
                double hasil;
                hasil = nilai1 / nilai2;
                textBox3.Text = hasil.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
