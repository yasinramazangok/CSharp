using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopExamples1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1000-1 arasındaki sayıları ekrana yazdırma programı 
            // 1000 ve 1 dahil 
            //Console.WriteLine("Lütfen 1000 ile 1 arasında bir sayı giriniz: ");
            int sayi;
            Console.Write("Lütfen 1000 ile 1 arasında bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1000; sayi <= i; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
