using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta8_Odev
{
    public class Kitap
    {
        public string ad;
        yayınevi yE;
        public Kitap(string AD)
        {
            this.ad = AD;
        }
        public Kitap(string ad, yayınevi yE)
        {
            this.ad = ad;
            this.yE = yE;
        }

        public string Ad { get { return ad; } set { ad = value; } }
           }
}
