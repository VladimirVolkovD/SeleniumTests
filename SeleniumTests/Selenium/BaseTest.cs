using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests.Selenium
{
    public class BaseTest
    {
        protected WebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}