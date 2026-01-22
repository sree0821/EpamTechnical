using OpenQA.Selenium;
using SeleniumNUnitAutomation.Utilities;
using SeleniumNUnitAutomation.Config;

namespace SeleniumNUnitAutomation.Pages
{
    public class GoogleSearchPage
    {
        private readonly IWebDriver driver;

        public GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Locators
        private By searchBoxByName = By.Id("searchbox");
        private By searchBoxByXPath = By.XPath("//input[@id='searchbox']");
        private By searchBoxByCss = By.CssSelector("input[name='q']");

        public void Navigate()
        {
            Logger.Info("Navigating to Google");
            driver.Navigate().GoToUrl(ConfigReader.GoogleUrl);
        }

        // Exceptionhandled search using multiple locators
        public void SearchText(string text)
        {
            Logger.Info("Entering search text: " + text);

            try
            {
                WaitHelper.WaitForElement(driver, searchBoxByName).SendKeys(text + Keys.Enter);
            }
            catch (NoSuchElementException)
            {
                Logger.Error("Name locator failed. Trying XPath...");
                WaitHelper.WaitForElement(driver, searchBoxByXPath).SendKeys(text + Keys.Enter);
            }
            catch (ElementNotInteractableException)
            {
                Logger.Error("XPath failed. Trying CSS...");
                WaitHelper.WaitForElement(driver, searchBoxByCss).SendKeys(text + Keys.Enter);
            }
        }
    }
}
