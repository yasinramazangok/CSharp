using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilenSayininKaresiniHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("On the way of software development!");
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());
            sayi *= sayi;
            Console.WriteLine("Girilen sayının karesi:{0}",sayi);
            Console.ReadKey();

        }
    }
}
