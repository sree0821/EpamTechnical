using System;
using IncubationProject.Base;
using OpenQA.Selenium;

namespace IncubationProject.Core
{
    public class ExceptionHandlingTask : BrowserBase
    {
        private const string ApplicationUrl = "https://www.google.com";

        public void ExecuteTest()
        {
            try
            {
                LaunchBrowser(ApplicationUrl);
                Console.WriteLine("Browser launched");

                PerformCriticalAction();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception handled at test level");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseBrowser();
                Console.WriteLine("Browser closed in finally block");
            }
        }

        private void PerformCriticalAction()
        {
            throw new InvalidOperationException("Critical automation failure: element not found");
        }
    }
}
