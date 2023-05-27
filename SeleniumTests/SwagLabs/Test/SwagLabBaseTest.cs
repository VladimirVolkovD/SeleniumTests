using OpenQA.Selenium.Chrome;
using SeleniumTests.Selenium;

namespace SeleniumTests.SwagLabs.Test
{
    internal class SwagLabBaseTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {           
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}
