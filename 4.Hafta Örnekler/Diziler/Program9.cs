using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = { "Zeynep", "Fatma", "Ali", "Yılmaz", "Gökhan", "Osman", "Feride" };

            Console.WriteLine("Aranacak ismi giriniz:");
            string isim=Console.ReadLine();

            Array.Sort(dizi);
            int index=Array.BinarySearch(dizi,isim);

            if (index < 0)
                Console.WriteLine("Aranan isim bulunamadı!");
            else
                Console.WriteLine("Aranan isim dizinin {0}. elemanında bulundu...", index);

            Console.ReadLine();


        }
    }
}
