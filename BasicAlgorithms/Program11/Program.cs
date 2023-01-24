using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Soru 13
            Console.WriteLine("Lütfen bir ondalıklı sayı giriniz: ");
            double number = Convert.ToDouble(Console.ReadLine());
            int integer = (int)Math.Floor(number); 
            double decimally = number - integer;
            Console.WriteLine("Girilen sayının tam kısmı: {0}",integer);
            Console.WriteLine("Girilen sayının ondalıklı kısmı: {0}",decimally);
            Console.ReadLine();
        }
    }
}
