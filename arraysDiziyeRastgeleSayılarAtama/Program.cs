using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysDiziyeRastgeleSayılarAtama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random rastgele = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(1, 200);
                Console.Write(dizi[i] + "\t");
            }
            Console.WriteLine();
            int sayac=0;
            for (int i = 0; i < dizi.Length; i++)
            {
                
                if (dizi[i] > 100)
                {
                    sayac++;
                    
                    
                }
            }
            Console.WriteLine("Dizideki {0} tane sayı 100'den büyüktür!",sayac);
            int ortalama = 0, toplam = 0, sayacA = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < 150)
                {
                    sayac++;
                    

                }
                toplam += dizi[i];

            }
            ortalama = toplam / sayac;
            Console.WriteLine("Dizideki 150'den küçük sayıların ortalaması {0}'dır!",ortalama);
            int sayacB=0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    sayacB++;
                }
            }
            Console.WriteLine("Dizideki çift sayılar {0} tanedir!",sayacB);

            Console.ReadKey();
        }
    }
}
