
using OpenQA.Selenium;
using SeleniumTests.Core;

namespace SeleniumTests.Selenium
{
    internal class InputTests : BaseTest
    {
        [Test]
        public void EnterNumbers()
        {

            Browser.Instance.Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");
           

            var input = Browser.Instance.Driver.FindElement(By.Id("file-submit"));

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
