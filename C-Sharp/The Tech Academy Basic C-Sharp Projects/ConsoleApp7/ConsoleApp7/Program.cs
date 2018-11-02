using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            double weight;
            double width;
            double height;
            double length;
            double eTotal;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                length = Convert.ToDouble(Console.ReadLine());

                eTotal = (width + height + length) * weight / 100;

                Console.WriteLine("Your estimated total for shipping this package is: $" + eTotal.ToString("F2") + "\nThank you.");
            }

            Console.ReadLine();
        }
    }
}
