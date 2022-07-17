using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysAndForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personelİsimleri = {"Burak, Özgür, Yasin, Ramazan "};
            foreach (var item in personelİsimleri)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.GetType());
            }
            Console.ReadKey();
        }
    }
}
