using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopGirilenSayininBinaryKarsiliginiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  sayi;
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int bit = 32; bit >= 1; bit--)
            {
                Console.Write("{0}", (sayi >> bit - 1) & 1);
            }
            Console.ReadLine();
        }
    }
}
