using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrgDi13
{   
class Deneme 
    {
        public int a;
        public int b;
        public Deneme(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
class Program
{
    static void Main()
    {
       
        PrgDi13.Deneme d = new PrgDi13.Deneme(1, 2);
        Console.WriteLine(d.a);
        Console.WriteLine(PrgDi13.Deneme.Topla(2, 3));
    }
}
