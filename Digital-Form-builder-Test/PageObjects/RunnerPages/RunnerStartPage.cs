using Digital_Form_builder_Test.PageObjects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects.RunnerPages
{
    public class RunnerStartPage
    {

        private IWebDriver Driver;
        public RunnerStartPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@id='submit']")]
        private IWebElement startnowBtn;

        public FirstPage ClickStartNowBtn()
        {
            startnowBtn.Click();
            return new FirstPage(Driver);
        }

    }
}
