using System;
using System.Linq;

namespace ConsoleApp1.Utilities
{
    public class ArrayHandlingTask
    {
        public void Execute()
        {
            string[] testCases = { "LoginTest", "SearchTest", "LogoutTest", "ProfileTest" };

            Console.WriteLine("Initial Test Cases:");
            foreach (var test in testCases)
            {
                Console.WriteLine(test);
            }


            string searchTest = "SearchTest";
            bool isTestPresent = testCases.Contains(searchTest);

            Console.WriteLine($"\nIs '{searchTest}' present: {isTestPresent}");


            Array.Sort(testCases);

            Console.WriteLine("\nSorted Test Cases:");
            foreach (var test in testCases)
            {
                Console.WriteLine(test);
            }

            Console.WriteLine($"\nFirst Test Case: {testCases[0]}");
            Console.WriteLine($"Last Test Case: {testCases[testCases.Length - 1]}");

            testCases[1] = "UpdatedTest";
            Console.WriteLine("\nAfter Updating Second Element:");
            foreach (var test in testCases)
            {
                Console.WriteLine(test);
            }
        }
    }
}
