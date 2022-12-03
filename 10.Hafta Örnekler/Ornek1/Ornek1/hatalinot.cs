using System;

namespace hatalınot
{
    public class hatalinot : ApplicationException
    {
        private int hatalivize;
        private string hatakaynagi;

        public hatalinot(int hatalivize, string hatakaynagi)
        {
            this.hatalivize = hatalivize;
            this.hatakaynagi = hatakaynagi;
        }
        public int Hatalivize
        {
            get { return hatalivize; }
        }
        public string Hatakaynagi
        {
            get { return hatakaynagi; }
        }
        public override string ToString()
        {
            string str1 = "Hata Kaynağı:" + hatakaynagi + "\n";
            string str2 = "Hata Değeri:" + hatalivize;
            return str1 + str2;

        }
    }
}
