using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
   public class Urunler<T> where T : UrunTemel
    {
        private List<T> urunListe;
        public Urunler()
        {
            urunListe = new List<T>();
        }
        public void Ekle(T uye)
        {
            urunListe.Add(uye);
        }
        public void Sil(T uye)
        {
            urunListe.Remove(uye);
        }
        public void Listele()
        {
            foreach(T uye in urunListe)
            {
                Console.WriteLine(uye.ToString());
            }
        }
    }
}
