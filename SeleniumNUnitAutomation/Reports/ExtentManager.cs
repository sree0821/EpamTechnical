using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;

namespace SeleniumNUnitAutomation.Utilities
{
    public static class ExtentManager
    {
        private static ExtentReports extent;
        private static ExtentSparkReporter reporter;

        public static ExtentReports GetExtent()
        {
            if (extent == null)
            {
                var reportPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "AutomationReport.html");

                reporter = new ExtentSparkReporter(reportPath);
                reporter.Config.DocumentTitle = "EPAM Automation Report";
                reporter.Config.ReportName = "Selenium NUnit Execution";

                extent = new ExtentReports();
                extent.AttachReporter(reporter);
            }
            return extent;
        }
    }
}
