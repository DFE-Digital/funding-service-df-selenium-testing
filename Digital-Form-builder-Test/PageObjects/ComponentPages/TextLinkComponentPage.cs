using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects.ComponentPages
{
    public class TextLinkComponentPage
    {

        private IWebDriver Driver;


        public TextLinkComponentPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='field-title']")]
        private IWebElement TextCompTitle;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='field-hint']")]
        private IWebElement TextCompHelpText;

        [FindsBy(How = How.XPath, Using = "//input[@id='field-options-hideTitle']")]
        private IWebElement TextCompHideTitleCheckBox;

        [FindsBy(How = How.XPath, Using = "//input[@id='field-options-required']")]
        private IWebElement TextCompOptionalOrReqCheckBox;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement SaveBtnOnTextComp;


        public void EnterTextCompTitle(String Title)
        {
            TextCompTitle.SendKeys(Title);
        }

        public void EnterTextCompHelpText(String HelpText)
        {
            TextCompHelpText.SendKeys(HelpText);
        }

        public void ClickTextCompHideTitleCheckBox()
        {
            TextCompHideTitleCheckBox.Click();
        }

        public void ClickTextCompOptionalOrReqCheckBox()
        {
            TextCompOptionalOrReqCheckBox.Click();
        }

        public FormDesignerPage ClickSaveBtnOnTextComp()
        {
            SaveBtnOnTextComp.Click();
            return new FormDesignerPage(Driver);
        }

        public FormDesignerPage CreateTextComponentOnPage01(String Title)
        {
            FormDesignerPage formDesignerPage = new FormDesignerPage(Driver);
            CreateComponentPage createComponentPage = formDesignerPage.ClickPage01CreateComponentBtn();
            TextLinkComponentPage textLinkComponentPage  = createComponentPage.ClickTextLink();
            TextCompTitle.SendKeys(Title);
            SaveBtnOnTextComp.Click();
            return new FormDesignerPage(Driver);
        }

        public FormDesignerPage CreateTextComponentOnPage02(String Title)
        {
            FormDesignerPage formDesignerPage = new FormDesignerPage(Driver);
            CreateComponentPage createComponentPage = formDesignerPage.ClickPage02CreateComponentBtn();
            TextLinkComponentPage textLinkComponentPage = createComponentPage.ClickTextLink();
            TextCompTitle.SendKeys(Title);
            SaveBtnOnTextComp.Click();
            return new FormDesignerPage(Driver);
        }


        public FormDesignerPage CreateTextComponentOnPage03(String Title)
        {
            FormDesignerPage formDesignerPage = new FormDesignerPage(Driver);
            CreateComponentPage createComponentPage = formDesignerPage.ClickPage03CreateComponentBtn();
            TextLinkComponentPage textLinkComponentPage = createComponentPage.ClickTextLink();
            TextCompTitle.SendKeys(Title);
            SaveBtnOnTextComp.Click();
            return new FormDesignerPage(Driver);
        }
    }
}
