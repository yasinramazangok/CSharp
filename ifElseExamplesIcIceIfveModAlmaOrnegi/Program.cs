using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseExamplesIcIceIfveModAlmaOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen hesaplamak istediğiniz sayıyı giriniz: ");
            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 10)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("{0} sayısı 10'dan küçük  çift sayıdır! ",sayi);
                }
                else
                {
                    Console.WriteLine("{0} sayısı 10'dan küçük ve tek sayıdır! ",sayi);
                }
            }
            else if(sayi > 10)
            {
                int sayi1;
                sayi1 = sayi*sayi;
                Console.WriteLine("{0} sayısı 10'dan büyüktür ve {1} sayısının karesi: {2}'dir!",sayi,sayi,sayi1);
            }
            else
            {
                Console.WriteLine("Girilen sayı 10'dur, çifttir ve karesi: 100'dür!");
            }
            Console.ReadKey();
        }
    }
}
