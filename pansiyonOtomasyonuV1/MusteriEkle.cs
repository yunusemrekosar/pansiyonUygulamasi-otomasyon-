using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Runtime.Remoting.Channels;

namespace pansiyonOtomasyonuV1
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        pansiyonEntities ent = new pansiyonEntities();
        private void doldur(Button button)
        {
            txtOdaNu.Text = button.Text;
            button.BackColor = Color.Tomato;
            button.Enabled = false;
        }


        private void doldurbosalt(Button button, string cikis = "1000/01/01")
        {
            button.BackColor = Color.FromArgb(128, 255, 128);
            button.Enabled = true;
            if (Convert.ToDateTime(cikis) > DateTime.Now)
            {
                button.BackColor = Color.Tomato;
                button.Enabled = false;
            }
        }

        public void kutularıbosalt()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelNu.Clear();
            comboBox1.Text = "";
            txtMail.Clear();
            txtTcKimlikNu.Clear();
            txtOdaUcreti.Clear();
            txtOdaNu.Clear();
            dtpGiris.Value = DateTime.Now;
            dtpCikis.Value = DateTime.Now;
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            doldur(btn101);
        }
        private void btn102_Click(object sender, EventArgs e)
        {
            doldur(btn102);
        }
        private void btn103_Click(object sender, EventArgs e)
        {
            doldur(btn103);
        }
        private void btn104_Click(object sender, EventArgs e)
        {
            doldur(btn104);
        }
        private void btn105_Click(object sender, EventArgs e)
        {
            doldur(btn105);
        }
        private void btn201_Click(object sender, EventArgs e)
        {
            doldur(btn201);
        }
        private void btn202_Click(object sender, EventArgs e)
        {
            doldur(btn202);
        }
        private void btn203_Click(object sender, EventArgs e)
        {
            doldur(btn203);
        }
        private void btn204_Click(object sender, EventArgs e)
        {
            doldur(btn204);
        }
        private void btn205_Click(object sender, EventArgs e)
        {
            doldur(btn205);
        }
        private void btn301_Click(object sender, EventArgs e)
        {
            doldur(btn301);
        }
        private void btn302_Click(object sender, EventArgs e)
        {
            doldur(btn302);
        }
        private void btn303_Click(object sender, EventArgs e)
        {
            doldur(btn303);
        }
        private void btn304_Click(object sender, EventArgs e)
        {
            doldur(btn304);
        }
        private void btn305_Click(object sender, EventArgs e)
        {
            doldur(btn305);
        }
        private void btn401_Click(object sender, EventArgs e)
        {
            doldur(btn401);
        }
        private void btn402_Click(object sender, EventArgs e)
        {
            doldur(btn402);
        }
        private void btn403_Click(object sender, EventArgs e)
        {
            doldur(btn403);
        }
        private void btn404_Click(object sender, EventArgs e)
        {
            doldur(btn404);
        }
        private void btn405_Click(object sender, EventArgs e)
        {
            doldur(btn405);
        }
        private void btn501_Click(object sender, EventArgs e)
        {
            doldur(btn501);
        }
        private void btn502_Click(object sender, EventArgs e)
        {
            doldur(btn502);
        }
        private void btn503_Click(object sender, EventArgs e)
        {
            doldur(btn503);
        }
        private void btn504_Click(object sender, EventArgs e)
        {
            doldur(btn504);
        }
        private void btn505_Click(object sender, EventArgs e)
        {
            doldur(btn505);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[] { txtAdi, txtSoyadi, txtTelNu, txtTcKimlikNu, txtOdaUcreti };
            ComboBox[] comboBoxes = new ComboBox[] { comboBox1 };
            Helper denetleyici = new Helper();
            int a = denetleyici.Tdenetleyici(textBoxes);
            int b = denetleyici.Cdenetleyici(comboBoxes);
            if (a + b > 0)
            {
                MessageBox.Show("Boş Bırakılamaz Bölümler Var");
                a = 0;
            }
            else
            {
                TBLmusteriler m = new TBLmusteriler();
                m.adi = txtAdi.Text;
                m.soyadi = txtSoyadi.Text;
                m.telNu = txtTelNu.Text;
                m.cinsiyet = comboBox1.Text;
                m.mail = txtMail.Text;
                m.tcKimlikNu = txtTcKimlikNu.Text;
                m.odaUcreti = int.Parse(txtOdaUcreti.Text);
                m.odaNu = txtOdaNu.Text;
                m.girisTarihi = dtpGiris.Value;
                m.cikisTarihi = dtpCikis.Value;
                ent.TBLmusteriler.Add(m);
                ent.SaveChanges();
                lblSonuc.Text = txtAdi.Text + " " + txtSoyadi.Text + " Adlı Müşteri eklendi";
                kutularıbosalt();
                MusteriEkle_Load(sender, e);
            }
        }
        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            DateTime giris = dtpGiris.Value;
            DateTime cikis = dtpCikis.Value;
            int kalinacakGun = cikis.Day - giris.Day;
            txtOdaUcreti.Text = (kalinacakGun * 200).ToString();
        }

        private void btnGoAnaMenu_Click(object sender, EventArgs e)
        {
            frmAnaMenu anaMenu = new frmAnaMenu();
            anaMenu.StartPosition = FormStartPosition.CenterScreen;
            anaMenu.Show();
            this.Hide();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

            var query = from item in ent.TBLmusteriler
                        select new { item.odaNu, item.girisTarihi, item.cikisTarihi };
            var liste = query.ToList();
            foreach (var item in liste)
            {
                string p1 = "btn" + item.odaNu.ToString();
                string p2 = item.cikisTarihi.ToString();
                switch (p1)
                {
                    case "btn101":
                        doldurbosalt(btn101, p2);
                        break;
                    case "btn102":
                        doldurbosalt(btn102, p2);
                        break;
                    case "btn103":
                        doldurbosalt(btn103, p2);
                        break;
                    case "btn104":
                        doldurbosalt(btn104, p2);
                        break;
                    case "btn105":
                        doldurbosalt(btn105, p2);
                        break;

                    case "btn201":
                        doldurbosalt(btn201, p2);
                        break;
                    case "btn202":
                        doldurbosalt(btn202, p2);
                        break;
                    case "btn203":
                        doldurbosalt(btn203, p2);
                        break;
                    case "btn204":
                        doldurbosalt(btn204, p2);
                        break;
                    case "btn205":
                        doldurbosalt(btn205, p2);
                        break;

                    case "btn301":
                        doldurbosalt(btn301, p2);
                        break;
                    case "btn302":
                        doldurbosalt(btn302, p2);
                        break;
                    case "btn303":
                        doldurbosalt(btn303, p2);
                        break;
                    case "btn304":
                        doldurbosalt(btn304, p2);
                        break;
                    case "btn305":
                        doldurbosalt(btn305, p2);
                        break;

                    case "btn401":
                        doldurbosalt(btn401, p2);
                        break;
                    case "btn402":
                        doldurbosalt(btn402, p2);
                        break;
                    case "btn403":
                        doldurbosalt(btn403, p2);
                        break;
                    case "btn404":
                        doldurbosalt(btn404, p2);
                        break;
                    case "btn405":
                        doldurbosalt(btn405, p2);
                        break;

                    case "btn501":
                        doldurbosalt(btn501, p2);
                        break;
                    case "btn502":
                        doldurbosalt(btn502, p2);
                        break;
                    case "btn503":
                        doldurbosalt(btn503, p2);
                        break;
                    case "btn504":
                        doldurbosalt(btn504, p2);
                        break;
                    case "btn505":
                        doldurbosalt(btn505, p2);
                        break;

                    default: break;
                }
            }
        }

        private void MusteriEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
