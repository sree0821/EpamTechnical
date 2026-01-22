using OpenQA.Selenium;
using SeleniumNUnitAutomation.Config;
using SeleniumNUnitAutomation.Utilities;

namespace SeleniumNUnitAutomation.Pages
{
    public class GooglePage
    {
        private IWebDriver driver;

        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By searchBox = By.Name("q");
        private By flipkartLink = By.XPath("//a//h3[contains(text(),'Flipkart')]");

        public void Navigate()
        {
            Logger.Info("Opening Google");
            driver.Navigate().GoToUrl(ConfigReader.GoogleUrl);
        }

        public void Search(string text)
        {
            Logger.Info("Searching: " + text);
            WaitHelper.WaitForElement(driver, searchBox).SendKeys(text + Keys.Enter);
        }

        public void ClickFlipkart()
        {
            Logger.Info("Clicking Flipkart result");
            WaitHelper.WaitForElement(driver, flipkartLink).Click();
        }

        public void FillForm()
        {

        }

        public bool GetTitle()
        {
            return true;
        }
    }
}
