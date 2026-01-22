using OpenQA.Selenium;
using SeleniumNUnitAutomation.Config;
using SeleniumNUnitAutomation.Utilities;

namespace SeleniumNUnitAutomation.Pages
{
    public class DemoQAMainPage
    {
        private IWebDriver driver;

        public DemoQAMainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By logo = By.XPath("//img[@src='/images/Toolsqa.jpg']");

        public void Navigate()
        {
            Logger.Info("Opening DemoQA");
            driver.Navigate().GoToUrl(ConfigReader.DemoQAMainUrl);
        }

        // Explicit Wait
        public void WaitForPageToLoad()
        {
            WaitHelper.WaitForElement(driver, logo);
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public int GetTitleLength()
        {
            return driver.Title.Length;
        }

        public string GetUrl()
        {
            return driver.Url;
        }

        public int GetUrlLength()
        {
            return driver.Url.Length;
        }

        public int GetPageSourceLength()
        {
            return driver.PageSource.Length;
        }
    }
}
