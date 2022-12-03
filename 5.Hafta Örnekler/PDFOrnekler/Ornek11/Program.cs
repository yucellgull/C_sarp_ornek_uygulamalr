using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetotlar
{
  class Oyuncu
    {
        static int Toplam;
        Oyuncu()
        {           
            Toplam++;
            Console.WriteLine("Toplam Oyuncu"+Toplam);
        }
        static Oyuncu()
        {
            Console.WriteLine("Oyun başladı...");
        }
        ~Oyuncu()
        {
            Console.WriteLine("Bir oyuncu ayrıldı...");
        }
        static void Main()
        {
            Oyuncu ahmet = new Oyuncu();
            Oyuncu mehmet = new Oyuncu();
            Oyuncu ayse = new Oyuncu();
            Oyuncu osman = new Oyuncu();
            Console.ReadLine();
           
        }
    }
}
