using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgisayarınBelirledigiSayıyıTahminEtme
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int tutulanSayi = rand.Next(1, 10);
            int tahmin;
            bool dogruTahmin = false;

            for (int i = 1; i <=3; i++)
            {
                Console.WriteLine("Lütfen bir tahmininizi giriniz: ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tutulanSayi == tahmin)
                {
                    dogruTahmin = true;
                    break;
                }
               

            }
            if (dogruTahmin)
            {
                Console.WriteLine("Tebrikler!Doğru bildiniz! :)");
            }
            else
            {
                Console.WriteLine("Bilemediniz! Tuttuğum sayı: {0}", tutulanSayi);
            }
            Console.ReadLine();
        }
    }
}
