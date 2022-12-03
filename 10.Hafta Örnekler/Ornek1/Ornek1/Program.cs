using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    class notlar
    {
        private int final;
        private int vize;
        public notlar(int f, int v)
        {
            if (v > 100)
            {
                throw new hatalinot(v, "yapıcı metot");
            }
            final = f;
            vize = v;
        }
        public void degerver(int f, int v)
        {
            if (v > 100)
                throw new hatalinot(v, "degerver metodu");
            final = f;
            vize = v;
        }

        public int Final
        {
            get { return final; }
            set { final = value; }
        }
        public int Vize
        {
            get { return vize; }
            set
            {
                if (value > 100)
                    throw new hatalinot(value, "Vize Giriş Hatası");
                vize = value;
            }
        }
    }

    class hatatesti
    {
        public static void Main()
        {
            notlar a = new notlar(50, 0);
            try
            {
                a.Vize = 120;
            }
            catch(notlar.hatalinot e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}


