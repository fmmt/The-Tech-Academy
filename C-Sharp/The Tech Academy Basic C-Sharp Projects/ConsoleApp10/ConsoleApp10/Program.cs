using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            byte indexNum;
            
            // Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            string[] strArray = new string[5] { "aaa", "bbb", "ccc", "ddd", "eee" };

            Console.WriteLine("Provide a number between 0 and 4:");
            indexNum = Convert.ToByte(Console.ReadLine());
            if (indexNum < 0 || indexNum > 4)
            {
                Console.WriteLine("The index does not exist.");
            }
            else
            {
                Console.WriteLine("String in index number " + indexNum + ": " + strArray[indexNum]);
            }

            // Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("\nProvide a number between 0 and 4:");
            indexNum = Convert.ToByte(Console.ReadLine());
            if (indexNum < 0 || indexNum > 4)
            {
                Console.WriteLine("The index does not exist.");
            }
            else
            {
                Console.WriteLine("Integer in index number " + indexNum + ": " + intArray[indexNum]);
            }

            // Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
            List<string> strList = new List<string>();
            strList.Add("aaa");
            strList.Add("bbb");
            strList.Add("ccc");
            strList.Add("ddd");
            strList.Add("eee");

            Console.WriteLine("\nProvide a number between 0 and 4:");
            indexNum = Convert.ToByte(Console.ReadLine());
            if (indexNum < 0 || indexNum > 4)
            {
                Console.WriteLine("The index does not exist.");
            }
            else
            {
                Console.WriteLine("String in index number " + indexNum + ": " + strList[indexNum]);
            }

            Console.Read();
        }
    }
}
