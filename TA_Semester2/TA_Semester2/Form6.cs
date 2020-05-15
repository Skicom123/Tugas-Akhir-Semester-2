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
    public partial class Form6 : Form
    {
        double harga;
        double x;
        double total;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.SetValueForText2 == "Jabodetabek")
            {
                harga = 50000;
                x = 10000;
                total = harga + x;
                MessageBox.Show("Pesanan Anda Berhasil" + "\n Atas nama : " + Form1.SetValueForText1 + "\nArea :" + Form1.SetValueForText2 + "\n Harga :" + total + "\n Akan sampai : 3 hari lagi");
            }
            else if (Form1.SetValueForText2 == "Luar Jabodetabek")
            {
                harga = 50000;
                x = 35000;
                total = harga + x;
                MessageBox.Show("Pesanan Anda Berhasil" + "\n Atas nama : " + Form1.SetValueForText1 + "\nArea :" + Form1.SetValueForText2 + "\n Harga :" + total + "\n Akan sampai: 7 hari lagi");
            }

        }
    }
}
