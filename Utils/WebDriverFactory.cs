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
                    var firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("--start-maximized");
                    return new FirefoxDriver(firefoxOptions);

                default:
                    throw new ArgumentException("Unsupported browser");
            }
        }
    }
}
