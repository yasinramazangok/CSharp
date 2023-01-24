using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program8
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Soru 10
            int number, sum = 0, evenSum = 0;
            long multiply = 1;
            Console.WriteLine("Lütfen 20'den büyük bir sayı giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 10; i < number; i++)
            {
                sum += number;
            }
            for (int i = 5; i < number; i += 2)
            {
                multiply *= i;
            }
            for (int i = 14; i < number; i += 2)
            {
                evenSum += i;
            }
            Console.WriteLine(sum);
            Console.WriteLine(multiply);
            Console.WriteLine(evenSum);
            Console.ReadLine();
        }
    }
}
