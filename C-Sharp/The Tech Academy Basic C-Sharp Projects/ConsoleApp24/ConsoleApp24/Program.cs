using System;
using System.Collections.Generic;

namespace ConsoleApp24
{
    class Program
    {
        static void Main()
        {
            string userInput;
            Console.WriteLine("What day of the week is it today?");
            userInput = Console.ReadLine().ToUpper();

            // Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            try
            {
                int enumValue = Convert.ToInt32((DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), userInput));
                Console.WriteLine("Variable assigned to " + userInput + ": " + enumValue);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }            

            Console.Read();
        }

        private enum DayOfTheWeek
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }
    }
}
