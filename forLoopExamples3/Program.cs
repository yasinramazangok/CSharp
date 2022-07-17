using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopExamples3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-1000 arasında 5'e bölünebilen 11. sayıyı ekrana yazdırma 
            int sayi = 1000,sayac=0;
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 5 == 0)
                {
                    sayac++;
                }
                if (sayac ==11)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
