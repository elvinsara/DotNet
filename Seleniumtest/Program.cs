using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Seleniumtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");*/
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            LoginPage _loginPage = new LoginPage(driver);
            _loginPage.Login("standard_user", "secret_sauce");

        }
    }
}