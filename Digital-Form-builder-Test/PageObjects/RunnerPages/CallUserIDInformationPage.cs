using Digital_Form_builder_Test.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects.RunnerPages
{
    public class CallUserIDInformationPage
    {

        private IWebDriver Driver;
        private IJavaScriptExecutor executor;
        public CallUserIDInformationPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[.='Back']")]
        private IWebElement backBtn;


    }
}
