using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1.Abstraction
{
    public class ChromeBrowserDriver : BrowserDriver
    {
        public override void LaunchBrowser()
        {
            ChromeOptions options = new();
            options.AddArgument("start-maximized");

            Driver = new ChromeDriver(options);
        }

        public override void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}