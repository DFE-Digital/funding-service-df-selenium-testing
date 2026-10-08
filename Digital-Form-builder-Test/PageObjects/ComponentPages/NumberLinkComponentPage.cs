using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects.ComponentPages
{
    public class NumberLinkComponentPage
    {

        private IWebDriver Driver;

        public NumberLinkComponentPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='field-title']")]
        private IWebElement NumberCompTitle;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='field-hint']")]
        private IWebElement NumberCompHelpText;

        [FindsBy(How = How.XPath, Using = "//input[@id='field-options-hideTitle']")]
        private IWebElement NumberCompHideTitleCheckBox;

        [FindsBy(How = How.XPath, Using = "//input[@id='field-options-required']")]
        private IWebElement NumberCompOptionalOrReqCheckBox;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement SaveBtnOnNumberComp;

        private By Prefix_CheckBox = By.XPath("//input[@id='add-prefix']");

        private By Prefix_SelectBox = By.XPath("//input[@id='select-prefix']");
        private By Custom_SelectBox = By.XPath("//input[@id='custom-prefix']");

        private By Custom_TextBox = By.XPath("//input[@id='text-input']");

        
        private By Prefix_Select = By.XPath("//select[@id='currency-list']");

        private By Suffix_CheckBox = By.XPath("//input[@id='add-suffix']");
        private By Suffix_TextBox = By.XPath("//input[@id='custom-suffix']");
        private By AdditionalSetting_Link = By.XPath("//span[text()='Additional settings']");

        private By Min_EditBox = By.XPath("//input[@id='field-schema-min']");
        private By Max_EditBox = By.XPath("//input[@id='field-schema-max']");
        private By Precision_EditBox = By.XPath("//input[@id='field-schema-precision']");



        public By Prefix()
        {
            return Prefix_CheckBox;
        }
        public By PrefixSelectBox()
        {
            return Prefix_SelectBox;
        }
        public By PrefixSelect()
        {
            return Prefix_Select;
        }

        public By CustomSelectBox()
        {
            return Custom_SelectBox;
        }

        public By CustomTextBox()
        {
            return Custom_TextBox;
        }

        public By SuffixCheckBox()
        {
            return Suffix_CheckBox;
        }

        public By SuffixTextBox()
        {
            return Suffix_TextBox;
        }

        public By AdditionalSettingLink()
        {
            return AdditionalSetting_Link;
        }


        public By MinEditBox()
        {
            return Min_EditBox;
        }
        public By MaxEditBox()
        {
            return Max_EditBox;
        }
        public By PrecisionEditBox()
        {
            return Precision_EditBox;
        }
        public void EnterNumberCompTitle(String Title)
        {
            NumberCompTitle.SendKeys(Title);
        }

        public void EnterNumberCompHelpText(String HelpText)
        {
            NumberCompHelpText.SendKeys(HelpText);
        }

        public void ClickNumberCompHideTitleCheckBox()
        {
            NumberCompHideTitleCheckBox.Click();
        }

        public void ClickNumberCompOptionalOrReqCheckBox()
        {
            NumberCompOptionalOrReqCheckBox.Click();
        }

        public FormDesignerPage ClickSaveBtnOnNumberComp()
        {
            SaveBtnOnNumberComp.Click();
            return new FormDesignerPage(Driver);
        }

        public FormDesignerPage CreateNumberComponentOnPage01(String Title)
        {
            FormDesignerPage formDesignerPage = new FormDesignerPage(Driver);
            CreateComponentPage createComponentPage = formDesignerPage.ClickPage01CreateComponentBtn();
            NumberLinkComponentPage numbercompPage = createComponentPage.ClickNumberLink();
            NumberCompTitle.SendKeys(Title);
            SaveBtnOnNumberComp.Click();
            return new FormDesignerPage(Driver);
        }

        public FormDesignerPage CreateNumberComponentOnPage02(String Title)
        {
            FormDesignerPage formDesignerPage = new FormDesignerPage(Driver);
            CreateComponentPage createComponentPage = formDesignerPage.ClickPage02CreateComponentBtn();
            NumberLinkComponentPage numbercompPage = createComponentPage.ClickNumberLink();
            NumberCompTitle.SendKeys(Title);
            SaveBtnOnNumberComp.Click();
            return new FormDesignerPage(Driver);
        }

        public FormDesignerPage CreateNumberComponentOnPage03(String Title)
        {
            FormDesignerPage formDesignerPage = new FormDesignerPage(Driver);
            CreateComponentPage createComponentPage = formDesignerPage.ClickPage03CreateComponentBtn();
            NumberLinkComponentPage numbercompPage = createComponentPage.ClickNumberLink();
            NumberCompTitle.SendKeys(Title);
            SaveBtnOnNumberComp.Click();
            return new FormDesignerPage(Driver);
        }

    }
}