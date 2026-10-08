using Digital_Form_builder_Test.Configrations;
using Digital_Form_builder_Test.PageObjects;
using Digital_Form_builder_Test.PageObjects.ComponentPages;
using Digital_Form_builder_Test.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using WindowsInput.Native;
using WindowsInput;
using SeleniumExtras.WaitHelpers;
using Digital_Form_builder_Test.PageObjects.RunnerPages;

namespace Digital_Form_builder_Test.PageObjects
{
    public class DashboardPage
    {
        private IWebDriver Driver;
        public IJavaScriptExecutor executor;
        public StartPage Startpage;
        public EditPage editpage;
        public FormDesignerPage formDesignerPage;
        public TextLinkComponentPage textLinkComponentPage;
        public NumberLinkComponentPage numberLinkComponentPage;
        public MenuAddPagePage menuaddpagepage;
        string formselectedxPath, OneFormStatus;
        int Totalexistingforms, i = 1;
        string formtitle = ConfigurationManager.AppSettings["FormName"];
        GenericFunctions genericFunctions = new GenericFunctions();

        public static string workingdirectory = Environment.CurrentDirectory;
        public static string projectdirectory = Directory.GetParent(workingdirectory).Parent.Parent.FullName;
        public static string fileName = projectdirectory + "\\file_" + DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".txt";
        string b = projectdirectory.ToString();
        public DashboardPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//h1[.='Digital Form Builder']")]
        private IWebElement dashboardPage;

        //My Forms buttons 

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Edit form')])[1]")]
        private IWebElement editFormBtn;

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Duplicate form')])[1]")]
        private IWebElement duplicateFormBtn;

        [FindsBy(How = How.XPath, Using = "(//button[text()='Change status'])[1]")]
        private IWebElement formStatusBtn;



        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Delete form')]")]
        private IWebElement deleteFormBtn;

        [FindsBy(How = How.XPath, Using = "//button[@title='Create form']")]
        private IWebElement createFormBtn;

        [FindsBy(How = How.XPath, Using = "//a[text()='Create new form']")]
        private IWebElement createNewFormBtn;

        private By startNowLink = By.XPath("//button[text()='Start now']");

        private By importSavedformLink = By.XPath("//a[contains(text(),'Import saved form')]");

        private By importSavedformText = By.XPath("//h2[contains(text(),'Import saved form')]");

        private By importFormTitle = By.XPath("//input[@id='import-form-title']");

        private By importFormButton = By.XPath("//button[contains(text(),'Import .json')]");

        private By sFirstFormCollegue = By.XPath("(//div[@class='govuk-radios__item']/input)[1]");


        private By colleguesForm =By.XPath("(//a[@class='govuk-tabs__tab'])[2]");

        private By MyForm = By.XPath("(//a[@class='govuk-tabs__tab'])[1]");

        private By formNameEditBox = By.XPath("//input[contains(@id,'formName')]");


        private By formNametable = By.XPath("(//tr[@class='govuk-table__row'])[2]/td[3]/div/span");


        private By selectForm = By.XPath("//div[@class='govuk-radios__item']/input");
        private By getFormName = By.XPath("//tr[@class='govuk-table__row']/td[3]");
        private By groupFormButton = By.XPath("//button[text()='Group form']");


        private By  deleteButton = By.XPath("//button[text()='Delete form']");
        private By deleteButtonConfirm = By.XPath("(//button[text()='Delete form'])[2]");

        private By accessTypeBtn = By.XPath("(//button[text()='Switch access'])[2]");

        private By colleguesFormStatus = By.XPath("(//button[text()='Edit form'])[2]");

        private By DuplicateTextBox = By.XPath("//input[@name='rename-parent-form']");

        private By DuplicateButton = By.XPath("//button[text()='Duplicate form']");

        private By EditBoxSearch = By.XPath("(//input)[1]");
        private By Noformsfound = By.XPath("//p[@class='govuk-body   govuk-!-text-align-centre govuk-!-margin-0 ']");

        public By colleguesFormLink = By.XPath("(//a[@class='govuk-tabs__tab'])[2]");
        public By UserNameEditBox = By.XPath("//input[@id='username']");
        public By Continue = By.XPath("//button[contains(text(),'Continue')]");
        public By nextButton = By.XPath("//button[contains(text(),'Next')]");
        private By previewTestLink = By.XPath("//a[contains(text(),'Test')]");
        private By previewProdLink = By.XPath("//a[contains(text(),'Prod')]");
        public By PasswordEditBox = By.XPath("//input[@id='password']");
        public By clickSearch = By.XPath("//input[@type='search']");
        public By selectFormButton = By.XPath("//input[@id='select-form']");

        private By Signinbutton = By.XPath("//button[@type='submit']");
        private By noFormsPresent = By.XPath("//p[text()='No items found']");
        private By NextButton = By.XPath("//button[text()='Next']");

        

        private By showfilter = By.XPath("//button[text()='Show filters']");
        
        private By DetailLink = By.XPath("//span[contains(text(),'Detail component')]");
        //Colleagues' forms

        private By Label_secondpage = By.XPath("//label[@class='govuk-label govuk-label--s']");

        private By SwitchAccess = By.XPath("(//button[text()='Switch access'])[1]");
        public By duplicateFormButton = By.XPath("//button[contains(text(),'Duplicate form')]");
        private By clickDuplicateFormButton = By.XPath("//button[text()='Duplicate form']");
        private By renameParentForm = By.XPath("//input[@name='rename-parent-form']");
        private By checkForDuplicateButton = By.XPath("//button[contains(text(),'Check for duplicate')]");
        private By changeStatusButton = By.XPath("//button[contains(text(),'Change status')]");
        private By deleteFormButton = By.XPath("//button[contains(text(),'Delete form')]");
        private By selectParentCheckbox = By.XPath("//div[@class='govuk-checkboxes__item']/input[1]");
        private By selectDfESigninRadioButton = By.XPath("//label[text()='DFE SignIn']/preceding-sibling::input");
        private By uploadCSVFile = By.XPath("//input[@type='file']");
        private By clickSwitchAccessButton = By.XPath("//button[text()='Switch access']");
        private By clickConfirmationCheckbox = By.XPath("//input[@name='check1']");
        private By clickChangeStatusConfirmation = By.XPath("//input[@name='status-confirm']");
        private By clickDeleteFormConfirmation = By.XPath("//input[@name='delete-confirm']");
        private By clickSwitchAccessConfirmationButton = By.XPath("(//button[text()='Switch access'])[2]");
        private By clickChangeFormStatusButton = By.XPath("//button[text()='Change form status']");
        private By clickDeleteFormButton = By.XPath("(//button[contains(text(),'Delete form')])[2]");

        private By DFESigninCheckbox = By.XPath("//input[@value='DFE SignIn']");
        private By PublicinCheckbox = By.XPath("//input[@value='Public']");
        private By formname = By.XPath("(//p[@class='dashboard-cell'])[2]");
        private By Introductoryvideos = By.XPath("//a[@href='https://www.youtube.com/channel/UCROOCs9OvIwqFOy5_E0Jtfg']");
        private By Contacts = By.XPath("//a[@href='https://www.gov.uk/contact-dfe']");
        private By SubmitBug = By.XPath("//a[@href='https://www.gov.uk/help/report-vulnerability']");
        private By WishList = By.XPath("(//a[@href='https://www.gov.uk/contact-dfe'])[2]");
        private By ContentDesc = By.XPath("//span[@class='govuk-footer__licence-description']");
        private By Copyright = By.XPath("//a[text()='© Crown copyright']");

        












        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Edit form')])[2]")]
        private IWebElement editFormBtnColleagues;

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Form status')])[2]")]
        private IWebElement formStatusBtnColleagues;

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Duplicate form')])[2]")]
        private IWebElement duplicateFormBtnColleagues;

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Access type')])[2]")]
        private IWebElement accessTypeBtnColleagues;

        public IWebElement CreateForm() => createFormBtn;
        public IWebElement EditForm() => editFormBtn;
        public IWebElement ChangeFormStatus() => formStatusBtn;
        public IWebElement DeleteForm() => deleteFormBtn;

        public IWebElement DuplicateForm() => duplicateFormBtn;



        public IWebElement EditColleaguesForm() => editFormBtnColleagues;
        public IWebElement ColleaguesFormStatus() => formStatusBtnColleagues;

        public IWebElement ColleaguesAccessTypeBtn() => accessTypeBtnColleagues;

        public IWebElement ColleaguesDuplicateForm() => duplicateFormBtnColleagues;


        //Actions 

        public bool NoFormsPresentInDashboard()
        {
            bool elementpresent = true;
            try
            {
                if (Driver.FindElement(noFormsPresent).Displayed)
                    elementpresent = true;
            }
            catch (Exception e)
            {
                elementpresent = false;
            }
            return elementpresent;
        }
        public EnterTitlePage ClickCreateFormBtn()
        {
            try
            {
                createFormBtn.Click();
                return new EnterTitlePage(Driver);
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", createFormBtn);
                return new EnterTitlePage(Driver);
            }
        }

        public void ClickCreateNewFormButton()
        {
            createNewFormBtn.Click();
        }

        public bool VerifyFormInDashboard(string formname)
        {
            IList<IWebElement> forms = Driver.FindElements(By.XPath("//tbody/tr/td[3]/div/span"));
            bool elemnentpresnt=false;
            if (forms.Count > 0)
            {
                foreach (IWebElement element in forms)
                {
                    if (element.Text.Equals(formname))
                        elemnentpresnt= true;
                }
            }
            return elemnentpresnt;
        }

        public FormDesignerPage ClickEditForm()
        {
            try
            {
                EditForm().Click();
                return new FormDesignerPage(Driver);
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", EditForm());
                return new FormDesignerPage(Driver);
            }
        }



        public ChangeFormStatusPage ClickChangeFormStatus()
        {
            try
            {
                ChangeFormStatus().Click();
                return new ChangeFormStatusPage(Driver);
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", ChangeFormStatus());
                return new ChangeFormStatusPage(Driver);
            }
        }


        public EnterTitlePage ClickDeleteForm()
        {
            try
            {
                DeleteForm().Click();
                return new EnterTitlePage(Driver);
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", ClickDeleteForm());
                return new EnterTitlePage(Driver);
            }
        }


        public void ClickDuplicateForm()
        {
            try
            {
                DuplicateForm().Click();

            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", DuplicateForm());

            }
        }


        //Functions to perform certain steps on dashboard page
        public FormDesignerPage CreateANewForm(String FormName)
        {

            EnterTitlePage entertitlePage = ClickCreateFormBtn();
            entertitlePage.EnterFormTitle(FormName);
            FormDesignerPage formDesignerPage = entertitlePage.ClickNextBtnOnFormTitlePage();
            editpage = formDesignerPage.ClickFirstPageEditBtn();
            editpage.EditPageOnExistingForm(PageType.StartPage, "Start Page");

            editpage = formDesignerPage.ClickSecondPageEditBtn();
            editpage.EditPageOnExistingForm(PageType.QuestionPage, "Page01");
            editpage = formDesignerPage.ClickThirdPageEditBtn();
            editpage.EditPageOnExistingForm(PageType.QuestionPage, "Page02");
            menuaddpagepage = formDesignerPage.ClickMenuAddPageBtn();
            menuaddpagepage.CreateANewPageOnExistingForm(PageType.SummaryPage, "/page02", "Summary Page");
            numberLinkComponentPage = new NumberLinkComponentPage(Driver);
            numberLinkComponentPage.CreateNumberComponentOnPage01("Testing01");
            numberLinkComponentPage.CreateNumberComponentOnPage01("Testing02");
            numberLinkComponentPage.CreateNumberComponentOnPage02("Testing03");
            numberLinkComponentPage.CreateNumberComponentOnPage02("Testing04");
            textLinkComponentPage = new TextLinkComponentPage(Driver);
            textLinkComponentPage.CreateTextComponentOnPage01("Text01");
            textLinkComponentPage.CreateTextComponentOnPage01("Text02");
            textLinkComponentPage.CreateTextComponentOnPage02("Text03");
            return new FormDesignerPage(Driver);

        }


        public FormDesignerPage OpenAnyExistingForm(String FormName)
        {

            Totalexistingforms = Driver.FindElements(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr")).Count();


            int flag = 0;
            if (Totalexistingforms == 1)
            {
                CreateANewForm(FormName);
                return new FormDesignerPage(Driver);
            }

            else
            {

                for (i = 1; i <= Totalexistingforms; i++)
                {

                    if (FormName == (Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[" + i + "]/td[2]")).Text))
                    {
                        Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[" + i + "]/td/div/div/input")).Click();
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    ClickEditForm();
                }

                else if (flag == 0)
                {
                    CreateANewForm(FormName);
                }
                return new FormDesignerPage(Driver);

            }

        }


        public void SelectExistingMyFormByStatus(String expectedformstatus)
        {
            Totalexistingforms = Driver.FindElements(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr")).Count();
            bool flag = false;

            if (expectedformstatus == "AnyForm")
            {
                Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[1]/td[1]/div/div/input")).Click();
            }

            else if ((Totalexistingforms == 1) && ((Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[1]/td[3]")).Text) == expectedformstatus))
            {
                Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[1]/td[1]/div/div/input")).Click();
            }

            else if ((Totalexistingforms == 1) && (!((Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[1]/td[3]")).Text) == expectedformstatus)))
            {
                Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[1]/td[1]/div/div/input")).Click();
                ChangeFormStatusPage changeformstatuspage = ClickChangeFormStatus();
                DashboardPage dashboardpage = changeformstatuspage.ChangeFormStatus(expectedformstatus);
                Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[1]/td[1]/div/div/input")).Click();
            }
            else
            {
                for (i = 1; i < Totalexistingforms; i++)
                {
                    if ((Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[" + i + "]/td[3]")).Text) == expectedformstatus)
                    {
                        Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[" + i + "]/td/div/div/input")).Click();
                        flag = true;
                        break;
                    }

                }

                if (flag == true)
                {

                }
                else
                {
                    try
                    {
                        Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[" + i + "]/td[1]/div/div/input")).Click();

                    }
                    catch (Exception ex)
                    {
                        executor = (IJavaScriptExecutor)Driver;
                        executor.ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[" + i + "]/td[1]/div/div/input")));

                    }
                    ChangeFormStatusPage changeformstatuspage = ClickChangeFormStatus();
                    DashboardPage dashboardpage = changeformstatuspage.ChangeFormStatus(expectedformstatus);
                    try
                    {
                        Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[" + i + "]/td[1]/div/div/input")).Click();

                    }
                    catch (Exception ex)
                    {
                        executor = (IJavaScriptExecutor)Driver;
                        executor.ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[" + i + "]/td[1]/div/div/input")));

                    }
                }
            }
        }


        public void SelectExistingColleaguesFormByStatus(String expectedformstatus)
        {



            if (expectedformstatus == "AnyForm")
            {


                try
                {
                    Driver.FindElement(By.XPath("(//div[@class='govuk-radios']/div/input)[3]")).Click();

                }
                catch (Exception ex)
                {
                    executor = (IJavaScriptExecutor)Driver;
                    executor.ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("(//div[@class='govuk-radios__item'])[4]")));

                }
            }

        }


        public void WaitForDashboardPageToDisplay()
        {
            Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1[contains(text(),'Digital Form Builder')]")));
            Thread.Sleep(1000);
        }

        public IWebElement SelectFIrstItem()
        {
            return Driver.FindElement(sFirstFormCollegue);
        }

        public IWebElement StartNow()
        {
            return Driver.FindElement(startNowLink);
        }

        public IWebElement ImportSavedFormLink()
        {
            return Driver.FindElement(importSavedformLink);
        }

        public String ValidateImportSavedFormPopUp()
        {
            return  Driver.FindElement(importSavedformText).Text;
        }

        public IWebElement EnterImportFormTitle()
        {
            return Driver.FindElement(importFormTitle);
        }

        public void ClickImportFormButton()
        {
            Driver.FindElement(importFormButton).Click();
        }

        public IWebElement ColleguesForm()
        {
            return Driver.FindElement(colleguesForm);
        }

        
        public void ScrolldowntoCollegueForm()
        {
            genericFunctions.ScrollDownToElement(Driver, colleguesForm);
            
        }
        public IWebElement FormNameEditBox()
        {
            return Driver.FindElement(formNameEditBox);
        }

        public IWebElement GetFormName()
        {
            return Driver.FindElement(formNametable);
        }

        public void SelectForminDashboard()
        {
            Thread.Sleep(3000);
             Driver.FindElement(selectForm).Click();
        }

        public IWebElement GetFormNameinDashboard()
        {
            Thread.Sleep(3000);
            return Driver.FindElement(getFormName);
        }

        public void ClickGroupFormButton()
        {
            Thread.Sleep(3000);
            Driver.FindElement(groupFormButton).Click();
        }

        public IWebElement Detail_link()
        {
            return Driver.FindElement(DetailLink);
        }

        public void EnterUserNamePassword(string dFEUserName)
        {

            //var textBytes = System.Text.Encoding.UTF8.GetBytes(Base);
            //string a = System.Convert.ToBase64String(textBytes);
            var base64Bytes = System.Convert.FromBase64String(ConfigurationManager.AppSettings["PWD"]);
            string pwd= System.Text.Encoding.UTF8.GetString(base64Bytes);
            genericFunctions.SendKeys(Driver, UserNameEditBox, dFEUserName);
            genericFunctions.Click(Driver, nextButton);
            //button[contains(text(),'Continue')]
            genericFunctions.SendKeys(Driver, PasswordEditBox, pwd);
            genericFunctions.Click(Driver, Signinbutton);

                }
        public void ChooseDFEandOrg(string dfesign, string org)
        { 
             if(dfesign.Trim().Equals("UKPRN"))
            {
                EnterCode(org);
            }else
            {
                Driver.FindElement(By.XPath("//span[contains(text(),'"+ org + "')]/parent::label/parent::div/input")).Click();
            }

             genericFunctions.Scrolldownpage();
            Thread.Sleep(1000);
            genericFunctions.Clickwebelement(Driver, "//input[@type='submit']");
            
        }

            public void EnterCode(string code)
        {
            
            genericFunctions.ScrollDownToElement(Driver, By.XPath("(//span[contains(text(),'"+code+"')]/parent::label)[1]/parent::div/input"));
            Thread.Sleep(7000);
            Driver.FindElement(By.XPath("(//span[contains(text(),'"+code+"')]/parent::label)[1]/parent::div/input")).Click();

        }

        public void SearchForForm(string formName)
        {
            Thread.Sleep(5000);
            Driver.FindElement(clickSearch).Clear();
            genericFunctions.SendKeys(Driver, clickSearch, formName);
            Thread.Sleep(6000);
            genericFunctions.SendKeys(Driver, clickSearch,Keys.Enter);

        }

        public void SelectForm()
        {
            Thread.Sleep(4000);
            genericFunctions.Click(Driver, selectFormButton);
        }
        public void SearchForm(string formname)
        {
            genericFunctions.WaitForElement(Driver, showfilter);
            genericFunctions.ScrollDownToElement(Driver, showfilter);
            // Driver.FindElement(EditBoxSearch).Click();
            Driver.FindElement(EditBoxSearch).SendKeys(formname);
            Thread.Sleep(5000);
            Driver.FindElement(EditBoxSearch).SendKeys(Keys.Enter);
        }
        public void UserSelectTheForm(string formname)
        {
            genericFunctions.WaitForElement(Driver, showfilter);
            genericFunctions.ScrollDownToElement(Driver, showfilter);
            // Driver.FindElement(EditBoxSearch).Click();
            Driver.FindElement(EditBoxSearch).Clear();
            Driver.FindElement(EditBoxSearch).SendKeys(formname);
            Thread.Sleep(6000);
            Driver.FindElement(EditBoxSearch).SendKeys(Keys.Enter);
            if (NoFormsPresentInDashboard())
            {
                collegueformlink();
            }
            Thread.Sleep(3000);

            IWebElement element = Driver.FindElement(By.XPath("((//span[contains(text(),'"+ formname+"')])[1]/preceding::input)[2]"));

            IJavaScriptExecutor executor;
            executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);
            genericFunctions.Scrolldownpage();
          //  Driver.FindElement(By.XPath("((//div[text()='"+ formname+"'])[1]/preceding::input)[2]")).Click();

            
        }
        
        public void DeleteTheForm()
        {
            executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", Driver.FindElement(deleteButton));
            //Driver.FindElement(deleteButton).Click();
        }

        public void ScrollDownEditForm()
        {
            genericFunctions.ScrollDownToElement(Driver, deleteButton);
        }
        public void ScrollDownCollegueStatus()
        {
            
            genericFunctions.ScrollDownToElement(Driver, colleguesFormLink);
        }


        public void ClickonEditForm(String element)
        {
         By formbutton = By.XPath("//button[text()='Delete form']");
         genericFunctions.Click(Driver,deleteButton);
        }

        public void ToDuplicateFo(String formname)
        {
            Driver.FindElement(DuplicateTextBox).Click();
            Driver.FindElement(DuplicateTextBox).Clear();
            Driver.FindElement(DuplicateTextBox).SendKeys(formname);
        }


        public void ClickDuplicateButton()
        {
            Driver.FindElement(DuplicateButton).Click();    
        }


        public IWebElement VerifyLabel()
        {
            return Driver.FindElement(Label_secondpage);
        }
        public IWebElement Myform()
        {
            return Driver.FindElement(MyForm);
        }
        public IWebElement Collegueform()
        {
            return Driver.FindElement(colleguesForm);
        }

        public void collegueformlink()
        {
            genericFunctions = new GenericFunctions();
            Thread.Sleep(2000);
            genericFunctions.WaitForElement(Driver, colleguesFormLink);
            Thread.Sleep(2000);
            genericFunctions.ScrollDownToElement(Driver,colleguesFormLink);
            Thread.Sleep(2000);
            executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", Driver.FindElement(colleguesFormLink));
            Driver.FindElement(colleguesFormLink).Click();
   
        }

        public IWebElement Noformsfoundlabel()
        {
            return Driver.FindElement(Noformsfound);
        }
        public IWebElement ClickDeleteConfirm()
        {
            return Driver.FindElement(deleteButtonConfirm);
        }
        public IWebElement LinkIntroductoryvideos()
        {
            return Driver.FindElement(Introductoryvideos);
        }

        public IWebElement LinkContacts()
        {
            return Driver.FindElement(Contacts);
        }
        public IWebElement LinkSubmitBug()
        {
            return Driver.FindElement(SubmitBug);
        }
        public IWebElement LinkWishList()
        {
            return Driver.FindElement(WishList);
        }
        public IWebElement LabelContentDesc()
        {
            return Driver.FindElement(ContentDesc);
        }
        public IWebElement LinkCopyright()
        {
            return Driver.FindElement(Copyright);
        }

        public IWebElement colleguesFormeditform()
        {
            genericFunctions.WaitForElement(Driver, SwitchAccess);
            return Driver.FindElement(SwitchAccess);

        }

        public IWebElement ClickSwitchAccessButton()
        {
            return Driver.FindElement(SwitchAccess);
        }

        public void ClickPreviewLink()
        {
            genericFunctions.WaitForElement(Driver, previewTestLink);
            Driver.FindElement(previewTestLink).Click();
        }

        public void ClickProdLink()
        {
            Thread.Sleep(5000);
           // genericFunctions.WaitForElement(Driver,previewProdLink);
            Driver.FindElement(previewProdLink).Click();
        }

        public void ClickChangeStatusButton()
        {
            Thread.Sleep(3000);
            Driver.FindElement(changeStatusButton).Click();
        }

        public void ClickDeleteFormButton()
        {
            Thread.Sleep(3000);
            Driver.FindElement(deleteFormButton).Click();
        }
        public void ClickDuplicateFormButton()
        {
            Thread.Sleep(3000);
            genericFunctions.WaitForElement(Driver, duplicateFormButton);
            genericFunctions.Scrolldownpage();
            Driver.FindElement(duplicateFormButton).Click();
        }

        public void RenameParentForm(String parentForm)
        {     
            string filePath = b + "\\TestData\\file.txt";
            String newFormName = parentForm + "_Duplicate";
            //Storing form name value in file.txt
            File.AppendAllText(filePath, newFormName + Environment.NewLine);
            genericFunctions.ScrollDownToElement(Driver, renameParentForm);
            Thread.Sleep(3000);
            Driver.FindElement(renameParentForm).SendKeys(newFormName);
        }

        public void CheckForDuplicate()
        {
            Thread.Sleep(7000);
            genericFunctions.ScrollDownToElement(Driver, checkForDuplicateButton);
            Thread.Sleep(3000);
            Driver.FindElement(checkForDuplicateButton).Click();
        }

        public void CheckForChildDuplicate(int number)
        {
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath("//tr[@class='govuk-table__row']["+number+"]//button[contains(text(),'Check for duplicate')][1]")).Click();
        }

        public void RenameChildForms(String[] forms)
        {
            for (int i = 1; i <forms.Length; i++)
            {
                Thread.Sleep(5000);
                 Driver.FindElement(By.XPath("//tr[@class='govuk-table__row']["+i+"]//input[@class='govuk-checkboxes__input']")).Click();
                Thread.Sleep(7000);
                        enterChildFormName(forms[i]+"_Duplicate",i);
                        Thread.Sleep(7000);
                        CheckForChildDuplicate(i);
                        CheckForChildDuplicate(i);
            }
        }

        public void enterChildFormName(String childForm, int childNumber)
        {
            Driver.FindElement(By.XPath("//tr[@class='govuk-table__row']["+ childNumber + "]//input[@class='govuk-input  ']")).SendKeys(childForm);
        }

        public void ClickOnDuplicateFormButton()
        {
            Thread.Sleep(6000);
            Driver.FindElement(clickDuplicateFormButton).Click();
        }

        public void SelectParentAccessTypeCheckbox()
        {
            Thread.Sleep(7000);
            genericFunctions.ScrollDownToElement(Driver, selectParentCheckbox);
            Thread.Sleep(3000);
            Driver.FindElement(selectParentCheckbox).Click();
        }

        public void SelectDfESignInRadiobtn()
        {
            Thread.Sleep(4000);
            Driver.FindElement(selectDfESigninRadioButton).Click();
        }

        public void UploadCSVFile(string fileName)
        {
            Thread.Sleep(4000);
            string workingdirectory = Environment.CurrentDirectory;
            var projectdirectory = Directory.GetParent(workingdirectory).Parent.Parent.FullName;
            string b = projectdirectory.ToString();
            string filename = b + "\\TestData\\" + fileName;
            Driver.FindElement(uploadCSVFile).SendKeys(filename);
        }

        public void ClickOnSwitchAccessButton()
        {
            Thread.Sleep(6000);
            Driver.FindElement(clickSwitchAccessButton).Click();
        }

        public void SelectStatus(string status)
        {
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath("//input[@class='govuk-radios__input'][@value='"+status+"']")).Click();
        }
        public void ClickConfirmation()
        {
            Thread.Sleep(4000);
            Driver.FindElement(clickConfirmationCheckbox).Click();
            Thread.Sleep(4000);
            Driver.FindElement(clickSwitchAccessConfirmationButton).Click();
        }

        public void ClickChangeStatusConfirmation()
        {
            Thread.Sleep(3000);
            Driver.FindElement(clickChangeStatusConfirmation).Click();
            Thread.Sleep(3000);
            Driver.FindElement(clickChangeFormStatusButton).Click();
        }

        public void ClickDeleteFormConfirmation()
        {
            Thread.Sleep(3000);
            Driver.FindElement(clickDeleteFormConfirmation).Click();
            Thread.Sleep(3000);
            Driver.FindElement(clickDeleteFormButton).Click();
        }

        public void DFESigninCheckboxClick()
        {
           // genericFunctions.WaitForElement(Driver, DFESigninCheckbox);
          //  executor = (IJavaScriptExecutor)Driver;
            //executor.ExecuteScript("arguments[0].click();", Driver.FindElement(DFESigninCheckbox));
            genericFunctions.Click(Driver, DFESigninCheckbox);
            Driver.FindElement(DFESigninCheckbox).Click();

        }
        public void PublicCheckboxClick()
        {
            // genericFunctions.WaitForElement(Driver, DFESigninCheckbox);
            //  executor = (IJavaScriptExecutor)Driver;
            //executor.ExecuteScript("arguments[0].click();", Driver.FindElement(DFESigninCheckbox));
            genericFunctions.Click(Driver, PublicinCheckbox);
            Driver.FindElement(PublicinCheckbox).Click();

        }


        public string FormName()
        {
            return Driver.FindElement(formname).Text;
        }

        public void SwitcAccessconfirm()
        {
            try
            {
                Driver.FindElement(accessTypeBtn).Click();
            }
            catch (Exception ex)
            {
                // Driver.FindElement(By.XPath("(//button[text()='Import data set'])[2]")).Click();
            }
        }
        public void SelectFocument(String filename)
        {
            try
            {
                Driver.FindElement(By.XPath("//label[text()='No file chosen']")).Click();
            }
            catch (Exception ex)
            {
                // Driver.FindElement(By.XPath("(//button[text()='Import data set'])[2]")).Click();
            }
            //Driver.FindElement(importdatasettitle).SendKeys("dataset");
            // Driver.FindElement(By.XPath("//label[text()='Choose file']")).Click();
            Thread.Sleep(1000);
            string workingdirectory = System.Environment.CurrentDirectory;
            var projectdirectory = Directory.GetParent(workingdirectory).Parent.Parent.FullName;
            string projdir = projectdirectory.Replace("\\", @"\");
            var characters = projdir.ToCharArray();


            string projectdir2 = projectdirectory.Replace("\\", "_");

            string[] authorsList = projectdir2.Split("_");
            string k = "";
            string m = "false";
            InputSimulator sim = new InputSimulator();
            for (int i = 0; i < authorsList.Length; i++)
            {
                Thread.Sleep(2000);
                k = k + authorsList[i];

                // press Tab key 
                sim.Keyboard.KeyPress(VirtualKeyCode.CONTROL);
                sim.Keyboard.TextEntry(authorsList[i]);
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(1000);

            }
            sim.Keyboard.KeyPress(VirtualKeyCode.CONTROL);
            sim.Keyboard.TextEntry("TestData");
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            sim.Keyboard.KeyPress(VirtualKeyCode.CONTROL);
            Thread.Sleep(3000);
            sim.Keyboard.TextEntry(filename.ToString());
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

    }
}
