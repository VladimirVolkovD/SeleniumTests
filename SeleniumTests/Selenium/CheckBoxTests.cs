using OpenQA.Selenium;
using SeleniumTests.Core;

namespace SeleniumTests.Selenium
{
    internal class CheckBoxTests : BaseTest
    {
        [Test]
        public void CheckBoxes()
        {
            Browser.Instance.Driver.FindElement(By.LinkText("Checkboxes")).Click();


            List<IWebElement> checkBoxes = Browser.Instance.Driver.FindElements(By.TagName("input")).ToList();
            Assert.IsNotEmpty(checkBoxes);

            var checkBoxOne = checkBoxes[0];
            var checkBoxSecond = checkBoxes[1];

            SetCheckBoxState(checkBoxOne, false);
            SetCheckBoxState(checkBoxOne, true);
            SetCheckBoxState(checkBoxOne, true);
            SetCheckBoxState(checkBoxOne, false);


            checkBoxSecond.Click();
            var selected = checkBoxSecond.Selected;
            var selectedByAttribute = checkBoxSecond.GetAttribute("checked");
        }

        public void SetCheckBoxState(IWebElement element, bool flag)
        {
            var selected = element.Selected;
            bool.TryParse(element.GetAttribute("checked"), out bool selectedByAttribute);

            if ( (selected || selectedByAttribute) != flag)
            {
                element.Click();
            }
        }
    }

}
