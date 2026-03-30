using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class ProductPage(IWebDriver driver) : BasePage(driver)
    {
        public ProductPage SelectItem(string name)
        {
            var itemList = driver.FindElements(By.CssSelector(".inventory_item"));

            foreach (var element in itemList)
            {
                var itemName = element.FindElement(By.CssSelector(".inventory_item_name"));
                var addButton = element.FindElement(By.CssSelector(".btn_inventory"));

                if (itemName.Text == name)
                {
                    addButton.Click();
                    break;
                }
            }

            return this;
        }

        public CartPage NavigateToCart()
        {
            driver.FindElement(By.CssSelector(".shopping_cart_link")).Click();

            return new CartPage(driver);
        }
    }
}
