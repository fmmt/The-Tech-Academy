using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main()
        {
            // 1. Prints the current date and time to the console.
            Console.WriteLine(DateTime.Now);

            // 2. Asks the user for a number.
            Console.WriteLine("Please provide an integer.");
            int number = Convert.ToInt32(Console.ReadLine());

            // 3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            DateTime datetime = DateTime.Now.AddHours(number);
            Console.WriteLine("It will be {0} in {1} hours.", datetime, number);

            Console.Read();
        }
    }
}
