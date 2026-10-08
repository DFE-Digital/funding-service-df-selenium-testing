using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects
{
    public class EnterTitlePage
    {
        private IWebDriver Driver;
        
          
        public EnterTitlePage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='formName']")]
        private IWebElement formtitleText;

        [FindsBy(How = How.XPath, Using = "//button[@class='govuk-button govuk-button--start']")]
        private IWebElement nextBtn;


        public IWebElement SetformtitleText() => formtitleText;

        public IWebElement SetNextBtn() => nextBtn;


        //Actions 

        public void EnterFormTitle(string formtitle)
        {
            SetformtitleText().SendKeys(formtitle);
        }

        public FormDesignerPage ClickNextBtnOnFormTitlePage()
        {
            SetNextBtn().Click();
            return new FormDesignerPage(Driver);
        }


        
    }
}
