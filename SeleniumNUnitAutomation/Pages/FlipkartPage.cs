using OpenQA.Selenium;
using SeleniumNUnitAutomation.Utilities;

namespace SeleniumNUnitAutomation.Pages
{
    public class FlipkartPage
    {
        private IWebDriver driver;

        public FlipkartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By closeLoginPopup = By.XPath("//button[contains(text(),'✕')]");
        private By searchBox = By.Name("q");
        private By productResults = By.XPath("//div[contains(@class,'_1YokD2')]");

        public void CloseLoginPopup()
        {
            try
            {
                WaitHelper.WaitForElement(driver, closeLoginPopup, 5).Click();
                Logger.Info("Closed login popup");
            }
            catch
            {
                Logger.Info("No login popup appeared");
            }
        }

        public void SearchProduct(string product)
        {
            Logger.Info("Searching product: " + product);
            WaitHelper.WaitForElement(driver, searchBox).SendKeys(product + Keys.Enter);
        }

        public bool IsResultsDisplayed()
        {
            return WaitHelper.WaitForElement(driver, productResults).Displayed;
        }
    }
}
