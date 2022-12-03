using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_sınıfı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Bir Sayı Giriniz:");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Girilen sayının mutlak değeri: "+Math.Abs(a));
            Console.WriteLine("Girilen sayının cosinüs değeri: " + Math.Cos(a * Math.PI / 180));
            Console.WriteLine("Girilen sayının sinüs değeri: " + Math.Sin(a * Math.PI / 180));
            Console.WriteLine("Girilen sayının yuvarlatılması: " + Math.Round(a));
            Console.WriteLine("Girilen sayının logaritması: " + Math.Log(a));
            Console.WriteLine("Girilen sayının karekökü: " + Math.Sqrt(a));
            Console.WriteLine("Girilen sayının karesi: " + Math.Pow(a,2));

            Console.ReadKey();


        }
    }
}
