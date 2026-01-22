using OpenQA.Selenium;

namespace ReqnrollProject.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By username = By.Id("user-name");
        private By password = By.Id("password");
        private By loginBtn = By.Id("login-button");

        public void Login(string user, string pass)
        {
            driver.FindElement(username).SendKeys(user);
            driver.FindElement(password).SendKeys(pass);
            driver.FindElement(loginBtn).Click();
        }
    }
}
