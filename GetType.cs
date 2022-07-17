using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class GetType
    {
        private void gettype()
        { 
            object x;
            x = 123423;
            Console.WriteLine(x.GetType());
            x = "asd";
            Console.WriteLine(x.GetType());
            x = 23.234f;
            Console.WriteLine(x.GetType());
            x = true;
            Console.WriteLine(x.GetType());
            x = 5.234M;
            Console.WriteLine(x.GetType());
            Console.ReadKey();
            
        }
    }
}
