using NUnit.Framework.Internal;
using SeleniumNUnitAutomation.Base;
using SeleniumNUnitAutomation.Pages;
using SeleniumNUnitAutomation.Utilities;
using Logger = SeleniumNUnitAutomation.Utilities.Logger;

[TestFixture]
[Category("Smoke")]
public class DemoQATests : TestBase
{
    private DemoQAPage page;
    private GoogleSearchPage googleSearchPage;

    [SetUp]
    public void Setup()
    {
        page = new DemoQAPage(driver);
        googleSearchPage = new GoogleSearchPage(driver);


    }

    [Test]
    public void RegisterUserTest()
    {
        test.Info("Opening DemoQA site");
        page.Navigate();

        page.EnterBasicInfo("Sreelakshmi", "Sajeev", "sree@test.com", "9876543210");
        page.EnterAddress("Kochi, Kerala");
        page.SelectGenderFemale();
        page.SelectCountry("India");
        page.Submit();

        Assert.That(page.GetHeaderText(), Is.EqualTo("Automation Demo Site"));
    }

    [Test]
    [Category("ExceptionHandling")]
    public void GoogleSearchWithMultipleLocators()
    {
        test.Info("Opening Google");
        googleSearchPage.Navigate();

        test.Info("Searching with fallback locators");
        googleSearchPage.SearchText("Selenium WebDriver");

        Assert.That(driver.Title, Does.Contain("Selenium"));
    }

    [Test]
    [Category("PageInfo")]
    public void DemoQAPageInfoTest()
    {
        var mainPage = new DemoQAMainPage(driver);

        test.Info("Opening DemoQA");
        mainPage.Navigate();

        test.Info("Waiting for page to load");
        mainPage.WaitForPageToLoad();   // Explicit wait

        Logger.Info("Title: " + mainPage.GetTitle());
        Logger.Info("Title Length: " + mainPage.GetTitleLength());

        Logger.Info("URL: " + mainPage.GetUrl());
        Logger.Info("URL Length: " + mainPage.GetUrlLength());

        Logger.Info("Page Source Length: " + mainPage.GetPageSourceLength());

        Assert.That(mainPage.GetTitleLength(), Is.GreaterThan(0));
    }

    [Test]
    [Category("E2E")]
    public void SauceDemoEndToEndTest()
    {
        var login = new SauceLoginPage(driver);
        var inventory = new SauceInventoryPage(driver);
        var cart = new SauceCartPage(driver);
        var checkout = new SauceCheckoutPage(driver);

        login.Navigate();
        login.Login("standard_user", "secret_sauce");

        string itemName = inventory.GetItemName();
        string itemPrice = inventory.GetItemPrice();
        inventory.AddItemToCart();
        inventory.GoToCart();

        Assert.That(cart.GetCartItemName(), Is.EqualTo(itemName));
        Assert.That(cart.GetCartItemPrice(), Is.EqualTo(itemPrice));

        cart.ClickCheckout();
        checkout.EnterDetails();

        Assert.That(checkout.GetCheckoutItemName(), Is.EqualTo(itemName));
        Assert.That(checkout.GetCheckoutItemPrice(), Is.EqualTo(itemPrice));

        checkout.Finish();
    }


}
