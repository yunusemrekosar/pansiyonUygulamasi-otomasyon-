namespace pansiyonOtomasyonuV1
{
    partial class frmMusteriGor
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
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.lstMusteriler = new System.Windows.Forms.ListView();
            this.musteriID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telNu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcKimlikNu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odaUcreti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odaNumarası = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.girisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cikisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTelNu = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOdaNu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.txtOdaUcreti = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTcKimlikNu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbTarihiAktiflestir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGüncelle.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGüncelle.Location = new System.Drawing.Point(541, 168);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(207, 37);
            this.btnGüncelle.TabIndex = 0;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.BackColor = System.Drawing.Color.YellowGreen;
            this.lstMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.musteriID,
            this.adi,
            this.soyadi,
            this.telNu,
            this.mail,
            this.tcKimlikNu,
            this.odaUcreti,
            this.odaNumarası,
            this.girisTarihi,
            this.cikisTarihi});
            this.lstMusteriler.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lstMusteriler.HideSelection = false;
            this.lstMusteriler.Location = new System.Drawing.Point(0, 254);
            this.lstMusteriler.Margin = new System.Windows.Forms.Padding(4);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(1173, 221);
            this.lstMusteriler.TabIndex = 1;
            this.lstMusteriler.UseCompatibleStateImageBehavior = false;
            this.lstMusteriler.View = System.Windows.Forms.View.Details;
            this.lstMusteriler.DoubleClick += new System.EventHandler(this.lstMusteriler_DoubleClick);
            // 
            // musteriID
            // 
            this.musteriID.Text = "ID";
            this.musteriID.Width = 34;
            // 
            // adi
            // 
            this.adi.Text = "Adı";
            this.adi.Width = 105;
            // 
            // soyadi
            // 
            this.soyadi.Text = "Soyadı";
            this.soyadi.Width = 90;
            // 
            // telNu
            // 
            this.telNu.Text = "Telefon Numarası";
            this.telNu.Width = 160;
            // 
            // mail
            // 
            this.mail.Text = "Mail";
            this.mail.Width = 95;
            // 
            // tcKimlikNu
            // 
            this.tcKimlikNu.Text = "TC Kimlik";
            this.tcKimlikNu.Width = 124;
            // 
            // odaUcreti
            // 
            this.odaUcreti.Text = "Oda Ücreti";
            this.odaUcreti.Width = 103;
            // 
            // odaNumarası
            // 
            this.odaNumarası.Text = "Oda Numarası";
            this.odaNumarası.Width = 131;
            // 
            // girisTarihi
            // 
            this.girisTarihi.Text = "Giriş Tarihi";
            this.girisTarihi.Width = 134;
            // 
            // cikisTarihi
            // 
            this.cikisTarihi.Text = "Çıkış Tarihi";
            this.cikisTarihi.Width = 168;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSil.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(756, 168);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(207, 37);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(13, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ana Menüye Dön";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTelNu
            // 
            this.txtTelNu.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtTelNu.Location = new System.Drawing.Point(199, 128);
            this.txtTelNu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTelNu.MaxLength = 12;
            this.txtTelNu.Name = "txtTelNu";
            this.txtTelNu.Size = new System.Drawing.Size(291, 28);
            this.txtTelNu.TabIndex = 54;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Diger"});
            this.comboBox1.Location = new System.Drawing.Point(199, 89);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 28);
            this.comboBox1.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(104, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Cinsiyet:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOdaNu
            // 
            this.txtOdaNu.Enabled = false;
            this.txtOdaNu.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtOdaNu.Location = new System.Drawing.Point(672, 52);
            this.txtOdaNu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtOdaNu.Name = "txtOdaNu";
            this.txtOdaNu.Size = new System.Drawing.Size(291, 28);
            this.txtOdaNu.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(583, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "Oda Nu:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCikis
            // 
            this.dtpCikis.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.dtpCikis.Location = new System.Drawing.Point(671, 122);
            this.dtpCikis.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(291, 28);
            this.dtpCikis.TabIndex = 49;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // txtOdaUcreti
            // 
            this.txtOdaUcreti.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtOdaUcreti.Location = new System.Drawing.Point(672, 15);
            this.txtOdaUcreti.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtOdaUcreti.Name = "txtOdaUcreti";
            this.txtOdaUcreti.Size = new System.Drawing.Size(291, 28);
            this.txtOdaUcreti.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(551, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Oda Ücreti:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(52, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "T.C Kimlik Nu:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtMail.Location = new System.Drawing.Point(199, 168);
            this.txtMail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(291, 28);
            this.txtMail.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(547, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Çıkış Tarihi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(140, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mail:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpGiris
            // 
            this.dtpGiris.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.dtpGiris.Location = new System.Drawing.Point(671, 86);
            this.dtpGiris.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(291, 28);
            this.dtpGiris.TabIndex = 48;
            this.dtpGiris.ValueChanged += new System.EventHandler(this.dtpGiris_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(547, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Giriş Tarihi:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTcKimlikNu
            // 
            this.txtTcKimlikNu.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtTcKimlikNu.Location = new System.Drawing.Point(199, 208);
            this.txtTcKimlikNu.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTcKimlikNu.MaxLength = 11;
            this.txtTcKimlikNu.Name = "txtTcKimlikNu";
            this.txtTcKimlikNu.Size = new System.Drawing.Size(291, 28);
            this.txtTcKimlikNu.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(76, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Telefon Nu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtSoyadi.Location = new System.Drawing.Point(199, 52);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(291, 28);
            this.txtSoyadi.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(121, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtAdi.Location = new System.Drawing.Point(199, 15);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(291, 28);
            this.txtAdi.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(154, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAra.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAra.Location = new System.Drawing.Point(970, 197);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(124, 36);
            this.btnAra.TabIndex = 55;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAra.Location = new System.Drawing.Point(680, 207);
            this.txtAra.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(283, 29);
            this.txtAra.TabIndex = 56;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGoruntule.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGoruntule.Location = new System.Drawing.Point(970, 52);
            this.btnGoruntule.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(124, 139);
            this.btnGoruntule.TabIndex = 57;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = false;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ad",
            "Soyad",
            "TC Kimlik",
            "Giriş Tarihi"});
            this.comboBox2.Location = new System.Drawing.Point(544, 206);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 30);
            this.comboBox2.TabIndex = 59;
            this.comboBox2.Text = "Ad";
            // 
            // cbTarihiAktiflestir
            // 
            this.cbTarihiAktiflestir.AutoSize = true;
            this.cbTarihiAktiflestir.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbTarihiAktiflestir.Location = new System.Drawing.Point(970, 17);
            this.cbTarihiAktiflestir.Name = "cbTarihiAktiflestir";
            this.cbTarihiAktiflestir.Size = new System.Drawing.Size(186, 24);
            this.cbTarihiAktiflestir.TabIndex = 60;
            this.cbTarihiAktiflestir.Text = "Tarihi Aktifleştir";
            this.cbTarihiAktiflestir.UseVisualStyleBackColor = true;
            // 
            // frmMusteriGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1172, 472);
            this.Controls.Add(this.cbTarihiAktiflestir);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtTelNu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOdaNu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpCikis);
            this.Controls.Add(this.txtOdaUcreti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpGiris);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTcKimlikNu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstMusteriler);
            this.Controls.Add(this.btnGüncelle);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriGor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müsteri Gör";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMusteriGor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.ListView lstMusteriler;
        public System.Windows.Forms.ColumnHeader musteriID;
        public System.Windows.Forms.ColumnHeader adi;
        public System.Windows.Forms.ColumnHeader soyadi;
        public System.Windows.Forms.ColumnHeader telNu;
        public System.Windows.Forms.ColumnHeader mail;
        public System.Windows.Forms.ColumnHeader tcKimlikNu;
        public System.Windows.Forms.ColumnHeader odaUcreti;
        public System.Windows.Forms.ColumnHeader odaNumarası;
        public System.Windows.Forms.ColumnHeader girisTarihi;
        public System.Windows.Forms.ColumnHeader cikisTarihi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTelNu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOdaNu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.TextBox txtOdaUcreti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTcKimlikNu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox cbTarihiAktiflestir;
    }
}