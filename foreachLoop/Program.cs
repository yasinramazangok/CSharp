using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 165, 465, 465, 4, 65498, 987, 984, 89491286, 41, 6481 };
            foreach (int sayi in numbers) // sayi değişkeninin tnaımlaması bir nevi burada olmaktadır!
            {

                Console.WriteLine(sayi);
                
            }
            Console.WriteLine("number tamsayılar dizisinin uzunluğu {0}'dır.",numbers.Length);
            Console.ReadLine();
        }
    }
}
