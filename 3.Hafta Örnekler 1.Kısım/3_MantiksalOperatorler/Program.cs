using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantiksalOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a=true;
            bool b=false;
            if (a ^ b) Console.WriteLine("a^b doğrudur");
            if (a && b) Console.WriteLine("a ve b doğrudur");
            if (a || b) Console.WriteLine("a veya b doğrudur");
        }
    }
}
