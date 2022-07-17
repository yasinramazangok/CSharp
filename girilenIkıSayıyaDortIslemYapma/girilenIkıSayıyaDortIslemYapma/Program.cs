using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilenIkıSayıyaDortIslemYapma
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplam, cıkarım, carpım, bolum;
            double sayi1, sayi2;
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("lütfen işlemler için ikinci sayıyı giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            toplam = sayi1 + sayi2;
            cıkarım = Math.Abs(sayi1 - sayi2); // Mutlak değer alma metodu
            // cıkarım = sayi1 - sayi2; ( if sayi1 bigger than sayi2 ; the conclusion(çözüm) will be negative. )
            carpım = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            Console.WriteLine("Toplama İşlemi Sonucu: " + toplam);
            Console.WriteLine("Çıkarma İşlemi Sonucu: " + cıkarım);
            Console.WriteLine("Çarpma İşlemi Sonucu: " + carpım);
            Console.WriteLine("Bölme İşlemi Sonucu: " + bolum);
            Console.WriteLine("Çıkmak için Enter tuşuna basınız!");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
            // Console.WriteLine("Sayfadan çıkmak için Enter'a basınız!"); ve enter a basılarak ancak konsol penceresini kapatma metodu 
        }
    }
}
