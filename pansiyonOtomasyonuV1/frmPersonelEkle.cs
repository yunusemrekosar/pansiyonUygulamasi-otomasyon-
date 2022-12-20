using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pansiyonOtomasyonuV1
{
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=pansiyon1DB;Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert TBLcalisanlar (calisanAdi, calisanSoyadi, calisanMaasi, calisanPozisyon)values(@calisanAdi, @calisanSoyadi, @calisanMaasi, @calisanPozisyon)", baglanti);
            komut.Parameters.AddWithValue("@calisanAdi", txtPersonelAdi.Text);
            komut.Parameters.AddWithValue("@calisanSoyadi", txtPersonelSoyadi.Text);
            komut.Parameters.AddWithValue("@calisanMaasi", txtPersonelMaasi.Text);
            komut.Parameters.AddWithValue("@calisanPozisyon", txtPersonelPozisyonu.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void veriyiac(string p1 = "01,01,1754", string p2 = "01,01,3000")
         {
             lstwPersonel.Items.Clear();
             baglanti.Open();
             SqlCommand komut = new SqlCommand("select * from TBLcalisanlar", baglanti);
            
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["calisanID"].ToString();
                ekle.SubItems.Add(oku["calisanAdi"].ToString());
                ekle.SubItems.Add(oku["calisanSoyadi"].ToString());
                ekle.SubItems.Add(oku["calisanMaasi"].ToString());
                ekle.SubItems.Add(oku["calisanPozisyon"].ToString());
                lstwPersonel.Items.Add(ekle);
                
            }
            
             baglanti.Close();
    }
        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            veriyiac();
        }
        int id = 0;
        private void lstwPersonel_DoubleClick(object sender, EventArgs e)
        {
           
            id = Convert.ToInt32(lstwPersonel.SelectedItems[0].SubItems[0].Text);
            txtPersonelAdi.Text = lstwPersonel.SelectedItems[0].SubItems[1].Text;
            txtPersonelSoyadi.Text = lstwPersonel.SelectedItems[0].SubItems[2].Text;
            txtPersonelMaasi.Text = lstwPersonel.SelectedItems[0].SubItems[3].Text;
            txtPersonelPozisyonu.Text = lstwPersonel.SelectedItems[0].SubItems[4].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from TBLcalisanlar where calisanID=@id", baglanti);
            sil.Parameters.AddWithValue("@id", id);
            sil.ExecuteNonQuery();
            baglanti.Close();
            veriyiac();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            lstwPersonel.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLcalisanlar set calisanAdi=@calisanAdi,calisanSoyadi=@calisanSoyadi,calisanMaasi=@calisanMaasi,calisanPozisyon=@calisanPozisyon where calisanID=@id", baglanti);
            komut.Parameters.AddWithValue("@calisanAdi", txtPersonelAdi.Text);
            komut.Parameters.AddWithValue("@calisanSoyadi", txtPersonelSoyadi.Text);
            komut.Parameters.AddWithValue("@calisanMaasi", txtPersonelMaasi.Text);
            komut.Parameters.AddWithValue("@calisanPozisyon", txtPersonelPozisyonu.Text);
            komut.Parameters.AddWithValue("@id  ", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriyiac();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnaMenu anaMenu = new frmAnaMenu();
            anaMenu.StartPosition = FormStartPosition.CenterScreen;
            anaMenu.Show();
            this.Hide();
        }
    }
}
