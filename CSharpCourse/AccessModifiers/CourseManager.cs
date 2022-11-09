using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // Bir class ya internal olur ya da public olur. private ya da protected olamaz. Ancak nested olursa kullanılabilir.
    class CourseManager
    {
        public void Add()
        {
            Course course = new Course(); // Course nesnesini aynı assembly altında ve internal olduğu için new'leyebildik. 
        }
        private class NestedClass
        {
            // İç içe class olursa private erişim bildigecini class'lar için kullanabiliriz.
        }
    }
}
