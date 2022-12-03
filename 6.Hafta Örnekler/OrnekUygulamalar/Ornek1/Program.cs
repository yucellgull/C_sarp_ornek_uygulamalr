using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    class Zaman
    {
        public int Saat; public int Dakika; public int Saniye;
        public Zaman(int saat, int dakika, int saniye)
        {
            Saat = saat + dakika / 60;
            Dakika = dakika + saniye / 60;
            Saniye = saniye % 60;
            Dakika = Dakika % 60;
        }
        /*public static Zaman operator+(Zaman a,Zaman b)
        {
            int ToplamSaniye = a.Saniye + b.Saniye;
            int ToplamDakika = a.Dakika + b.Dakika;
            int ToplamSaat = a.Saat + b.Saat;

            return new Zaman(ToplamSaat, ToplamDakika, ToplamSaniye);   

        }

          public static bool operator ==(Zaman a, Zaman b)
        {
            if (a.Saniye == b.Saniye && a.Dakika == b.Dakika && a.Saat == b.Saat)
                return true;
            else
                return false;
        }
        public static bool operator!=(Zaman a, Zaman b)
            {
            return !(a == b);
            }

        public static bool operator|(Zaman a, Zaman b)
        {
            if (a.Saat > 12 || b.Saat > 12)
                return true;
            else
                return false;
        }*/
        class AnaProgram
        {
            static void Main()
            {
                Zaman zaman1 = new Zaman(5, 58, 60);
                Zaman zaman2 = new Zaman(3, 38, 120);
                Zaman zaman3 = zaman1 + zaman2;

                Console.WriteLine("{0}.{1}.{2}", zaman3.Saat, zaman3.Dakika, zaman3.Saniye);

                Console.ReadLine();

               /* if (zaman1)
                    Console.WriteLine("Öğleden Sonra");
                else
                    Console.WriteLine("Öğleden Önce");

                if (zaman2)
                    Console.WriteLine("Öğleden Sonra");
                else
                    Console.WriteLine("Öğleden Önce");
               */
            }
        }
    }
}
