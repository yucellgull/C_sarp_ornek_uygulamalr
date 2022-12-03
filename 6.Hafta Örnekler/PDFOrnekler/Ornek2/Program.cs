using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorYuklemeKarmasikSayi
{
  class Karmasiksayi
    {
        private double mGercek;
        private double mSanal;

        public double Gercek
        {
            get { return mGercek; }
            set { mGercek = value; }
        }
        public double Sanal
        {
            get { return mSanal; }
            set { mSanal = value; }
        }
        public Karmasiksayi(double x,double y)
        {
            mGercek = x;
            mSanal = y;
        }
        public Karmasiksayi()
        {
            mGercek = 0;
            mSanal = 0;
        }
        public Karmasiksayi(Karmasiksayi k)
        {
            mGercek= k.mGercek;
            mSanal = k.mSanal;
        }
        public void Yaz()
        {
            if (mSanal > 0)
                Console.WriteLine("{0}+{1}i", mGercek, mSanal);
            else
                Console.WriteLine("{0}-{1}i", mGercek, -mSanal);
        }
    }
    class AnaProgram
    {
        public static void Main()
        {
            Karmasiksayi k = new Karmasiksayi(-5,6);
            k.Yaz();
            Console.ReadLine();
        }
    }
}
