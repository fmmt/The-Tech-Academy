using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            double inputNumber;
            double outputNumber;

            Console.WriteLine("Please provide a number:");
            inputNumber = Convert.ToDouble(Console.ReadLine());
            outputNumber = inputNumber * 50;
            Console.WriteLine(inputNumber + " multiplied by 50 equals to: " + outputNumber);

            Console.WriteLine("\nPlease provide a number:");
            inputNumber = Convert.ToDouble(Console.ReadLine());
            outputNumber = inputNumber + 25;
            Console.WriteLine(inputNumber + " adds 25 equals to: " + outputNumber);

            Console.WriteLine("\nPlease provide a number:");
            inputNumber = Convert.ToDouble(Console.ReadLine());
            outputNumber = inputNumber / 12.5;
            Console.WriteLine(inputNumber + " devided by 12.5 equals to: " + outputNumber);

            Console.WriteLine("\nPlease provide a number:");
            inputNumber = Convert.ToDouble(Console.ReadLine());
            bool trueOrFalse = inputNumber > 50;
            Console.WriteLine(inputNumber + " is greater than 50: " + trueOrFalse.ToString());

            Console.WriteLine("\nPlease provide a number:");
            inputNumber = Convert.ToDouble(Console.ReadLine());
            outputNumber = inputNumber % 7;
            Console.WriteLine("The remainder for " + inputNumber + " / 7 equals to: " + outputNumber);


            Console.Read();
        }
    }
}
