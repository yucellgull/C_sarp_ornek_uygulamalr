using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    public class Silecek : UrunTemel
    {
        private int uzunluk;

        public Silecek(int kodu,double fiyat,string bilgi) : base(kodu, fiyat, bilgi) { }

        public int Uzunluk
        {
            get { return uzunluk; }
            set { uzunluk = value; }
        }

        public override string ToString()
        {
            return UrunKodu.ToString() + " " + BirimFiyat.ToString() 
                + " " + UrunTanimi + " " + Uzunluk.ToString();
        }
    }
}
