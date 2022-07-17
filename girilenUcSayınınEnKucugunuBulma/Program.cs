using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilenUcSayınınEnKucugunuBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üçüncü sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi < sayi1 && sayi < sayi2)
            {
                Console.WriteLine("{0} sayısı en küçük sayıdır!", sayi);

            }
            else if (sayi1 < sayi && sayi1 < sayi2)
            {
                Console.WriteLine("{0} sayısı en küçük sayıdır!", sayi1);

            }
            else if (sayi2 < sayi && sayi2 < sayi1)
            {

                Console.WriteLine("{0} sayısı en küçük sayıdır!", sayi2);

            }
            else if (sayi == sayi1 && sayi == sayi2)
            {
                Console.WriteLine("Girilen sayılar birbirine eşittir!");

            }
            else if (sayi == sayi1 && sayi < sayi2)
            {
                Console.WriteLine("İlk iki sayı birbirine eşit ve en küçük sayılardır!");
            }
            else if (sayi1 == sayi2 && sayi1 < sayi)
            {
                Console.WriteLine("Son iki sayı birbirine eşit ve en küçük sayılardır!");
            }

            else if (sayi == sayi2 && sayi < sayi1)
            {
                Console.WriteLine("Birinci ve üçüncü sayı birbirine eşit ve en küçük sayılardır!");
            }
            else
                Console.WriteLine("Lütfen tamsayılar giriniz!");
            Console.ReadKey();

        }
    }
}
