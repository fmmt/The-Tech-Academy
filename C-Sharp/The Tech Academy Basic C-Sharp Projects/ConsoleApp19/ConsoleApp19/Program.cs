using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
        }
    }
}
