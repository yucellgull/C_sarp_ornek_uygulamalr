using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ForDogusu1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; int j= 0;
            for (i = 0, j = 0; i < 20; i++, j++) ;
            {
                i *= j;
                Console.WriteLine("i=" + i + "j=" + j);
            }
        }
    }
}
