using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Topla
    {
        public int tpl;
        public Topla(int toplam)
        {
            tpl = toplam;
        }
        public int Toplama
        {
            get { return tpl; }
            set { tpl = value+tpl; }
        }
        static void Main(String[] args)
        {
            Topla ekle = new Topla(99);
            Console.WriteLine("Başlangıç değeri:" + ekle.Toplama);
            for (int i = 0; i < 100; i++) ekle.Toplama = i;
            Console.WriteLine("Sayıların Toplamı:" + ekle.Toplama);
            Console.ReadLine();
        }
    }
}
