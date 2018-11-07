using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main()
        {
            Number number = new Number();
            number.Amount = 20.18m;
            Console.WriteLine(number.Amount);
            Console.Read();
        }

        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
