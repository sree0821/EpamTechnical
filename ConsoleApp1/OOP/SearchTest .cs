using System;

namespace ConsoleApp1.OOP
{
    public class SearchTest : BaseTestScenario
    {
        public override void ExecuteTest()
        {
            try
            {
                OpenApplication();
                Console.WriteLine("Search Test: Browser opened");

                // Simulated search steps
                Console.WriteLine("Entering search keyword");
                Console.WriteLine("Clicking search");

                Console.WriteLine("Search Test Passed");
            }
            finally
            {
                CloseBrowser();
                Console.WriteLine("Browser closed after Search Test");
            }
        }
    }
}
