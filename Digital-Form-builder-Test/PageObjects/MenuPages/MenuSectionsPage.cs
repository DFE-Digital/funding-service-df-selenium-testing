using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using static com.sun.tools.javah.Util;

namespace Digital_Form_builder_Test.PageObjects
{
    public class MenuSectionsPage
    {
        private IWebDriver Driver;
        public MenuSectionsPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }
        private By Backbutton = By.XPath("//a[text()='Back']");
        private By heading_label = By.XPath("//h1");
        private By addsectionbutton = By.XPath("//button[@name='add-section-button']");
        private By Sectiontitle = By.XPath("//span[text()='Section title']");
        private By Repeatableavailable_label = By.XPath("//span[text()='Repeatable section available']");
        private By Nosectionfound_label = By.XPath("//p[text()='No section found']");
        private By SectionTitle_EditBox = By.XPath("//input[@name='section-title']");
        private By AddSection_Button = By.XPath("//button[text()='Add section']");
        private By saveSection_Button = By.XPath("//button[text()='Save section']");
        private By EditSection_Button = By.XPath("//button[text()='Edit section']");
        private By DeleteSection_Button = By.XPath("//button[text()='Delete section']");
        private By DeleteSection_alert = By.XPath("//input[@name='confirm-section-delete']");
        private By DeleteSection_Button1 = By.XPath("(//button[text()='Delete section'])[2]");
        private By markSectionAsRepeatableCheckbox = By.XPath("//input[@name='repeatable-section']");
        public By DeleteSection1()
        {
            return DeleteSection_Button1;
        }
        public By DeleteSection_pop()
        {
            return DeleteSection_alert;
        }

        public By DeleteSection()
        {
            return DeleteSection_Button;
        }

        public By EditSection()
        {
            return EditSection_Button;
        }

        public By AddSection()
        {
            return AddSection_Button;
        }

        public By SaveSection()
        {
            return saveSection_Button;
        }

        public By SectionTitle()
        {
            return SectionTitle_EditBox;
        }
        public By Back()
        {
            return Backbutton;
        }
        public By heading()
        {
            return heading_label;
        }
        public By addsection()
        {
            return addsectionbutton;
        }
        public By Sectiont()
        {
            return Sectiontitle;
        }
        public By Repeatableavailable_l()
        {
            return Repeatableavailable_label;
        }
        public By Nosectionfound()
        {
            return Nosectionfound_label;
        }


        public By checkMarkSectionRepeatable()
        {
            return markSectionAsRepeatableCheckbox;
        }

        public By selectNumberTrigger(String numTrigger)
        {
            return By.XPath("//select[@name='select-number-comp']/option[@data-title='" + numTrigger + "']");
        }

        public By selectYesnoTrigger(String yesnoTrigger)
        {
            {
                return By.XPath("//select[@name='select-conditional-comp']/option[@data-title='" + yesnoTrigger + "']");

            }

        }
    }
}
