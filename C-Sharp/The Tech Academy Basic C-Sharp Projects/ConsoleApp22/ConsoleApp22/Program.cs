using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee { FirstName = "Jordan", LastName = "Smith", Id = "111" };
            Employee employee2 = new Employee { FirstName = "Marie", LastName = "Martinez", Id = "222" };

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);

            Console.Read();
        }
    }
}
