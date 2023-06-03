
namespace SeleniumTests.Core.Selenium
{
    public class BaseTest
    {

        [SetUp]
        public void SetUp()
        {

        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}