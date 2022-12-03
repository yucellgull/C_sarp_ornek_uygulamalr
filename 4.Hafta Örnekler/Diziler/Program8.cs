using System;
using System.Linq;

namespace Dizi_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = { "Zeynep", "Fatma", "Ali", "Yılmaz", "Gökhan", "Osman", "Feride" };

            Console.WriteLine("Dizinin Elemanlari\n====================");
            foreach (string s in dizi)
                Console.WriteLine(s);

            Array.Sort(dizi);
            Console.WriteLine();

            Console.WriteLine("Sıralanmış Dizi\n======================");
            foreach(string s in dizi)           
                Console.WriteLine(s);
            

            Console.ReadLine();
        }
    }
}
