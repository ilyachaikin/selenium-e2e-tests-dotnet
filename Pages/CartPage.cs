using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class CartPage(IWebDriver driver) : BasePage(driver)
    {
        public string GetItemName()
        {
            var cartItem = driver.FindElement(By.CssSelector(".cart_item"));

            return cartItem.FindElement(By.CssSelector(".inventory_item_name")).Text;
        }

        public CheckoutPage NavigateToCheckout()
        {
            driver.FindElement(By.CssSelector(".checkout_button")).Click();

            return new CheckoutPage(driver);
        }
    }
}
