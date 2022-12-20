using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyonOtomasyonuV1
{
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnGoFrmMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriekle = new MusteriEkle();
            musteriekle.StartPosition = FormStartPosition.CenterScreen;
            musteriekle.Show();
            this.Hide();
        }

        private void btnGoFrmOdalar_Click(object sender, EventArgs e)
        {
            frmOdalar odalar = new frmOdalar();
            odalar.StartPosition = FormStartPosition.CenterScreen;
            odalar.Show();
            this.Hide();
        }

        private void btnGoFrmMusteriGor_Click(object sender, EventArgs e)
        {
            frmMusteriGor musteriGor= new frmMusteriGor();
            musteriGor.StartPosition = FormStartPosition.CenterScreen;
            musteriGor.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGelirGider gelirGider= new frmGelirGider();
            gelirGider.StartPosition = FormStartPosition.CenterScreen;
            gelirGider.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStok stok= new frmStok();
            stok.StartPosition = FormStartPosition.CenterScreen;
            stok.Show();
            this.Hide();
        }

        private void frmAnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPersonelEkle personelEkle = new frmPersonelEkle();
            personelEkle.StartPosition= FormStartPosition.CenterScreen;
            personelEkle.Show();
            this.Hide();
        }
    }
}
