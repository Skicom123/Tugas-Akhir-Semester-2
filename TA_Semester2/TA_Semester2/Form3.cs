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
    public partial class Form3 : Form
    {

        double harga;
        double x;
        double total;
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            harga = 160000;
            textBox1.Text = harga.ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            harga = 170000;
            textBox1.Text = harga.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            harga = 175000;
            textBox1.Text = harga.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            harga = 180000;
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

        }
    }
}
