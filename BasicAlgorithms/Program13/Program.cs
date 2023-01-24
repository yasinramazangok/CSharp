using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Soru 15
            int number, onlarBasamagi, birlerBasamagi;
            int[] numbers = new int[99];
            for (int i = 1; i < 99; i++)
            { 
                onlarBasamagi = i / 10;
                number = i - (onlarBasamagi * 10); 
                birlerBasamagi = i;
                if ((onlarBasamagi + birlerBasamagi) % 2 == 1)
                {
                    numbers[i] = i;
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Haneleri toplamı tek olan sayılar: {0}", numbers[i]);
            }
            Console.ReadKey();
        }
    }
}
