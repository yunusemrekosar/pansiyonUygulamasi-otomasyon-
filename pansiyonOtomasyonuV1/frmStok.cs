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
    public partial class frmStok : Form
    {
        public frmStok()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=pansiyon1DB;Integrated Security=True");

        private void btnAnamenuyeDon_Click(object sender, EventArgs e)
        {
            frmAnaMenu anaMenu= new frmAnaMenu();
            anaMenu.StartPosition = FormStartPosition.Manual;
            anaMenu.Location = new Point(104, 104);
            anaMenu.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert TBLalisveris (domates,patates,sogan,peynir,ekmek,salatalik,bal,recel,tereyag,yumurta,girisTarihi,toplamTutar) values (@domates,@patates,@sogan,@ekmek,@salatalik,@bal,@recel,@tereyag,@yumurta,@girisTarihi,@toplamTutar)", baglanti);
            komut.Parameters.AddWithValue("@domates", Convert.ToDecimal(txtDomates.Text));
            komut.Parameters.AddWithValue("@patates", Convert.ToDecimal(txtPatates.Text));
            komut.Parameters.AddWithValue("@sogan", Convert.ToDecimal(txtSogan.Text));
            komut.Parameters.AddWithValue("@peynir", Convert.ToDecimal(txtPeynir.Text));
            komut.Parameters.AddWithValue("@ekmek", int.Parse(txtEkmek.Text));
            komut.Parameters.AddWithValue("@salatalik", Convert.ToDecimal(txtSalatalık.Text));
            komut.Parameters.AddWithValue("@bal", Convert.ToDecimal(txtBal.Text));
            komut.Parameters.AddWithValue("@recel", Convert.ToDecimal(txtRecel.Text));
            komut.Parameters.AddWithValue("@tereyag", Convert.ToDecimal(txtTereyag.Text));
            komut.Parameters.AddWithValue("@yumurta", int.Parse(txtYumurta.Text));
            komut.Parameters.AddWithValue("@girisTarihi", dtpAlıs.Value.ToString("yyyy/MM/dd"));
            komut.Parameters.AddWithValue("@toplamTutar", int.Parse(txtToplam.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            frmStok_Load(sender, e);
        }

        private void frmStok_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutd = new SqlCommand("select sum(domates) from TBLalisveris", baglanti);
            decimal domates = (decimal)komutd.ExecuteScalar();
            txtDomatesStok.Text = domates.ToString();

            SqlCommand komut1 = new SqlCommand("select sum(patates) from TBLalisveris", baglanti);
            decimal patates = (decimal)komut1.ExecuteScalar();
            txtPatatesStok.Text = patates.ToString();
          
            SqlCommand komut2 = new SqlCommand("select sum(sogan) from TBLalisveris", baglanti);
            decimal sogan = (decimal)komut2.ExecuteScalar();
            txtSoganStok.Text = sogan.ToString();
           
            SqlCommand komut3 = new SqlCommand("select sum(peynir) from TBLalisveris", baglanti);
            decimal peynir = (decimal)komut3.ExecuteScalar();
            txtPeynirStok.Text = peynir.ToString();
         
            SqlCommand komut4 = new SqlCommand("select sum(ekmek) from TBLalisveris", baglanti);
            int ekmek = (int)komut4.ExecuteScalar();
            txtEkmekStok.Text = ekmek.ToString();
          
            SqlCommand komut5 = new SqlCommand("select sum(salatalik) from TBLalisveris", baglanti);
            decimal salatalik = (decimal)komut5.ExecuteScalar();
            txtSalatalıkStok.Text = salatalik.ToString();
          
            SqlCommand komut6 = new SqlCommand("select sum(bal) from TBLalisveris", baglanti);
            decimal bal = (decimal)komut6.ExecuteScalar();
            txtBalStok.Text = bal.ToString();
          
            SqlCommand komut7 = new SqlCommand("select sum(recel) from TBLalisveris", baglanti);
            decimal recel = (decimal)komut7.ExecuteScalar();
            txtRecelStok.Text = recel.ToString();
            
            SqlCommand komut8 = new SqlCommand("select sum(tereyag) from TBLalisveris", baglanti);
            decimal tereyag = (decimal)komut8.ExecuteScalar();
            txtTereyagStok.Text = tereyag.ToString();
            
            SqlCommand komut9 = new SqlCommand("select sum(yumurta) from TBLalisveris", baglanti);
            int yumurta = (int)komut9.ExecuteScalar();
            txtYumurtaStok.Text = yumurta.ToString();

            baglanti.Close();

        }

        private void frmStok_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
