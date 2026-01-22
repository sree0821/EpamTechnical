using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumNUnitAutomation.Utilities;

namespace SeleniumNUnitAutomation.Base
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected ExtentReports extent;
        protected ExtentTest test;

        [OneTimeSetUp]
        public void SetupReport()
        {
            extent = ExtentManager.GetExtent();
        }

        [SetUp]
        public void Setup()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Logger.Info("Launching browser");
            driver = DriverFactory.CreateDriver();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status ==
                NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Fail("Test Failed");
                ScreenshotHelper.Capture(driver, TestContext.CurrentContext.Test.Name);
            }
            else
            {
                test.Pass("Test Passed");
            }

            driver.Dispose();
            extent.Flush();
        }
    }
}
