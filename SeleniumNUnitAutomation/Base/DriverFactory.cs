using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumNUnitAutomation.Config;

namespace SeleniumNUnitAutomation.Base
{
    public static class DriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            IWebDriver driver;

            if (ConfigReader.Browser.ToLower() == "firefox")
                driver = new FirefoxDriver();
            else
                driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ConfigReader.ImplicitWait);

            return driver;
        }
    }
}
