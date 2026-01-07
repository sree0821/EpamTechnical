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
                LaunchBrowser(ApplicationUrl);
                Console.WriteLine("Browser launched");
                bool isLoginButtonPresent = false;

                if (!isLoginButtonPresent)
                {
                    throw new AutomationException("Login button not found on the page");
                }

                Console.WriteLine("Test executed successfully");
            }
            catch (AutomationException ex)
            {
                Console.WriteLine("Custom automation exception handled");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseBrowser();
                Console.WriteLine("Browser closed in finally block");
            }
        }
    }
}
