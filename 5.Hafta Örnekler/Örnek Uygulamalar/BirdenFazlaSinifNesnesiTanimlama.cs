using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdenFazlaSinif_NesnesiTanimlama
{
    class KrediHesabi
    {
        public ulong HesapNo;
    }
    class AnaSinif
    {
        static void Main()
        {
            KrediHesabi hesap1 = new KrediHesabi();
            KrediHesabi hesap2 = new KrediHesabi();
            hesap1.HesapNo = 3456;
            hesap2.HesapNo = 2321;
            Console.WriteLine(hesap1.HesapNo);
            Console.WriteLine(hesap2.HesapNo);
            Console.ReadLine();
        }
    }
}
