using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starsWithForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int satır = 0; satır < 15; satır = satır + 1)
            {
                for (int sutun = 0; sutun < 14; sutun++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}
