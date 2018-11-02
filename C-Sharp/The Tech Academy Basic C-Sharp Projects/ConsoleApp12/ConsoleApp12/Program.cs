using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    class Program
    {
        static void Main()
        {
            // 1. Create a list of integers. Ask the user for a number to divide each number in the list by. 
            // Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
            try
            {
                List<int> intList1 = new List<int>();
                intList1.Add(80);
                intList1.Add(38);
                intList1.Add(43);
                intList1.Add(23);
                Console.WriteLine("Provide a number.");
                int number1 = Convert.ToInt32(Console.ReadLine());
                foreach (int int1 in intList1)
                {
                    Console.WriteLine(int1 + " devided by " + number1 + ": " + int1 / number1);
                }
                error = false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exception Error");
                Console.WriteLine("Please provide a valid integer.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DevideByZero Exception Error");
                Console.WriteLine("You cannot devide a number by 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
