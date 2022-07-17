using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileLoopXYArasindakiCiftSayilariBulanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.WriteLine("Lütfen başlangıç sayısını giriniz: ");
            int sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Lütfen bitiş sayısını giriniz: ");
            int sayi2 = Convert.ToInt16(Console.ReadLine());
            for (int i = sayi1; i <= sayi2; i++)
            {

                if (i % 2 == 0)
                {

                    toplam += i;


                }

               
            }
            Console.Write("{0} ile {1} arasındaki çift sayıların toplamı: ", sayi1, sayi2);
            Console.Write(" {0}", toplam);
            Console.ReadLine();
        }
    }
}
