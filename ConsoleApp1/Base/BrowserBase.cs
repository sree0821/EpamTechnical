using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IncubationProject.Base
{
    // Abstract base class for browser setup
    public abstract class BrowserBase
    {
        protected IWebDriver? Driver;

        protected void LaunchBrowser(string url)
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(url);
            if (Driver == null)
            {
                throw new InvalidOperationException("Driver is not initialized");
            }
        }

        protected void CloseBrowser()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }
    }
}
