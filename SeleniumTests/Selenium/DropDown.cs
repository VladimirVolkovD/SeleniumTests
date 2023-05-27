
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests.Selenium
{
    [TestFixture]
    internal class DropDownTests : BaseTest
    {

        private int counter = 0;

        [Test]
        public void SelectOptions()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();

            SelectElement select = new(driver.FindElement(By.Id("dropdown")));

            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(element => element.FindElement(By.LinkText("Dropdown")));

            select.SelectByIndex(0);

        }

        [Test]
        public void SelectOptionSecond()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();

            SelectElement select = new(driver.FindElement(By.Id("dropdown")));

            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(element => element.FindElement(By.LinkText("Dropdown")));

            select.SelectByIndex(1);
        }

        private static bool IsSelected(IWebElement element) => bool.Parse(element.GetAttribute("selected"));

        [Test]
        [Retry(3)]
        public void Retry()
        {
            counter++;
            Assert.AreEqual(counter, 2);
        }
    }
}
