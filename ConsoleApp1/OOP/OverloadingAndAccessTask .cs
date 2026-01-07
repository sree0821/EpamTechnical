using System;
using IncubationProject.Base;

namespace ConsoleApp1.OOP
{
    // Parent class
    public class OverloadingAndAccessTask : BrowserBase
    {
        // protected -> accessible in child classes
        protected const string ApplicationUrl = "https://www.flipkart.com";

        // public -> accessible everywhere
        public void OpenApplication()
        {
            LaunchBrowser(ApplicationUrl);
            Console.WriteLine("Application opened using default URL");
        }

        // METHOD OVERLOADING (Task 7)
        // same method name, different parameters
        public void OpenApplication(string url)
        {
            LaunchBrowser(url);
            Console.WriteLine($"Application opened using custom URL: {url}");
        }

        public void Close()
        {
            CloseBrowser();
            Console.WriteLine("Browser closed");
        }
    }
}
