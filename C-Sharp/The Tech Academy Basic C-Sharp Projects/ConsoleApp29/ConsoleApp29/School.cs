using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class School
    {
        // 3. Chain two constructors together.
        public School(string schoolName) : this(schoolName, "Portland")
        {

        }
        public School(string schoolName, string city)
        {
            SchoolName = schoolName;
            City = city;
        }

        public string SchoolName { get; set; }
        public string City { get; set; }
    }
}
