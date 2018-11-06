using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main()
        {
            IQuittable iQuittable = new Employee();
            iQuittable.Quit();        
        }
    }
}
