using AutomationTestsNet.Pages;
using AutomationTestsNet.Utils;
using NUnit.Framework;

namespace AutomationTestsNet.Tests
{
    [TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.Firefox)]
    public class DataDrivenTests(BrowserType browser) : BaseTest(browser)
    {
        [TestCase("standard_user", "secret_sauce")]
        [TestCase("locked_out_user", "secret_sauce")]
        public void LoginWithVariousUsers(string user, string pass)
        {
            var indexPage = new IndexPage(Driver);

            var catalogPage = indexPage
                .Open()
                .Login(user, pass);

            bool catalogIsLoaded = Driver.Url == "https://www.saucedemo.com/inventory.html";


        }
    }
}
