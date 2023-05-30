using OpenQA.Selenium.Chrome;
using SeleniumTests.Selenium;

namespace SeleniumTests.SwagLabs.Test
{
    internal class SwagLabBaseTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {    
            // like option if we don't use OpenPage() method       
           // driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}
