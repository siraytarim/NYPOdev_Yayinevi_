using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta8_Odev
{
    public class yayınevi
    {
        public string ad;

        List<Kitap> ykitaplar = new List<Kitap>();
        List<Editor> editors = new List<Editor>();  

        public yayınevi(string ad)
        {
            this.ad = ad;
            this.editors = new List<Editor>();
            this.ykitaplar = new List<Kitap>(); 
        }
        public string Ad() { return this.ad; }
    }
}
