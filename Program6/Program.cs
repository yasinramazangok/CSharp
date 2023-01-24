using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    public class Program
    {
        static void Main(string[] args)
        {
            double radius, diameter, height, circleArea, cylinderArea, cylinderVolume;
            const double PI = 3.14;
            Console.WriteLine("Lütfen yarıçap değerini giriniz: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen yükseklik değerini giriniz: ");
            height = Convert.ToDouble(Console.ReadLine());
            diameter = radius + radius;
            circleArea = PI * radius * radius;
            cylinderArea = PI*diameter*(height+radius);
            cylinderVolume = circleArea * height;
            Console.WriteLine("Silindirin Alanı: {0}",cylinderArea);
            Console.WriteLine("Silindirin Hacmi: {0}",cylinderVolume);
            Console.ReadLine();

        }
    }
}
