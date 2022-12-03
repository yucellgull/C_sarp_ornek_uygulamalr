using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_6
{
    internal class Program
    {
        static void DegerTipAktarim(int sayi)
        {
            sayi = 30;
        }
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine(x);

            DegerTipAktarim(x);
            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
