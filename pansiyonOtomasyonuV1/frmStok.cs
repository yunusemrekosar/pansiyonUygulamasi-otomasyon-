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
    public partial class frmStok : Form
    {
        public frmStok()
        {
            InitializeComponent();
        }
        pansiyonEntities ent = new pansiyonEntities();
        private void btnAnamenuyeDon_Click(object sender, EventArgs e)
        {
            frmAnaMenu anaMenu = new frmAnaMenu();
            anaMenu.StartPosition = FormStartPosition.CenterScreen;
            anaMenu.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[] { txtToplam };
            Helper denetleyici = new Helper();
            int a = denetleyici.Tdenetleyici(textBoxes);
            if (a > 0)
            {
                MessageBox.Show("Toplam Tutar Boş Bırakılamaz");
            }
            else
            {
                TBLalisveris alıs = new TBLalisveris();
                alıs.domates = Convert.ToDecimal(txtDomates.Text);
                alıs.sogan = Convert.ToDecimal(txtSogan.Text); ;
                alıs.patates = Convert.ToDecimal(txtPatates.Text);
                alıs.peynir = Convert.ToDecimal(txtPeynir.Text);
                alıs.ekmek = byte.Parse(txtEkmek.Text);
                alıs.salatalik = Convert.ToDecimal(txtSalatalık.Text);
                alıs.bal = Convert.ToDecimal(txtBal.Text);
                alıs.tereyag = Convert.ToDecimal(txtTereyag.Text);
                alıs.yumurta = byte.Parse(txtYumurta.Text);
                alıs.recel = Convert.ToDecimal(txtRecel.Text);
                alıs.toplamTutar = int.Parse(txtToplam.Text);
                alıs.girisTarihi = dtpAlıs.Value;
                ent.TBLalisveris.Add(alıs);
                ent.SaveChanges();
                frmStok_Load(sender, e);
            }
        }

        private void frmStok_Load(object sender, EventArgs e)
        {
            var domates = ent.TBLalisveris.Sum(p => p.domates);
            txtDomatesStok.Text = domates.ToString();

            var sogan = ent.TBLalisveris.Sum(p => p.domates);
            txtSoganStok.Text = sogan.ToString();

            var patates = ent.TBLalisveris.Sum(p => p.domates);
            txtPatatesStok.Text = patates.ToString();

            var peynir = ent.TBLalisveris.Sum(p => p.domates);
            txtPeynirStok.Text = peynir.ToString();

            var ekmek = ent.TBLalisveris.Sum(p => p.domates);
            txtEkmekStok.Text = ekmek.ToString();

            var salatalik = ent.TBLalisveris.Sum(p => p.domates);
            txtSalatalıkStok.Text = salatalik.ToString();

            var bal = ent.TBLalisveris.Sum(p => p.domates);
            txtBalStok.Text = bal.ToString();

            var tereyag = ent.TBLalisveris.Sum(p => p.domates);
            txtTereyagStok.Text = tereyag.ToString();

            var yumurta = ent.TBLalisveris.Sum(p => p.domates);
            txtYumurtaStok.Text = yumurta.ToString();

            var recel = ent.TBLalisveris.Sum(p => p.domates);
            txtRecelStok.Text = recel.ToString();
        }

        private void frmStok_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
