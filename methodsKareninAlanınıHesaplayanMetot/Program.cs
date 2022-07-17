using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsKareninAlanınıHesaplayanMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen karenin kenar uzunluğunu giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Karenin alanı: {0}",KareninAlanınıHEsapla(sayi));
            Console.ReadKey();
        }
        static int KareninAlanınıHEsapla(int sayi)
        {
            return sayi * sayi;
        }
    }
}
