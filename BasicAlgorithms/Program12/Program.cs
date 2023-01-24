using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Soru 14
            int number;
            Console.Write("Say Giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number + " karakteri ASCII Kaşılığı >> " + Convert.ToChar(number));
            char character;
            Console.Write("Karakter Giriniz: ");
            character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(character + " karakteri ASCII Kaşılığı >> " + Convert.ToInt32(character));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
 