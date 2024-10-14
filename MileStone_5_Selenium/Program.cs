using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MileStone_5_Selenium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Set up the Chrome WebDriver
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Step 2: Navigate to the Sauce Demo login page
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");

                // Step 3: Maximize the browser window
                driver.Manage().Window.Maximize();

                // Step 4: Create a WebDriverWait instance
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                // Wait until the username field is visible
                IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("user-name")));
                usernameField.SendKeys("standard_user");

                // Wait until the password field is visible
                IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
                passwordField.SendKeys("secret_sauce");

                // Wait until the login button is clickable
                IWebElement loginButton = wait.Until(driver => driver.FindElement(By.XPath("//input[@type='submit']")));
                loginButton.Click();

                // Step 5: Verify the login was successful by checking the URL
                wait.Until(driver => driver.Url == "https://www.saucedemo.com/inventory.html");
                Console.WriteLine("Login successful. Current URL: " + driver.Url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            /*finally
            {
                // Step 6: Close the browser
               // driver.Quit();
            }*/
        }
    }
}