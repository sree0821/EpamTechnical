using System;
using IncubationProject.Base;
using OpenQA.Selenium;

namespace IncubationProject.Core
{
    public class ExceptionHandlingTask : BrowserBase
    {
        private static string ApplicationUrl = "https://www.google.com";

        public void ExecuteTest()
        {
            try
            {
                // Open browser
                LaunchBrowser(ApplicationUrl);
                Console.WriteLine("Browser launched");

                // Call method that propagates exception (throws equivalent)
                PerformCriticalAction();
            }
            catch (Exception ex)
            {
                // Handling propagated exception (Throwable equivalent)
                Console.WriteLine("Exception handled at test level");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Cleanup
                CloseBrowser();
                Console.WriteLine("Browser closed in finally block");
            }
        }

        private void PerformCriticalAction()
        {
            // No try-catch here → exception propagates automatically
            throw new Exception("Critical automation failure: element not found");
        }
    }
}
