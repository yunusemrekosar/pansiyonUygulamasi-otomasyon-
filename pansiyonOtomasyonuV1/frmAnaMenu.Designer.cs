namespace pansiyonOtomasyonuV1
{
    partial class frmAnaMenu
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
            this.btnGoFrmMusteriEkle = new System.Windows.Forms.Button();
            this.btnGoFrmMusteriGor = new System.Windows.Forms.Button();
            this.btnGoFrmOdalar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoFrmMusteriEkle
            // 
            this.btnGoFrmMusteriEkle.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGoFrmMusteriEkle.Location = new System.Drawing.Point(80, 32);
            this.btnGoFrmMusteriEkle.Name = "btnGoFrmMusteriEkle";
            this.btnGoFrmMusteriEkle.Size = new System.Drawing.Size(277, 145);
            this.btnGoFrmMusteriEkle.TabIndex = 0;
            this.btnGoFrmMusteriEkle.Text = "Müşteri Ekle";
            this.btnGoFrmMusteriEkle.UseVisualStyleBackColor = false;
            this.btnGoFrmMusteriEkle.Click += new System.EventHandler(this.btnGoFrmMusteriEkle_Click);
            // 
            // btnGoFrmMusteriGor
            // 
            this.btnGoFrmMusteriGor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGoFrmMusteriGor.Location = new System.Drawing.Point(80, 205);
            this.btnGoFrmMusteriGor.Name = "btnGoFrmMusteriGor";
            this.btnGoFrmMusteriGor.Size = new System.Drawing.Size(277, 145);
            this.btnGoFrmMusteriGor.TabIndex = 1;
            this.btnGoFrmMusteriGor.Text = "Müşterileri Gör/Düzenle";
            this.btnGoFrmMusteriGor.UseVisualStyleBackColor = false;
            this.btnGoFrmMusteriGor.Click += new System.EventHandler(this.btnGoFrmMusteriGor_Click);
            // 
            // btnGoFrmOdalar
            // 
            this.btnGoFrmOdalar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoFrmOdalar.Location = new System.Drawing.Point(383, 205);
            this.btnGoFrmOdalar.Name = "btnGoFrmOdalar";
            this.btnGoFrmOdalar.Size = new System.Drawing.Size(277, 145);
            this.btnGoFrmOdalar.TabIndex = 2;
            this.btnGoFrmOdalar.Text = "Odaları Gör";
            this.btnGoFrmOdalar.UseVisualStyleBackColor = false;
            this.btnGoFrmOdalar.Click += new System.EventHandler(this.btnGoFrmOdalar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(383, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 145);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(686, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 145);
            this.button2.TabIndex = 4;
            this.button2.Text = "Gelir Gider";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Location = new System.Drawing.Point(686, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 145);
            this.button3.TabIndex = 5;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1172, 472);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoFrmOdalar);
            this.Controls.Add(this.btnGoFrmMusteriGor);
            this.Controls.Add(this.btnGoFrmMusteriEkle);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmAnaMenu";
            this.Text = "Ana Menü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnaMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoFrmMusteriEkle;
        private System.Windows.Forms.Button btnGoFrmMusteriGor;
        private System.Windows.Forms.Button btnGoFrmOdalar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}