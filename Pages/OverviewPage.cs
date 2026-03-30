using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class OverviewPage(IWebDriver driver) : BasePage(driver)
    {
        public CompletePage Finish()
        {
            driver.FindElement(By.CssSelector("#finish")).Click();

            return new CompletePage(driver);
        }
    }
}
