using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    public class Program
    {
        static void Main(string[] args)
        {
            double radius, height, edge, circleArea, coneArea, coneVolume;
            const double PI = 3.14;
            Console.WriteLine("Lütfen yarıçap değerini giriniz: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen yükseklik değerini giriniz: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen koninin yanal ayrıt değerini giriniz: ");
            edge = Convert.ToDouble(Console.ReadLine());
            circleArea = PI * radius * radius;
            coneArea = (PI * radius * radius) + (2 * PI * radius * edge);
            coneVolume = PI * radius * radius * height * 1 / 3;
            Console.WriteLine("Koni Alanı: {0}", coneArea);
            Console.WriteLine("Koni Hacmi: {0}", coneVolume);
            Console.ReadLine();
        }
    }
}
