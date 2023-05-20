using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta8_Odev
{
    public class Editor
    {
        string adsoyad;
        string yE;
        public Editor(string adsoyad,string yE)
        {
            this.adsoyad = adsoyad;
            this.yE = yE;
        }
        public string AdSoyad { get { return adsoyad; } set {adsoyad=value ;} }
        public string YE { get { return yE; } set { yE=value; } }
    }
}
