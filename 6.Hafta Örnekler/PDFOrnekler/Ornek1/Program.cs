﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikselOpeAsiriYuk
{
    class Program
    {
        public int x, y;
        public Program(int dd,int ff)
        {
            x = dd;
            y = ff; 
        }
        public void Yaz()
        {
            Console.WriteLine(x + " " + y);
        }
        public static Program operator +(Program a ,Program b)
        {
            int c = a.x + b.y;
            int z = b.x + b.y;
            return new Program(c,z);
        }

    }
    class AnaSinif
    {
        public static void Main()
        {
            Program a = new Program(5, 8);
            Program b = new Program(7, 9);
            Program c = new Program(6, 2);
            Program m = a + b + c;
            m.Yaz();
            Console.ReadLine();
        }
    }
}
