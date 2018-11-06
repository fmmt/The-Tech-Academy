using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main()
        {
            int userInput;
            Console.WriteLine("Please provide an integer.");
            userInput = Convert.ToInt32(Console.ReadLine());

            int answer1, answer2, answer3;
            answer1 = math.PowerOf2(userInput);
            answer2 = math.PowerOf3(userInput);
            answer3 = math.PowerOf4(userInput);

            Console.WriteLine(userInput + " to the power of 2 is " + answer1 + ".");
            Console.WriteLine(userInput + " to the power of 3 is " + answer2 + ".");
            Console.WriteLine(userInput + " to the power of 4 is " + answer3 + ".");
            Console.Read();
        }
    }
}
