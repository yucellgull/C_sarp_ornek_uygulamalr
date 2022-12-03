using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomm
{
    class Program
    {
       
        public static void metotlar(int a,int b,int c)
        {
            Console.WriteLine("a: " + a + " b: " + b + " c: " + c);
        }
        static void Main(String[] args)
        {                        
            Random rdn = new Random(); 
            
            Program prg = new Program();
            metotlar(rdn.Next(1,7),rdn.Next(1,7), rdn.Next(1, 7));
            Console.ReadLine();
        }
    }
}
