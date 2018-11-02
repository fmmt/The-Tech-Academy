using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            double hourlyRate1;
            double hourlyRate2;
            double hoursWorked1;
            double hoursWorked2;
            double weeklySalary1;
            double weeklySalary2;
            bool trueOrFalse;

            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("\nPerson 1");
            Console.WriteLine("Hourly Rate?");
            hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            hoursWorked1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Hourly Rate?");
            hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            hoursWorked2 = Convert.ToDouble(Console.ReadLine());

            weeklySalary1 = hourlyRate1 * hoursWorked1;
            weeklySalary2 = hourlyRate2 * hoursWorked2;
            trueOrFalse = weeklySalary1 > weeklySalary2;

            Console.WriteLine("\nWeekly salary of Person 1: " + weeklySalary1);
            Console.WriteLine("Weekly salary of Person 2: " + weeklySalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?: " + Convert.ToString(trueOrFalse));

            Console.ReadLine();
        }
    }
}
