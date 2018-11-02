using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            byte day;

            // boolean comparison using a while statement
            Console.WriteLine("What date is Thanksgiving in 2018?");
            day = Convert.ToByte(Console.ReadLine());
            while (day != 22)
            {
                Console.WriteLine("Your answer is wrong.\nWhat date is Thanksgiving in 2018?");
                day = Convert.ToByte(Console.ReadLine());
            }
            Console.WriteLine("Correct!\n");

            // boolean comparison using a do while statement
            do
            {
                Console.WriteLine("What date is Thanksgiving in 2018?");
                day = Convert.ToByte(Console.ReadLine());
            }
            while (day != 22);
            Console.WriteLine("Correct!");

            Console.ReadLine();

        }
    }
}
