using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Soru 12
            Console.WriteLine("Lütfen bir negatif giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int positiveNumber = number * (-1);
            int positiveNumber1 = Math.Abs(number);
            Console.WriteLine(positiveNumber);
            Console.WriteLine(positiveNumber1);
            Console.ReadLine();
        }
    }
}
