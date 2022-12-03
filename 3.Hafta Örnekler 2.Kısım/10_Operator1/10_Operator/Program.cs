using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2; int b = 3; int c = 6; int d = 1;
            Console.WriteLine("(a<b)&&(c<d)-->" + ((a < b) && (c < d)));
            Console.WriteLine("(a<b)||(c<d)-->" + ((a < b) || (c < d)));
            Console.WriteLine("!(a<b)-->" + (!(a < b)));
            Console.WriteLine("(a<b)&(c<d)-->" + ((a < b) & (c < d)));
            Console.WriteLine("(a<b)|(c<d)-->" + ((a < b) | (c < d)));
            Console.WriteLine("(a<b)^(c<d)-->" + ((a < b) ^ (c < d)));
        }
    }
}
