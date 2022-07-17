using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopsBirIleBinArasındakiSayılarınKareleriniYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1000, sayac = 1,sayilarinKaresi;
            while (sayac<=sayi)
            {
                sayilarinKaresi = sayac * sayac;
                Console.WriteLine("{0} sayısının karesi: {1}",sayac,sayilarinKaresi);
                sayac++;
            }
            Console.ReadLine();
        }
    }
}
