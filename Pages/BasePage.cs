using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public abstract class BasePage(IWebDriver Driver)
    {
        protected IWebDriver driver = Driver;
    }
}
