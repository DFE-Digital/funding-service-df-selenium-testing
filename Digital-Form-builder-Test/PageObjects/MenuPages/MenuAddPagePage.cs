using Digital_Form_builder_Test.Configrations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects
{
    public class MenuAddPagePage
    {
        private IWebDriver Driver;
        public MenuAddPagePage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h4[.='Add Page']")]
        private IWebElement AddPageTitle;

        [FindsBy(How = How.XPath, Using = "//select[@id='page-type']")]
        private IWebElement PageTypeDropDown;

        [FindsBy(How = How.XPath, Using = "//select[@id='link-from']")]
        private IWebElement LinkFrom;

        [FindsBy(How = How.XPath, Using = "//input[@id='page-title']")]
        private IWebElement PageTitle;

        [FindsBy(How = How.XPath, Using = "//input[@id='page-path']")]
        private IWebElement Path;

        [FindsBy(How = How.XPath, Using = "//button[.='Save']")]
        private IWebElement SaveBtn;


        


        public bool IsExistAddPageTitle()
        {
            return AddPageTitle.Displayed;
             
        }

        public void SelectPageTypeDropDownOnAddPage(String dropdown)
        {
           
           var selectElement = new SelectElement(PageTypeDropDown);
           selectElement.SelectByText(dropdown);

        }

        public void SelectLinkFrom(String dropdown)
        {
            var selectElement = new SelectElement(LinkFrom);
            selectElement.SelectByText(dropdown);

        }

        public IWebElement EnterPageTitle()
        {
            return PageTitle;
            
        }

        public IWebElement EnterPath()
        {
           
            return Path;
        }

        public FormDesignerPage ClickSaveBtn()
        {
            SaveBtn.Click();
            return new FormDesignerPage(Driver);
        }

        public FormDesignerPage CreateANewPageOnExistingForm(PageType pageType, String pageroot, String Pagetitle)
        {
            var SelectPageTypeDropDown = new SelectElement(PageTypeDropDown);
            SelectPageTypeDropDown.SelectByIndex((int)pageType);
            var SelectPageRootDropDown = new SelectElement(LinkFrom);
            SelectPageRootDropDown.SelectByText(pageroot);
            EnterPageTitle().SendKeys(Pagetitle);
            ClickSaveBtn();
            return new FormDesignerPage(Driver);
        }


        


    }
}
