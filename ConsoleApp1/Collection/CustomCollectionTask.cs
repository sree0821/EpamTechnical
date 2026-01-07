using System;

namespace ConsoleApp1.Collection
{
    public class CustomCollectionTask
    {
        public void Execute()
        {
            TestCaseCollection testCases = new TestCaseCollection();

            testCases.Add("LoginTest");
            testCases.Add("SearchTest");
            testCases.Add("LogoutTest");

            Console.WriteLine("Custom IEnumerable collection:");

            foreach (var test in testCases)
            {
                Console.WriteLine(test);
            }
        }
    }
}
