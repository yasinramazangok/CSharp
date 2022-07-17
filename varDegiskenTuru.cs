using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varDegiskenTuru
{
    class Program
    {
        static void Main(string[] args)
        {
            var degisken1 = "software";
            Console.WriteLine(degisken1.GetType());
            Console.WriteLine(degisken1);
            // degisken1 = 23; burada derleyici hata verir. Çünkü ilk değer atamasında var tipine string bir değer atadığımız için
            // bundan sonraki atamalarda da string tipli bir değer isteyecektir.
            degisken1 = "engineering";
            Console.WriteLine(degisken1);
            Console.ReadKey();
        }
    }
}
