using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if 
            var number = 20;
            if (number == 20)
            {
                Console.WriteLine("Number is {0}", number);
            }
            else
            {
                Console.WriteLine("Number is not {0}", number);
            }

            var number1 = 40;
            Console.WriteLine(number1 == 40 ? $"Number is {number1}" : $"Number is not {number1}"); // Bu yazım şekline 'single line if' denir.

            var number2 = 30;
            if (number2 == 20)
            {
                Console.WriteLine("Number is {0}", number2);
            }
            else if (number2 == 30)
            {
                Console.WriteLine($"Number is {number2}");
            }
            else
            {
                Console.WriteLine("Number is not {0}", number2);
            }
            // if bloklarında else bloğu da tanımlanmış ise bloklardan bir tanesi kesinlikle çalışır.

            // Örnek bir if uygulaması
            var number4 = 150;
            if (number4 >= 0 && number4 <= 100)
            {
                Console.WriteLine("Number is between 0 - 100");
            }
            else if (number4 > 100 && number4 <= 200 )
            {
                Console.WriteLine($"Number is between 101 - 200");
            }
            else if(number4 > 200 || number4 < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }



            // switch
            var number3 = 1;
            switch (number3)
            {
                case 0:
                    Console.WriteLine("Birinci duruma uygundur.");
                    break;
                case 10:
                    Console.WriteLine("İkinci duruma uygundur.");
                    break;
                case 20:
                    Console.WriteLine("Üçüncü duruma uygundur.");
                    break;
                case 30:
                    Console.WriteLine("Dördüncü duruma uygundur.");
                    break;
                case 40:
                    Console.WriteLine("Beşinci duruma uygundur.");
                    break;
                default:
                    Console.WriteLine("Şartların dışında bir duruma uygundur.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
