using AutomationTestsNet.Utils;
using NUnit.Framework;
using Allure.NUnit;
using OpenQA.Selenium;

namespace AutomationTestsNet.Tests
{
    [Parallelizable(ParallelScope.All)]
    [AllureNUnit]
    public abstract class BaseTest(BrowserType browserType)
    {
        protected IWebDriver Driver => DriverManager.Instance.GetDriver(browserType);

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
