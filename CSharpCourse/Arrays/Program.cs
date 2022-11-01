using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            // Array ile tek bir değişkende bütün verileri yönetmek amaçlanır.
            // Koleksiyonlar array'lerin iyileştirilmiş halidir.
            // string ile metinsel veri tiplerini kullanırız. Referans tiptir.****
            string[] students2 = new string[] {"Yasin","Ramazan","Steve"}; // Array tanımı 2
            string[] students3 = new[] { "Yasin", "Ramazan", "Steve" }; // Array tanımı 3 
            string[] students = new string[3]; // Array tanımı
            students[0] = "Yasin";
            students[1] = "Ramazan";
            students[2] = "Steve";

            // Array'ler benzer tip verileri tutmak için kullanılır ve türü tanımlanırken belirtilir.

            foreach (var student in students)
            {
                // foreach bir array'deki her bir elemanı tek tek gezmek için kullanılır.
                Console.WriteLine(student);
            }

            Console.WriteLine("----------------------------------------");

            // Multidimensional Array
            string[,] regions = new string[5, 3] // 5 satır, 3 sütun 
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"}
            };

            // Satırlar gezilir ve her satır için sütunlar tek tek yazdırılır.
            // 0. dimension satırlar, 1. dimension sütunları ifade etmektedir.
            for (int i = 0; i <= regions.GetUpperBound(0); i++) // 0. dimension'ın en üst değeri 
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) // 1. dimension'un en üst değeri
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("--------------Yeni Bölgeye Geçiş--------------");
            }

            Console.ReadLine();
        }
    }
}
