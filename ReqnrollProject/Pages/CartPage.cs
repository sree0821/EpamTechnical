using OpenQA.Selenium;

namespace ReqnrollProject.Pages
{
    public class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By cartPrice = By.ClassName("inventory_item_price");
        private By checkoutBtn = By.Id("checkout");

        public string GetCartPrice()
        {
            return driver.FindElement(cartPrice).Text;
        }

        public void Checkout()
        {
            driver.FindElement(checkoutBtn).Click();
        }
    }
}
