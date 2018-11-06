using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main()
        {
            Math math = new Math();

            int answer;
            int answer2;
            int answer3;

            answer = Math.MathOperation(12);
            answer2 = Math.MathOperation(63.4);
            answer3 = Math.MathOperation("abcde");

            Console.WriteLine(answer);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            
            Console.Read();
        }
    }
}
