using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 25;
            Console.WriteLine(x);
            Console.WriteLine(y);
            // ++ -- Arttırma-azaltma operatörleri
            x++;  
            y--;  
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();

            // += -= *= /=  Aritmetik işlem operatörleri

            //x += 5; // x = x+5; x=20
            //y -= 4; // y = y-4; y=21
            //x *= y; // x = x*y; x = 420
            //y /= 3; // y = y/3; y = 6

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.ReadKey();

            ////  && : ve ( bu ve bu doğruysa mantığı ile çalışır.), || : ya da ( bu veya bundan herhangi birisi doğru ise mantığı ile çalışır.)

            //if (x >= 20 && y <= 25)
            //{
            //    Console.WriteLine(...);
            //    Console.ReadKey();
            //}
            //else if (x >= 20 || y <= 25)
            //{
            //    Console.WriteLine("İkinci koşul sağlandı!");
            //    Console.ReadKey();
            //}
        }
    }
}
