using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp26
{
    class Program
    {
        static void Main()
        {
            // In the Main() method, create a list of at least 10 employees. 
            // Each employee should have a first and last name, as well as an Id. 
            // At least two employees should have the first name "Joe".
            List<string> employees = new List<string>()
                { "Joe,Smith,2", "Michael,Smith,5", "Robert,Smith,7", "Maria,Garcia,1", "David,Smith,10",
                "Joe,Rodriguez,3", "Mary,Hernandez,6", "Maria,Martinez,4", "Joe,Johnson,8", "James,Johnson,9" };

            // Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<string> joes1 = new List<string>();
            string firstName;
            foreach (string employee1 in employees)
            {
                firstName = employee1.Split(',')[0];
                if (firstName == "Joe")
                {
                    joes1.Add(firstName + " " + employee1.Split(',')[1] + ", ID: " + employee1.Split(',')[2]);
                }
            }
            foreach (string joe1 in joes1)
            {
                Console.WriteLine(joe1);
            }

            // Do the same thing again, but this time with a lambda expression.
            List<string> joes2 = employees.Where(x => x.Contains("Joe")).ToList();
            foreach (string employee2 in joes2)
            {
                Console.WriteLine(employee2.Split(',')[0] + " " + employee2.Split(',')[1] + ", ID: " + employee2.Split(',')[2]);
            }

            // Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<string> idGreaterThan5 = employees.Where(x => Convert.ToInt32(x.Split(',')[2]) > 5).ToList();
            foreach (string employee3 in idGreaterThan5)
            {
                Console.WriteLine(employee3.Split(',')[0] + " " + employee3.Split(',')[1] + ", ID: " + employee3.Split(',')[2]);
            }

            Console.Read();
        }
    }
}
