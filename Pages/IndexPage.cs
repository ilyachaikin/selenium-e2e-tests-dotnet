using AutomationTestsNet.Utils;
using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class IndexPage
    {
        private static string Url { get; } = "https://www.saucedemo.com/";

        private readonly IWebDriver driver;

        public IndexPage(BrowserType browser) => this.driver = DriverManager.Instance.GetDriver(browser);

        public IndexPage Open()
        {
            driver.Url = Url;
            return this;
        }

        public void Login(string username, string password)
        {
            var inputUsername = driver.FindElement(By.Id("user-name"));
            var inputPassword = driver.FindElement(By.Id("password"));
            var loginButton = driver.FindElement(By.Id("login-button"));

            inputUsername.SendKeys(username);
            inputPassword.SendKeys(password);
            loginButton.Click();
        }
    }
}
