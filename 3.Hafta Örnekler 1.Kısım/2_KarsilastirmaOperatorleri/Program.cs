using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 15;
            if (a == b) Console.WriteLine("a,b ye eşittir");
            if (a < b) Console.WriteLine("a,b'den büyüktür");
            if (a > b) Console.WriteLine("a, b'den büyüktür");
            if (a != b) Console.WriteLine("a,b'ye eşit değidir");
            if (a >= b) Console.WriteLine("a,b 'ye eşittir veya büyüktür");
            if (a <= b) Console.WriteLine("a,b'ye eşittir veya küçüktür");
        }
    }
}
