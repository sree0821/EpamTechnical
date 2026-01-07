using System;
using IncubationProject.Base;
using OpenQA.Selenium;

namespace IncubationProject.Core
{
    // sealed = final (cannot be inherited)
    public sealed class KeywordsTask : BrowserBase
    {
        // static configuration value
        public static string ApplicationUrl = "https://www.google.com";

        public void ExecuteTest()
        {
            try
            {
                LaunchBrowser(ApplicationUrl);
                Console.WriteLine("Browser launched and URL opened");

                // instanceof equivalent in C# -> is
                if (Driver is IWebDriver)
                {
                    Console.WriteLine("Valid WebDriver instance");
                }

                for (int step = 1; step <= 5; step++)
                {
                    if (step == 2)
                    {
                        Console.WriteLine("Non-mandatory validation skipped");
                        continue; // continue keyword
                    }

                    if (step == 4)
                    {
                        Console.WriteLine("Critical failure encountered");
                        throw new InvalidOperationException("element not found"); // throw keyword
                    }

                    Console.WriteLine($"Test step {step} executed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught during execution: {ex.Message}");
            }
            finally
            {
                // finally keyword 
                CloseBrowser();
                Console.WriteLine("Browser closed in finally block");
            }
        }
    }
}
