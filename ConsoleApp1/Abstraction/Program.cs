using ConsoleApp1.Collection;
using ConsoleApp1.Core;
using ConsoleApp1.OOP;
using ConsoleApp1.Task1;
using ConsoleApp1.Utilities;
using IncubationProject.API;
using IncubationProject.Core;
using IncubationProject.Tests;

namespace ConsoleApp1.Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrowserDriver driver = new ChromeBrowserDriver();
            TestExecution test = new(driver);
            test.RunTest();

            StringOperations stringOps = new StringOperations();
            stringOps.Concatenation();
            stringOps.Navigation();
            stringOps.Comparison();

            KeywordsTask task = new KeywordsTask();
            task.ExecuteTest();

            ExceptionHandlingTask task3 = new ExceptionHandlingTask();
            task3.ExecuteTest();

            CustomExceptionTask task4 = new CustomExceptionTask();
            task4.ExecuteTest();

            AccessModifiersTask task5 = new AccessModifiersTask();
            task5.ExecuteTest();

            ITestScenario loginTest = new LoginTest();
            loginTest.ExecuteTest();

            ITestScenario searchTest = new SearchTest();
            searchTest.ExecuteTest();

            OverloadingChildTask task79 = new OverloadingChildTask();
            task79.ExecuteTest();

            ObjectComparisonTask task10 = new ObjectComparisonTask();
            task10.Execute();

            StringBuilderTask task11 = new StringBuilderTask();
            task11.Execute();

            ArrayHandlingTask task1213 = new ArrayHandlingTask();
            task1213.Execute();

            LoggerTask task14 = new LoggerTask();
            task14.ExecuteTest();

            CollectionsTask task1 = new CollectionsTask();
            task1.Execute();

            CustomCollectionTask task2 = new CustomCollectionTask();
            task2.Execute();

            HttpClientApiTest apiTest = new HttpClientApiTest();
            apiTest.ExecuteAsync().GetAwaiter().GetResult();
        }
    }
}