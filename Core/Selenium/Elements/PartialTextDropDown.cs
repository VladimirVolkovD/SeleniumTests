﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Core.Selenium.Elements
{
    public class PartialTextDropDown : BaseElement
    {

        string optionTemplate = "//*[@title='{0}']";
        string optionByPartTemplate = "//*[contains(@title,'{0}')]";

        private By ClearSectionCross = By.CssSelector("button[title='Clear Selection']");

        public PartialTextDropDown(By locator) : base(locator)
        {
        }

        public PartialTextDropDown(string locator) : base($"//label[text()='{locator}']/following-sibling::div//input")
        {
        }
          
        public void Select(string option)
        {
            var optionLocator = string.Format(optionTemplate, option);
            BaseSelect(option, By.XPath(optionLocator));
        }

        public void SelectByPartText(string option)
        {           
            var optionLocator = string.Format(optionByPartTemplate, option);
            BaseSelect(option, By.XPath(optionLocator));
        }


        public void BaseSelect(string option, By by)
        {
            WebDriver.FindElement(locator).Click();
            WebDriver.FindElement(locator).SendKeys(option);           
            WebDriver.FindElement(by).Click();
        }

        public void Clear()
        {
            new BaseElement(ClearSectionCross).ClickElementViaJs();
        }
    }
}
