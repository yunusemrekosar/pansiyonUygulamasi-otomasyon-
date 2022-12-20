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
            musteriekle.StartPosition = FormStartPosition.Manual;
            musteriekle.Location = new Point(104, 104);
            musteriekle.Show();
            this.Hide();
        }

        private void btnGoFrmOdalar_Click(object sender, EventArgs e)
        {
            frmOdalar odalar = new frmOdalar();
            odalar.StartPosition = FormStartPosition.Manual;
            odalar.Location = new Point(104, 104);
            odalar.Show();
            this.Hide();
        }

        private void btnGoFrmMusteriGor_Click(object sender, EventArgs e)
        {
            frmMusteriGor musteriGor= new frmMusteriGor();
            musteriGor.StartPosition = FormStartPosition.Manual;
            musteriGor.Location = new Point(104, 104);
            musteriGor.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGelirGider gelirGider= new frmGelirGider();
            gelirGider.StartPosition = FormStartPosition.Manual;
            gelirGider.Location = new Point(104, 104);
            gelirGider.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStok stok= new frmStok();
            stok.StartPosition = FormStartPosition.Manual;
            stok.Location = new Point(104, 104);
            stok.Location = this.Location;
            stok.Show();
            this.Hide();
        }

        private void frmAnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
