using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopFaktoriyelHesaplayanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi,sonuc=1;
            Console.WriteLine("Lütfen hesaplanacak faktöriyel sayısını giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
                 
            }
            Console.WriteLine("Girilen sayının faktöriyeli: {0}",sonuc);
            Console.ReadLine();
        }
    }
}
