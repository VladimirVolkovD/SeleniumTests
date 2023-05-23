
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests.Selenium
{
    internal class DropDownTests : BaseTest
    {
        [Test]
        public void SelectOptions()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();

            SelectElement select = new(driver.FindElement(By.Id("dropdown")));

            select.SelectByIndex(0);

        }

        [Test]
        public void SelectOptionSecond()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();

            SelectElement select = new(driver.FindElement(By.Id("dropdown")));

            select.SelectByIndex(1);
        }
    }
}
