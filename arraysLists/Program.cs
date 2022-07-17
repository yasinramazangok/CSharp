using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysLists
{
    class Program
    {
        static void Main(string[] args)
        { // List ler , dizilerin daha gelişmiş haliş gibi düşünülebilir.
            List<int> sayilar = new List<int>(); // List oluşturma
            sayilar.Add(3); // List'e eleman ekleme 
            sayilar.Add(5);
            sayilar.Add(7);
            Console.WriteLine(sayilar[2]); // 2. indeks numaralı elemanı ekrana yazdırma
            sayilar.Remove(5); // 5 elemanını List'ten sildik.
            Console.WriteLine(sayilar[1]);
            sayilar.Add(12);
            sayilar.Add(45);
            sayilar.Add(4);
            sayilar.Add(1);
           
            sayilar.RemoveAt(3); // 3. indeks numaralı elamanı List'ten sildik.
            Console.WriteLine(sayilar[3]);
            
            int uzunluk = sayilar.Count(); // Count() List'lerin uzunluğunu bulmamıza yarayan metot!
            Console.WriteLine(uzunluk);


            // sayilar.Remove(1);
            if (sayilar.Contains(1)) // List, 1 içeriyor mu?
            {
                Console.WriteLine("List'te 1 elemanı vardır!");
            }
            else
            {
                Console.WriteLine("List'te 1 elemanı yoktur!");
            }
            sayilar.Clear(); // List'teki bütün elemanları siler.

            Console.ReadKey();
        }
    }
}
