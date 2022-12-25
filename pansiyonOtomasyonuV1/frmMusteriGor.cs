using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace pansiyonOtomasyonuV1
{
    public partial class frmMusteriGor : Form
    {
        public frmMusteriGor()
        {
            InitializeComponent();
        }
        pansiyonEntities ent = new pansiyonEntities();
        private void veriyiac(string p1 = "01,01,1754", string p2 = "01,01,3000")
        {
            lstMusteriler.Items.Clear();
            var query = from item in ent.TBLmusteriler
                        where item.girisTarihi >= Convert.ToDateTime(p1) && item.cikisTarihi >= Convert.ToDateTime(p2)
                        select item;
            var musList = ent.TBLmusteriler.ToList();
            foreach (var item in musList)
            {
                ListViewItem ekle = new ListViewItem(item.musteriID.ToString());
                ekle.SubItems.Add(item.adi.ToString());
                ekle.SubItems.Add(item.soyadi.ToString());
                ekle.SubItems.Add(item.telNu.ToString());
                ekle.SubItems.Add(item.mail.ToString());
                ekle.SubItems.Add(item.tcKimlikNu.ToString());
                ekle.SubItems.Add(item.odaUcreti.ToString());
                ekle.SubItems.Add(item.odaNu.ToString());
                ekle.SubItems.Add(item.girisTarihi.ToString());
                ekle.SubItems.Add(item.cikisTarihi.ToString());
                if (item.cinsiyet.ToString() == "Erkek")
                {
                    ekle.BackColor = Color.LightSkyBlue;
                }
                if (item.cinsiyet.ToString() == "Kadın")
                {
                    ekle.BackColor = Color.LightPink;
                }
                if (item.cinsiyet.ToString() == "Diğer")
                {
                    ekle.BackColor = Color.LightYellow;
                }
                lstMusteriler.Items.Add(ekle);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAnaMenu anaMenu = new frmAnaMenu();
            anaMenu.StartPosition = FormStartPosition.CenterScreen;
            anaMenu.Show();
            this.Hide();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            if (cbTarihiAktiflestir.Checked)
            {
                lstMusteriler.Items.Clear();
                veriyiac(dtpGiris.Value.ToString(), dtpCikis.Value.ToString());
            }
            else
            {
                lstMusteriler.Items.Clear();
                veriyiac();
            }
        }
        int id = 0;
        private void lstMusteriler_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(lstMusteriler.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = lstMusteriler.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = lstMusteriler.SelectedItems[0].SubItems[2].Text;
            txtTelNu.Text = lstMusteriler.SelectedItems[0].SubItems[3].Text;
            txtMail.Text = lstMusteriler.SelectedItems[0].SubItems[4].Text;
            txtTcKimlikNu.Text = lstMusteriler.SelectedItems[0].SubItems[5].Text;
            txtOdaUcreti.Text = lstMusteriler.SelectedItems[0].SubItems[6].Text;
            txtOdaNu.Text = lstMusteriler.SelectedItems[0].SubItems[7].Text;
            dtpGiris.Text = lstMusteriler.SelectedItems[0].SubItems[8].Text;
            dtpCikis.Text = lstMusteriler.SelectedItems[0].SubItems[9].Text;
            if (lstMusteriler.SelectedItems[0].BackColor == Color.LightSkyBlue)
            {
                comboBox1.Text = "Erkek";
            }
            if (lstMusteriler.SelectedItems[0].BackColor == Color.LightPink)
            {
                comboBox1.Text = "Kadın";
            }
            if (lstMusteriler.SelectedItems[0].BackColor == Color.LightYellow)
            {
                comboBox1.Text = "Diğer";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var x = ent.TBLmusteriler.Find(id);
            ent.TBLmusteriler.Remove(x);
            ent.SaveChanges();
            veriyiac();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[] {txtAdi, txtSoyadi, txtTelNu, txtTcKimlikNu, txtOdaUcreti};
            Helper denetleyici = new Helper();
            int a = denetleyici.Tdenetleyici(textBoxes);
            if (a > 0)
            {
                MessageBox.Show("Boş Bırakılamaz Metin Kutuları Var");
                a = 0;
            }
            else
            {
                lstMusteriler.Items.Clear();

                DateTime giris = dtpGiris.Value;
                DateTime cikis = dtpCikis.Value;

                var x = ent.TBLmusteriler.Find(id);
                x.adi = txtAdi.Text;
                x.soyadi = txtSoyadi.Text;
                x.telNu = txtTelNu.Text;
                x.cinsiyet = comboBox1.Text;
                x.mail = txtMail.Text;
                x.tcKimlikNu = txtTcKimlikNu.Text;
                x.odaUcreti = int.Parse(txtOdaUcreti.Text);
                x.odaNu = txtOdaNu.Text;
                x.girisTarihi = giris;
                x.cikisTarihi = cikis;
                ent.SaveChanges();
                veriyiac();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            lstMusteriler.Items.Clear();
            if (comboBox2.Text == "Ad")
            {
                string aranan = txtAra.Text;
                var query = from item in ent.TBLmusteriler
                            where item.adi.Contains(aranan)
                            select item;
                var adList = query.ToList();

                foreach (var item in adList)
                {
                    ListViewItem ekle = new ListViewItem(item.musteriID.ToString());
                    ekle.SubItems.Add(item.adi.ToString());
                    ekle.SubItems.Add(item.soyadi.ToString());
                    ekle.SubItems.Add(item.telNu.ToString());
                    ekle.SubItems.Add(item.mail.ToString());
                    ekle.SubItems.Add(item.tcKimlikNu.ToString());
                    ekle.SubItems.Add(item.odaUcreti.ToString());
                    ekle.SubItems.Add(item.odaNu.ToString());
                    ekle.SubItems.Add(item.girisTarihi.ToString());
                    ekle.SubItems.Add(item.cikisTarihi.ToString());
                    if (item.cinsiyet.ToString() == "Erkek")
                    {
                        ekle.BackColor = Color.LightSkyBlue;
                    }
                    if (item.cinsiyet.ToString() == "Kadın")
                    {
                        ekle.BackColor = Color.LightPink;
                    }
                    if (item.cinsiyet.ToString() == "Diğer")
                    {
                        ekle.BackColor = Color.LightYellow;
                    }
                    lstMusteriler.Items.Add(ekle);
                }
            }

            if (comboBox2.Text == "Soyad")
            {
                string aranan = txtAra.Text;
                var query = from item in ent.TBLmusteriler
                            where item.soyadi.Contains(aranan)
                            select item;
                var soyadList = query.ToList();

                foreach (var item in soyadList)
                {
                    ListViewItem ekle = new ListViewItem(item.musteriID.ToString());
                    ekle.SubItems.Add(item.adi.ToString());
                    ekle.SubItems.Add(item.soyadi.ToString());
                    ekle.SubItems.Add(item.telNu.ToString());
                    ekle.SubItems.Add(item.mail.ToString());
                    ekle.SubItems.Add(item.tcKimlikNu.ToString());
                    ekle.SubItems.Add(item.odaUcreti.ToString());
                    ekle.SubItems.Add(item.odaNu.ToString());
                    ekle.SubItems.Add(item.girisTarihi.ToString());
                    ekle.SubItems.Add(item.cikisTarihi.ToString());
                    if (item.cinsiyet.ToString() == "Erkek")
                    {
                        ekle.BackColor = Color.LightSkyBlue;
                    }
                    if (item.cinsiyet.ToString() == "Kadın")
                    {
                        ekle.BackColor = Color.LightPink;
                    }
                    if (item.cinsiyet.ToString() == "Diğer")
                    {
                        ekle.BackColor = Color.LightYellow;
                    }
                    lstMusteriler.Items.Add(ekle);
                }
            }

            if (comboBox2.Text == "TC Kimlik")
            {
                string aranan = txtAra.Text;
                var query = from item in ent.TBLmusteriler
                            where item.tcKimlikNu.Contains(aranan)
                            select item;
                var tcList = query.ToList();

                foreach (var item in tcList)
                {
                    ListViewItem ekle = new ListViewItem(item.musteriID.ToString());
                    ekle.SubItems.Add(item.adi.ToString());
                    ekle.SubItems.Add(item.soyadi.ToString());
                    ekle.SubItems.Add(item.telNu.ToString());
                    ekle.SubItems.Add(item.mail.ToString());
                    ekle.SubItems.Add(item.tcKimlikNu.ToString());
                    ekle.SubItems.Add(item.odaUcreti.ToString());
                    ekle.SubItems.Add(item.odaNu.ToString());
                    ekle.SubItems.Add(item.girisTarihi.ToString());
                    ekle.SubItems.Add(item.cikisTarihi.ToString());
                    if (item.cinsiyet.ToString() == "Erkek")
                    {
                        ekle.BackColor = Color.LightSkyBlue;
                    }
                    if (item.cinsiyet.ToString() == "Kadın")
                    {
                        ekle.BackColor = Color.LightPink;
                    }
                    if (item.cinsiyet.ToString() == "Diğer")
                    {
                        ekle.BackColor = Color.LightYellow;
                    }
                    lstMusteriler.Items.Add(ekle);
                }
            }
        }

        private void frmMusteriGor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            if (cbTarihiAktiflestir.Checked == false)
            {
                DateTime giris = dtpGiris.Value;
                DateTime cikis = dtpCikis.Value;
                int kalinacakGun = cikis.Day - giris.Day;
                txtOdaUcreti.Text = (kalinacakGun * 200).ToString();
            }
        }

        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {
            if (cbTarihiAktiflestir.Checked == false)
            {
                DateTime giris = dtpGiris.Value;
                DateTime cikis = dtpCikis.Value;
                int kalinacakGun = cikis.Day - giris.Day;
                txtOdaUcreti.Text = (kalinacakGun * 200).ToString();
            }
        }

        private void frmMusteriGor_Load(object sender, EventArgs e)
        {
            txtAdi.MaxLength = 30;
            txtSoyadi.MaxLength = 20;
            txtTelNu.MaxLength = 11;
            txtMail.MaxLength = 50;
            txtTcKimlikNu.MaxLength = 11;
        }
    }
}
