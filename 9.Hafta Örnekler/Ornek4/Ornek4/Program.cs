﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    abstract class Ogr_not
    {
        public int vize;
        public int final;
        public Ogr_not(int v, int f)
        {
            vize = v; final = f;
        }
    }
    class ögr : Ogr_not
    {
        public string str;
        public ögr(string ad, int vize, int final) : base(vize, final)
        { str = ad; }
        public void ad_göster()
        {

            Console.WriteLine("Öğrenci Adı: " + str);
            Console.WriteLine("Vize notu:" + vize + "\n" + "Final notu:" + final);
        }
    }

    class Ana_sinif
    {

        static void Main()
        {

            ögr d = new ögr("Erkan TANYILDIZI", 77, 98);
            d.ad_göster();

        }
    }
}
