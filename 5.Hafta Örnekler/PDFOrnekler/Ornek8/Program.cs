using System;
using System.Linq;

namespace DizilerdeMetotDonusumu
{
    class Donustur
    {
        public static int[] Inte(Array dizi)
        {
            int[] gecici = new int[dizi.Length];
            for (int i = 0; i < dizi.Length; i++)
                gecici[i] = Convert.ToInt32(dizi.GetValue(i));
            return gecici;
        }
        public static string[] Stringe(Array dizi)
        {
            string[] gecici = new string[dizi.Length];
            for (int i = 0; i < dizi.Length; i++)
                gecici[i] = dizi.GetValue(i).ToString();
            return gecici;
        }
    }
    class AnaSinif
    {
        static void Main(string[] args)
        {
            string[] a = { "2", "5", "7", "9" };
            int[] b = Donustur.Inte(a);
            Console.WriteLine(b[1] + b[3]);
            int[] c = { 2, 7, 9, 4 };
            int[]d = Donustur.Inte(c);
            Console.WriteLine(d[0] + d[3]);

            Console.ReadLine();
        }
    }
    
}
