using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp13
{
    class Program
    {
        static void Main()
        {
            // 1. Ask a user for a number.
            Console.WriteLine("Please provide a number.");

            // 2. Log that number to a text file.
            string numberW = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Fumi\Desktop\log.txt", numberW);

            // 3. Print the text file back to the user.
            string numberR = File.ReadAllText(@"C:\Users\Fumi\Desktop\log.txt");
            Console.WriteLine(numberR);

            Console.Read();
        }
    }
}
