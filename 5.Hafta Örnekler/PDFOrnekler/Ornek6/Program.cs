using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_set
{
  /*class MetotSinif
    {
        int Sayi;
        public void SayiBelirle(int sayi)
        {
            if (sayi < 0) Sayi = 0;
            else Sayi = sayi;
        }
        public int SayiAl()
        {
            if (Sayi > 100)
                return Sayi / 100;
            else return Sayi;
        }
    }
    class AnaSinif
    {
        static void Main()
        {
            MetotSinif nesne =new MetotSinif();
            nesne.SayiBelirle(34);
            Console.WriteLine(nesne.SayiAl());
            Console.ReadLine();
        }
    }*/

    class set_get
    {
        int Sayi;
        public int SahteOzellik
        {
            set
            {
                if(value < 0)Sayi = 0;
                else Sayi = value;
            }
            get
            {
                if (Sayi > 100) return Sayi / 100;
                else return Sayi;
            }
        }
    }
    class AnaSinif
    {
        static void Main()
        {
            set_get nesne =new set_get();
            nesne.SahteOzellik = 11;
            Console.WriteLine(nesne.SahteOzellik);
            Console.ReadLine();
        }
    }
}
