using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilenSayiOndanBuyukmuVeTekMiCiftMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir tam sayı giriniz: ");
            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 10)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Girdiğiniz sayı 10'dan küçük ve çift bir sayıdır!");
                }
                else if (sayi % 2 == 1)
                {
                    Console.WriteLine("Girdiğiniz sayı 10'dan küçük ve tek sayıdır!");



                }
               

            }
            else if (sayi > 10)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Girdiğiniz sayı 10'dan büyük ve çift bir sayıdır!");
                }
                else if (sayi % 2 == 1)
                {
                    Console.WriteLine("Girdiğiniz sayı 10'dan büyük ve tek sayıdır!");
                }
                 
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı 10'a eşittir ve çift sayıdır!");
            }
            Console.ReadKey();

        }
    }
}
