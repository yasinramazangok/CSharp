using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopBirIleGirilenSayıArasındakiSayılarıYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
           
              Console.WriteLine("Aşağıda 1'den {0}'a kadar olan sayılar listelenmektedir: ", number);
            int sayac = 1;
            while (sayac <= number)
            {
                
                Console.WriteLine(sayac);
                sayac++;
            }
            Console.WriteLine("{0} ile 1 arasındaki sayılar ise aşağıdaki gibidir: ", number);
            while (number >= 1)
            {

                Console.WriteLine(number);
                number--;
            }
          
            Console.ReadLine();
        }
    }
}
