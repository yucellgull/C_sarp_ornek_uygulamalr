using System;
using System.Linq;

namespace Ornek_5
{
    internal class Program
    {
        static void DiziYaz(int[] a, int sekil)
        {
            if (sekil == 0)
            {
                foreach (Object o in a)
                    Console.WriteLine(o.ToString() + " ");
                Console.WriteLine();
            }
            else if (sekil == 1)
            {
                int x = 1;
                foreach (Object o in a)
                {
                    Console.WriteLine("{0,5}", o.ToString());
                    if (x % 3 == 0) Console.WriteLine();
                    x++;
                }
            }
            else
            {
                foreach (Object o in a)
                    Console.WriteLine(o.ToString());
            }
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            int[] dizi = {1,2,3,4,5,6,7,8,9};
            DiziYaz(dizi, 0);
            DiziYaz(dizi, 1);
            DiziYaz(dizi, 2);

            Console.ReadKey();
        }
    }
}
