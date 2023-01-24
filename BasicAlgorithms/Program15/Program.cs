using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program15
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Soru 22
            double x=0, y;
            Console.WriteLine("Lütfen birinci noktanın koordinatlarını giriniz: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci noktanın koordinatlarını giriniz: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double slope = (y2 - y1) / (x2 - x1);
            y = slope*(x-x1) + y1;
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
