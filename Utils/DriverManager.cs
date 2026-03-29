using OpenQA.Selenium;

namespace AutomationTestsNet.Utils
{
    public sealed class DriverManager
    {
        public static readonly Lazy<DriverManager> instance = new Lazy<DriverManager>(() => new DriverManager());
        
        private static readonly ThreadLocal<IWebDriver> threadLocal = new ThreadLocal<IWebDriver>();

        private static DriverManager Instance => instance.Value;

        private DriverManager() { }

        public IWebDriver GetDriver (BrowserType browser)
        {
            if(threadLocal.Value == null)
            {
                threadLocal.Value = WebDriverFactory.CreateWebDriver(browser);
            }

            return threadLocal.Value!;
        }

        public void QuitDriver()
        {
            if (threadLocal.Value != null)
            {
                threadLocal.Value.Quit();
                threadLocal.Value.Dispose();
                threadLocal.Value = null!;
            }
        }
    }
}
