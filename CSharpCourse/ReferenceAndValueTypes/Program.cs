using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);


            string[] cities = new string[] { "Ankara", "Adana", "Afyon" };
            Console.WriteLine("A ile başlayan şehirler:");
            Console.WriteLine("---------------------------");
            foreach (string city in cities)
            {
                Console.Write(city + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("B ile başlayan şehirler:");
            Console.WriteLine("---------------------------");
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            foreach (string city2 in cities2)
            {
                Console.Write(city2 + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            cities2 = cities; // Burada referanslar üzerinden işlem yapılır.
            Console.WriteLine();
            Console.WriteLine("Referans işleminden sonra A ile başlayan şehirler:");
            foreach (string city in cities)
            {
                Console.Write(city + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Referans işleminden sonra B ile başlayan şehirler:");
            foreach (string city2 in cities2)
            {
                Console.Write(city2 + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            cities[0] = "Hatay";
            Console.WriteLine("Bursa yerine Hatay yazacaktır: {0}",cities2[0]);
            Console.ReadLine();
        }
    }
}
