using Allure.NUnit.Attributes;
using AutomationTestsNet.Pages;
using AutomationTestsNet.Utils;
using NUnit.Framework;

namespace AutomationTestsNet.Tests
{
    [TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.Firefox)]
    [AllureSuite("Checkout Tests")]
    public class CheckoutTests(BrowserType browser) : BaseTest(browser)
    {
        [TestCase("Sauce Labs Backpack")]
        [TestCase("Sauce Labs Bike Light")]
        [TestCase("Sauce Labs Bolt T-Shirt")]
        [AllureTag("End-to-End")]
        [AllureSeverity(Allure.Net.Commons.SeverityLevel.critical)]
        [AllureOwner("Chaikin Ilya")]
        public void AddProduct_ShouldAppearInCart(string expectedItem)
        {
            var indexPage = new IndexPage(Driver);

            var cartPage = indexPage
                .Open()
                .Login("standard_user", "secret_sauce")
                .SelectItem(expectedItem)
                .NavigateToCart();

            var itemName = cartPage.GetItemName();

            var completePage = cartPage
                .NavigateToCheckout()
                .FillInfo("Ilya", "Chaikin", "111111")
                .Finish();

            Assert.Multiple(() =>
            {
                Assert.That(itemName, Is.EqualTo(expectedItem), $"Expected result '{expectedItem}', but found '{itemName}'");
                Assert.That(completePage.OrderIsSuccess(), Is.True, "Order is failed");
            });
        }
    }
}
