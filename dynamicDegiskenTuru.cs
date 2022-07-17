using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicDegiskenTuru
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic word = "Yasin Ramazan";
            dynamic tamsayi = 15;
            Console.WriteLine(word.GetType());
            Console.WriteLine(tamsayi.GetType());
            dynamic word1 = "Java";
            double ondalikli = 12.34;
            int tamsayi2 = 14 + Convert.ToInt32(ondalikli);
            Console.WriteLine(word1+ " " +tamsayi2);
            word = 78;
            word = 21 + word;
            word++;
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
