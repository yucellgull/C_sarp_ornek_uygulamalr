using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
   class Yapilar
    {
        struct Ogrenci
        {
            public int numara;
            public string ad;
            public string soyad;
        }

        public static void Main()
        {
            Ogrenci ogrt = new Ogrenci();

            ogrt.numara = 87;
            ogrt.ad = "Ali";
            ogrt.soyad = "Türk";

            Ogrenci ogrt2 = ogrt;

            ogrt2.numara = 435;

            Console.WriteLine("{0} {1} {2}", ogrt.numara, ogrt.ad, ogrt.soyad);
            Console.WriteLine("{0}{1}{2}", ogrt2.numara, ogrt2.ad, ogrt2.soyad);
        }
    }
}
