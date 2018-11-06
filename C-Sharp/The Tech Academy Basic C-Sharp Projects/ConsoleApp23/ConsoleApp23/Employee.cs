using System;
using System.Collections.Generic;

namespace ConsoleApp23
{
    public class Employee<T>
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }
    }
}
