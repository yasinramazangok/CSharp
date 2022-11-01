using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loops
            // Veri kümesini kolaylıkla 'iterate' etmek için yani gezmek için kullanılan yapılardır.

            // ForEachLoop();
            // DoWhileLoop();
            // WhileLoop();
            // ForLoop();

            if (IsPrimeNumber(31))
            {
                Console.WriteLine("Asal sayıdır.");
            }
            else
            {
                Console.WriteLine("Asal sayı değildir.");
            }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            // Asal sayılar yalnızca 1'e ve kendisine bölünebilen sayılardır.
            // 2 ve kendisinin 1 eksiğine kadar olan sayılarda döngü kurulup kontrol yapılırsa algoritma sağlanır.
            bool result = true;    
            for (int i = 2; i < number-1; i++)
            {
                if(number%i == 0)
                {
                    result = false;
                    break; // Programın gereksiz yere çalışmaması için döngüden asal olmadığı bulunduğu anda çıkılması gerektiği için break komutunu kullanıyoruz.
                    // i = number; // Bu şekilde de döngünün gereksiz yere çalışması önlenebilir.
                }
            }
            return result;
        }

        private static void ForEachLoop()
        {
            // foreach Loop
            // Dizi temelli verilerin iterate edilmesi için kullanılır.
            // Genellikle veritabanından çekilen tablolardaki verileri gezmek için sıklıkla kullanılır.
            string[] fruits = new[] { "Orange", "Lemon", "Watermelon", "Strawberry", "Banana" };
            foreach (string fruit in fruits)
            {
                // foreach ile iterate edilen elemanlar o anda readonly durumdadır ve döngü içerisinde değerleri değiştirilemez.
                Console.WriteLine(fruit);
            }
        }

        private static void DoWhileLoop()
        {
            // do-while Loop
            // Çok sık kullanılan bir döngü değildir.
            // do bloku mutlaka bir kez çalışır.
            int number = 20;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number > 0);

            Console.WriteLine("----------------------");

            // Şart sağlanmasa bile döngü bir kez çalışır.
            int number1 = 20;
            do
            {
                Console.WriteLine(number1);
                number1--;
            } while (number1 >= 21);
        }

        private static void WhileLoop()
        {
            // while Loop
            // Belirli bir şart sağlanana kadar döngü tekrarlanır. 
            // Sonsuz döngü***
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--; // Şarta müdahale etmez isek sonsuz döngü oluşabilirdi.
            }
        }

        private static void ForLoop()
        {
            // for Loop

            Console.WriteLine("1'den 100'e kadar olan sayılar");
            for (int i = 1; i <= 100; i++)
            {
                // For döngüsü, döngülerin en temeli ve en çok kullanılanlarından birisidir.
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("1'den 100'e kadar olan çift sayılar");
            for (int i = 2; i <= 100; i += 2)
            {
                // For döngüsü, döngülerin en temeli ve en çok kullanılanlarından birisidir.
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("1'den 100'e kadar olan tek sayılar");
            for (int i = 1; i <= 100; i += 2)
            {
                // For döngüsü, döngülerin en temeli ve en çok kullanılanlarından birisidir.
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("100'den 1'e kadar olan sayılar");
            for (int i = 100; i >= 1; i--)
            {
                // For döngüsü, döngülerin en temeli ve en çok kullanılanlarından birisidir.
                Console.WriteLine(i);
            }
        }
    }
}
