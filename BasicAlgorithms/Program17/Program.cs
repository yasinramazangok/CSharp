using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Soru 27
            int equivalentResistance = 0;
            Console.WriteLine("Dirençleri nasıl bağlamak istiyorsunuz? Seri/Paralel ?");
            string connectionState = Console.ReadLine();
            Console.WriteLine("Direnç değerini giriniz: ");
            int resistance = Convert.ToInt32(Console.ReadLine());
            if(connectionState=="s")
                equivalentResistance += resistance;
            else if(connectionState=="p")
                1/equivalentResistance = 
            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Yeni direnç değeri girmek istiyor musunuz? E/H ?");
                string state = Convert.ToString(Console.ReadLine());
                if(state == 'e')
                {
                    Console.WriteLine("Yeni direnç değerini giriniz: ");

                }
            }
            
        }
    }
}
