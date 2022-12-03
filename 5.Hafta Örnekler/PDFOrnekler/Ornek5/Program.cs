using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Program
    {
        int topla;
        public void sayiTopla(int topla)
        {
            this.topla += topla;
        }
        public void sayiEkranaYaz()
        {
            Console.WriteLine("Toplam=" + topla);
        }
        static void Main(String[] args)
        {
            Program th=new Program();
            th.sayiTopla(2);
            th.sayiTopla(3);
            th.sayiEkranaYaz();

            Console.ReadKey();
        }
    }
}
