using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumNUnitAutomation.Base
{
    public class DriverFactory
    {
        public static IWebDriver CreateDriver(string browser = "chrome")
        {
            return browser.ToLower() switch
            {
                "firefox" => new FirefoxDriver(),
                _ => new ChromeDriver()
            };
        }
    }
}
