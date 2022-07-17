using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace methodsKareUcgenDaire
{
    class Program
    {
        static void Main(string[] args)
        { int indeksNo, kareKenarı, tabanUzunlugu, yukseklik, yaricap;
            Console.WriteLine("Lütfen hesaplamak istediğiniz şeklin indeks numarasına basınız!");
            Console.WriteLine("1-Kare\n2-Üçgen\n3-Daire");
            indeksNo = Convert.ToInt16(Console.ReadLine());
            switch (indeksNo)
            {
                case 1:
                    Console.WriteLine("Lütfen karenin kenar uzunluğunu giriniz: ");
                    kareKenarı = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Karenin Alanı: {0}",kareninAlanıHesapla(kareKenarı));
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Lütfen üçgenin taban uzunluğunu giriniz: ");
                    tabanUzunlugu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen üçgenin yüksekliğini giriniz: ");
                    yukseklik = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Üçgenin Alanı: {0}", ucgeninAlanıHesapla(tabanUzunlugu,yukseklik));
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Lütfen dairenin yarıçap uzunluğunu giriniz: ");
                    yaricap = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dairenin Alanı: {0}",daireninAlanıHesapla(yaricap));
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Lütfen belirtilen indeks numaralarından birisini giriniz!");
                    Console.ReadLine();
                    break;

                    
            }
        }
        static int kareninAlanıHesapla(int kareKenarı)
        {
            return kareKenarı*kareKenarı;
        }
        static int ucgeninAlanıHesapla(int tabanUzunlugu,int yukseklik)
        {
            return tabanUzunlugu * yukseklik / 2;
        }
        static double daireninAlanıHesapla(int yaricap)
        {
            return Math.PI * yaricap * yaricap;
        }
    }
}
