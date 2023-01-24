using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Soru 26
            Console.Write("1. sayıyı giriniz: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int maximum = number1 * number2;
            int ekok = 0;
            for (int i = maximum; i > 0; i--)
            {
                if (i % number1 == 0 && i % number2 == 0)
                {
                    ekok = i;
                }
            }
            Console.WriteLine("{0} ve {1}'in ekoku: {2}",number1, number2, ekok);
            Console.ReadLine();

        }
    }
}
