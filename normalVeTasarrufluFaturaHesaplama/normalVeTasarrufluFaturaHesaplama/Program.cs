using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace normalVeTasarrufluFaturaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen evinizdeki ampul sayısını giriniz: ");
            int ampulSayısı = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Lütfen ışıkların günde kaç saat açık kaldığını giriniz: ");
            int saat = Convert.ToInt16(Console.ReadLine());
            int normalFatura = ampulSayısı * saat*2;
            int tasarrufluFatura = (ampulSayısı * saat * 2) * 80 / 100;
            Console.WriteLine("Normal ampul kullanımında aylık faturanız:{0}",normalFatura);
            Console.WriteLine("Tasarruflu ampul kullanımında aylık faturanız:{0}",tasarrufluFatura);
            Console.ReadKey();
        }
    }
}
