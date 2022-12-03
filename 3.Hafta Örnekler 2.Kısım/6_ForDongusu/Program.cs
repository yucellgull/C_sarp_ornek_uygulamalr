using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i <=n; i++)
                toplam=toplam+i;
            Console.WriteLine("1\'den {0}\'e kadar olan sayıların toplamı {1}\'dir",n,toplam);
        }
    }
}
