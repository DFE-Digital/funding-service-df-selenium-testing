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
    public class SummaryPage
    {

        private IWebDriver Driver;
        private IJavaScriptExecutor executor;
        public SummaryPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        private IWebElement submitBtn;

        private By componentname = By.XPath("//div[contains(@class,'govuk-summary-list__row')]/dt[1]");
        private By componentvalue = By.XPath("//div[contains(@class,'govuk-summary-list__row')]/dd[1]");

        private By Checkboxtitle = By.XPath("(//label)[2]");
        private By SubmissionId = By.XPath("//div[contains(text(),'Your reference number')]/strong");
        private By pdftosummary = By.XPath("//button[contains(text(),'Save summary as PDF')]");
        private By Signout_Link = By.XPath("//a[contains(text(),'Sign out')]");
        private By Confirm_SelectionBox = By.XPath("//input[@id='confirmcheckbox']");
        private By Signout_Button = By.XPath("//button[text()='Sign out']");

        public By SignoutLink()
        {
            return Signout_Link;
        }
        public By ConfirmSelectionBox()
        {
            return Confirm_SelectionBox;
        }
        public By SignoutButton()
        {
            return Signout_Button;
        }

        ////dd[contains(text(),'Optional Fields')]/preceding-sibling:: dt[contains(text(),'Checkboxes component')]

        public IWebElement VerifyComponentName()
        {

            return Driver.FindElement(componentname);
        }
        public IWebElement VerifyComponentValue()
        {

            return Driver.FindElement(componentvalue);
        }
        public SubmissionCompletePage ClickSubmitBtn()
        {
            try
            {

                submitBtn.Click();
                return new SubmissionCompletePage(Driver);
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", submitBtn);
                return new SubmissionCompletePage(Driver);
            }
        }

        public IWebElement CheckboxComponentValue(string checkboxname)
        {

            return Driver.FindElement(By.XPath("//label[contains(text(),'"+ checkboxname+"')]"));
        }

        public IWebElement LabelCheckboxtitle()
        {

            return Driver.FindElement(Checkboxtitle);
        }
        public IWebElement LabelSubmissionID()
        {

            return Driver.FindElement(SubmissionId);
        }




        

        public IWebElement pdftosummarybutton()
        {

            return Driver.FindElement(pdftosummary);
        }

        public IWebElement LabelCheckboxhelptext(string helptext)
        {

            return Driver.FindElement(By.XPath("//div[contains(text(),'"+ helptext+"')]"));
        }
        

    }

}
