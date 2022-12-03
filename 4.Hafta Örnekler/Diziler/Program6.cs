using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array dizi = Array.CreateInstance(typeof(int), 5, 4, 3);
            Random r = new Random();
            for(int i = 0; i < dizi.GetLength(0); i++)
                for(int j = 0; j < dizi.GetLength(1); j++)
                    for(int k = 0; k < dizi.GetLength(2); k++)
                    {
                        dizi.SetValue(r.Next(10, 100), i, j, k);
                        Console.WriteLine("dizi[{0},{1},{2}]={3,3}",i,j,k,dizi.GetValue(i,j,k));
                    }
            Console.ReadLine();
        }
    }
}
