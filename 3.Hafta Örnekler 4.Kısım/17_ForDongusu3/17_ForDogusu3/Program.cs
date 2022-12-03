using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ForDogusu3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, a, n;
            Console.WriteLine("Bir Sayı Giriniz:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Artım Miktarını Giriniz:");
            a = Convert.ToInt32(Console.ReadLine());

            for (; i < n;)
            {
                Console.WriteLine("{0}",i);
                i += a;
            }

        }
    }
}
