using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumNUnitAutomation.Config;
using SeleniumNUnitAutomation.Utilities;

public class DemoQAPage
{
    private readonly IWebDriver driver;

    public DemoQAPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    // Locators
    private readonly By headerText = By.XPath("//h1");
    private readonly By firstName = By.XPath("//input[@placeholder='First Name']");
    private readonly By lastName = By.XPath("//input[@placeholder='Last Name']");
    private readonly By address = By.XPath("//textarea");
    private readonly By genderFemale = By.XPath("//input[@value='FeMale']");
    private readonly By countryDropdown = By.Id("countries");
    private readonly By email = By.Id("eid");
    private readonly By phone = By.XPath("//input[@type='tel']");
    private readonly By submitButton = By.Id("submitbtn");

    // Navigation
    public void Navigate()
    {
        driver.Navigate().GoToUrl(ConfigReader.DemoSiteUrl);
    }

    // Business Actions
    public void EnterBasicInfo(string fname, string lname, string mail, string phoneNo)
    {
        WaitHelper.WaitForElement(driver, firstName).SendKeys(fname);
        WaitHelper.WaitForElement(driver, lastName).SendKeys(lname);
        WaitHelper.WaitForElement(driver, email).SendKeys(mail);
        WaitHelper.WaitForElement(driver, phone).SendKeys(phoneNo);
    }

    public void EnterAddress(string value)
    {
        WaitHelper.WaitForElement(driver, address).SendKeys(value);
    }

    public void SelectGenderFemale()
    {
        WaitHelper.WaitForElement(driver, genderFemale).Click();
    }

    public void SelectCountry(string country)
    {
        Logger.Info("Selecting country: " + country);
        var dropdown = new SelectElement(WaitHelper.WaitForElement(driver, countryDropdown));
        dropdown.SelectByText(country);
    }

    public void Submit()
    {
        JavaScriptHelper.ScrollToBottom(driver);
        WaitHelper.WaitForElement(driver, submitButton).Click();
    }

    public string GetHeaderText()
    {
        return WaitHelper.WaitForElement(driver, headerText).Text;
    }
}
