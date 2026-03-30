using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class CheckoutPage(IWebDriver driver) : BasePage(driver)
    {
        public OverviewPage FillInfo(string firstName, string lastName, string zipCode)
        {
            driver.FindElement(By.CssSelector("#first-name")).SendKeys(firstName);
            driver.FindElement(By.CssSelector("#last-name")).SendKeys(lastName);
            driver.FindElement(By.CssSelector("#postal-code")).SendKeys(zipCode);

            driver.FindElement(By.CssSelector("#continue")).Click();

            return new OverviewPage(driver);
        }
    }
}
