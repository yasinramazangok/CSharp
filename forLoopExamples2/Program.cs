using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopExamples2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-1000 arasında 3'e bölünebilen sayıları ekrana yazdırma
            int sayi = 1000;
            Console.WriteLine("3'e bölünebilen sayıların listesi aşağıdaki gibidir: ");
            for (int i = 1; i < sayi; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            
        }
    }
}
