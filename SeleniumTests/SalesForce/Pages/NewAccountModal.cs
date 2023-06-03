using OpenQA.Selenium;
using SeleniumTests.Core.Selenium.Elements;

namespace SeleniumTests.SalesForce.Pages
{
    public class NewAccountModal
    {
        Input accountName = new("Account Name");
        DropDown typeDropDown = new("Type");
        Button saveButton = new(By.CssSelector("button[title = 'Save']"));

        internal void CreateAccount(string name, string listOption)
        {
            accountName.GetElement().SendKeys(name);
            typeDropDown.Select("Customer");
            saveButton.GetElement().Click();
        }
    }
}