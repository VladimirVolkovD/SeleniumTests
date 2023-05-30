
using OpenQA.Selenium;

namespace SeleniumTests.Selenium
{
    internal class InputTests : BaseTest
    {
        [Test]
        public void EnterNumbers()
        {

            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");
           

            var input = driver.FindElement(By.Id("file-submit"));

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
