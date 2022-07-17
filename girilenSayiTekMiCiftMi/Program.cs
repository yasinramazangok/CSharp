using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilenSayiTekMiCiftMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool ciftMi;
            if(sayi%2==0)
            {
                ciftMi = true;
                
            }
            else
            {
                ciftMi = false;
            }
            if (ciftMi == true)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir!");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir!");
            }
            Console.ReadKey();
        }
    }
}
