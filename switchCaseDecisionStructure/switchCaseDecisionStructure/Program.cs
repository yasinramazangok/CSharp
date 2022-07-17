using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCaseDecisionStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string islem;
            double sayi, sayi1, toplam, fark, carpim, bolum;
            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Toplama işlemi için t'ye");
            Console.WriteLine("Çıkarma işlemi için f'ye");
            Console.WriteLine("Çarpma işlemi için ç'ye");
            Console.WriteLine("Bölme işlemi için b'ye basınız!");
            islem = Convert.ToString(Console.ReadLine());
            toplam = sayi + sayi1;
            if (sayi > sayi1)
            {
                fark = sayi - sayi1;
            }
            else if (sayi < sayi1)
            {
                fark = sayi1 - sayi;
            }
            else
            {
                fark = 0;
            }
            carpim = sayi * sayi1;
            if (sayi > sayi1)
            {
                bolum = sayi / sayi1;
            }
            else if (sayi < sayi1)
            {
                bolum = sayi1 / sayi;

            }
            else
            {
                bolum = 1;
            }

            switch (islem)
            {
                case "t":
                    Console.WriteLine("Sayıların toplamı:{0} ", toplam);
                    break;
                case "f":
                    Console.WriteLine("Sayıların farkı:{0} ", fark);
                    break;
                case "ç":
                    Console.WriteLine("Sayıların çarpımı:{0} ", carpim);
                    break;
                case "b":
                    Console.WriteLine("Sayıların bölümü:{0} ", bolum);
                    break;


                default:
                    Console.WriteLine("Hatalı giriş yaptınız!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
