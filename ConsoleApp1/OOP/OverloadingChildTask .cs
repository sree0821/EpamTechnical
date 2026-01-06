using System;

namespace ConsoleApp1.OOP
{
    // Child class inherits parent
    public class OverloadingChildTask : OverloadingAndAccessTask
    {
        public void ExecuteTest()
        {
            // protected member accessible in child
            Console.WriteLine($"Accessing protected URL: {ApplicationUrl}");

            // Calling overloaded methods
            OpenApplication(); // calls method without parameter
            OpenApplication("https://google.com"); // calls overloaded method

            Console.WriteLine("Test steps executed");

            Close();
        }
    }
}
