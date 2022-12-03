using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {

        static int Topla(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            
            int a=Topla(1,2);
            Console.Write(a);
            Console.ReadLine();
        }
    }
}
