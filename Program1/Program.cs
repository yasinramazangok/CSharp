using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int square = number * number;
            int cube = square * number; // number*number*number 
            double squareRoot = Math.Sqrt(number); // camelCase, PascalCase veya UpperCamelCase
            Console.WriteLine("Girilen sayının karesi: {0}",square);
            Console.WriteLine("Girilen sayının küpü: {0}", cube);
            Console.WriteLine("Girilen sayının karekökü: {0}", squareRoot);
            Console.ReadLine();
        }
    }
}
