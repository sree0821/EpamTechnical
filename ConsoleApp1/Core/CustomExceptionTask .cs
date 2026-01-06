using System;
using IncubationProject.Base;

namespace ConsoleApp1.Core
{
    public class CustomExceptionTask : BrowserBase
    {
        private static string ApplicationUrl = "https://www.google.com";

        public void ExecuteTest()
        {
            try
            {
                // Open browser
                LaunchBrowser(ApplicationUrl);
                Console.WriteLine("Browser launched");

                // Simulated automation condition
                bool isLoginButtonPresent = false;

                if (!isLoginButtonPresent)
                {
                    // Throwing custom exception
                    throw new AutomationException("Login button not found on the page");
                }

                Console.WriteLine("Test executed successfully");
            }
            catch (AutomationException ex)
            {
                // Handling custom exception
                Console.WriteLine("Custom automation exception handled");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Cleanup
                CloseBrowser();
                Console.WriteLine("Browser closed in finally block");
            }
        }
    }
}
