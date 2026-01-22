using OpenQA.Selenium;
using SeleniumNUnitAutomation.Utilities;

namespace SeleniumNUnitAutomation.Pages
{
    public class SauceCheckoutPage
    {
        private IWebDriver driver;

        public SauceCheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By firstName = By.Id("first-name");
        private By lastName = By.Id("last-name");
        private By zip = By.Id("postal-code");
        private By continueBtn = By.Id("continue");
        private By finishBtn = By.Id("finish");
        private By itemName = By.ClassName("inventory_item_name");
        private By itemPrice = By.ClassName("inventory_item_price");

        public void EnterDetails()
        {
            WaitHelper.WaitForElement(driver, firstName).SendKeys("Sree");
            WaitHelper.WaitForElement(driver, lastName).SendKeys("Lakshmi");
            WaitHelper.WaitForElement(driver, zip).SendKeys("682001");
            WaitHelper.WaitForElement(driver, continueBtn).Click();
        }

        public string GetCheckoutItemName()
        {
            return WaitHelper.WaitForElement(driver, itemName).Text;
        }

        public string GetCheckoutItemPrice()
        {
            return WaitHelper.WaitForElement(driver, itemPrice).Text;
        }

        public void Finish()
        {
            WaitHelper.WaitForElement(driver, finishBtn).Click();
        }
    }
}
