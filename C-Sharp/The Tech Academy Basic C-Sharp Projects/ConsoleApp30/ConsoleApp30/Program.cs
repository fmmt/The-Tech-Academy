using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main()
        {
            int age = 0;
            bool validAnswer = false;
            try
            {
                while (!validAnswer)
                {
                    // 1. Ask the user for his age.
                    Console.WriteLine("How old are you?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter your actual age.");
                }
                if (age <= 0)
                {
                    // 4. Display appropriate error messages if user enters zero or negative numbers.
                    throw new typoException();
                }

                DateTime today = DateTime.Today;
                DateTime yearOfBirth = today.AddYears(-age);
                
                // 2. Display the year user born.
                Console.WriteLine("You were born in {0}.", yearOfBirth.ToString("yyyy"));
                Console.Read();
            }
            catch(typoException)
            {
                Console.WriteLine("I know you are older than {0}.", age);
            }
            catch(Exception)
            {
                // 5. Display a general message if exception caused by anything else.
                Console.WriteLine("An error occured. Please contact your System Administrator.");

            }

            Console.Read();
        }
    }
}


