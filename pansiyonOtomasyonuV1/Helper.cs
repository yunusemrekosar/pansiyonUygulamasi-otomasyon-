using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyonOtomasyonuV1
{
    internal class Helper
    {
        public int Tdenetleyici(TextBox[] items)
        {
            int sonuc = 0;
            foreach (var item in items)
            {

                if (string.IsNullOrEmpty(item.Text))
                {
                    sonuc++;
                }
            }
            return sonuc;
        }

        public int Cdenetleyici(ComboBox[] items)
        {
            int sonuc = 0;
            foreach (var item in items)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    sonuc++;
                }
            }
            return sonuc;
        }


    }
}






