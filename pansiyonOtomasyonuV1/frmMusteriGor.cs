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

        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=pansiyon1DB;Integrated Security=True");

        private void veriyiac(string p1 = "01,01,1754", string p2 = "01,01,3000")
        {
            lstMusteriler.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLmusteriler where girisTarihi between @p1 and @p2 ", baglanti);
            komut.Parameters.AddWithValue("@p1", Convert.ToDateTime(p1));
            komut.Parameters.AddWithValue("@p2", Convert.ToDateTime(p2));
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteriID"].ToString();
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["telNu"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tcKimlikNu"].ToString());
                ekle.SubItems.Add(oku["odaUcreti"].ToString());
                ekle.SubItems.Add(oku["odaNu"].ToString());
                ekle.SubItems.Add(oku["girisTarihi"].ToString());
                ekle.SubItems.Add(oku["cikisTarihi"].ToString());
                if (oku["Cinsiyet"].ToString() == "Erkek")
                {
                    ekle.BackColor = Color.LightSkyBlue;
                }
                if (oku["Cinsiyet"].ToString() == "Kadın")
                {
                    ekle.BackColor = Color.LightPink;
                }
                if (oku["Cinsiyet"].ToString() == "Diğer")
                {
                    ekle.BackColor = Color.LightYellow;

                }
                lstMusteriler.Items.Add(ekle);
            }
            baglanti.Close();
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
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from TBLmusteriler where musteriID=@id", baglanti);
            sil.Parameters.AddWithValue("@id", id);
            sil.ExecuteNonQuery();
            baglanti.Close();
            veriyiac();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[] { txtAdi, txtSoyadi, txtTelNu, txtTcKimlikNu, txtOdaUcreti };
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
                baglanti.Open();
                DateTime giris = dtpGiris.Value;
                DateTime cikis = dtpCikis.Value;
                SqlCommand guncelle = new SqlCommand("update TBLmusteriler set Adi=@Adi,soyadi=@soyadi,telNu=@telNu,cinsiyet=@cinsiyet, mail=@mail,tcKimlikNu=@tcKimlikNu,odaUcreti=@odaUcreti,odaNu=@odaNu,girisTarihi=@girisTarihi,cikisTarihi=@cikisTarihi where musteriID=@id", baglanti);
                guncelle.Parameters.AddWithValue("@id", id);
                guncelle.Parameters.AddWithValue("@Adi", txtAdi.Text);
                guncelle.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
                guncelle.Parameters.AddWithValue("@telNu", txtTelNu.Text);
                guncelle.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
                guncelle.Parameters.AddWithValue("@mail", txtMail.Text);
                guncelle.Parameters.AddWithValue("@tcKimlikNu", txtTcKimlikNu.Text);
                guncelle.Parameters.AddWithValue("@odaUcreti", int.Parse(txtOdaUcreti.Text));
                guncelle.Parameters.AddWithValue("@odaNu", txtOdaNu.Text);
                guncelle.Parameters.AddWithValue("@girisTarihi", giris.ToString("yyyy /MM/dd"));
                guncelle.Parameters.AddWithValue("@cikisTarihi", cikis.ToString("yyyy /MM/dd"));
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                veriyiac();
            }

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            lstMusteriler.Items.Clear();
            baglanti.Open();

            if (comboBox2.Text == "Ad")
            {
                SqlCommand ara = new SqlCommand("Select * from TBLmusteriler where adi like '%" + txtAra.Text + "%' ", baglanti);
                SqlDataReader oku = ara.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["musteriID"].ToString();
                    ekle.SubItems.Add(oku["adi"].ToString());
                    ekle.SubItems.Add(oku["soyadi"].ToString());
                    ekle.SubItems.Add(oku["telNu"].ToString());
                    ekle.SubItems.Add(oku["mail"].ToString());
                    ekle.SubItems.Add(oku["tcKimlikNu"].ToString());
                    ekle.SubItems.Add(oku["odaUcreti"].ToString());
                    ekle.SubItems.Add(oku["odaNu"].ToString());
                    ekle.SubItems.Add(oku["girisTarihi"].ToString());
                    ekle.SubItems.Add(oku["cikisTarihi"].ToString());
                    if (oku["Cinsiyet"].ToString() == "Erkek")
                    {
                        ekle.BackColor = Color.LightSkyBlue;
                    }
                    if (oku["Cinsiyet"].ToString() == "Kadın")
                    {
                        ekle.BackColor = Color.LightPink;
                    }
                    if (oku["Cinsiyet"].ToString() == "Diğer")
                    {
                        ekle.BackColor = Color.LightYellow;

                    }
                    lstMusteriler.Items.Add(ekle);

                }

            }

            if (comboBox2.Text == "Soyad")
            {
                SqlCommand ara = new SqlCommand("Select * from TBLmusteriler where soyadi like '%" + txtAra.Text + "%'", baglanti);
                SqlDataReader oku = ara.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["musteriID"].ToString();
                    ekle.SubItems.Add(oku["adi"].ToString());
                    ekle.SubItems.Add(oku["soyadi"].ToString());
                    ekle.SubItems.Add(oku["telNu"].ToString());
                    ekle.SubItems.Add(oku["mail"].ToString());
                    ekle.SubItems.Add(oku["tcKimlikNu"].ToString());
                    ekle.SubItems.Add(oku["odaUcreti"].ToString());
                    ekle.SubItems.Add(oku["odaNu"].ToString());
                    ekle.SubItems.Add(oku["girisTarihi"].ToString());
                    ekle.SubItems.Add(oku["cikisTarihi"].ToString());
                    if (oku["Cinsiyet"].ToString() == "Erkek")
                    {
                        ekle.BackColor = Color.LightSkyBlue;
                    }
                    if (oku["Cinsiyet"].ToString() == "Kadın")
                    {
                        ekle.BackColor = Color.LightPink;
                    }
                    if (oku["Cinsiyet"].ToString() == "Diğer")
                    {
                        ekle.BackColor = Color.LightYellow;

                    }
                    lstMusteriler.Items.Add(ekle);

                }

            }

            if (comboBox2.Text == "TC Kimlik")
            {
                SqlCommand ara = new SqlCommand("Select * from TBLmusteriler where tcKimlikNu like '%" + txtAra.Text + "%'", baglanti);
                SqlDataReader oku = ara.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["musteriID"].ToString();
                    ekle.SubItems.Add(oku["adi"].ToString());
                    ekle.SubItems.Add(oku["soyadi"].ToString());
                    ekle.SubItems.Add(oku["telNu"].ToString());
                    ekle.SubItems.Add(oku["mail"].ToString());
                    ekle.SubItems.Add(oku["tcKimlikNu"].ToString());
                    ekle.SubItems.Add(oku["odaUcreti"].ToString());
                    ekle.SubItems.Add(oku["odaNu"].ToString());
                    ekle.SubItems.Add(oku["girisTarihi"].ToString());
                    ekle.SubItems.Add(oku["cikisTarihi"].ToString());
                    if (oku["Cinsiyet"].ToString() == "Erkek")
                    {
                        ekle.BackColor = Color.LightSkyBlue;
                    }
                    if (oku["Cinsiyet"].ToString() == "Kadın")
                    {
                        ekle.BackColor = Color.LightPink;
                    }
                    if (oku["Cinsiyet"].ToString() == "Diğer")
                    {
                        ekle.BackColor = Color.LightYellow;

                    }
                    lstMusteriler.Items.Add(ekle);
                }
            }
            baglanti.Close();
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
