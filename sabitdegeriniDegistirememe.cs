using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class sabitdegeriniDegistirememe
    { 
        static void Main()
        {
            const int x = 5, y = 10;
            x += 2; // Sabit atanan değişkenin değerini değiştiremediğimiz için derleme hatası alınır.
            int t = x+y ;
            Console.WriteLine(t);
        }
    }
}
