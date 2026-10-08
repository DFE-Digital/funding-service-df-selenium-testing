using Digital_Form_builder_Test.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects.RunnerPages
{
    public class SecondPage
    {

        private IWebDriver Driver;
        private IJavaScriptExecutor executor;
        public SecondPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//input[contains(@class,'govuk-input')])[1]")]
        private IWebElement inputOne;

        [FindsBy(How = How.XPath, Using = "(//input[contains(@class,'govuk-input')])[2]")]
        private IWebElement inputTwo;

        [FindsBy(How = How.XPath, Using = "(//input[contains(@class,'govuk-input')])[3]")]
        private IWebElement inputThree;


        [FindsBy(How = How.XPath, Using = "//button[@id='submit']")]
        private IWebElement continueBtn;


        public void EnterValueInFieldOne(int number)
        {
            inputOne.SendKeys("" + number);
        }

        public void EnterValueInFieldTwo(int number)
        {
            inputTwo.SendKeys("" + number);
        }

        public void EnterValueInFieldThree(string number)
        {
            inputThree.SendKeys(number);
        }

       

        public SummaryPage ClickContinueBtn()
        {
            try
            {
                
                continueBtn.Click();
                return new SummaryPage(Driver);
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", continueBtn);
                return new SummaryPage(Driver);
            }
        }
    }
}
