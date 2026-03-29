using AutomationTestsNet.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestsNet.Tests
{
    [Parallelizable(ParallelScope.All)]
    public abstract class BaseTest
    {
        private readonly BrowserType browser;

        protected BaseTest(BrowserType browserType)
        {
            browser = browserType;
        }

        protected IWebDriver Driver => DriverManager.Instance.GetDriver(browser);

        [SetUp]
        public void SetUp()
        {
            _ = Driver;
        }

        [TearDown]
        public void TearDown()
        {
            DriverManager.Instance.QuitDriver();
        }
    }
}
