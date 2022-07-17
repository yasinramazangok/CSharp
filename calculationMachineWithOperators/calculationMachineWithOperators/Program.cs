using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculationMachineWithOperators
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
            Console.WriteLine("Toplama işlemi için t'ye," + "\n" + "Çıkarma işlemi için f'ye," + "\n" + "Çarpma işlemi için ç'ye," + "\n" + "Bölme işlemi için b'ye basınız!");
            islem = Convert.ToString(Console.ReadLine());
            if (islem == "t")
            {
                toplam = sayi + sayi1;
                Console.WriteLine("Sayıların toplamı: " + toplam);
            }
            if (islem == "f")
            {
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
                Console.WriteLine("Sayıların farkı: " + fark);
            }
            if (islem == "ç")
            {
                carpim = sayi * sayi1;
                Console.WriteLine("Sayıların çarpımı: " + carpim);
            }
            if (islem == "b")
            {
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
                Console.WriteLine("Sayıların bölümü: " + bolum);
            }
            Console.ReadKey();    
        }
    }
}
