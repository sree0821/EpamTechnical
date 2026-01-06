
using ConsoleApp1.Abstraction;
using ConsoleApp1.Core;
using ConsoleApp1.OOP;
using ConsoleApp1.Task1;
using IncubationProject.Core;
using IncubationProject.Tests;

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
    }
}