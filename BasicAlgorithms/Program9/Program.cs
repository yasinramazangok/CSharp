using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Soru 11
            Console.WriteLine("Lütfen bir harf giriniz: ");
            string character = Convert.ToString(Console.ReadLine());
            string upperCharacter = character.ToUpper();
            Console.WriteLine(upperCharacter);
            Console.ReadLine();
        }
    }
}
