using OpenQA.Selenium;
using SeleniumTests.Core.Selenium.Elements;

namespace SeleniumTests.SalesForce.Pages
{
    public class NewAccountModal
    {
        Input accountName = new("Account Name");
        DropDown typeDropDown = new("Type");
        Button saveButton = new(By.XPath("//*[@title='Save']//button"));

        public void CreateAccount(string name, string listOption)
        {
            accountName.GetElement().SendKeys(name);
            typeDropDown.Select("Prospect");
            saveButton.GetElement().Click();
        }
    }
}