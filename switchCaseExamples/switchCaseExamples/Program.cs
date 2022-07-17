using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCaseExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Lütfen bir 1 ile 5 arasında sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Girdiğiniz sayı 1'dir!");
                    break;
                case 2:
                    Console.WriteLine("Girdiğiniz sayı 2'dir!");
                    break;
                case 3:
                    Console.WriteLine("Girdiğiniz sayı 3'tür!");
                    break;
                case 4:
                    Console.WriteLine("Girdiğiniz sayı 4'dür!");
                    goto case 1;
                case 5:
                    Console.WriteLine("Girdiğiniz sayı 5'dir!");
                    break;
                default:
                    Console.WriteLine("Lütfen belirtilen aralıkta bir sayı giriniz!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
