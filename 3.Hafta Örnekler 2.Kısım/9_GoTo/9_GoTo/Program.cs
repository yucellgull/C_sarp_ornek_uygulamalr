using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_GoTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int n = 10;
        Bas:
            m++;
                if (m <= n) goto Bas;
            else goto son;
                son:Console.WriteLine("m="+m);
    }
    }
}
