using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarDortgen
{
   class Dortgen
    {
        public int En;
        public int Boy;
        public int Alan()
        {
            int Alan = En * Boy;return Alan;
        }
        public void EnBoyBelirle(int en,int boy) { En = en; Boy = boy; }
        public void Yaz()
        {
            Console.WriteLine("**************");
            Console.WriteLine("En:{0,5}",En);
            Console.WriteLine("Boy:{0,5}",Boy);
            Console.WriteLine("Alan:{0,5}", Alan());
            Console.WriteLine("**************");
        }

    }
    class AnaSinif
    {
        static void Main(String[] args)
        {
            Dortgen d1=new Dortgen();
            d1.EnBoyBelirle(20,50);
            d1.Yaz();

            Dortgen d2 = new Dortgen();
            d2.EnBoyBelirle(25,12);
            d2.Yaz();

            Console.ReadLine();
        }
    }
}
