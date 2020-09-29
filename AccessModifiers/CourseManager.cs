using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class CourseManager
    {
        public void Add()
        {
            //aynı proje içerisinde internal class tanımlandıgımız ıcın kullanabilmekteyiz.
            Course course = new Course();
        }
    }
}
