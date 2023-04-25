
namespace kuyumcu_proje
{
    partial class Urunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunler));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.turfiltre = new System.Windows.Forms.ComboBox();
            this.katfiltre = new System.Windows.Forms.ComboBox();
            this.urunid = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Usifirla = new System.Windows.Forms.Button();
            this.Usil = new System.Windows.Forms.Button();
            this.Uguncelle = new System.Windows.Forms.Button();
            this.Ukaydet = new System.Windows.Forms.Button();
            this.UrunDGW = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MIKTAR = new System.Windows.Forms.TextBox();
            this.FIYAT = new System.Windows.Forms.TextBox();
            this.TurAdi = new System.Windows.Forms.ComboBox();
            this.KatagoriAdi = new System.Windows.Forms.ComboBox();
            this.EsyaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.turfiltre);
            this.panel1.Controls.Add(this.katfiltre);
            this.panel1.Controls.Add(this.urunid);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.Usifirla);
            this.panel1.Controls.Add(this.Usil);
            this.panel1.Controls.Add(this.Uguncelle);
            this.panel1.Controls.Add(this.Ukaydet);
            this.panel1.Controls.Add(this.UrunDGW);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MIKTAR);
            this.panel1.Controls.Add(this.FIYAT);
            this.panel1.Controls.Add(this.TurAdi);
            this.panel1.Controls.Add(this.KatagoriAdi);
            this.panel1.Controls.Add(this.EsyaAdi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 585);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Olive;
            this.button1.Location = new System.Drawing.Point(476, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turfiltre
            // 
            this.turfiltre.BackColor = System.Drawing.Color.FloralWhite;
            this.turfiltre.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.turfiltre.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.turfiltre.FormattingEnabled = true;
            this.turfiltre.Items.AddRange(new object[] {
            "GUMUS\t",
            "ALTIN",
            "ELMAS"});
            this.turfiltre.Location = new System.Drawing.Point(577, 371);
            this.turfiltre.Name = "turfiltre";
            this.turfiltre.Size = new System.Drawing.Size(154, 28);
            this.turfiltre.TabIndex = 37;
            this.turfiltre.Text = "TURLER";
            this.turfiltre.SelectionChangeCommitted += new System.EventHandler(this.turfiltre_SelectionChangeCommitted);
            // 
            // katfiltre
            // 
            this.katfiltre.BackColor = System.Drawing.Color.FloralWhite;
            this.katfiltre.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.katfiltre.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.katfiltre.FormattingEnabled = true;
            this.katfiltre.Items.AddRange(new object[] {
            "KUPE\t",
            "YUZUK",
            "KOLYE",
            "BILEZIK"});
            this.katfiltre.Location = new System.Drawing.Point(320, 371);
            this.katfiltre.Name = "katfiltre";
            this.katfiltre.Size = new System.Drawing.Size(150, 28);
            this.katfiltre.TabIndex = 36;
            this.katfiltre.Text = "KATAGORILER";
            this.katfiltre.SelectionChangeCommitted += new System.EventHandler(this.katfiltre_SelectionChangeCommitted);
            // 
            // urunid
            // 
            this.urunid.BackColor = System.Drawing.Color.FloralWhite;
            this.urunid.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.urunid.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.urunid.Location = new System.Drawing.Point(19, 241);
            this.urunid.Name = "urunid";
            this.urunid.Size = new System.Drawing.Size(40, 27);
            this.urunid.TabIndex = 35;
            this.urunid.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Usifirla
            // 
            this.Usifirla.BackColor = System.Drawing.Color.Beige;
            this.Usifirla.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Usifirla.ForeColor = System.Drawing.Color.Olive;
            this.Usifirla.Location = new System.Drawing.Point(806, 285);
            this.Usifirla.Name = "Usifirla";
            this.Usifirla.Size = new System.Drawing.Size(155, 28);
            this.Usifirla.TabIndex = 20;
            this.Usifirla.Text = "SIFIRLA";
            this.Usifirla.UseVisualStyleBackColor = false;
            this.Usifirla.Click += new System.EventHandler(this.Usifirla_Click);
            // 
            // Usil
            // 
            this.Usil.BackColor = System.Drawing.Color.Beige;
            this.Usil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Usil.ForeColor = System.Drawing.Color.Olive;
            this.Usil.Location = new System.Drawing.Point(594, 285);
            this.Usil.Name = "Usil";
            this.Usil.Size = new System.Drawing.Size(155, 28);
            this.Usil.TabIndex = 19;
            this.Usil.Text = "SIL";
            this.Usil.UseVisualStyleBackColor = false;
            this.Usil.Click += new System.EventHandler(this.Usil_Click);
            // 
            // Uguncelle
            // 
            this.Uguncelle.BackColor = System.Drawing.Color.Beige;
            this.Uguncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Uguncelle.ForeColor = System.Drawing.Color.Olive;
            this.Uguncelle.Location = new System.Drawing.Point(381, 285);
            this.Uguncelle.Name = "Uguncelle";
            this.Uguncelle.Size = new System.Drawing.Size(155, 28);
            this.Uguncelle.TabIndex = 18;
            this.Uguncelle.Text = "GUNCELLE";
            this.Uguncelle.UseVisualStyleBackColor = false;
            this.Uguncelle.Click += new System.EventHandler(this.Uguncelle_Click);
            // 
            // Ukaydet
            // 
            this.Ukaydet.BackColor = System.Drawing.Color.Beige;
            this.Ukaydet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ukaydet.ForeColor = System.Drawing.Color.Olive;
            this.Ukaydet.Location = new System.Drawing.Point(141, 285);
            this.Ukaydet.Name = "Ukaydet";
            this.Ukaydet.Size = new System.Drawing.Size(155, 28);
            this.Ukaydet.TabIndex = 17;
            this.Ukaydet.Text = "KAYDET";
            this.Ukaydet.UseVisualStyleBackColor = false;
            this.Ukaydet.Click += new System.EventHandler(this.Ukaydet_Click);
            // 
            // UrunDGW
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Olive;
            this.UrunDGW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UrunDGW.BackgroundColor = System.Drawing.Color.Ivory;
            this.UrunDGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UrunDGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UrunDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UrunDGW.DefaultCellStyle = dataGridViewCellStyle3;
            this.UrunDGW.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.UrunDGW.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UrunDGW.Location = new System.Drawing.Point(193, 416);
            this.UrunDGW.Name = "UrunDGW";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UrunDGW.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.UrunDGW.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UrunDGW.RowTemplate.Height = 25;
            this.UrunDGW.Size = new System.Drawing.Size(644, 159);
            this.UrunDGW.TabIndex = 16;
            this.UrunDGW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrunDGW_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(449, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "URUN LISTESI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(849, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "MIKTAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(662, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "FIYAT";
            // 
            // MIKTAR
            // 
            this.MIKTAR.BackColor = System.Drawing.Color.FloralWhite;
            this.MIKTAR.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MIKTAR.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.MIKTAR.Location = new System.Drawing.Point(830, 240);
            this.MIKTAR.Name = "MIKTAR";
            this.MIKTAR.Size = new System.Drawing.Size(153, 27);
            this.MIKTAR.TabIndex = 10;
            // 
            // FIYAT
            // 
            this.FIYAT.BackColor = System.Drawing.Color.FloralWhite;
            this.FIYAT.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FIYAT.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.FIYAT.Location = new System.Drawing.Point(632, 240);
            this.FIYAT.Name = "FIYAT";
            this.FIYAT.Size = new System.Drawing.Size(150, 27);
            this.FIYAT.TabIndex = 9;
            // 
            // TurAdi
            // 
            this.TurAdi.BackColor = System.Drawing.Color.FloralWhite;
            this.TurAdi.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TurAdi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.TurAdi.FormattingEnabled = true;
            this.TurAdi.Items.AddRange(new object[] {
            "GUMUS\t",
            "ALTIN",
            "ELMAS"});
            this.TurAdi.Location = new System.Drawing.Point(449, 239);
            this.TurAdi.Name = "TurAdi";
            this.TurAdi.Size = new System.Drawing.Size(154, 28);
            this.TurAdi.TabIndex = 8;
            this.TurAdi.Text = "TURLER";
            // 
            // KatagoriAdi
            // 
            this.KatagoriAdi.BackColor = System.Drawing.Color.FloralWhite;
            this.KatagoriAdi.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.KatagoriAdi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.KatagoriAdi.FormattingEnabled = true;
            this.KatagoriAdi.Items.AddRange(new object[] {
            "KUPE\t",
            "YUZUK",
            "KOLYE",
            "BILEZIK"});
            this.KatagoriAdi.Location = new System.Drawing.Point(253, 240);
            this.KatagoriAdi.Name = "KatagoriAdi";
            this.KatagoriAdi.Size = new System.Drawing.Size(150, 28);
            this.KatagoriAdi.TabIndex = 7;
            this.KatagoriAdi.Text = "KATAGORILER";
            // 
            // EsyaAdi
            // 
            this.EsyaAdi.BackColor = System.Drawing.Color.FloralWhite;
            this.EsyaAdi.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EsyaAdi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.EsyaAdi.Location = new System.Drawing.Point(65, 240);
            this.EsyaAdi.Name = "EsyaAdi";
            this.EsyaAdi.Size = new System.Drawing.Size(150, 27);
            this.EsyaAdi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(84, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "KULLANIM";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(440, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(662, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "MÜSTERİLER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(577, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(371, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜNLER";
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1069, 607);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urunler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MIKTAR;
        private System.Windows.Forms.TextBox FIYAT;
        private System.Windows.Forms.ComboBox TurAdi;
        private System.Windows.Forms.ComboBox KatagoriAdi;
        private System.Windows.Forms.TextBox EsyaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Usifirla;
        private System.Windows.Forms.Button Usil;
        private System.Windows.Forms.Button Uguncelle;
        private System.Windows.Forms.Button Ukaydet;
        private System.Windows.Forms.DataGridView UrunDGW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox urunid;
        private System.Windows.Forms.ComboBox turfiltre;
        private System.Windows.Forms.ComboBox katfiltre;
        private System.Windows.Forms.Button button1;
    }
}