using System;

namespace ConsoleApp22
{
    public class Employee : Person
    {
        public override void SayName()
        {
            base.SayName();
        }
        public int Id { get; set; }

        // Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator== (Employee employee1, Employee employee2)
        {
            return (employee1.Id == employee2.Id);
        }
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return !(employee1.Id == employee2.Id);
        }

    }
}
