using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTestsNet.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        protected BasePage(IWebDriver Driver)
        {
            driver = Driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
