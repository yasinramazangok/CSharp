using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int edge3; // tanımlama
            Console.WriteLine("Lütfen üçgenin 1. kenarını giriniz: ");
            int edge1 = Convert.ToInt32(Console.ReadLine()); // hem tanımlama hem değer ataması
            Console.WriteLine("Lütfen üçgenin 2. kenarını giriniz: ");
            int edge2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üçgenin 3. kenarını giriniz: ");
            edge3 = Convert.ToInt32(Console.ReadLine()); // değer ataması
            if(edge1 == edge2 && edge2 == edge3)
            {
                Console.WriteLine("Bu üçgen eşkenar üçgendir.");
            }
            else if (edge1 == edge2 || edge1 == edge3 || edge2 == edge3)
            {
                Console.WriteLine("Bu üçgen ikizkenar üçgendir.");
            }
            else
            {
                Console.WriteLine("Bu üçgen çeşitkenar üçgendir.");
            }
            Console.ReadLine();
        }
    }
}
