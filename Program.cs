using AutomationTestsNet.Pages;
using AutomationTestsNet.Utils;

namespace AutomationTestsNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var indexPage = new IndexPage(BrowserType.Chrome);

                indexPage.Open().Login("standard_user", "secret_sauce");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                DriverManager.Instance.QuitDriver();
            }
        }
    }
}
