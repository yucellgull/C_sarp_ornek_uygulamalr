using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            int a, b, c;
            Console.WriteLine("1.Sayıyı Giriniz:");
            s = Console.ReadLine();
            a=Int32.Parse(s);
            Console.WriteLine("2.Sayıyı Giriniz:");
            s=Console.ReadLine();
            b=Int32.Parse(s);
            Console.WriteLine("3.Sayıyı Giriniz");
            s = Console.ReadLine();
            c=Int32.Parse(s);
            if(a>=b&&a>=c)Console.WriteLine("Enbüyük:"+a);
            else if(b>=c)Console.WriteLine("Enbüyük:"+b);
            else Console.WriteLine("Enbüyük:"+c);
        }
    }
}
