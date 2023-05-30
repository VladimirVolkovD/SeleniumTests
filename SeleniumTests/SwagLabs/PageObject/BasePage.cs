﻿using OpenQA.Selenium;
using SeleniumTests.Core;

namespace SeleniumTests.SwagLabs.PageObject
{
    internal abstract class BasePage
    {
        protected IWebDriver driver;

        public BasePage()
        {
            driver = Browser.Instance.Driver;
        }

        public abstract BasePage OpenPage();
    }
}
