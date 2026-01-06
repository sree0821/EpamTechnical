using System;

namespace ConsoleApp1.OOP
{
    public class LoginTest : BaseTestScenario
    {
        public override void ExecuteTest()
        {
            try
            {
                OpenApplication();
                Console.WriteLine("Login Test: Browser opened");

                // Simulated login steps
                Console.WriteLine("Entering username");
                Console.WriteLine("Entering password");
                Console.WriteLine("Clicking login button");

                Console.WriteLine("Login Test Passed");
            }
            finally
            {
                CloseBrowser();
                Console.WriteLine("Browser closed after Login Test");
            }
        }
    }
}
