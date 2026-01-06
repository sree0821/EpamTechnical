using OpenQA.Selenium;

namespace ConsoleApp1.Abstraction
{
    public abstract class BrowserDriver
    {
        protected IWebDriver? Driver;

        public abstract void LaunchBrowser();
        public abstract void NavigateToUrl(string url);

        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}