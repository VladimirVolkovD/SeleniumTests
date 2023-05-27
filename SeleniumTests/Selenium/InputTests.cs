
using OpenQA.Selenium;

namespace SeleniumTests.Selenium
{
    internal class InputTests : BaseTest
    {
        [Test]
        public void EnterNumbers()
        {

            driver.FindElement(By.LinkText("Inputs")).Click();

            WaitHelper.WaitElementWithTitle(driver, By.LinkText("Inputs"), "Demo", 25);

            var input = driver.FindElement(By.TagName("input"));

            input.SendKeys("A1B2C3D!");
            input.Clear();

            input.SendKeys("48");
            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowUp);

         


            input.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);

            var text = input.GetAttribute("value");

        }
    }
}
