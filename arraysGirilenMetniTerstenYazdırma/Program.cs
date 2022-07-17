using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysGirilenMetniTerstenYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir metin giriniz: ");
            string text = Console.ReadLine();
            Console.WriteLine(text.Length);
            for (int i = text.Length - 1; i >=0; i--)
            {
                Console.Write(text[i]);

            }
            Console.ReadLine();
        }
    }
}
