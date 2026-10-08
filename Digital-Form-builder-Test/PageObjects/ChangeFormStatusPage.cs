using Digital_Form_builder_Test.PageObjects;
using Digital_Form_builder_Test.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects
{
    public class ChangeFormStatusPage
    {

        private IWebDriver Driver;
        private IJavaScriptExecutor executor;
        public ChangeFormStatusPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        GenericFunctions generic=new GenericFunctions();
        //Page Objects

        [FindsBy(How = How.XPath, Using = "//a[.='Back']")]
        private IWebElement backBtn;

        [FindsBy(How = How.XPath, Using = "//caption[.='Change Status of calculationtest']")]
        private IWebElement changeformstatusPageTitle;


        [FindsBy(How = How.XPath, Using = "//input[@value='In development']")]
        private IWebElement rdoBtndevelopment;


        [FindsBy(How = How.XPath, Using = "//input[@value='UAT']")]
        private IWebElement rdobtnuat;

        [FindsBy(How = How.XPath, Using = "//input[@value='Published']")]
        private IWebElement rdobtnPublished;

        [FindsBy(How = How.XPath, Using = "//input[@value='Closed']")]
        private IWebElement rdobtnClosed;

        [FindsBy(How = How.XPath, Using = "(//button[text()='Change status'])[1]")]
        private IWebElement updatefromstatusBtn;

        [FindsBy(How = How.XPath, Using = "//input[@class='govuk-checkboxes__input']")]
        private IWebElement confirmcheckboxonalert;

        [FindsBy(How = How.XPath, Using = "//button[.='Continue']")]
        private IWebElement continuebtnonalert;

        [FindsBy(How = How.XPath, Using = "//button[text()='Change form status']")]
        private IWebElement changestatus_confimbutton;
        public void ClickBackBtnOnChangeStatusPage() => backBtn.Click();

        public String GetchangeformstatusPageTitle()
        {
            String changeformtitle = changeformstatusPageTitle.Text;
            return changeformtitle;
        }

        public IWebElement SelectRdoBtnDevelopment()
        {
            rdoBtndevelopment.Click();
            return rdoBtndevelopment;
        }


        public void ClickBackBtn()
        {


            try
            {
                backBtn.Click();
                
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", backBtn);
                
            }
            
        }


        public IWebElement SelectRdoBtnUAT()
        {
            rdobtnuat.Click();
            return rdobtnuat;
        }

        public IWebElement SelectRdoBtnPublished() {

            rdobtnPublished.Click();
            return rdobtnPublished;
        }

        public IWebElement SelectRdoBtnClosed()
        {
            rdobtnClosed.Click();
            return rdobtnClosed;
        }

        public IWebElement SelectUpdateFromStatusBtn()
        {
            updatefromstatusBtn.Click();
            return updatefromstatusBtn;
        }

        public IWebElement SelectConfirmCheckBoxOnAlert()
        {
            try
            {
                confirmcheckboxonalert.Click();
            }catch(Exception e) { }
            return confirmcheckboxonalert;
        }
        public IWebElement SelectContinueBtnOnAlert()
        {
            
            continuebtnonalert.Click();
            return continuebtnonalert;
        }
        public IWebElement ChangeStatus_confirmButton()
        {

            changestatus_confimbutton.Click();
            return continuebtnonalert;
        }



        public DashboardPage ChangeFormStatus(String expectedformstatus)
        {
            if (expectedformstatus == "UAT")
            {
                SelectRdoBtnUAT();
                SelectUpdateFromStatusBtn();
                SelectConfirmCheckBoxOnAlert();
                SelectContinueBtnOnAlert();
                ClickBackBtn();
                return new DashboardPage(Driver);
            }
            else if (expectedformstatus == "In development")
            {
                SelectRdoBtnDevelopment();
                SelectUpdateFromStatusBtn();
                SelectConfirmCheckBoxOnAlert();
                SelectContinueBtnOnAlert();
                ClickBackBtn();
                return new DashboardPage(Driver);
            }

            else if (expectedformstatus == "Published")
            {
                SelectRdoBtnPublished();
                SelectUpdateFromStatusBtn();
                SelectConfirmCheckBoxOnAlert();
                SelectContinueBtnOnAlert();
                ClickBackBtn();
                return new DashboardPage(Driver);
            }

            else if (expectedformstatus == "Closed")
            {
                SelectRdoBtnClosed();
                SelectUpdateFromStatusBtn();
                SelectConfirmCheckBoxOnAlert();
                SelectContinueBtnOnAlert();
                ClickBackBtn();
                return new DashboardPage(Driver);
            }
            else
            {
                return new DashboardPage(Driver);
            }
        }
        //Actions
        public void ChangeFromStatusToDevlopment()
        {
            SelectRdoBtnDevelopment();
            SelectUpdateFromStatusBtn();
            SelectConfirmCheckBoxOnAlert();
            SelectContinueBtnOnAlert();
            SelectRdoBtnUAT();
        }

        public void ChangeFromStatusToUAT()
        {
            SelectRdoBtnUAT();
            SelectUpdateFromStatusBtn();
            SelectConfirmCheckBoxOnAlert();
            SelectContinueBtnOnAlert();
            SelectRdoBtnUAT();

        }

        public void ChangeFromStatusToPublished()
        {
            SelectRdoBtnPublished();
            SelectUpdateFromStatusBtn();
            SelectConfirmCheckBoxOnAlert();
            SelectContinueBtnOnAlert();
            SelectRdoBtnUAT();
        }

        public void ChangeFromStatusToClosed()
        {
            SelectRdoBtnClosed();
            SelectUpdateFromStatusBtn();
            SelectConfirmCheckBoxOnAlert();
            SelectContinueBtnOnAlert();
            SelectRdoBtnUAT();
        }

        public void WaitForChangeFormStatusPageToDisplay()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='In development']")));
        }

    }
}
