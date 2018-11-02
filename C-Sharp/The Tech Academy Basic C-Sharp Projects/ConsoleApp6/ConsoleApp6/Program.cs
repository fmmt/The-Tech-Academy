using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            byte age;
            bool duiRecord;
            uint tickets;
            bool bQualified;

            Console.WriteLine("What is your age?");
            age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?(true or false)");
            duiRecord = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            tickets = Convert.ToUInt32(Console.ReadLine());

            bQualified = (age >= 15 && duiRecord == false && tickets < 3);

            Console.WriteLine("Qualified?: " + Convert.ToString(bQualified));

            Console.ReadLine();
        }
    }
}
