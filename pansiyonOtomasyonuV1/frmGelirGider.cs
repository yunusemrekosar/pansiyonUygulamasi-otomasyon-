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
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=pansiyon1DB;Integrated Security=True");
        private int Hesapla(string tablo, string kolon, int ay, string tarihkolonu = "")
        {
            int sonuc = 0;
            baglanti.Open();

            if (tarihkolonu != "")
            {
                DateTime tarih = DateTime.Now;
                DateTime tarihDegiskeni = tarih.AddMonths(-ay);
                string tarih1 = tarihDegiskeni.ToString("yyyy/MM/dd");
                string tarih2 = tarih.ToString("yyyy/MM/dd");

                SqlCommand komut = new SqlCommand("select sum(" + kolon + ") from [" + tablo + "] where " + tarihkolonu + " between '" + tarih1 + "' and '" + tarih2 + "'", baglanti);


                sonuc += Convert.ToInt32(komut.ExecuteScalar());

            }
            if (tarihkolonu == "")
            {
                SqlCommand komut = new SqlCommand("select sum([" + kolon + "]) from [" + tablo + "]", baglanti); ;
                sonuc = (int)komut.ExecuteScalar();
                sonuc = sonuc * ay;
            }

            baglanti.Close();
            return sonuc;
        }

        private void frmGelirGider_Load(object sender, EventArgs e)
        {

            decimal gaylık = Hesapla("TBLmusteriler", "odaUcreti", 1, "cikisTarihi");
            decimal gaylık3 = Hesapla("TBLmusteriler", "odaUcreti", 3, "cikisTarihi");
            decimal gaylık6 = Hesapla("TBLmusteriler", "odaUcreti", 6, "cikisTarihi");
            decimal gyıllık = Hesapla("TBLmusteriler", "odaUcreti", 12, "cikisTarihi");
            lblAylıkGelir.Text = gaylık.ToString();
            lbl3AylıkGelir.Text = gaylık3.ToString();
            lbl6AylıkGelir.Text = gaylık6.ToString();
            lblYıllıkGelir.Text = gyıllık.ToString();
            decimal maylık = Hesapla("TBLalisveris", "toplamTutar", 1, "girisTarihi");
            decimal maylık3 = Hesapla("TBLalisveris", "toplamTutar", 3, "girisTarihi");
            decimal maylık6 = Hesapla("TBLalisveris", "toplamTutar", 6, "girisTarihi");
            decimal myıllık = Hesapla("TBLalisveris", "toplamTutar", 12, "girisTarihi");
            lblAylıkMutfak.Text = maylık.ToString();
            lbl3AylıkMutfak.Text = maylık3.ToString();
            lbl6AylıkMutfak.Text = maylık6.ToString();
            lblYıllıkMutfak.Text = myıllık.ToString();
            decimal caylık = Hesapla("TBLcalisanlar", "calisanMaasi", 1);
            decimal caylık3 = Hesapla("TBLcalisanlar", "calisanMaasi", 3);
            decimal caylık6 = Hesapla("TBLcalisanlar", "calisanMaasi", 6);
            decimal cyıllık = Hesapla("TBLcalisanlar", "calisanMaasi", 12);
            lblAylıkCalısan.Text = caylık.ToString();
            lbl3AylıkCalısan.Text = caylık3.ToString();
            lbl6AylıkCalısan.Text = caylık6.ToString();
            lblYıllıkCalısan.Text = cyıllık.ToString();
        }

        private void frmGelirGider_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaMenuyeDon_Click(object sender, EventArgs e)
        {
            frmAnaMenu anaMenu = new frmAnaMenu();
            anaMenu.StartPosition = FormStartPosition.Manual;
            anaMenu.Location = new Point(104, 104);
            anaMenu.Show();
            this.Hide();
        }
    }
}
