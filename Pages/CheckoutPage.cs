using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver) { }

        public CheckoutPage FillInfo(string firstName, string lastName, string zipCode)
        {
            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);
            driver.FindElement(By.Name("postalCode")).SendKeys(zipCode);
        }
    }
}
