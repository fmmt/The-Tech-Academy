using System;

namespace ConsoleApp21
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("Please shut down manually.");
            Console.Read();
        }
    }
}
