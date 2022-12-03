using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    using System;
    struct üniversite
    {
        public string fakulte;
        public string bolum;
        public string Ogrgor;
        public üniversite(string a, string b, string c)
        { fakulte = a; bolum = b; Ogrgor = c; }
      
    }
    class structornek
    {
        public static void Main()
        {
            üniversite k1 = new üniversite("Teknoloji Fakültesi", "Yazılım Mühendisliği", "2.sınıf");
            üniversite k2;
            Console.WriteLine(k1.fakulte);
            Console.WriteLine(k1.bolum);
            Console.WriteLine(k1.Ogrgor);
            k2.fakulte = "Tıp Fakultesi";
            Console.WriteLine();
            Console.WriteLine(k2.fakulte);
        }
    }
}
