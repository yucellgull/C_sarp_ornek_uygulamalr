﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (BitConverter.IsLittleEndian)
                Console.WriteLine("Litte Endian");
            else
                Console.WriteLine("Big Endian");

            int a = 46513;
            byte[] b = BitConverter.GetBytes(a);

            foreach(byte x in b) Console.WriteLine(x);
        }
    }
}
