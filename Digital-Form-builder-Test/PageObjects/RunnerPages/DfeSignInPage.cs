using Digital_Form_builder_Test.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace Digital_Form_builder_Test.PageObjects.RunnerPages
{
    public class DfeSignInPage
    {

        private IWebDriver Driver;
        private IJavaScriptExecutor executor;
        public DfeSignInPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

    }
}
