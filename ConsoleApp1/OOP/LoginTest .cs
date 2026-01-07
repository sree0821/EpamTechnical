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
