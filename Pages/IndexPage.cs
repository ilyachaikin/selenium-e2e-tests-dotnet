using AutomationTestsNet.Utils;
using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class IndexPage : BasePage
    {
        private static string Url { get; } = "https://www.saucedemo.com/";

        public IndexPage(IWebDriver driver) : base(driver) { }

        public IndexPage Open()
        {
            driver.Url = Url;
            return this;
        }

        public ProductPage Login(string username, string password)
        {
            var inputUsername = driver.FindElement(By.Id("user-name"));
            var inputPassword = driver.FindElement(By.Id("password"));
            var loginButton = driver.FindElement(By.Id("login-button"));

            inputUsername.SendKeys(username);
            inputPassword.SendKeys(password);
            loginButton.Click();

            return new ProductPage(driver);
        }
    }
}
