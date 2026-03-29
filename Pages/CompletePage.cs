using OpenQA.Selenium;

namespace AutomationTestsNet.Pages
{
    public class CompletePage(IWebDriver driver) : BasePage(driver)
    {
        public bool OrderIsSuccess()
        {
            var message = driver.FindElement(By.ClassName("complete-header")).Text;

            if (message == "Thank you for your order!")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
