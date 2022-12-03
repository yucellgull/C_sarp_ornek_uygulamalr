using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Siniflar1
{
    class SinifIsmi
    {
        public int ozellik1 = 55;
        public string ozellik2;
        private float ozellik3;
        public int metot1(int a, int b)
        {
            return a + b;
        }
        private void metot2(string a)
        {
            Console.WriteLine(a);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            SinifIsmi nesne=new SinifIsmi();
            Console.WriteLine(nesne.ozellik1);
            Console.WriteLine(nesne.ozellik2);
            Console.WriteLine(nesne.ozellik3);
            Console.WriteLine(nesne.metot1(2, 5));
            Console.WriteLine(nesne.metot2("deneme"));
        }
    }
}
