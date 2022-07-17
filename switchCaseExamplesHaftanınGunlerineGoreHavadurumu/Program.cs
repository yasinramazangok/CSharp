using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCaseExamplesHaftanınGunlerineGoreHavadurumu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen hava durumunu öğrenmek istediğiniz günün indeks numarasını giriniz: ");
            Console.WriteLine("1-Pazartesi\n2-Salı\n3-Çarşamba\n4-Perşembe\n5-cuma\n6-Cumartesi\n7-Pazar");
            int gun = Convert.ToInt32(Console.ReadLine());

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi günü hava yağmurlu!");
                    break;
                case 2:
                    Console.WriteLine("Salı günü hava az bulutlu ve sıcaklık 10 C' olacak!");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba günü hava parçalı bulutlu!");
                    break;
                case 4:
                    Console.WriteLine("Perşembe günü hava yağmurlu ve sert rüzgarlı!");
                    break;
                case 5:
                    Console.WriteLine("Cuma günü hava açık ve güneşli, sıcaklık 22 C' olacak!");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi hava güneşli!");
                    break;
                case 7:
                    Console.WriteLine("Pazar günü hava parçalı bulutlu!");
                    break;
                default:
                    Console.WriteLine("Lütfen belirtilen indeks numaralarından birisini giriniz!");
                    break;

            }
            Console.ReadKey();
        
        }
    }
}
