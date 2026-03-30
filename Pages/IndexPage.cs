using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class IndexPage(IWebDriver driver) : BasePage(driver)
    {
        private static string Url { get; } = "https://www.saucedemo.com/";

        public IndexPage Open()
        {
            driver.Url = Url;
            return this;
        }

        public ProductPage Login(string username, string password)
        {
            var inputUsername = driver.FindElement(By.CssSelector("#user-name"));
            var inputPassword = driver.FindElement(By.CssSelector("#password"));
            var loginButton = driver.FindElement(By.CssSelector("#login-button"));

            inputUsername.SendKeys(username);
            inputPassword.SendKeys(password);
            loginButton.Click();

            return new ProductPage(driver);
        }

        public string GetErrorMessage()
        {
            return driver.FindElement(By.CssSelector("div.error h3")).Text;
        }
    }
}
