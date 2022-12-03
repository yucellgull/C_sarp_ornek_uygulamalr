using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s; int a;
            Console.WriteLine("Kaçıncı Sınıftasınız:");
            s = Console.ReadLine();
            a=Int32.Parse(s);
            switch(a)
            {
                case 0:
                case 1:Console.WriteLine("Daha yenisiniz");break;
                case 2:Console.WriteLine("Mirascısınız");break;
                case 3:Console.WriteLine("Ev Sahibisiniz");break;
                case 4:Console.WriteLine("Misafirsiniz");break;
                default:Console.WriteLine("Siz Okulu Uzatmıssınız");goto case 1;
            }
        }
    }
}
