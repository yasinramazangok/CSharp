using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsVeMetotTanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayi1;
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplama işlemi sonucunuz: {0}",toplamıHesapla(sayi,sayi1));
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Environment.Exit(0);

            }
            else
            {
                Console.ReadLine();
            }
        }
        static int toplamıHesapla(int sayi, int sayi1)
        {
            return sayi + sayi1;
        }
    }
}
