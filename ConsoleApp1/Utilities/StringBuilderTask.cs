using System;
using System.Text;

namespace ConsoleApp1.Utilities
{
    public class StringBuilderTask
    {
        public void Execute()
        {
            // StringBuilder used for report/log creation
            StringBuilder reportBuilder = new StringBuilder();

            reportBuilder.Append("Test Execution Report\n");
            reportBuilder.Append("---------------------\n");

            string testName = "LoginTest";
            string browser = "Chrome";

            // String operations
            reportBuilder.Append($"Test Name: {testName}\n");
            reportBuilder.Append($"Browser: {browser}\n");

            reportBuilder.Append("Status: PASSED\n");

            string report = reportBuilder.ToString().Replace("PASSED", "SUCCESS");
            Console.WriteLine($"Contains SUCCESS: {report.Contains("SUCCESS")}");

            Console.WriteLine("\nFinal Report:\n");
            Console.WriteLine(report);
        }
    }
}
