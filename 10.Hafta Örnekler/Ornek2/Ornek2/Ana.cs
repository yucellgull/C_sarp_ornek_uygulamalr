using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    class Ana
    {
        static void Main()
        {
            Urunler<UrunTemel> urunler = new Urunler<UrunTemel>();
            Lastik st1 = new Lastik(1000, 10, "Otomobil Lastiği");
            st1.Tip = "Kış Lastiği";
            st1.Cap = 185;
            st1.Genislik = 75;

            Silecek slc = new Silecek(1001, 5, "On Silecek Takımı");
            slc.Uzunluk = 60;

            urunler.Ekle(st1);
            urunler.Ekle(slc);

            urunler.Listele();
        }
    }
}
