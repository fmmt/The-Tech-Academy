using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main()
        {
            Math math = new Math();

            double number;
            Console.WriteLine("Please provide a number:");
            number = Convert.ToDouble(Console.ReadLine());
            math.MathOperation(number);
            Console.WriteLine(number + " devided by 2: " + math.Answer);

            double answer;
            math.MathOperation(number, out answer);
            Console.WriteLine(number + " devided by 2: " + answer);

            Console.Read();
        }
    }
}
