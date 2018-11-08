using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main()
        {
            // 2. In the Main() method, instantiate that class.
            Math math = new Math();

            // 3. Have the user enter a number. Call the method on that number. 
            // Display the output to the screen. It should be the entered number, divided by two.
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
