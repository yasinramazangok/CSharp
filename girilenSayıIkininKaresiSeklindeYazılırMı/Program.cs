using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilenSayıIkininKaresiSeklindeYazılırMı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool yazilabilirlik=false;
            for (int i = 0; i < sayi; i++)
            {
                for (int x = 0; x < sayi; x++)
                {
                    if (i * i + x * x == sayi)
                    {
                        yazilabilirlik = true;
                        Console.WriteLine("(" + i + "*" + i + ")+(" + x + "*" + x + ")" + " şeklinde yazılabilir!");

                    }
                  
                }
            }
            if (yazilabilirlik  ==false)
            {
                Console.WriteLine("{0} sayısı iki sayının kareleri toplamı şeklinde yazılamaz!", sayi);
            }
            
            Console.ReadLine();
        }
    }
}
