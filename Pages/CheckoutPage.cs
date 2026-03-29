using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class CheckoutPage(IWebDriver driver) : BasePage(driver)
    {
        public OverviewPage FillInfo(string firstName, string lastName, string zipCode)
        {
            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);
            driver.FindElement(By.Name("postalCode")).SendKeys(zipCode);

            driver.FindElement(By.Id("continue")).Click();

            return new OverviewPage(driver);
        }
    }
}
