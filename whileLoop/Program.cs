using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 125;
            while (sayi>3)
            {
                Console.WriteLine(sayi.GetHashCode());
                Console.WriteLine(sayi);
                sayi--;
            }
            Console.ReadLine();
        }
    }
}
