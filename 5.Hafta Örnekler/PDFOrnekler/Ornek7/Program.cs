using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerdeMetot
{
    class YardimciSinif
    {
        public int[] Dizi = {7,4,3};
        public int[] Metot()
        {
            int[] a = { 23, 45, 67 };
            return a;
        }
    }
    class AnaSinif
    {
        static void Main()
        {
            YardimciSinif nesne = new YardimciSinif();
            Console.WriteLine(nesne.Dizi[0]);
            Console.WriteLine(nesne.Metot()[2]);
            Console.ReadLine();
        }
    }
}
