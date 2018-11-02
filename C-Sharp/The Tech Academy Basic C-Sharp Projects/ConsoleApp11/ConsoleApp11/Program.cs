using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a one-dimensional Array of strings. Ask the user to input some text. 
            // Create a loop that goes through each string in the Array, adding the user’s text to the string. 
            // Then create a loop that prints off each string in the Array on a separate line.
            int i;
            string[] strArray1 = new string[5];
            for (i = 0; i < strArray1.Length; i++)
            {
                Console.WriteLine("Provide a word to fill an array:");
                strArray1[i] = Console.ReadLine();
            }
            foreach (string str1 in strArray1)
            {
                Console.WriteLine(str1);
            }

            // 2. Create an infinite loop.
            //for (i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 3. Fix the infinite loop so it will execute.
            for (i = 0; i >= 0; i++)
            {
                Console.WriteLine(i);
                if (i == 100) break;
            }

            // 4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            // 5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            for (i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            // 6. Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. 
            // Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            List<string> strList1 = new List<string>();
            strList1.Add("BLUE");
            strList1.Add("RED");
            strList1.Add("GREEN");
            Console.WriteLine("Pick a color from primary colors of RGB color model:");
            string color = Console.ReadLine().ToUpper();
            bool exitLoop = false;
            for (i = 0; i < strList1.Count; i++)
            {
                if (strList1[i] == color)
                {
                    Console.WriteLine("Index of " + color + ": " + i);
                    // 8. Add code to that above loop that stops it from executing once a match has been found.
                    exitLoop = true;
                }

                if (exitLoop) break;
            }

            // 7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            if (exitLoop == false)
            {
                Console.WriteLine("The color you picked is not a primary color.");
            }

            // 9. Create a List of strings that has at least two identical strings in the List.
            // Ask the user to select text to search for in the List. 
            // Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            List<string> strList2 = new List<string>();
            strList2.Add("CHICKEN");
            strList2.Add("BEEF");
            strList2.Add("VEGAN");
            strList2.Add("CHICKEN");
            strList2.Add("VEGAN");

            List<int> intList = new List<int>();
            Console.WriteLine("Would you like chicken, beef or vegan for your meal?:");
            string meal = Console.ReadLine().ToUpper();
            string result1;
            for (i = 0; i < strList2.Count; i++)
            {
                if (strList2[i] == meal)
                {
                    intList.Add(i);
                }
            }

            if (intList.Count > 0)
            {
                result1 = "Index of " + meal + ": ";
                foreach (int index in intList)
                {
                    result1 = result1 + index + ", ";
                }
                result1 = result1.Remove(result1.Length - 2, 2);
            }
            else
            {
                // 10. Add code to that above loop that tells a user if they put in text that isn’t in the List.
                result1 = "We are sorry we do not have " + meal + ".";
            }
            Console.WriteLine(result1);

            // 11. Create a List of strings that has at least two identical strings in the List. 
            // Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> strList3 = new List<string>();
            strList3.Add("CHICKEN");
            strList3.Add("BEEF");
            strList3.Add("CHICKEN");
            strList3.Add("CHICKEN");
            strList3.Add("BEEF");
            strList3.Add("VEGAN");

            string result2;
            List<string> strList4 = new List<string>();

            foreach (string str3 in strList3)
            {
                bool appeared = false;
                foreach (string str4 in strList4)
                {
                    if (str4 == str3)
                    {
                        appeared = true;
                    }
                }
                result2 = str3;
                if (appeared)
                {
                    result2 = result2 + ": duplicate order";
                }
                else
                {
                    strList4.Add(str3);
                }

                Console.WriteLine(result2);
            }

            Console.Read();
        }
    }
}
