using OpenQA.Selenium;

namespace SeleniumTests.Selenium
{
    internal class AddRemoveElementsTests : BaseTest
    {       
        [Test]
        public void AddRemoveButton()
        {
            var expectedUrl = "http://the-internet.herokuapp.com/add_remove_elements/";
                     
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            Assert.That(driver.Url, Is.EqualTo(expectedUrl));

            driver.FindElement(By.TagName("button")).Click();
            var addedButton = driver.FindElement(By.ClassName("added-manually"));
            Assert.That(addedButton, Is.Not.Null);

            addedButton.Click();
            Assert.That(driver.FindElements(By.ClassName("added-manually")), Is.Empty);
        }       
    }
}
