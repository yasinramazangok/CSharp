using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // dizilerin indeks numaları 0' dan başlar.
            int[] sayilar = new int[10]; // 10 elemanlı bir tamsayı dizisini ifade eder!
            sayilar[3] = 24; // İndeks numarası 3 olan elemana 24 değerini verdik.
            Console.WriteLine(sayilar[3]); // İndeks numarası 3 olan elamanı ekrana yazdırdık.
            Console.WriteLine(sayilar[7]); // 7. elemanın değeri olmadığı için 0 yazacaktır.
            //string[] kelimeler = new string[3]; // burada tek tek atama yapılması gerekir.
            string[] kelimeler = { "Uzay","Mehmet","Merve","Ali","Barış","Gizem" };
            Console.WriteLine(kelimeler[2]);
            Console.WriteLine(kelimeler.Length); // Length, dizinin kaç elemana sahip olduğunu bulmamıza yarayan metottur.
            Console.ReadKey();
        }
        
    }
}
