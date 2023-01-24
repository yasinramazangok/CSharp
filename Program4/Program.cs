using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i<3; i++)
            {
                Console.Write("Lütfen sayı giriniz: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(numbers); // Küçükten büyüğe sıralar.
            Array.Reverse(numbers); // Diziyi tersten sıralar.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
