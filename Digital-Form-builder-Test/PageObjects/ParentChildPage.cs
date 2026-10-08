using Digital_Form_builder_Test.PageObjects.ComponentPages;
using Digital_Form_builder_Test.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;

namespace Digital_Form_builder_Test.PageObjects
{
    public class ParentChildPage
    {
        private IWebDriver Driver;
        public IJavaScriptExecutor executor;
        public StartPage Startpage;
        public EditPage editpage;
        public FormDesignerPage formDesignerPage;
        public TextLinkComponentPage textLinkComponentPage;
        public NumberLinkComponentPage numberLinkComponentPage;
        public MenuAddPagePage menuaddpagepage;
        GenericFunctions genericFunctions = new GenericFunctions();

        public ParentChildPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        private By markAsParentFormCheckbox = By.XPath("//input[@class='govuk-checkboxes__input']");

        private By descriptionText = By.XPath("//textarea[@name='add-child-list-description']");
        private By headingText = By.XPath("//input[@name='add-child-list-heading']");
        private By childSearchFormButton = By.XPath("//a[text()='Search form']");
        private By dependentSearchFormButton = By.XPath("//a[text()='Search forms']");
        public By clickSearch = By.XPath("//input[@type='search']");
        public By clickChildSearch = By.XPath("//input[@type='text']");
        private By selectForm = By.XPath("//tr[@class='govuk-table__row']/td[2]");
        private By addToChildList = By.XPath("//button[text()='Add to child list']");
        private By addToDependentList = By.XPath("//button[text()='Add to dependent list']");
        private By addChildButton = By.XPath("//button[text()='Add child']");
        private By groupFormButton = By.XPath("//button[text()='Group form']");
        private By clickConfirmCheckbox = By.XPath("//input[@id='confirm']");
        private By selectConditionName = By.XPath("//select[@name='pnc-condition']");
        private By clickGroupFormModalwindowButton = By.XPath("//div[@class='modal']//button[text()='Group form']");
        private By validateArrowMarkforParentForm = By.XPath("//div[@class='table-cell']/span");


        //Actions 

        public void ClickMarkThisAsParentFormCheckbox()
        {
            Driver.FindElement(markAsParentFormCheckbox).Click();
        }

        public void EnterDescriptionAndHeading()
        {
            Driver.FindElement(descriptionText).SendKeys("Welcome to Parent page");
            Driver.FindElement(headingText).SendKeys("List of Child forms");
        }

        public void EnterlargeDescriptionAndHeading()
        {
            Driver.FindElement(descriptionText).SendKeys("Welcome to Parent page");
            Driver.FindElement(headingText).SendKeys("List of Child forms This is displayed as a heading for the child form list This is displayed as a heading for the child form list This is displayed as a heading for the child form listList of Child forms This is displayed as a heading for the child form list This is displayed as a heading for the child form list This is displayed as a heading for the child form listList of Child forms This is displayed as a heading for the child form list This is displayed as a heading for the child form list This is displayed as a heading for the child form listList of Child forms This is displayed as a heading for the child form list This is displayed as a heading for the child form list This is displayed as a heading for the child form listList of Child forms This is displayed as a heading for the child form list This is displayed as a heading for the child form list This is displayed as a heading for the child form listList of Child forms This is displayed as a heading for the child form list This is displayed as a heading for the child form list This is displayed as a heading for the child form listList of Child forms This is displayed as a heading for the child form list This is displayed as ");
        }

        public void SelectChildForm(string formname)
        {
            Thread.Sleep(5000);
            genericFunctions.ScrollDownToElement(Driver,childSearchFormButton);
            Thread.Sleep(10000);
            Driver.FindElement(childSearchFormButton).Click();
            SearchForForm(formname);
        }
        public void SearchForForm(string formName)
        {
            Driver.FindElement(clickChildSearch).Clear();
            genericFunctions.SendKeys(Driver, clickChildSearch, formName);
            genericFunctions.SendKeys(Driver, clickChildSearch, Keys.Enter);
            Thread.Sleep(3000);
            Driver.FindElement(selectForm).Click();
            Thread.Sleep(3000);
            Driver.FindElement(addToChildList).Click();
        }

        public void SelectDepedentForm(string formname)
        {
            Thread.Sleep(7000);
            genericFunctions.ScrollDownToElement(Driver, dependentSearchFormButton);
            Thread.Sleep(3000);
            Driver.FindElement(dependentSearchFormButton).Click();
            SelectDependentForm(formname);
        }

        public void SelectDependentForm(string formName)
        {
            Driver.FindElement(clickChildSearch).Clear();
            genericFunctions.SendKeys(Driver, clickChildSearch, formName);
            genericFunctions.SendKeys(Driver, clickChildSearch, Keys.Enter);
            Thread.Sleep(3000);
            Driver.FindElement(selectForm).Click();
            Thread.Sleep(3000);
            Driver.FindElement(addToDependentList).Click();
        }

        public void SelectDependentFormStatuses()
        {
            Thread.Sleep(5000);
            IList<IWebElement> allDependentInprogressStatuses = Driver.FindElements(By.XPath("//table[@id='selected-dependent-forms']//tr/td[2]//input[1]/following-sibling::label[text()='In progress']/preceding-sibling::input"));
            if (allDependentInprogressStatuses.Count > 0)
            {
                for (int i = 1; i <= allDependentInprogressStatuses.Count; i++)
                {
                    Thread.Sleep(5000);
                    genericFunctions.ScrollDownToElement(Driver, By.XPath("(//table[@id='selected-dependent-forms']//tr/td[2]//input[1]/following-sibling::label[text()='In progress']/preceding-sibling::input)[" + i + "]"));
                   Thread.Sleep(2000);
                    Driver.FindElement(By.XPath("(//table[@id='selected-dependent-forms']//tr/td[2]//input[1]/following-sibling::label[text()='In progress']/preceding-sibling::input)["+i+"]")).Click();
                    genericFunctions.Scrolldownpage();
                }
            }
        }

        public void SelectCondition()
        {
            genericFunctions.SelectElementByText(Driver, selectConditionName, "DSI Condition");
        }

        public void ClickOnRadio(IWebElement element)
        {
            Thread.Sleep(7000);
            element.Click();
        }

        public void ClickAddChildButton()
        {
            Thread.Sleep(3000);
            Driver.FindElement(addChildButton).Click();
        }

        public void ClickOnGroupFormButton()
        {
            Thread.Sleep(8000);
            Driver.FindElement(groupFormButton).Click();
        }

        public void ConfirmParentChildGrouping()
        {
            Thread.Sleep(3000);
            Driver.FindElement(clickConfirmCheckbox).Click();
            Thread.Sleep(3000);
            Driver.FindElement(clickGroupFormModalwindowButton).Click();
        }

        public bool checkArrowForParent()
        {
            bool elementVisible = Driver.FindElement(validateArrowMarkforParentForm).Displayed;
            return elementVisible;
        }
    }
}
