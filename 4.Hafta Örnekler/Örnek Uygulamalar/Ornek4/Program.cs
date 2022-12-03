using System;
using System.Linq;

namespace Ornek_4
{
    internal class Program
    {
        static int BuyukBul(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.Write("1.Sayıyı Giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.SayıyıGiriniz:");
            sayi2=Convert.ToInt32(Console.ReadLine());

            int enbuyuk=BuyukBul(sayi1, sayi2);
            Console.WriteLine("En Büyük {0}\'dir.",enbuyuk);


            Console.ReadLine();
        }
    }
}
