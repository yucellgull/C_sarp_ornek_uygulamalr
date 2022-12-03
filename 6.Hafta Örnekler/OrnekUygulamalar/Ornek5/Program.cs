using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5
{
    using System;
    enum GUNLER : byte
    {
        PAZARTESI,
        SALI,
        CARSAMBA,
        PERSEMBE,
        CUMA,
        CUMARTESI,
        PAZAR
    }
  
    class Numaralandirma
    {
        public static void Main()
        {
            string[] sabitler = Enum.GetNames(typeof(GUNLER));
            foreach (string s in sabitler)
                Console.WriteLine(s);
        }
    }
}
