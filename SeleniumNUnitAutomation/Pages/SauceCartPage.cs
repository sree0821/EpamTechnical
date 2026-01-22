using OpenQA.Selenium;
using SeleniumNUnitAutomation.Utilities;

namespace SeleniumNUnitAutomation.Pages
{
    public class SauceCartPage
    {
        private IWebDriver driver;

        public SauceCartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By itemName = By.ClassName("inventory_item_name");
        private By itemPrice = By.ClassName("inventory_item_price");
        private By checkoutBtn = By.Id("checkout");

        public string GetCartItemName()
        {
            return WaitHelper.WaitForElement(driver, itemName).Text;
        }

        public string GetCartItemPrice()
        {
            return WaitHelper.WaitForElement(driver, itemPrice).Text;
        }

        public void ClickCheckout()
        {
            WaitHelper.WaitForElement(driver, checkoutBtn).Click();
        }
    }
}
