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


namespace pansiyonOtomasyonuV1
{
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }
        pansiyonEntities enti = new pansiyonEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[] { txtPersonelAdi, txtPersonelSoyadi, txtPersonelMaasi, txtPersonelPozisyonu};
            Helper denetleyici = new Helper();
            int a = denetleyici.Tdenetleyici(textBoxes);
            if (a > 0)
            {
                MessageBox.Show("Boş Bırakılamaz Metin Kutuları Var");
                a = 0;
            }
            else
            {
                TBLcalisanlar per = new TBLcalisanlar();
                per.calisanAdi = txtPersonelAdi.Text;
                per.calisanSoyadi = txtPersonelSoyadi.Text;
                per.calisanMaasi = short.Parse(txtPersonelMaasi.Text);
                per.calisanPozisyon = txtPersonelPozisyonu.Text;
                enti.TBLcalisanlar.Add(per);
                enti.SaveChanges();
                veriyiac();
            }
        }

        private void veriyiac()
         {
            lstwPersonel.Items.Clear();
            var perList = enti.TBLcalisanlar.ToList();

            foreach (var item in perList)
            {
                ListViewItem ekle = new ListViewItem(item.calisanID.ToString());
                ekle.SubItems.Add(item.calisanAdi.ToString());
                ekle.SubItems.Add(item.calisanSoyadi.ToString());
                ekle.SubItems.Add(item.calisanMaasi.ToString());
                ekle.SubItems.Add(item.calisanPozisyon.ToString());
                lstwPersonel.Items.Add(ekle);
            }
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
            var per = enti.TBLcalisanlar.Find(id);
            enti.TBLcalisanlar.Remove(per);
            enti.SaveChanges();
            veriyiac();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[] { txtPersonelAdi, txtPersonelSoyadi, txtPersonelMaasi, txtPersonelPozisyonu };
            Helper denetleyici = new Helper();
            int a = denetleyici.Tdenetleyici(textBoxes);
            if (a > 0)
            {
                MessageBox.Show("Boş Bırakılamaz Metin Kutuları Var");
                a = 0;
            }
            else
            {
                lstwPersonel.Items.Clear();
                var per = enti.TBLcalisanlar.Find(id);
                per.calisanAdi = txtPersonelAdi.Text;
                per.calisanSoyadi = txtPersonelSoyadi.Text;
                per.calisanMaasi = short.Parse(txtPersonelMaasi.Text);
                per.calisanPozisyon = txtPersonelPozisyonu.Text;
                enti.SaveChanges();
                veriyiac();
            }
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
