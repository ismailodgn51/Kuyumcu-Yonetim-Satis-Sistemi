using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;


namespace kuyumcu_proje
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
            Doldur();
        }
        


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-EH0A9L2\SQLEXPRESS;Initial Catalog=KuyumcuSistemi;Integrated Security=True");
        private void Doldur()
            {
            baglanti.Open();

            string sorgu = "select * from Tbl_Urun";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
            SqlCommandBuilder olustur = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UrunDGW.DataSource = ds.Tables[0];
            baglanti.Close();
            
                
                
                }
        private void Filtrekatagori()
        {
            baglanti.Open();

            string sorgu = "select * from Tbl_Urun where UrunKatagori='" + katfiltre.SelectedItem.ToString() + "'" ;
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
            SqlCommandBuilder olustur = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UrunDGW.DataSource = ds.Tables[0];
            baglanti.Close();



        }
        private void Filtretur()
        {
            baglanti.Open();

            string sorgu = "select * from Tbl_Urun where UrunTur='" + turfiltre.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
            SqlCommandBuilder olustur = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UrunDGW.DataSource = ds.Tables[0];
            baglanti.Close();



        }


        private void Ukaydet_Click(object sender, EventArgs e)
        {
            if (EsyaAdi.Text == "" || FIYAT.Text == "" || MIKTAR.Text == "" || KatagoriAdi.SelectedIndex == -1 || TurAdi.SelectedIndex == -1) 
            {
                MessageBox.Show("HEPSİNİ DOLDURUNUZ");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "insert into Tbl_Urun values('" + EsyaAdi.Text + "','" + KatagoriAdi.SelectedItem.ToString() + "','" + TurAdi.SelectedItem.ToString() + "'," + FIYAT.Text + "," + MIKTAR.Text + ")";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Urun Kayıt Edildi");
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

        
        private void UrunDGW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = UrunDGW.SelectedCells[0].RowIndex;
            urunid.Text= UrunDGW.Rows[secilen].Cells[0].Value.ToString();
            EsyaAdi.Text = UrunDGW.Rows[secilen].Cells[1].Value.ToString();
            KatagoriAdi.SelectedItem = UrunDGW.Rows[secilen].Cells[2].Value.ToString();
            TurAdi.SelectedItem = UrunDGW.Rows[secilen].Cells[3].Value.ToString();
            FIYAT.Text = UrunDGW.Rows[secilen].Cells[4].Value.ToString();
            MIKTAR.Text = UrunDGW.Rows[secilen].Cells[5].Value.ToString();
            
            
        }
       
        private void Reset()
        {
            urunid.Text = "";
            EsyaAdi.Text = "";
            KatagoriAdi.SelectedIndex = -1;
            TurAdi.SelectedIndex = -1;
            FIYAT.Text = "";
            MIKTAR.Text = "";
            
        }

        private void Usifirla_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Usil_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from  Tbl_Urun where Urunid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", urunid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Urun silindi");
            Doldur();
            Reset();

        }

        private void Uguncelle_Click(object sender, EventArgs e)
        {
             
                    baglanti.Open();
                    SqlCommand komutguncelle = new SqlCommand ("update Tbl_Urun set UrunAd=@a1,UrunKatagori=@a2,UrunTur=@a3,UrunFiyat=@a4,UrunMiktar=@a5 where Urunid=@a6", baglanti);
                    komutguncelle.Parameters.AddWithValue("@a1", EsyaAdi.Text);
                    komutguncelle.Parameters.AddWithValue("@a2", KatagoriAdi.SelectedItem.ToString());
                    komutguncelle.Parameters.AddWithValue("@a3", TurAdi.SelectedItem.ToString());
                    komutguncelle.Parameters.AddWithValue("@a4", FIYAT.Text);
                    komutguncelle.Parameters.AddWithValue("@a5", MIKTAR.Text);
                    komutguncelle.Parameters.AddWithValue("@a6", urunid.Text);
                    komutguncelle.ExecuteNonQuery();
                    
                    baglanti.Close();
                     MessageBox.Show("Urun guncel  Edildi");
            Doldur();
            Reset();
                
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Musteriler Mus = new Musteriler();
            Mus.Show();
            this.Hide();
        }

        private void katfiltre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filtrekatagori();
        }

        private void turfiltre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filtretur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        

      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            oturumac FTR = new oturumac();
            FTR.Show();
            this.Hide();
        }

        
    }
}
