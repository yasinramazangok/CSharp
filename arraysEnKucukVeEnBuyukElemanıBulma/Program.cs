using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysEnKucukVeEnBuyukElemanıBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[12] { 11, 34, 4723, 7546235, 648345,0,-1, 578, 35, 455, 2352, 1231 };
            int enBuyuk = sayilar[0], enKucuk = sayilar[0];
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (enKucuk > sayilar[i])
                {
                    enKucuk = sayilar[i]; // yer değiştirme yapılıyor burada yeni en küçüğü buluyoruz ve enKucuk değişkenine atıyoruz.
                }
                if (enBuyuk < sayilar[i])
                {
                    enBuyuk=sayilar[i];
                }
            }
            Console.WriteLine("{0} en büyük eleman ve {1} en küçük elemandır!",enBuyuk,enKucuk);
            Console.ReadLine();
        }
    }
}
