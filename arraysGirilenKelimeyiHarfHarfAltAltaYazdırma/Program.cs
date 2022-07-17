using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysGirilenKelimeyiHarfHarfAltAltaYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir metin giriniz: ");
            string text =  Console.ReadLine();
            foreach (char character in text)
            {
                Console.WriteLine(character);

            }
            Console.ReadLine();
        }
    }
}
