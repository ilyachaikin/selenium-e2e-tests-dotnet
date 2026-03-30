using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationTestsNet.Utils
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(BrowserType browser)
        {
            switch (browser)
            {
                case BrowserType.Chrome:
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--start-maximized");
                    return new ChromeDriver(chromeOptions);

                case BrowserType.Firefox:
                    var driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    return driver;

                default:
                    throw new ArgumentException("Unsupported browser");
            }
        }
    }
}
