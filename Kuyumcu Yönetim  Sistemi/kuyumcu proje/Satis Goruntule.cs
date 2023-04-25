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
    public partial class Satis_Goruntule : Form
    {
        public Satis_Goruntule()
        {
            InitializeComponent();
            Doldur();

        }

        private void Ukaydet_Click(object sender, EventArgs e)
        {
            Fatura FTR = new Fatura();
            FTR.Show();
            this.Hide();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-EH0A9L2\SQLEXPRESS;Initial Catalog=KuyumcuSistemi;Integrated Security=True");
        private void Doldur()
        {
            baglanti.Open();

            string sorgu = "select * from Tbl_Fatura";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
            SqlCommandBuilder olustur = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        int a = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            faturaıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            a = a + Convert.ToInt32(textBox1.Text);
            aaa.Text = a.ToString();

        }

        private void SIL_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand SATISSIL = new SqlCommand("Delete from  Tbl_Fatura where Faturaid=@k1", baglanti);
            SATISSIL.Parameters.AddWithValue("@k1", faturaıd.Text);
            SATISSIL.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satıs silindi");
            Doldur();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            a = 0;
            aaa.Text = a.ToString();
        }
    }
}
