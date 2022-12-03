using System;
using System.Linq;

namespace Dizi4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[4, 4]; int k = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = i; j < 4; j++) { dizi[i, j] = k; dizi[j, i] = k; k++; }
            }
            k = 1;
            foreach (int x in dizi)
            {
                if (k % 4 == 0)
                {
                    Console.Write(x + " "); Console.WriteLine();
                }
                else Console.Write(x + " "); k++;
            }
            Console.ReadLine();
        }
        
        
        }
}


