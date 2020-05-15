using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_Semester2
{
    public partial class Form5 : Form
    {
        double harga;
        double x;
        double total;
        public Form5()
        {
            InitializeComponent();
        }

        private void btnM_CheckedChanged(object sender, EventArgs e)
        {
            harga = 180000;
            textBox1.Text = harga.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnL_CheckedChanged(object sender, EventArgs e)
        {
            harga = 185000;
            textBox1.Text = harga.ToString();
        }

        private void btnXL_CheckedChanged(object sender, EventArgs e)
        {
            harga = 190000;
            textBox1.Text = harga.ToString();
        }

        private void btnXXL_CheckedChanged(object sender, EventArgs e)
        {
            harga = 195000;
            textBox1.Text = harga.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.SetValueForText2 == "Jabodetabek")
            {
                x = 10000;
                total = harga + x;
                MessageBox.Show("Pesanan Anda Berhasil" + "\n Atas nama : " + Form1.SetValueForText1 + "\nArea :" + Form1.SetValueForText2 + "\n Harga :" + total + "\n Akan sampai : 3 hari lagi");
            
            }
            else if (Form1.SetValueForText2 == "Luar Jabodetabek")
            {
                x = 35000;
                total = harga + x;
                MessageBox.Show("Pesanan Anda Berhasil" + "\n Atas nama : " + Form1.SetValueForText1 + "\nArea :" + Form1.SetValueForText2 + "\n Harga :" + total + "\n Akan sampai : 7 hari lagi");
            }

            MessageBox.Show("Pesanan Anda Berhasil" + "\n Atas nama : " + Form1.SetValueForText1 + "\nArea :" + Form1.SetValueForText2 + "\n Harga :" + total);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
