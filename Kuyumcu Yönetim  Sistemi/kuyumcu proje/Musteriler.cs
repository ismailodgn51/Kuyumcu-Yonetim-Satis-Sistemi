using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kuyumcu_proje
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
            Doldur();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Urunler Urn = new Urunler();
            Urn.Show();
            this.Hide();
        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-EH0A9L2\SQLEXPRESS;Initial Catalog=KuyumcuSistemi;Integrated Security=True");
        private void Doldur()
        {
            baglanti.Open();

            string sorgu = "select * from Tbl_Musteri";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
            SqlCommandBuilder olustur = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MusteriDGW.DataSource = ds.Tables[0];
            baglanti.Close();



        }
        private void Reset()
        {
            musteriid.Text = "";
            MusAdi.Text = ""; 
            MusTelefon.Text = "";
            Adress.Text = "";

        }

        private void KaydetM_Click(object sender, EventArgs e)
        {
            if (MusAdi.Text == "" || MusTelefon.Text == "" || Adress.Text =="")
            {
                MessageBox.Show("HEPSİNİ DOLDURUNUZ");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "insert into Tbl_Musteri values('" + MusAdi.Text + "','" + MusTelefon.Text + "','" + Adress.Text + "')";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Musteri Kayıt Edildi");
                    baglanti.Close();
                    Doldur();
                    Reset();
                }
                catch (Exception a)
                {

                    MessageBox.Show(a.Message);
                }
            }
        }

        private void SIFIRLAM_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void MusteriDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = MusteriDGW.SelectedCells[0].RowIndex;
            musteriid.Text = MusteriDGW.Rows[secilen].Cells[0].Value.ToString();
            MusAdi.Text = MusteriDGW.Rows[secilen].Cells[1].Value.ToString();
            MusTelefon.Text = MusteriDGW.Rows[secilen].Cells[2].Value.ToString();
            Adress.Text = MusteriDGW.Rows[secilen].Cells[3].Value.ToString();
            
        }

        private void SILM_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from  Tbl_Musteri where Musteriid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", musteriid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müsteri silindi");
            Doldur();
            Reset();
        }

        private void GUNCELLEM_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Musteri set MusteriAd=@a1,MusteriPhone=@a2,MusteriAdres=@a3", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", MusAdi.Text);
            komutguncelle.Parameters.AddWithValue("@a2", MusTelefon.Text);
            komutguncelle.Parameters.AddWithValue("@a3", Adress.Text);
           
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Musteri guncel  Edildi");
            Doldur();
            Reset();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            oturumac FTR = new oturumac();
            FTR.Show();
            this.Hide();
        }
    }
}
