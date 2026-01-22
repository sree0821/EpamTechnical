using OpenQA.Selenium;
using SeleniumNUnitAutomation.Utilities;

namespace SeleniumNUnitAutomation.Pages
{
    public class SauceInventoryPage
    {
        private IWebDriver driver;

        public SauceInventoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By firstItemName = By.ClassName("inventory_item_name");
        private By firstItemPrice = By.ClassName("inventory_item_price");
        private By firstAddToCart = By.XPath("(//button[contains(text(),'Add to cart')])[1]");
        private By cartIcon = By.ClassName("shopping_cart_link");

        public string GetItemName()
        {
            return WaitHelper.WaitForElement(driver, firstItemName).Text;
        }

        public string GetItemPrice()
        {
            return WaitHelper.WaitForElement(driver, firstItemPrice).Text;
        }

        public void AddItemToCart()
        {
            WaitHelper.WaitForElement(driver, firstAddToCart).Click();
        }

        public void GoToCart()
        {
            WaitHelper.WaitForElement(driver, cartIcon).Click();
        }
    }
}
