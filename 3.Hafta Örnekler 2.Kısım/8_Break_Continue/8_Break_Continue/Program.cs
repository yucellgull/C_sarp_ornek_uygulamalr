using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Break_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, t = 0;
            while (true)
            {
                Console.WriteLine("Negatif Bir Sayı Girin:");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0) break;
                if(sayi>0)
                {
                    Console.WriteLine("Pozitif sayı girdiniz,Tekrar Deneyin");
                    continue;

                }
                t=t+sayi;
            }
            Console.WriteLine("Toplam:{0}", t);
        }
    }
}
