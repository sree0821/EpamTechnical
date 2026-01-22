using ReqnrollProject.Pages;

namespace ReqnrollProject.StepDefinitions
{
    [Binding]
    public class SauceDemoSteps
    {
        private LoginPage loginPage;
        private InventoryPage inventoryPage;
        private CartPage cartPage;
        private CheckoutPage checkoutPage;

        private string inventoryPrice;

        [Given(@"I launch SauceDemo application")]
        public void LaunchApp()
        {
            loginPage = new LoginPage(Hooks.Driver);
        }

        [Given(@"I login with valid credentials")]
        public void Login()
        {
            loginPage.Login("standard_user", "secret_sauce");
        }

        [When(@"I add a product to the cart")]
        public void AddProductToCart()
        {
            inventoryPage = new InventoryPage(Hooks.Driver);
            inventoryPrice = inventoryPage.GetItemPrice();
            inventoryPage.AddItemToCart();
        }

        [Then(@"the product price should be same in cart")]
        public void VerifyPriceInCart()
        {
            cartPage = new CartPage(Hooks.Driver);
            Assert.AreEqual(inventoryPrice, cartPage.GetCartPrice());
        }

        [When(@"I checkout the product")]
        public void CheckoutProduct()
        {
            cartPage.Checkout();
            checkoutPage = new CheckoutPage(Hooks.Driver);
            checkoutPage.EnterDetailsAndContinue();
        }

        [Then(@"the order should be completed successfully")]
        public void VerifyOrderCompleted()
        {
            Assert.IsTrue(checkoutPage.IsOrderCompleted());
        }
    }
}
