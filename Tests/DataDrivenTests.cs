using Allure.NUnit.Attributes;
using AutomationTestsNet.Pages;
using AutomationTestsNet.Utils;
using NUnit.Framework;

namespace AutomationTestsNet.Tests
{
    [TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.Firefox)]
    [AllureSuite("Login Tests")]
    public class DataDrivenTests(BrowserType browser) : BaseTest(browser)
    {
        [TestCase("standard_user", "secret_sauce", true, "")]
        [TestCase("locked_out_user", "secret_sauce", false, "Epic sadface: Sorry, this user has been locked out.")]
        [AllureTag("End-to-End")]
        [AllureSeverity(Allure.Net.Commons.SeverityLevel.blocker)]
        [AllureOwner("Chaikin Ilya")]
        public void LoginWithVariousUsers(string user, string pass, bool success, string errorMessage)
        {
            var indexPage = new IndexPage(Driver);

            var catalogPage = indexPage
                .Open()
                .Login(user, pass);

            bool catalogIsLoaded = Driver.Url == "https://www.saucedemo.com/inventory.html";

            if (success)
            {
                Assert.That(catalogIsLoaded, Is.True, "Standard login failed");
            }
            else
            {
                Assert.That(indexPage.GetErrorMessage(), Is.EqualTo(errorMessage), "Wrong error message");
            }
        }
    }
}
