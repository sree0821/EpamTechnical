using SeleniumNUnitAutomation.Base;
using SeleniumNUnitAutomation.Pages;
using SeleniumNUnitAutomation.Utilities;
namespace SeleniumNUnitAutomation.Tests
{
    [TestFixture]
    [Category("E2E")]
    public class GoogleToFlipkartTests : TestBase
    {
        private GooglePage google;
        private FlipkartPage flipkart;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Logger.Info("Starting Google → Flipkart Test Suite");
        }

        [SetUp]
        public void TestSetup()
        {
            google = new GooglePage(driver);
            flipkart = new FlipkartPage(driver);
            Logger.Info("Test setup completed");
        }

        // MAIN TEST
        [Test]
        [Category("Smoke")]
        public void SearchFlipkartAndFindIphone()
        {
            google.Navigate();
            google.Search("Flipkart");
            google.ClickFlipkart();

            flipkart.CloseLoginPopup();
            flipkart.SearchProduct("iPhone");

            Assert.IsTrue(flipkart.IsResultsDisplayed(), "Flipkart product results not displayed");
        }

        // SECOND TEST
        [Test]
        [Category("Regression")]
        public void SearchFlipkartAndFindLaptop()
        {
            google.Navigate();
            google.Search("Flipkart");
            google.ClickFlipkart();

            flipkart.CloseLoginPopup();
            flipkart.SearchProduct("Laptop");

            Assert.IsTrue(flipkart.IsResultsDisplayed(), "Laptop results not displayed");
        }

        // DISABLED TEST
        [Test]
        [Ignore("Demo Ignore attribute for EPAM Task")]
        public void IgnoredTestExample()
        {
            Assert.Fail("This test should not run");
        }

        [TearDown]
        public void Cleanup()
        {
            Logger.Info("Test finished");
        }

        [OneTimeTearDown]
        public void OneTimeCleanup()
        {
            Logger.Info("Google → Flipkart Test Suite finished");
        }
    }
}
