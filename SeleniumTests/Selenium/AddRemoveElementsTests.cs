using OpenQA.Selenium;
using SeleniumTests.Core;

namespace SeleniumTests.Selenium
{
    internal class AddRemoveElementsTests : BaseTest
    {       
        [Test]
        public void AddRemoveButton()
        {
            var expectedUrl = "http://the-internet.herokuapp.com/add_remove_elements/";


            Browser.Instance.Driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            Assert.That(Browser.Instance.Driver.Url, Is.EqualTo(expectedUrl));

            Browser.Instance.Driver.FindElement(By.TagName("button")).Click();
            var addedButton = Browser.Instance.Driver.FindElement(By.ClassName("added-manually"));
            Assert.That(addedButton, Is.Not.Null);

            addedButton.Click();
            Assert.That(Browser.Instance.Driver.FindElements(By.ClassName("added-manually")), Is.Empty);
        }       
    }
}
