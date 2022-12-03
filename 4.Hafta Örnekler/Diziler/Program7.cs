using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] dizi2 = new int[10];
            int[] dizi3 = new int[10];

            dizi1.CopyTo(dizi2, 2);
            foreach(int i in dizi2)
                Console.WriteLine(i);

            Console.WriteLine();

            Array.Copy(dizi1, 2, dizi3, 5, 3);
                foreach(int i in dizi3)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
