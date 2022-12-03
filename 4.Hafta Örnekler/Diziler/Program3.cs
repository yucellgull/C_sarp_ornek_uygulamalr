using System;
using System.Linq;

namespace Dizi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] dizi = new int[3];
            dizi[0] = rnd.Next(2, 10);
            dizi[1] = rnd.Next(50);
            dizi[2] = rnd.Next();
            
            foreach(int i in dizi)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
