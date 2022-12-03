using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin Boyutunu Giriniz:");
            int boyut =Convert.ToInt32(Console.ReadLine());
            bool[]dizi=new bool[boyut];
            for(int i = 0; i < boyut; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();
        }
    }
}
