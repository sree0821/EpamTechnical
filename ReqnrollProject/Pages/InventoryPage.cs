using OpenQA.Selenium;

namespace ReqnrollProject.Pages
{
    public class InventoryPage
    {
        private IWebDriver driver;

        public InventoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By firstItemPrice = By.ClassName("inventory_item_price");
        private By addToCartBtn = By.Id("add-to-cart-sauce-labs-backpack");
        private By cartIcon = By.ClassName("shopping_cart_link");

        public string GetItemPrice()
        {
            return driver.FindElement(firstItemPrice).Text;
        }

        public void AddItemToCart()
        {
            driver.FindElement(addToCartBtn).Click();
            driver.FindElement(cartIcon).Click();
        }
    }
}
