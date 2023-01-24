using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int temperature;
            Console.WriteLine("Lütfen maddenin sıcaklık değerini giriniz: ");
            temperature = Convert.ToInt32(Console.ReadLine());
            if(temperature <= 0) // Maddenin donma noktası 0 kabul edilmiştir.
            {
                Console.WriteLine("Madde katı haldedir.");
            }
            else if (temperature > 0 && temperature<100)
            {
                Console.WriteLine("Madde sıvı haldedir.");
            }
            else
            {
                // Maddenin kaynama noktası 100 derece kabul edilmiştir.
                Console.WriteLine("Madde gaz halindedir.");
            }
            Console.ReadLine();
        }
    }
}
