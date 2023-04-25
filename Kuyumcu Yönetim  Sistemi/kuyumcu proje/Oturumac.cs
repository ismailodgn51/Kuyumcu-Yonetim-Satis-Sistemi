using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kuyumcu_proje
{
    public partial class oturumac : Form
    {
        public oturumac()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if (Sifre.Text == "" || Kadi.Text == "")
            {
                MessageBox.Show("Kulanici adi ve Sifrenizi girin");
            }
           
            else if (Kadi.Text == "Admin" && Sifre.Text == "123" )
            {
                Urunler Urn = new Urunler();
                Urn.Show();
                this.Hide();
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Fatura ftr = new Fatura();
            ftr.Show();
            this.Hide();

        }

        private void Sifre_TextChanged(object sender, EventArgs e)
        {
            Sifre.UseSystemPasswordChar = true;
        }
    }
}
