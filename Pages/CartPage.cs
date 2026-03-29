using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class CartPage(IWebDriver driver) : BasePage(driver)
    {
        public string GetItemName()
        {
            var cartItem = driver.FindElement(By.ClassName("cart_item"));

            return cartItem.FindElement(By.ClassName("inventory_item_name")).Text;
        }

        public CheckoutPage NavigateToCheckout()
        {
            driver.FindElement(By.ClassName("btn btn_action btn_medium checkout_button ")).Click();

            return new CheckoutPage(driver);
        }
    }
}
