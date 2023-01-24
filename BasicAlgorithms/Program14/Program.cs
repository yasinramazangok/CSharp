using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program14
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Soru 18
            int yuzlerBasamagi, onlarBasamagi, birlerBasamagi;
            Console.WriteLine("Lütfen 1000'den küçük bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            yuzlerBasamagi = number / 100; 
            number = number - (yuzlerBasamagi * 100); 
            onlarBasamagi =number / 10; 
            number = number - (onlarBasamagi * 10); ; 
            birlerBasamagi = number;
            int sum = yuzlerBasamagi+ onlarBasamagi+birlerBasamagi;
            Console.WriteLine("Girilen sayının basamakları toplamı: {0}",sum);
            Console.ReadKey();
        }
    }
}
