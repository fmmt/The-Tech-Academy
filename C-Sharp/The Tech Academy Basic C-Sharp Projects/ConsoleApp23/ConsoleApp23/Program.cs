using System;
using System.Collections.Generic;

namespace ConsoleApp23
{
    class Program
    {
        static void Main()
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Country", "State", "City" };

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 1986, 1954, 1963 };

            foreach (int thing2 in employee2.Things)
            {
                Console.WriteLine(thing2.ToString());
            }

            Console.Read();
        }
    }
}
