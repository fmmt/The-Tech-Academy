using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main()
        {
            int number1;
            int number2;
            int answer;

            Math math = new Math();

            Console.WriteLine("Please provide an integer:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide another integer if you want:");
            try
            {
                number2 = Convert.ToInt32(Console.ReadLine());
                answer = Math.MathOperation(number1, number2);
            }
            catch(Exception ex)
            {
                answer = Math.MathOperation(number1);
            }

            Console.WriteLine(answer);
            Console.Read();
        }
    }
}
