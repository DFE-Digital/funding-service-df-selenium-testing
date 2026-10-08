using Digital_Form_builder_Test.PageObjects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects
{
    public class StartPage
    {

        private IWebDriver Driver;
        public StartPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[.='Start now']")]
        private IWebElement startnowBtn;

        public DashboardPage ClickStartNowBtn()
        {
            startnowBtn.Click();
            return new DashboardPage(Driver);
        }

    }
}