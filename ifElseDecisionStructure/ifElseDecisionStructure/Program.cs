using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseDecisionStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string kulAd, sifre;
            Console.WriteLine("Lütfen kullanıcı adınızı giriniz: ");
            kulAd = Console.ReadLine();
            Console.WriteLine("Lütfen şifrenizi giriniz: ");
            sifre = Console.ReadLine();
            if (kulAd == "yasinramazangok" && sifre == "123456")
            {
                Console.WriteLine("Hoşgeldiniz!");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Hatalı Giriş!");
                Console.ReadKey();
                ;
            }
        }
    }
}
