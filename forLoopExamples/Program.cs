using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-x arasındaki sayıları ekrana yazdıran program 
            // 1 dahil, x dahil değil
            int sayi;
            Console.WriteLine("Lütfen bir tamsayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < sayi; i++)
            {
                //Console.Write(i);
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
