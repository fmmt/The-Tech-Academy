using System;

namespace ConsoleApp16
{
    class Math
    {
        public static int MathOperation(int number)
        {
            int answer = number * number;
            return answer;
        }
        public static int MathOperation(double number)
        {
            int answer = Convert.ToInt32(number * 100);
            return answer;
        }
        public static int MathOperation(string userInput)
        {
            int answer;
            try
            {
                answer = Convert.ToInt32(userInput);
            }
            catch(Exception ex)
            {
                answer = userInput.Length;
            }

            return answer;
        }
        
    }
}
