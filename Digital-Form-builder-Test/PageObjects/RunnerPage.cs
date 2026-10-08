using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects
{
    public class RunnerPage
    {
        IWebDriver Driver;
        public RunnerPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[@class='govuk-heading-l']")]
        private IWebElement applicationclosed;
        private By Submit = By.XPath("//button[contains(text(),'Submit')]");


        public string ApplicationClosed()
        {
            String application = applicationclosed.Text;
            return application;
        }

        public IWebElement Submitbutton()
        {

            return Driver.FindElement(Submit);
        }
    }
}
