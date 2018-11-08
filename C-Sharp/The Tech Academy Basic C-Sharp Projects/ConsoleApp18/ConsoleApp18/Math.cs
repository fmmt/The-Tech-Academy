using System;

namespace ConsoleApp18
{
    public class Math
    {
        // 1. Create a class. In that class, create a void method that outputs an integer. 
        // Have the method divide the data passed to it by 2
        public double Answer { get; set; }
        public void MathOperation(double number)
        {
            double answer = number / 2;
            Answer = answer;
        }

        // 4. Create a method with output parameters.
        // 5. Overload a method.
        public void MathOperation(double number, out double answer)
        {
            answer = number / 2;
        }
    }
}
