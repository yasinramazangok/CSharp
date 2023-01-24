using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
     public class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Birinci sayıyı giriniz: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if(number1 > number2)
            {
                Console.WriteLine("{0} daha büyüktür.",number1);
            }
            else if(number2 > number1)
            {
                Console.WriteLine("{0} daha büyüktür.",number2);
            }
            else
            {
                Console.WriteLine("{0} ve {1} birbirine eşittir.",number1,number2);
                // Console.WriteLine("Girilen sayılar birbirine eşittir.");
            }
            Console.ReadLine();
        }
    }
}
