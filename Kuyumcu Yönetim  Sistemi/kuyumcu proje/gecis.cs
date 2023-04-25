using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuyumcu_proje
{
    public partial class gecis : Form
    {
        public gecis()
        {
            InitializeComponent();
        }


        int baslangıcnoktası = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            baslangıcnoktası += 4;
            progressBar1.Value = baslangıcnoktası;
            yuzde.Text = baslangıcnoktası + "%";
            if (progressBar1.Value ==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                oturumac otrm = new oturumac();
                otrm.Show();
                this.Hide();
            }
        }

        private void gecıs_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

     
    }
}
