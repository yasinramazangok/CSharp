using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers; // Önce references'a ekledik, ardından projeye import ettik.
namespace AccessModifiersDemo
{
    // list priveleges yani bir nesnenin minimumda hangi belirtece ihtiyacı var ise o tanımlanmalıdır. Yazılım geliştirmede önemli bir yaklaşımdır.
    internal class Program
    {
        static void Main(string[] args)
        {
            Course2 course2 = new Course2(); // AccessModifiers projesinden public olduğu için çağırılabilen sınıf
        }
    }
}
