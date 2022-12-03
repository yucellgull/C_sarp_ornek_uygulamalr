using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDegiskenler
{
  class Static
    {
        public static int b = 10;
        public static int Deneme()
        {
            int a = 5;
            int b = a;
            return b;
        }
    }
    class AnaProgram
    {
        static void Main(string[] args)
        {
            Static a =new Static();//gereksizdir ama hata vermez.
            Console.WriteLine(b.Deneme());//Hata verir.Statik metotlara
                                          //nesne üzerinden erismek mümkün değildir.
            Console.WriteLine(Static.Deneme());//deneme metoduna erişim var.5 değerini yazar.
            Console.WriteLine(Static.b);//b değişkenine erişim var.5 değerini yazar.
            Console.WriteLine(Static.a);//Hata verir,stativ veya statik olmayan metot
                                        //içerisindeki değerlere erişim yoktur.
        }
    }
}
