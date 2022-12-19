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
    public partial class frmOdalar : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=pansiyon1DB;Integrated Security=True");

        public frmOdalar()
        {
            InitializeComponent();
        }

        private void doldurbosalt(Button button, string cikis = "1000/01/01", string adı= "")
        {
            string odanu = button.Text;
            button.BackColor = Color.FromArgb(128, 255, 128);
            button.Enabled = true;
            button.Text = odanu;

            if (Convert.ToDateTime(cikis) > DateTime.Now)
            {
                button.Text = adı;
                button.BackColor = Color.Tomato;
                button.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnaMenu anaMenu = new frmAnaMenu();
            anaMenu.StartPosition = FormStartPosition.Manual;
            anaMenu.Location = new Point(104, 104);
            anaMenu.Show();
            this.Hide();
        }

        private void frmOdalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select adi,soyadi,odaNu,cikisTarihi from TBLmusteriler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string p1 = "btn" + oku["odaNu"].ToString();
                string p2 = oku["cikisTarihi"].ToString();
                string p3 = oku["adi"] + " " + oku["soyadi"];
                switch (p1)
                {
                    case "btn101":
                        doldurbosalt(btn101, p2, p3);
                        break;
                    case "btn102":
                        doldurbosalt(btn102, p2, p3);
                        break;
                    case "btn103":
                        doldurbosalt(btn103, p2, p3);
                        break;
                    case "btn104":
                        doldurbosalt(btn104, p2, p3);
                        break;
                    case "btn105":
                        doldurbosalt(btn105, p2, p3);
                        break;

                    case "btn201":
                        doldurbosalt(btn201, p2, p3);
                        break;
                    case "btn202":
                        doldurbosalt(btn202, p2, p3);
                        break;
                    case "btn203":
                        doldurbosalt(btn203, p2, p3);
                        break;
                    case "btn204":
                        doldurbosalt(btn204, p2, p3);
                        break;
                    case "btn205":
                        doldurbosalt(btn205, p2, p3);
                        break;

                    case "btn301":
                        doldurbosalt(btn301, p2, p3);
                        break;
                    case "btn302":
                        doldurbosalt(btn302, p2, p3);
                        break;
                    case "btn303":
                        doldurbosalt(btn303, p2, p3);
                        break;
                    case "btn304":
                        doldurbosalt(btn304, p2, p3);
                        break;
                    case "btn305":
                        doldurbosalt(btn305, p2, p3);
                        break;

                    case "btn401":
                        doldurbosalt(btn401, p2, p3);
                        break;
                    case "btn402":
                        doldurbosalt(btn402, p2, p3);
                        break;
                    case "btn403":
                        doldurbosalt(btn403, p2, p3);
                        break;
                    case "btn404":
                        doldurbosalt(btn404, p2, p3);
                        break;
                    case "btn405":
                        doldurbosalt(btn405, p2, p3);
                        break;

                    case "btn501":
                        doldurbosalt(btn501, p2, p3);
                        break;
                    case "btn502":
                        doldurbosalt(btn502, p2, p3);
                        break;
                    case "btn503":
                        doldurbosalt(btn503, p2, p3);
                        break;
                    case "btn504":
                        doldurbosalt(btn504, p2, p3);
                        break;
                    case "btn505":
                        doldurbosalt(btn505, p2, p3);
                        break;
                    default: break;
                }

            }
            baglanti.Close();
        }

        private void frmOdalar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
