using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            float b = 32.32f;
            double c;
            c = b;
            a = (int)c;
            Console.Write("b'nin değeri=" + b + "\n c'nin değeri=" + c + "\na'nın değeri=" + a+"\n"); // \n satırı alta geçirir.
            long sayi = 127912;
            int sayi3 = Convert.ToInt32(sayi);
            Console.WriteLine(sayi3);
            long sayi11= 1241423;
            string sayi1 = sayi11.ToString();
            int sayi4 = Convert.ToInt32(sayi1);
            Console.WriteLine(sayi4);

            Console.WriteLine("Lütfen bir sayı giriniz:");
            string word = Console.ReadLine();
            int sayi2 = Convert.ToInt16(word);
            Console.WriteLine(sayi2);
            Console.ReadKey();
            /* a. Bool, decimal ve double türünden herhangi bir türe
               b. Herhangi bir türden char türüne
               c. Float ve decimal türünden herhangi bir türe (float türünden double türüne dönüşüm hariç) */

        }
    }
}
