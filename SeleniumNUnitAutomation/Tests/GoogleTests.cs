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
            Assert.That(googlePage.GetTitle(), Does.Contain("Selenium"));
        }

        [Test]
        public void DemoQAFormTest()
        {
            try
            {
                demoQAPage.FillForm();
                demoQAPage.ClickSubmitSafely();
            }
            catch (Exception ex)
            {
                ScreenshotHelper.TakeScreenshot(driver, "FormFailure");
                throw;
            }
        }
    }
}
