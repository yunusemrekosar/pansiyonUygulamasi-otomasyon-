namespace pansiyonOtomasyonuV1
{
    partial class frmPersonelEkle
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblPersonelAdi = new System.Windows.Forms.Label();
            this.lblPersonelMaasi = new System.Windows.Forms.Label();
            this.lblİseAlımTarihi = new System.Windows.Forms.Label();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.txtPersonelMaasi = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtPersonelPozisyonu = new System.Windows.Forms.TextBox();
            this.lblPersonelPozisyonu = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lstwPersonel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(1013, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 73);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ana Menüye Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPersonelAdi
            // 
            this.lblPersonelAdi.Location = new System.Drawing.Point(360, 61);
            this.lblPersonelAdi.Name = "lblPersonelAdi";
            this.lblPersonelAdi.Size = new System.Drawing.Size(144, 22);
            this.lblPersonelAdi.TabIndex = 10;
            this.lblPersonelAdi.Text = "Personel Adı:";
            this.lblPersonelAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPersonelMaasi
            // 
            this.lblPersonelMaasi.Location = new System.Drawing.Point(335, 133);
            this.lblPersonelMaasi.Name = "lblPersonelMaasi";
            this.lblPersonelMaasi.Size = new System.Drawing.Size(169, 22);
            this.lblPersonelMaasi.TabIndex = 30;
            this.lblPersonelMaasi.Text = "Personel Maaşı:";
            this.lblPersonelMaasi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblİseAlımTarihi
            // 
            this.lblİseAlımTarihi.Location = new System.Drawing.Point(340, 98);
            this.lblİseAlımTarihi.Name = "lblİseAlımTarihi";
            this.lblİseAlımTarihi.Size = new System.Drawing.Size(164, 22);
            this.lblİseAlımTarihi.TabIndex = 20;
            this.lblİseAlımTarihi.Text = "Çalışan Soyadı:";
            this.lblİseAlımTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(510, 58);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(125, 29);
            this.txtPersonelAdi.TabIndex = 1;
            // 
            // txtPersonelMaasi
            // 
            this.txtPersonelMaasi.Location = new System.Drawing.Point(510, 130);
            this.txtPersonelMaasi.Name = "txtPersonelMaasi";
            this.txtPersonelMaasi.Size = new System.Drawing.Size(125, 29);
            this.txtPersonelMaasi.TabIndex = 3;
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(510, 95);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(125, 29);
            this.txtPersonelSoyadi.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKaydet.Location = new System.Drawing.Point(509, 201);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(244, 41);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtPersonelPozisyonu
            // 
            this.txtPersonelPozisyonu.Location = new System.Drawing.Point(510, 166);
            this.txtPersonelPozisyonu.Name = "txtPersonelPozisyonu";
            this.txtPersonelPozisyonu.Size = new System.Drawing.Size(125, 29);
            this.txtPersonelPozisyonu.TabIndex = 4;
            // 
            // lblPersonelPozisyonu
            // 
            this.lblPersonelPozisyonu.Location = new System.Drawing.Point(305, 169);
            this.lblPersonelPozisyonu.Name = "lblPersonelPozisyonu";
            this.lblPersonelPozisyonu.Size = new System.Drawing.Size(199, 22);
            this.lblPersonelPozisyonu.TabIndex = 80;
            this.lblPersonelPozisyonu.Text = "Çalışan Pozisyonu:";
            this.lblPersonelPozisyonu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSil.Location = new System.Drawing.Point(640, 57);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(113, 67);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGuncelle.Location = new System.Drawing.Point(640, 130);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(113, 65);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lstwPersonel
            // 
            this.lstwPersonel.BackColor = System.Drawing.Color.YellowGreen;
            this.lstwPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstwPersonel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lstwPersonel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lstwPersonel.HideSelection = false;
            this.lstwPersonel.Location = new System.Drawing.Point(0, 263);
            this.lstwPersonel.Name = "lstwPersonel";
            this.lstwPersonel.Size = new System.Drawing.Size(1172, 210);
            this.lstwPersonel.TabIndex = 12;
            this.lstwPersonel.UseCompatibleStateImageBehavior = false;
            this.lstwPersonel.View = System.Windows.Forms.View.Details;
            this.lstwPersonel.DoubleClick += new System.EventHandler(this.lstwPersonel_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Personel Adı";
            this.columnHeader1.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Personel Soyadı";
            this.columnHeader2.Width = 222;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Personel Maaşi";
            this.columnHeader3.Width = 237;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Personel Pozisyonu";
            this.columnHeader4.Width = 244;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 69;
            // 
            // frmPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1172, 472);
            this.Controls.Add(this.lstwPersonel);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtPersonelPozisyonu);
            this.Controls.Add(this.lblPersonelPozisyonu);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtPersonelSoyadi);
            this.Controls.Add(this.txtPersonelMaasi);
            this.Controls.Add(this.txtPersonelAdi);
            this.Controls.Add(this.lblİseAlımTarihi);
            this.Controls.Add(this.lblPersonelMaasi);
            this.Controls.Add(this.lblPersonelAdi);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekle";
            this.Load += new System.EventHandler(this.frmPersonelEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPersonelAdi;
        private System.Windows.Forms.Label lblPersonelMaasi;
        private System.Windows.Forms.Label lblİseAlımTarihi;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.TextBox txtPersonelMaasi;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtPersonelPozisyonu;
        private System.Windows.Forms.Label lblPersonelPozisyonu;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ListView lstwPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}