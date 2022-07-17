using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopUstHesaplayanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int taban, us,sonuc=1;
            Console.WriteLine("Lütfen taban sayısını giriniz: ");
            taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üs sayısını giriniz: ");
            us = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= us; i++)
            {
                sonuc *= taban;
            }
            Console.WriteLine("{0} sayısının {1}'inci kuvveti: {2}",taban,us,sonuc);
            Console.ReadLine();
        }

    }
}
