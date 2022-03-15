using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Odev_Telefon_Rehberi
{
    internal class Degiskenler
    {
        private string ad;
        public string Ad   // property
        {
            get { return ad; }   // get method
            set { ad = value; }  // set method
        }

        private string soyad;
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        private string numara;
        public string Numara
        {
            get { return numara; }
            set { numara = value; }
        
        }

        public Degiskenler(string ad, string soyad, string numara)
        {
            Ad = ad;
            Soyad = soyad;
            Numara = numara;
        }
    }
}
