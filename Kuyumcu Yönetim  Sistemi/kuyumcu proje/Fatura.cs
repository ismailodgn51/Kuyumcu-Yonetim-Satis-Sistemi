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
    public partial class Fatura : Form
    {
        public Fatura()
        {
            InitializeComponent();
            Doldur();
            Mdoldur();
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
        private void Mdoldur()
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

        private void guncelle()
        { baglanti.Open();
            int stok = Convert.ToInt32(miktar.Text) - Convert.ToInt32(Imiktar.Text);

            SqlCommand komutguncelle = new SqlCommand("update Tbl_Urun set UrunMiktar=@a5 where Urunid=@a6", baglanti);
            komutguncelle.Parameters.AddWithValue("@a5", stok);
            komutguncelle.Parameters.AddWithValue("@a6", urunid.Text);
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();

            Doldur();


        }
        int n = 0, toplam2 = 0;
        private void Faturaekle_Click(object sender, EventArgs e)
        {
            if (Imiktar.Text == "" )
            {
                MessageBox.Show("Lütfen Tam Doldurun");
                }
            else if (Convert.ToInt32(miktar.Text) < Convert.ToInt32(Imiktar.Text))
            {
                MessageBox.Show("stokta yok");
            }
            else if (Convert.ToInt32(Imiktar.Text) == 0)
            {
                MessageBox.Show("Lütfen miktar giriniz");
            }
            else
            {
                int total = Convert.ToInt32(Imiktar.Text) * Convert.ToInt32(FiyatF.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(FaturaDGW);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = MusteriAdiF.Text;
                newRow.Cells[2].Value = UrunAdiF.Text;
                newRow.Cells[3].Value = Imiktar.Text;
                newRow.Cells[4].Value = total;
                FaturaDGW.Rows.Add(newRow);


                n++;
            }
            if (Imiktar.Text == "" || Convert.ToInt32(miktar.Text) < Convert.ToInt32(Imiktar.Text))
            {
                
            }
           
            else
            {


                int a = Convert.ToInt32(Imiktar.Text) * Convert.ToInt32(FiyatF.Text);
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Tbl_Fatura (MusteriAd,Urun,Musteritel,MusteriAdres,Kasa) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", MusteriAdiF.Text);
                komut.Parameters.AddWithValue("@p2", UrunAdiF.Text);
                komut.Parameters.AddWithValue("@p3", telno.Text);
                komut.Parameters.AddWithValue("@p4", adresssss.Text);
                komut.Parameters.AddWithValue("@p5", a);
                toplam2 = toplam2 + a;

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("ONAYLANDI");
                guncelle();
                Reset();
            }
           
        }
        

        private void UrunDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = UrunDGW.SelectedCells[0].RowIndex;
            UrunAdiF.Text = UrunDGW.Rows[secilen].Cells[2].Value.ToString();
            FiyatF.Text = UrunDGW.Rows[secilen].Cells[4].Value.ToString();
            miktar.Text = UrunDGW.Rows[secilen].Cells[5].Value.ToString();
            urunid.Text = UrunDGW.Rows[secilen].Cells[0].Value.ToString();
        }

        private void musteriDgwf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = MusteriDGW.SelectedCells[0].RowIndex;

            MusteriAdiF.Text = MusteriDGW.Rows[secilen].Cells[1].Value.ToString();
            adresssss.Text = MusteriDGW.Rows[secilen].Cells[3].Value.ToString();
            telno.Text = MusteriDGW.Rows[secilen].Cells[2].Value.ToString();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Satis_Goruntule stg = new Satis_Goruntule();
            stg.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            oturumac FTR = new oturumac();
            FTR.Show();
            this.Hide();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toplam2.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            urunid.Text = "";
            UrunAdiF.Text = "";
            Imiktar.Text = "";
            miktar.Text = "";
            FiyatF.Text = "";
        }

       

        private void Mikreset()
            {
            miktar.Text = "";

            }
        


    }
}
