using OpenQA.Selenium;

namespace SeleniumTests.Core.Selenium.Elements
{
    internal class Input : BaseElement
    {
        public Input(By locator) : base(locator)
        {
        }

        public Input(string name) : base($"//span[text()='{name}']/ancestor::div[contains(@class,'uiInput')]//input")
        {
        }
    }
}
