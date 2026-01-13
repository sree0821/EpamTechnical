using NUnit.Framework;
using SeleniumNUnitAutomation.Base;
using SeleniumNUnitAutomation.Pages;

namespace SeleniumNUnitAutomation.Tests
{
    [TestFixture]
    public class DemoQATests : TestBase
    {
        private DemoQAPage demoQAPage;

        [SetUp]
        public void TestSetup()
        {
            demoQAPage = new DemoQAPage(driver);
        }

        [Test]
        public void FillDemoQAFormTest()
        {
            demoQAPage.Navigate();
            demoQAPage.FillForm("Sree", "sree@test.com");
            demoQAPage.SubmitForm();
        }
    }
}
