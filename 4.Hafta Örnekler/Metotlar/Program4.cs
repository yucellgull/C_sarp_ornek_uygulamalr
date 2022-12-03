using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_4
{
    internal class Program
    {
        static void BitYaz(int b)
        {
            if (b == 0) return;
            BitYaz(b >> 1);
            Console.Write(b & 1);

        }
        static void Main(string[] args)
        {
            BitYaz(15);Console.WriteLine();
            BitYaz(32);Console.WriteLine();

            Console.ReadKey();
        }
    }
}
