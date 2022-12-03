using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifNesnesi
{
    class Sayi
    {
        public int i;
    }
    class NesnelerdeAtama
    {
        public static void Main(String[] args)
        {
            Sayi s1 = new Sayi();
            Sayi s2 = new Sayi();

            s1.i = 9; s2.i = 47;
            Console.WriteLine("1:s1.i:"+s1.i+",s2.i:"+s2.i);
            s1 = s2;
            Console.WriteLine("2:s1.i:" +s1.i + ",s2.i:" + s2.i);
            s1.i = 27;
            Console.WriteLine("3:s1.i:" +s1.i + ",s2.i:" + s2.i);

            Console.ReadLine();
        }
    }


}

