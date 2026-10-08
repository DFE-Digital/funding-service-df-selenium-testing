using com.sun.tools.@internal.xjc;
using Digital_Form_builder_Test.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using static java.lang.Character;

namespace Digital_Form_builder_Test.PageObjects.RunnerPages
{
    public class YourDetailPage
    {

        private IWebDriver Driver;
        private IJavaScriptExecutor executor;
        public YourDetailPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        private By ContinueButton = By.XPath("//button[text()='Continue']");
        private By title = By.XPath("//h1[@class='govuk-heading-l']");
        private By UKPRNlabel = By.XPath("//td[text()='UKPRN']/following-sibling::td");


        public IWebElement YourTitle()
        {

            return Driver.FindElement(title);
        }
        public IWebElement UKPRNValue()
        {

            return Driver.FindElement(UKPRNlabel);
        }
        public IWebElement Continue()
        {

            return Driver.FindElement(ContinueButton);
        }



        


    }

}
