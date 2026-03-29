using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        protected BasePage(IWebDriver Driver)
        {
            driver = Driver;
        }
    }
}
