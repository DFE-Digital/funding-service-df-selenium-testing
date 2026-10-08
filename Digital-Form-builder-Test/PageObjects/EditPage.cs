using Digital_Form_builder_Test.Configrations;
using Digital_Form_builder_Test.Utilities;
using java.util.concurrent.locks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static com.sun.tools.javah.Util;
using static sun.awt.image.ImageWatched;

namespace Digital_Form_builder_Test.PageObjects
{
    public class EditPage
    {

        private IWebDriver Driver;
        public EditPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//select[@id='page-type']")]
        private IWebElement PageTypeDropDown;

        [FindsBy(How = How.XPath, Using = "//input[@id='page-title']")]
        private IWebElement PageTitleTextBox;

        [FindsBy(How = How.XPath, Using = "//input[@id='page-path']")]
        private IWebElement PagePathTextBox;

        [FindsBy(How = How.XPath, Using = "//button[.='Save']")]
        private IWebElement SaveButton;


        private By Condition_button= By.XPath("//button[text()='Conditions']");

        private By AddoreditconditionLabel = By.XPath("//h4");

        private By ConditionName_EditBox = By.Id("cond-name");
        private By ComponetName_Selectbox = By.XPath("//select[@name='cond-field']");
        private By SelectImportedDataset_Selectbox = By.XPath("//select[@name='cond-value']");
        private By enterCustomText = By.XPath("//input[@id='cond-value']");
        private By selectCustomText = By.XPath("//input[@id='custom-prefix']");
        private By selectImportedDataset = By.XPath("//input[@id='select-prefix']");
        private By Condition_Selectbox = By.Id("cond-operator");
        private By value_EditBox = By.Id("cond-value");
        private By addcondiiton_link = By.Id("add-condition-link");
        private By add_link = By.Id("save-condition");
        private By Save_button = By.Id("save-inline-conditions");

        private By Condition_value = By.XPath("(//ul[@class='govuk-list']/li/a)[1]");

        private By DeleteButton = By.XPath("//button[text()='Delete']");

        

        GenericFunctions _genericFunctions = new GenericFunctions();




        public void SelectPageTypeDropDown(String dropdown)
        {
            var selectElement = new SelectElement(PageTypeDropDown);
            selectElement.SelectByText(dropdown);

        }

        public void EnterPageTitleTextBox(String pagename)
        {
            PageTitleTextBox.Clear();
            PageTitleTextBox.SendKeys(pagename);
            
        }
        public void EnterPagePathTextBox(String pagename)
        {
            PagePathTextBox.Clear();
            PagePathTextBox.SendKeys("/"+pagename);  
            
        }
        public FormDesignerPage ClickSaveButton()
        {
            SaveButton.Click();
            return new FormDesignerPage(Driver);
        }


        public FormDesignerPage EditPageOnExistingForm(PageType pageType, String Pagetitle)
        {
            var SelectPageTypeDropDown = new SelectElement(PageTypeDropDown);
            SelectPageTypeDropDown.SelectByIndex((int)pageType);
            PageTitleTextBox.Clear();
            PageTitleTextBox.SendKeys(Pagetitle);
            SaveButton.Click();
            return new FormDesignerPage(Driver);
        }
        public IWebElement ConditionButton()
        {
            return Driver.FindElement(Condition_button);
        }


        public void ClickOnDelete()
        {
            _genericFunctions.Click(Driver, DeleteButton);
        }
        public IWebElement Conditionvalue()
        {
            return Driver.FindElement(Condition_value);
        }

        public void DeleteInCondition(string condition)
        {

        }


        public IWebElement Addoreditcondition()
        {
            return Driver.FindElement(AddoreditconditionLabel);
        }

        public void ConditionValue(string DisplayName, string Componentname, string condition, string value)
        {
            
            _genericFunctions.Click(Driver, addcondiiton_link);
            _genericFunctions.SendKeys(Driver, ConditionName_EditBox, DisplayName);
            _genericFunctions.SelectElementByText(Driver, ComponetName_Selectbox, Componentname);
            _genericFunctions.SelectElementByText(Driver, Condition_Selectbox, condition);
            _genericFunctions.SendKeys(Driver, value_EditBox, value);
            _genericFunctions.Click(Driver, add_link);
            _genericFunctions.Click(Driver, Save_button);
         
        }

        public void ImportDataSetWithCondition(string DisplayName, string Componentname, string condition, string value)
        {
            _genericFunctions.Click(Driver, addcondiiton_link);
            _genericFunctions.SendKeys(Driver, ConditionName_EditBox, DisplayName);
            _genericFunctions.SelectElementByText(Driver, ComponetName_Selectbox, Componentname);
            _genericFunctions.SelectElementByText(Driver, Condition_Selectbox, condition);
            _genericFunctions.Click(Driver, selectImportedDataset);
            _genericFunctions.SelectElementByText(Driver, SelectImportedDataset_Selectbox, value);
            Thread.Sleep(3000);
            _genericFunctions.Click(Driver, add_link);
            _genericFunctions.Click(Driver, Save_button);
        }

        public void addConditionWithCustomText(string DisplayName, string Componentname, string condition, string value)
        {
            _genericFunctions.Click(Driver, addcondiiton_link);
            _genericFunctions.SendKeys(Driver, ConditionName_EditBox, DisplayName);
            _genericFunctions.SelectElementByText(Driver, ComponetName_Selectbox, Componentname);
            _genericFunctions.SelectElementByText(Driver, Condition_Selectbox, condition);
            _genericFunctions.Click(Driver, selectCustomText);
            _genericFunctions.SendKeys(Driver, enterCustomText, value);
            Thread.Sleep(3000);
            _genericFunctions.Click(Driver, add_link);
            _genericFunctions.Click(Driver, Save_button);
        }


    }
}
