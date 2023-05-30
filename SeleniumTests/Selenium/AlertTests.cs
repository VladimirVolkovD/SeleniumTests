using OpenQA.Selenium;
using SeleniumTests.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Selenium
{
    internal class AdvanceTests : BaseTest
    {

        [Test]
        public void AcceptAlert()
        {
            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/javascript_alerts");
            var button = Browser.Instance.Driver.FindElement(By.XPath("(//button)[1]"));

            Browser.Instance.ExecuteScript("arguments[0].click();", button);

            Browser.Instance.AcceptAllert();        
        }


        [Test]
        public void Iframe()
        {
            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/iframe");
            Browser.Instance.SwitchToFrame("mce_0_ifr");

            var text = Browser.Instance.Driver.FindElement(By.TagName("p")).Text;

            Browser.Instance.SwitchToDefault();

        }

        [Test]
        public void Upload()
        {
            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/upload");


            Browser.Instance.Driver.FindElement(By.Id("file-upload")).SendKeys(DirectoryHelper.GetTestDataFolderPath() + "HomeWork.docx");
           
            
            var text = Browser.Instance.Driver.FindElement(By.Id("file-upload")).Text;
            text = Browser.Instance.Driver.FindElement(By.Id("file-upload")).GetAttribute("value");


        }

    }
}
