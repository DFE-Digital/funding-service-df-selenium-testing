using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects
{
    public class MenuSummaryBehaviourPage
    {

        private IWebDriver Driver;
        public MenuSummaryBehaviourPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

    }
}
