using System;
using System.Linq;

namespace Metot_2
{
    internal class Program

    {
        static void Yaz(object a, int b)
        {
            if (b > 10) return;
            for (; b > 0; b--) Console.WriteLine(a);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Yaz("Merhaba", 5);
        }

    }
}
