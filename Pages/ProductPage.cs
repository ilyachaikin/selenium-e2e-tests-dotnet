using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class ProductPage : BasePage
    {
        public ProductPage(IWebDriver driver) : base(driver) { }

        public ProductPage SelectItem(string name)
        {
            var itemList = driver.FindElements(By.ClassName("inventory_item"));

            foreach (var element in itemList)
            {
                var itemName = element.FindElement(By.ClassName("inventory_item_name"));
                var addButton = element.FindElement(By.ClassName("btn_inventory"));

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
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();

            return new CartPage(driver);
        }
    }
}
