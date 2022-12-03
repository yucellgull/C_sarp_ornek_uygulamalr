using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
  class A
    {
        public int x;
        private int y;
        protected int z;

        public A()
        {
            x = 1;
            y = 2;
            z = 3;
            Console.WriteLine("A yapıcısı çalıştı...");
        }

        public void listele()
        {
            Console.WriteLine("x={0}; y={1}; z={2};", x, y, z);
        }
    }
    class T : A
    {
        public string s;

        public T()
        {
            s = "Türetilmiş Sınıf";
            Console.WriteLine("T yapıcısı calıştı...");
        }
        public void yaz()
        {
            Console.WriteLine("s={0}; x={1}; z={2};", s, x, z);
        }
    }
    class program
    {
        static void Main()
        {
            T t = new T();
            t.listele();
            t.yaz();
        }
    }
}
