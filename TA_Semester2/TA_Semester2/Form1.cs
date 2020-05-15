using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_Semester2
{
    public partial class Form1 : Form
    {
        private Form activeform;
        public static string SetValueForText1 = " ";
        public static string SetValueForText2 = " ";
        
        public Form1()
        {
            InitializeComponent();
            customizedesign();

        }
        private void customizedesign()
        {
            pnlPria.Visible = false;
            pnlWanita.Visible = false;
        }

        private void hidesubmenu()
        {
            if (pnlPria.Visible == true)
                pnlPria.Visible = false;
            if (pnlWanita.Visible == true)
                pnlWanita.Visible = false;
        }

        private void showmenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hidesubmenu();
                menu.Visible = true;
            }
            else menu.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            activeform.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPria_Click(object sender, EventArgs e)
        {
            showmenu(pnlPria);
        }

        private void btnWanita_Click(object sender, EventArgs e)
        {
            showmenu(pnlWanita);
        }

        private void btnJaketPria_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            openchildform(new Form2());
        }

        private void btnBajuPria_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            openchildform(new Form3());
        }

        private void btnJaketWanita_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            openchildform(new Form5());
        }

        private void btnBajuWanita_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            openchildform(new Form4());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            openchildform(new Form6());

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel3.Controls.Add(childform);
            panel3.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            if (comboBox1.Text == "Jabodetabek") 
            {
                SetValueForText2 = comboBox1.Text;
                MessageBox.Show("Pilihan Anda Berhasil Direkam");
            }
            else if (comboBox1.Text == "Luar Jabodetabek" )
            {
                SetValueForText2 = comboBox1.Text;
                MessageBox.Show("Pilihan Anda Berhasil Direkam");
            }
            else
            {
                MessageBox.Show("Mohon Pilih SALAH SATU");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Mohon Untuk Memasukan Huruf Saja");
               
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
