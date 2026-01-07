using System;

namespace ConsoleApp1.Utilities
{
    public class ObjectComparisonTask
    {
        public void Execute()
        {
            TestResult expected = new TestResult
            {
                TestName = "LoginTest",
                IsPassed = true
            };

            TestResult actual = new TestResult
            {
                TestName = "LoginTest",
                IsPassed = true
            };

            if (expected.Equals(actual))
            {
                Console.WriteLine("Test Result Comparison: PASSED");
            }
            else
            {
                Console.WriteLine("Test Result Comparison: FAILED");
            }
        }
    }
}
