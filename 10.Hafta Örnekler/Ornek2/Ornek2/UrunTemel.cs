using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    public class UrunTemel
    {
        private int urunKodu;
        private double urunFiyati;
        private string urunBilgisi;
        public UrunTemel(int kod, double fiyat, string bilgi)
        {
            urunKodu = kod;
            urunFiyati = fiyat;
            urunBilgisi = bilgi;
        }
        public int UrunKodu
        {
            get { return urunKodu; }
        }
        public double BirimFiyat
        {
            get { return urunFiyati; }
        }
        public string UrunTanimi
        {
            get { return urunBilgisi; }
        }
    }
}
