using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetot
{
    class StaticMetot
    {
        public static void SMetot1()
        {
            Console.WriteLine("Static Metot 1");
        } 
        public static void SMetot2()
        {
            SMetot1();
            Console.WriteLine("Static Metot 2");
        }
    }
    class AnaProgram
    {
        static void Main()
        {
            StaticMetot.SMetot2();
            Console.ReadLine();
        }
    }
}
