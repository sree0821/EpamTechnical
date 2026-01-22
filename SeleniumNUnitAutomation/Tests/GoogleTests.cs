using NUnit.Framework;
using SeleniumNUnitAutomation.Base;
using SeleniumNUnitAutomation.Pages;
using SeleniumNUnitAutomation.Utilities;

namespace SeleniumNUnitAutomation.Tests
{
    [TestFixture]
    [Category("Smoke")]
    public class GoogleTests : TestBase
    {
        private DemoQAPage demoQAPage;

        [SetUp]
        public void TestSetup()
        {
            demoQAPage = new DemoQAPage(driver);
        }

        [Test]
        public void GoogleSearchTest()
        {
            // Arrange
            var googlePage = new GooglePage(driver);

            // Act
            googlePage.Navigate();
            googlePage.Search("Selenium");

            // Assert
            Assert.That(googlePage.GetTitle().Equals(true));
        }

        [Test]
        public void DemoQAFormTest()
        {
            try
            {
                demoQAPage.EnterBasicInfo("ll","jj", "kk","yy");
                demoQAPage.Submit();
            }
            catch (Exception ex)
            {
                ScreenshotHelper.Capture(driver, "FormFailure");
                throw;
            }
        }
    }
}
