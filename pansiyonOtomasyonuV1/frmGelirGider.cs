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

            decimal gaylık = Hesapla("TBLmusteriler", "odaUcreti", 1, "girisTarihi");
            string gaylıks = gaylık.ToString();
            gaylıks = String.Format("{0:n0}", gaylık);
            decimal gaylık3 = Hesapla("TBLmusteriler", "odaUcreti", 3, "girisTarihi");
            string gaylık3s = gaylık3.ToString();
            gaylık3s = String.Format("{0:n0}", gaylık3);
            decimal gaylık6 = Hesapla("TBLmusteriler", "odaUcreti", 6, "girisTarihi");
            string gaylık6s = gaylık6.ToString();
            gaylık6s = String.Format("{0:n0}", gaylık6);
            decimal gyıllık = Hesapla("TBLmusteriler", "odaUcreti", 12, "girisTarihi");
            string gyıllıks = gyıllık.ToString();
            gyıllıks = String.Format("{0:n0}", gyıllık);
            lblAylıkGelir.Text = "Gelir:" + "  " + gaylıks;
            lbl3AylıkGelir.Text = "Gelir:" + "  " + gaylık3s;
            lbl6AylıkGelir.Text = "Gelir:" + "  " + gaylık6s;
            lblYıllıkGelir.Text = "Gelir:" + "  " + gyıllıks;

            decimal maylık = Hesapla("TBLalisveris", "toplamTutar", 1, "girisTarihi");
            string maylıks = maylık.ToString();
            maylıks = String.Format("{0:n0}", maylık);
            decimal maylık3 = Hesapla("TBLalisveris", "toplamTutar", 3, "girisTarihi");
            string maylık3s = maylık3.ToString();
            maylık3s = String.Format("{0:n0}", maylık3);
            decimal maylık6 = Hesapla("TBLalisveris", "toplamTutar", 6, "girisTarihi");
            string maylık6s = maylık6.ToString();
            maylık6s = String.Format("{0:n0}", maylık6);
            decimal myıllık = Hesapla("TBLalisveris", "toplamTutar", 12, "girisTarihi");
            string myıllıks = myıllık.ToString();
            myıllıks = String.Format("{0:n0}", myıllık);
            lblAylıkMutfak.Text = "Mutfak Harcaması:" + "  " + maylıks;
            lbl3AylıkMutfak.Text = "Mutfak Harcaması:" + "  " + maylık3s;
            lbl6AylıkMutfak.Text = "Mutfak Harcaması:" + "  " + maylık6s;
            lblYıllıkMutfak.Text = "Mutfak Harcaması:" + "  " + myıllıks;


            decimal caylık = Hesapla("TBLcalisanlar", "calisanMaasi", 1);
            string caylıks = caylık.ToString();
            caylıks = String.Format("{0:n0}", caylık);
            decimal caylık3 = Hesapla("TBLcalisanlar", "calisanMaasi", 3);
            string caylık3s = caylık3.ToString();
            caylık3s = String.Format("{0:n0}", caylık3);
            decimal caylık6 = Hesapla("TBLcalisanlar", "calisanMaasi", 6);
            string caylık6s = caylık6.ToString();
            caylık6s = String.Format("{0:n0}", caylık6);
            decimal cyıllık = Hesapla("TBLcalisanlar", "calisanMaasi", 12);
            string cyıllıks = cyıllık.ToString();
            cyıllıks = String.Format("{0:n0}", cyıllık);
            lblAylıkCalısan.Text = "Çalışan Ücreti:" + "  " + caylıks;
            lbl3AylıkCalısan.Text = "Çalışan Ücreti:" + "  " + caylık3s;
            lbl6AylıkCalısan.Text = "Çalışan Ücreti:" + "  " + caylık6s;
            lblYıllıkCalısan.Text = "Çalışan Ücreti:" + "  " + cyıllıks;

            decimal faylık = Hesapla("TBLfaturalar", "faturaTutari", 1, "faturaTarihi");
            string faylıks = faylık.ToString();
            faylıks = String.Format("{0:n0}", faylık);
            decimal faylık3 = Hesapla("TBLfaturalar", "faturaTutari", 3, "faturaTarihi");
            string faylık3s = faylık3.ToString();
            faylık3s = String.Format("{0:n0}", faylık3);
            decimal faylık6 = Hesapla("TBLfaturalar", "faturaTutari", 6, "faturaTarihi");
            string faylık6s = faylık6.ToString();
            faylık6s = String.Format("{0:n0}", faylık6);
            decimal fyıllık = Hesapla("TBLfaturalar", "faturaTutari", 12, "faturaTarihi");
            string fyıllıks = fyıllık.ToString();
            fyıllıks = String.Format("{0:n0}", fyıllık);
            lblAylıkFatura.Text = "Faturalar:" + "  " + faylıks;
            lbl3AylıkFatura.Text = "Faturalar:" + "  " + faylık3s;
            lbl6AylıkFatura.Text = "Faturalar:" + "  " + faylık6s;
            lblYıllıkFatura.Text = "Faturalar:" + "  " + fyıllıks;

            decimal aylıkSayı = Convert.ToDecimal((gaylık - ((gaylık / 100) * 18)) - (maylık + caylık + faylık));
            string aylıkSayıs = aylıkSayı.ToString();
            aylıkSayıs = String.Format("{0:n0}", aylıkSayı);
            lblAylık.Text = "Kasa:" + "  " + aylıkSayıs.ToString();

            decimal aylıkSayı3 = Convert.ToDecimal((gaylık3 - ((gaylık3 / 100) * 18)) - (maylık3 + caylık3 + faylık3));
            string aylıkSayıs3 = aylıkSayı3.ToString();
            aylıkSayıs3 = String.Format("{0:n0}", aylıkSayı3);
            lbl3Aylık.Text = "Kasa:" + "  " + aylıkSayıs3.ToString();

            decimal aylıkSayı6 = Convert.ToDecimal((gaylık6 - ((gaylık6 / 100) * 18)) - (maylık6 + caylık6 + faylık6));
            string aylıkSayıs6 = aylıkSayı3.ToString();
            aylıkSayıs6 = String.Format("{0:n0}", aylıkSayı6);
            lbl6Aylık.Text = "Kasa:" + "  " + aylıkSayıs6.ToString();

            decimal yıllıkSayı = Convert.ToDecimal((gyıllık - ((gyıllık / 100) * 18)) - (myıllık + cyıllık + fyıllık));
            string yıllıkSayıs = yıllıkSayı.ToString();
            yıllıkSayıs = String.Format("{0:n0}", yıllıkSayı);
            lblYıllık.Text = "Kasa:" + "  " + yıllıkSayıs.ToString();

            decimal aylıkVergi = Convert.ToDecimal((((gaylık + maylık + caylık + faylık) / 100) * 18));
            string aylıkVergis = aylıkVergi.ToString();
            aylıkVergis = String.Format("{0:n0}", aylıkVergi);
            lblAylıkVergi.Text = "Vergi:" + "  " + aylıkVergis.ToString();

            decimal aylıkVergi3 = Convert.ToDecimal((((gaylık3 + maylık3 + caylık3 + faylık3) / 100) * 18));
            string aylıkVergis3 = aylıkVergi3.ToString();
            aylıkVergis3 = String.Format("{0:n0}", aylıkVergi3);
            lbl3AylıkVergi.Text = "Vergi:" + "  " + aylıkVergis3.ToString();

            decimal aylıkVergi6 = Convert.ToDecimal((((gaylık6 + maylık6 + caylık6 + faylık6) / 100) * 18));
            string aylıkVergis6 = aylıkVergi6.ToString();
            aylıkVergis6 = String.Format("{0:n0}", aylıkVergi6);
            lbl6AylıkVergi.Text = "Vergi:" + "  " + aylıkVergis6.ToString();

            decimal yıllıkVergi = Convert.ToDecimal((((gyıllık + myıllık + cyıllık + fyıllık) / 100) * 18));
            string yıllıkVergis = yıllıkVergi.ToString();
            yıllıkVergis = String.Format("{0:n0}", yıllıkVergi);
            lblYıllıkVergi.Text = "Vergi:" + "  " + yıllıkVergis.ToString();
        }


        private void frmGelirGider_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaMenuyeDon_Click(object sender, EventArgs e)
        {
            frmAnaMenu anaMenu = new frmAnaMenu();
            anaMenu.StartPosition = FormStartPosition.CenterScreen;
            anaMenu.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ComboBox[] comboBoxes = new ComboBox[] { cbFaturaAdi };
            TextBox[] textBoxes = new TextBox[] { txtFaturaTutari };
            Helper denetleyici = new Helper();
            int a = denetleyici.Tdenetleyici(textBoxes);
            int b = denetleyici.Cdenetleyici(comboBoxes);
            if (a+b > 0)
            {
                MessageBox.Show("Boş Bırakılamaz Metin Kutuları Var");
                a = 0;
            }
            else
            {
                DateTime tarih = new DateTime();
                tarih = dtpTarih.Value;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert TBLfaturalar (faturaAdi, faturaTutari, faturaTarihi)values(@adi,@tutari,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@adi", cbFaturaAdi.Text);
                komut.Parameters.AddWithValue("@tutari", Convert.ToDecimal(txtFaturaTutari.Text));
                komut.Parameters.AddWithValue("@tarih", tarih.ToString("yyyy/MM/dd"));
                komut.ExecuteNonQuery();
                baglanti.Close();
                label1.Text = "Fatura Eklendi";
                frmGelirGider_Load(sender, e);
            }
        }
    }
}
