using Digital_Form_builder_Test.PageObjects;
using Digital_Form_builder_Test.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects.RunnerPages
{
    public class FirstPage
    {

        private IWebDriver Driver;
        private IJavaScriptExecutor executor;
        public FirstPage(IWebDriver Driver)
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

        [FindsBy(How = How.XPath, Using = "(//input[contains(@class,'govuk-input')])[4]")]
        private IWebElement inputFour;

        [FindsBy(How = How.XPath, Using = "//button[@id='submit']")]
        private IWebElement continueBtn;

        GenericFunctions genericFunctions = new GenericFunctions();
        public void EnterValueInFieldOne(int number)
        {
            inputOne.SendKeys(""+ number);
        }

        public void EnterValueInFieldTwo(int number)
        {
            inputTwo.SendKeys(""+number);
        }

        public void EnterValueInFieldThree(string number)
        {
            inputThree.SendKeys(number);
        }

        public void EnterValueInFieldFour(string number)
        {
            inputFour.SendKeys(number);
        }
        public void ClickContinu()
        {
            Driver.FindElement(By.XPath("//button[@id='submit']")).Click();
        }
        public SecondPage ClickContinueBtn()
        {
            try
            {
              genericFunctions.WaitForElement(Driver, (By)continueBtn);
                continueBtn.Click();
                return new SecondPage(Driver);

            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", continueBtn);
                return new SecondPage(Driver);
            }
        }


    }
}
