using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseExamplesKenarlarıVerilenUcgenCizilebilirMi
{
    class Program
    {
        static void Main(string[] args)
        {   // |b-c|<a<b+c formülü 
            // Üçgen çizilebilme kuralı
            // Kenar uzunlukları verilen üçgende;
            // 1) Herhangi iki kenarının toplamı üçüncü kenarın uzunluğuna eşit ya da  az olamaz.
            // 2) Herhangi iki kenarının farkının mutlak değeri üçüncü kenarın uzunluğuna eşit ya da büyük olamaz.
            Console.WriteLine("Lütfen üçgenin birinci kenarını giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üçgenin ikinci kenarını giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üçgenin üçüncü kenarını giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayi + sayi1;
            int mutlakFark=sayi-sayi1;
            if (mutlakFark < 0)
            {
                mutlakFark = mutlakFark * (-1);

            }
            if(mutlakFark<sayi2 && sayi2 < toplam)
            {
                Console.WriteLine("Girilen değerlere uygun üçgen çizilebilir!");

            }
            else
            {
                Console.WriteLine("Girilen değerlere uygun üçgen çizilemez!");
            }
            Console.ReadKey();
         
        }
    }
}
