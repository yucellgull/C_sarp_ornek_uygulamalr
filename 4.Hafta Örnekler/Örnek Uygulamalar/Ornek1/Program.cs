using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r=new Random();

            int[] dizi = new int[20];
            char[] chr=new char[20];

            for(int i = 0; i < 20; i++)
            {
                dizi[i] = r.Next(1, 51);
                chr[i] = (char)r.Next(20, 126);
            }
            for(int i = 0; i < 0; i++)
            {
                Console.Write("(0,2).değer(1,2)->",i,dizi[i]);
                for (int j = 0; j < dizi.Length; j++)
                    Console.Write(chr[i]);
                
               
            } 
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
