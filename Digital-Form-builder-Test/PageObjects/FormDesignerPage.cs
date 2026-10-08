using com.sun.xml.@internal.ws.api.pipe;
using Digital_Form_builder_Test.PageObjects.RunnerPages;
using Digital_Form_builder_Test.Utilities;
using java.lang;
using javax.xml.crypto;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reqnroll;
using Exception = System.Exception;

namespace Digital_Form_builder_Test.PageObjects
{
    public class FormDesignerPage
    {
        private IWebDriver Driver;
        public IJavaScriptExecutor executor;

        public FormDesignerPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        // Web elements on the page

        GenericFunctions _genericFunctions = new GenericFunctions();

        [FindsBy(How = How.XPath, Using = "//button[.='Form details']")]
        private IWebElement MenuFormDetailsBtn;

        [FindsBy(How = How.XPath, Using = "//button[.='Add page']")]
        private IWebElement MenuAddPageBtn;

        [FindsBy(How = How.XPath, Using = "//button[.='Add link']")]
        private IWebElement MenuAddLinksBtn;

        [FindsBy(How = How.XPath, Using = "//button[.='Sections']")]
        private IWebElement MenuSectionsBtn;

        [FindsBy(How = How.XPath, Using = "//button[.='Conditions']")]
        private IWebElement MenuConditionsBtn;

        [FindsBy(How = How.XPath, Using = "//button[.='Lists']")]
        private IWebElement MenuListBtn;

        [FindsBy(How = How.XPath, Using = "//button[.='Outputs']")]
        private IWebElement MenuOutputsBtn;

        [FindsBy(How = How.XPath, Using = "//button[.='Summary behaviour']")]
        private IWebElement MenuSummaryBehaviourBtn;

        [FindsBy(How = How.XPath, Using = "//button[.='Summary']")]
        private IWebElement MenuSummaryBtn;

        [FindsBy(How = How.XPath, Using = "(//button[.='Edit page'])[1]")]
        private IWebElement FirstPageEditBtn;

        [FindsBy(How = How.XPath, Using = "(//button[.='Edit page'])[2]")]
        private IWebElement SecondPageEditBtn;

        [FindsBy(How = How.XPath, Using = "(//button[.='Edit page'])[3]")]
        private IWebElement ThirdPageEditBtn;

        [FindsBy(How = How.XPath, Using = "(//button[.='Create component'])[1]")]
        private IWebElement StartPageCreateComponentBtn;

        [FindsBy(How = How.XPath, Using = "(//button[.='Create component'])[2]")]
        private IWebElement Page01CreateComponentBtn;

        [FindsBy(How = How.XPath, Using = "(//button[.='Create component'])[3]")]
        private IWebElement Page02CreateComponentBtn;

        [FindsBy(How = How.XPath, Using = "(//button[.='Create component'])[4]")]
        private IWebElement Page03CreateComponentBtn;

        [FindsBy(How = How.XPath, Using = "(//button[.='Create component'])[5]")]
        private IWebElement SummaryPageCreateComponentBtn;

        [FindsBy(How = How.XPath, Using = "(//a[@title='Preview page'])[1]")]
        private IWebElement FirstPagepPreviewBtn;

        [FindsBy(How = How.XPath, Using = "(//a[@title='Preview page'])[2]")]
        private IWebElement SecondPagepPreviewBtn;

        [FindsBy(How = How.XPath, Using = "(//a[@title='Preview page'])[3]")]
        private IWebElement ThirdPagepPreviewBtn;

        [FindsBy(How = How.XPath, Using = "//ul[@class='govuk-list govuk-error-summary__list']")]
        public IWebElement fileMoreThan10MB;

        private By createNewFormLink = By.XPath("//a[text()='Create new form']");
        private By TitleEditBox = By.XPath("//input[@name='title']");
        private By ContentEditBox = By.XPath("//textarea[@id='field-content']");
        private By SaveButton = By.XPath("//button[text()='Save']");

        private By EditIcon = By.XPath("(//div[@class='component-item'])[1]");
        private By DeleteIcon = By.XPath("//button[contains(text(),'Delete')]");

        private By ListTitleLink = By.XPath("//button[text()='Lists']");
        private By AddListLink = By.XPath("//button[text()='Add List']");

        private By GenerateStructureButton = By.XPath("//button[contains(text(),'Generate structure')]");
        private By SelectTabLabel = By.XPath("//input[@id='tab-label']");
        private By SelectTabHeaderl = By.XPath("//input[@id='tab-header']");

        private By ListTitleEditBox = By.XPath("//input[@name='list-title']");

        private By ListContinue = By.XPath("(//button[contains(text(),'Continue')])[1]");

        private By htmlcontent = By.XPath("//textarea");
        private By autocomplete_edit = By.XPath("(//input)[4]");

        private By date_edit = By.XPath("(//input)[4]");
        private By Import_File_editbox= By.XPath("(//input)[7]");
        private By Import_File_editbox1 = By.XPath("(//input)[10]");


        private By SaveButton1 = By.XPath("(//button[text()='Save'])[2]");

        private By DayEditBox = By.XPath("//input[contains(@name,'day')]");
        private By MonthEditBox = By.XPath("//input[contains(@name,'month')]");
        private By YearEditBox = By.XPath("//input[contains(@name,'year')]");
        private By HourEditBox = By.XPath("//input[contains(@name,'hour')]");
        private By MinuteEditBox = By.XPath("//input[contains(@name,'minute')]");
        private By emailEditBox = By.XPath("//input[@type='email']");
        private By AddressLine1EditBox = By.XPath("//input[contains(@name,'addressLine1')]");
        private By AddressLine2EditBox = By.XPath("//input[contains(@name,'addressLine2')]");
        private By TownLine2EditBox = By.XPath("//input[contains(@name,'town')]");
        private By PostCodeEditBox = By.XPath("//input[contains(@name,'post')]");
        private By NumberEditBox = By.XPath("//input[@inputmode='numeric']");
        private By SaveCloseIcon = By.XPath("//a[@title='Close']");
        private By ListSelectDropdown = By.XPath("//select[@id='list-datasets']");
        private By AddList_Link = By.XPath("//button[text()='Add list']");
        private By EditList_Link = By.XPath("//button[text()='Edit list']");
        private By ListItem_EditBox = By.XPath("//input[@name='list-item-title']");
        private By Helptext_EditBox = By.XPath("//input[@name='list-item-help-text']");
        private By Value_EditBox = By.XPath("//input[@name='list-item-value']");
        private By Enterlink_EditBox = By.XPath("//input[@name='list-item-link']");
        private By SaveListItem_Link = By.XPath("//button[text()='Save list item']");
        private By CheckboxAlert_option = By.XPath("//input[@class='govuk-checkboxes__input']");
        private By Removelist_button = By.XPath("//button[contains(text(),'Remove list item')]");
        private By Savelist_button = By.XPath("//button[text()='Save list']");
        private By DeleteList_Link = By.XPath("//button[text()='Delete list']");
        private By Importdataset_Link = By.XPath("//button[text()='Import data set']");
        private By SuccessMessage_Label = By.XPath("(//h2[text()='Success'])[1]");
        private By SuccessCheck_Label = By.XPath("(//p[@class='govuk-notification-banner__heading'])[4]");
        private By YesRadio_checkbox = By.XPath("(//input[@type='radio'])[1]");
        private By NoRadio_checkbox = By.XPath("(//input[@type='radio'])[2]");

        private By SaveandContinue = By.XPath("//button[contains(text(),'Save and continue')]");
        private By summaryBehaviourButton = By.XPath("//button[text()='Summary behaviour']");
        private By enterDeclaration = By.XPath("//textarea[@id='declaration']");
        private By enterCustomiseSummaryMessage = By.XPath("//textarea[@id='custom-summary-message']");
        private By pageTitle = By.XPath("//input[@name='title']");
        private By duplicateButton = By.XPath("//button[text()='Duplicate']");
        private By duplciatedPageNames = By.XPath("//h3[text()='Second page']");
        private By closeLink = By.XPath("//a[text()='Close']");
        private By Startnow = By.XPath("//button[contains(text(),'Start now')]");
        private By summaryPageEdit = By.XPath("//button[text()='Edit page']/ancestor::div[@id='/summary']//button[@title='Edit page']");
        private By SuccessCheck_Label1 = By.XPath("(//ul[@class='govuk-list govuk-list--bullet'])[2]/li[1]");
        private By SuccessCheck_Label2 = By.XPath("(//ul[@class='govuk-list govuk-list--bullet'])[2]/li[2]");
        private By SuccessCheck_Label3 = By.XPath("(//ul[@class='govuk-list govuk-list--bullet'])[2]/li[3]");
        private By SuccessCheck_Label4 = By.XPath("(//ul[@class='govuk-list govuk-list--bullet'])[2]/li[4]");
        private By LinkFrom_select= By.XPath("//select[@id='link-from']");
        private By LinkCondition_select = By.XPath("//select[@id='select-condition']");
        private By PageTitle_Edit = By.XPath("//input[contains(@id,'title')]");
        private By PageType_Select = By.XPath("//select[@id='page-type']");
        private By Linkfrom_Select = By.XPath("//select[@id='link-source']");
        private By Linkto_Select = By.XPath("//select[@id='link-target']");
        private By Addlinkbutton = By.XPath("//button[text()='Add link']");
        private By Closebutton = By.XPath("//a[text()='Close']");
        private By Sectionbutton = By.XPath("//button[text()='Sections']");
        private By selectSection = By.XPath("//select[@id='page-section']");
        private By enterNumberTriggerValue = By.XPath("//input[@type='number']");
        private By enterMultilineValue = By.XPath("//textarea[@class='govuk-textarea']");
        private By enterTelephoneValue = By.XPath("//input[@type='tel']");
        private By enterEmailAddressValue = By.XPath("//input[@id='email']");
        private By selectYesNoValue = By.XPath("//input[@type='radio'][@value='false']");


        public By Section()
        {
            return Sectionbutton;
        }

        public By Close()
        {
            return Closebutton;
        }
        public By Addlink()
        {
            return Addlinkbutton;
        }

        public By LinkfromSelect()
        {
            return Linkfrom_Select;
        }
        public By LinktoSelect()
        {
            return Linkto_Select;
        }
        public By removethepage(string page)
        {
            return By.XPath("//a[contains(@href,'"+ page + "')]/preceding::button[@title='Edit page'][1]");
        }
        public By PageTitle()
        {
            return PageTitle_Edit;
        }
        public By PageType()
        {
            return PageType_Select;
        }
        public By LinkCondition()
        {
            return LinkCondition_select;
        }
        public By LinkFrom()
        {
            return LinkFrom_select;
        }
        public By SuccessCheck1()
        {
            return SuccessCheck_Label1;
        }
        public By SuccessCheck2()
        {
            return SuccessCheck_Label2;
        }
        public By SuccessCheck3()
        {
            return SuccessCheck_Label3;
        }
        public By SuccessCheck4()
        {
            return SuccessCheck_Label4;
        }
  
        public By SuccessCheck()
        {
            return SuccessCheck_Label;
        }
        public MenuFormDetailsPage ClickMenuFormDetailsBtn()
        {
            MenuFormDetailsBtn.Click();
            return new MenuFormDetailsPage(Driver);
        }
        public By Importdataset()
        {
            return Importdataset_Link;
        }
        
        public By YesRadiocheckbox()
            { return YesRadio_checkbox; 
        }
        public By NoRadiocheckbox()
        {
            return NoRadio_checkbox;
        }

        
        public By Removelist()
        {
            return Removelist_button;
        }
        public By CheckboxAlert()
        {
            return CheckboxAlert_option;
        }
        public By CloseIcon()
        {
            return SaveCloseIcon;
        }
        public By Selectdropdown()
        {
            return ListSelectDropdown;
        }

        public By Listicon()
        {
            return ListTitleLink;
        }

        public By EditList()
        {
            return EditList_Link;
        }
        public By DelteList()
        {
            return DeleteList_Link;
        }
        
        public By SuccessMessage()
        {
            return SuccessMessage_Label;
        }
        public By ListCheckBoxEdit(string listname)
        {
            return By.XPath("//span[text()='"+ listname+"']/preceding::input[1]");
        }
        public By ListTitle_Label(string ListTitle)
        {
            return By.XPath("//span[@title='"+ ListTitle+"']");
        }
        public By NoOfItems(string ListTitle)
        {
            return By.XPath("//span[@title='"+ ListTitle+"']/following::p[1]");
        }
        public By Datasetavailable(string ListTitle)
        {
            return By.XPath("//span[@title='" + ListTitle + "']/following::p[2]");
        }
        public By Linksavailable(string ListTitle)
        {
            return By.XPath("//span[@title='" + ListTitle + "']/following::p[3]");
        }

        public By EditItem(string item)
        {
            return By.XPath("(//span[@class='govuk-label inline-block separator']/following-sibling::div[contains(text(),'" + item + "')]/following::div/div[text()='Edit'])[1]\r\n");
        }
        public By RemoveItem(string item)
        {
            return By.XPath("(//span[@class='govuk-label inline-block separator']/following-sibling::div[contains(text(),'" + item + "')]/following::div/div[text()='Remove'])[1]");
        }


        public By itemtext()
        {
            return ListItem_EditBox;
        }
        public By Helptext()
        {
            return Helptext_EditBox;
        }
        public By Value()
        {
            return Value_EditBox;
        }
        public By Enterlink()
        {
            return Enterlink_EditBox;
        }

        public By AddList()
        {
            return AddList_Link;
        }

        public By SaveListItem()
        {
            return SaveListItem_Link;
        }


        public By SaveList()
        {
            return Savelist_button;
        }
        public MenuAddPagePage ClickMenuAddPageBtn()
        {


            try
            {
                MenuAddPageBtn.Click();
                return new MenuAddPagePage(Driver);
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", MenuAddPageBtn);
                return new MenuAddPagePage(Driver);
            }
            
            
        }

        public MenuAddLinkPage ClickMenuAddLinksBtn()
        {
            MenuAddLinksBtn.Click();
            return new MenuAddLinkPage(Driver);
        }


        public MenuSectionsPage ClickMenuSectionsBtn()
        {
            MenuSectionsBtn.Click();
            return new MenuSectionsPage(Driver);
        }

        public MenuConditionsPage ClickMenuConditionsBtn()
        {
            MenuConditionsBtn.Click();
            return new MenuConditionsPage(Driver);
        }

        public MenuListPage ClickMenuListBtn()
        {
            MenuListBtn.Click();
            return new MenuListPage(Driver);
        }

        public MenuOutputPage ClickMenuOutputsBtn()
        {
            MenuOutputsBtn.Click();
            return new MenuOutputPage(Driver);
        }

        public MenuSummaryBehaviourPage ClickMenuSummaryBehaviourBtn()
        {
            MenuSummaryBehaviourBtn.Click();
            return new MenuSummaryBehaviourPage(Driver);
        }

        public MenuSummaryPage ClickMenuSummaryBtn()
        {
            MenuSummaryBtn.Click();
            return new MenuSummaryPage(Driver);
        }

        public EditPage ClickFirstPageEditBtn()
        {
            FirstPageEditBtn.Click();
            return new EditPage(Driver);
        }

        public EditPage ClickSecondPageEditBtn()
        {

            try
            {
                SecondPageEditBtn.Click();
                return new EditPage(Driver);
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", SecondPageEditBtn);
                return new EditPage(Driver);
            }

            
        }

        public void EditPageTitle(string newFormName)
        {
            Driver.FindElement(pageTitle).Clear();
            Driver.FindElement(pageTitle).SendKeys(newFormName);
        }

        public void ClickDuplciateButton()
        {
            Driver.FindElement(duplicateButton).Click();
        }

        public void ClickCloseLink()
        {
            Driver.FindElement(closeLink).Click();
        }

        public void ClickEditPageOfDuplicatePage()
        {
            Driver.FindElement(By.XPath("(//button[text()='Edit page'])[4]")).Click();
        }

        public int VerifyNewDuplicatePage()
        {
            int count = Driver.FindElements(duplciatedPageNames).Count;
            return count;
        }


        public void ClickSummaryBehaviourButton()
        {
            Driver.FindElement(summaryBehaviourButton).Click();
        }

        public void EnterDeclarationAndCustomiseSummaryMessage(string declaration, string message)
        {
            Driver.FindElement(enterDeclaration).SendKeys(declaration);
            Thread.sleep(4000);
            Driver.FindElement(enterCustomiseSummaryMessage).SendKeys(message);
        }
        public EditPage ClickThirdPageEditBtn()
        {
            ThirdPageEditBtn.Click();
            return new EditPage(Driver);
        }

        public EditPage clickSummaryEditPage()
        {
            Driver.FindElement(summaryPageEdit).Click();
            return new EditPage(Driver);
        }
        public CreateComponentPage ClickStartPageCreateComponentBtn()
        {

            try
            {
                StartPageCreateComponentBtn.Click();
                return new CreateComponentPage(Driver);
            }
            catch (Exception ex)
            {

                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", StartPageCreateComponentBtn);
                return new CreateComponentPage(Driver);
            }

            
        }
     
        public CreateComponentPage ClickPage01CreateComponentBtn()
        {
            try
            {
                Thread.sleep(8000);
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                GenericFunctions genericFunctions = new GenericFunctions();
                genericFunctions.WaitForElement(Driver, (By)Page01CreateComponentBtn);
                Thread.sleep(5000);
                Page01CreateComponentBtn.Click();
                return new CreateComponentPage(Driver);
            }
            catch (Exception ex)
            {

                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", Page01CreateComponentBtn);
                return new CreateComponentPage(Driver);
            }
            
        }


        public CreateComponentPage ClickPage02CreateComponentBtn()
        {
            try
            {
                Page02CreateComponentBtn.Click();
                return new CreateComponentPage(Driver);
            }
            catch (Exception ex)
            {

                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", Page02CreateComponentBtn);
                return new CreateComponentPage(Driver);
            }

        }

        public CreateComponentPage ClickPage03CreateComponentBtn()
        {
            try
            {
                Page03CreateComponentBtn.Click();
                return new CreateComponentPage(Driver);
            }
            catch (Exception ex)
            {

                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", Page03CreateComponentBtn);
                return new CreateComponentPage(Driver);
            }

        }

        public CreateComponentPage ClickSummaryPageCreateComponentBtn()
        {
            try
            {
                SummaryPageCreateComponentBtn.Click();
                return new CreateComponentPage(Driver);
            }
            catch (Exception ex)
            {

                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", SummaryPageCreateComponentBtn);
                return new CreateComponentPage(Driver);
            }

        }



        public RunnerStartPage ClickFirstPagepPreviewBtn()
        {
            Thread.sleep(5000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GenericFunctions gen = new GenericFunctions();
            By element = By.XPath("(//a[@title='Preview page'])[1]");
           // gen.WaitForPageToLoad(element);
            gen.WaitForElement(Driver, element);
            FirstPagepPreviewBtn.Click();
            string parentwindow = Driver.WindowHandles[0];
            string chindwindow = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(chindwindow);
            return new RunnerStartPage(Driver);
        }

        public RunnerPage ClickSecondPagepPreviewBtn()
        {
            SecondPagepPreviewBtn.Click();
            string parentwindow = Driver.WindowHandles[0];
            string chindwindow = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(chindwindow);
            return new RunnerPage(Driver);
        }

        public RunnerPage ClickThirdPagepPreviewBtn()
        {
            ThirdPagepPreviewBtn.Click();
            string parentwindow = Driver.WindowHandles[0];
            string chindwindow = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(chindwindow);
            return new RunnerPage(Driver);
        }


        public IWebElement VerifyLabel(string label)
        {

            return Driver.FindElement(By.XPath("//h3[text()='" + label + "']"));
        }
        public By EnterEmailement()
        {
            return emailEditBox;
                }
        public IWebElement GoToDashboard()
        {

            return Driver.FindElement(createNewFormLink);
        }

        public IWebElement clicksaveandcontinue()
        {
            return Driver.FindElement(SaveandContinue);
        }
        public IWebElement StartNow()
        {
            return Driver.FindElement(Startnow);
        }
        public void EnterTitleAndContent(string title, string content)
        {
            Driver.FindElement(TitleEditBox).SendKeys(title);
            Driver.FindElement(ContentEditBox).SendKeys(content);
        }

        public IWebElement savebutton()
        {
            return Driver.FindElement(SaveButton);
        }

        public void ClickEditicon()
        {
            Driver.FindElement(EditIcon).Click();
        }

        public void ClickDeletebutton()
        {
            Driver.FindElement(DeleteIcon).Click();
        }

        public void EnterTitle(string Title)
        {
            Driver.FindElement(TitleEditBox).SendKeys(Title);
        }

        public void ClickGenerateStructureButton()
        {
            Driver.FindElement(GenerateStructureButton).Click();
        }
        public void SelectTabData()
        {
            IList<IWebElement> all = Driver.FindElements(By.XPath("//div[@class='table-container']//div[@class='cell  ']"));
            if (all.Count > 0)
            {
                foreach (IWebElement element in all)
                {
                    ClickOnBlock(element);
                }
            }
        }
        public void ClickOnBlock(IWebElement element)
        {
            element.Click();
            SelectBlockData();
        }

        public void SelectBlockData()
        {
            Driver.FindElement(SelectTabLabel).SendKeys("Test Label");
            Driver.FindElement(SelectTabHeaderl).SendKeys("Test Header");
            SelectElement selectDataset = new SelectElement(Driver.FindElement(By.XPath("//select[@id='tab-select']")));
            selectDataset.SelectByIndex(1);
        }

        public void EnterAddNewList(string ListTitle, string ListValue)
        {
            Driver.FindElement(ListTitleLink).Click();
            Driver.FindElement(AddListLink).Click();
            Thread.sleep(3000);
            Driver.FindElement(ListTitleEditBox).SendKeys(ListTitle);
            string[] subs = ListValue.Split(',');
            int a = subs.Count();
           for(int i = 0; i < a; i++)
            {
                Driver.FindElement(By.XPath("//button[text()='Add list item']")).Click();
                Thread.sleep(3000);
                Driver.FindElement(By.XPath("//input[@name='list-item-title']")).SendKeys(subs[i]);
                Driver.FindElement(By.XPath("//input[@name='list-item-value']")).SendKeys(subs[i]);
                _genericFunctions.Scrolldownpage();
                Thread.sleep(3000);
                By element = By.XPath("//button[text()='Save list item']");
                _genericFunctions.WaitForElement(Driver, element);
                Driver.FindElement(By.XPath("//button[text()='Save list item']")).Click();
                Thread.sleep(3000);
            }
            _genericFunctions.Scrolldownpage();
            Thread.sleep(3000);
            Driver.FindElement(By.XPath("//button[text()='Add list']")).Click();
            By elementback = By.XPath("//a[text()='Back']");
            _genericFunctions.WaitForElement(Driver, elementback);
            _genericFunctions.Click(Driver, elementback);
       
        }
        public void AddListTitle(string ListTitle)
        {
            Driver.FindElement(ListTitleLink).Click();
            Driver.FindElement(AddListLink).Click();
            Thread.sleep(3000);
            Driver.FindElement(ListTitleEditBox).SendKeys(ListTitle);
        }
        public  IWebElement VerifyList(string value)
        {
            return Driver.FindElement(By.XPath("//li[text()='" + value + "']"));
        }

        public IWebElement NumberEdit()
        {
            return Driver.FindElement(By.XPath("//input[@inputmode='numeric']"));
        }

        
        public IWebElement VerifyInTitle()
        { 
       return Driver.FindElement(By.XPath("//label[@class='govuk-label govuk-label--s']"));
        }
    public void SelectTheInDropdown(string ListTitle)
        {
            var list = Driver.FindElement(By.XPath("//select[@id='field-options-list']"));
            var seletuklist = new SelectElement(list);
            Thread.sleep(2000);
            seletuklist.SelectByText(ListTitle);
        }

        public void ContinueButtonInList()
        {
            Driver.FindElement(ListContinue).Click();
        }

        public void EnterContentInHTMLContent(string textContent)
        {
            Driver.FindElement(htmlcontent).Clear();
            Thread.sleep(3000);
            Driver.FindElement(htmlcontent).SendKeys(textContent);
        }
        public By NumberComponentelement()
        {
            return By.XPath("//div[text()='£']/following::input[1]");
        }
        public By Telephonecomponentelement()
        {
            return By.XPath("//input[@type='tel']");
        }
        public By textcomponentelement()
        {
            return By.XPath("//input[@title='Text component']");
        }
        public By Websitecomponentelement()
        {
            return By.XPath("//input[@title='Website component']");
        }
        public By radiocomponentelement(string elementname)
        {
            return By.XPath("//input[@value='"+ elementname+"' and @type='radio']");
        }
        public By checkboxcomponentelement(string elementname)
        {
            return By.XPath("//input[@value='" + elementname + "' and @type='checkbox']");
        }

        
        public void EnterInAutocomple(string item)
        {
            Driver.FindElement(autocomplete_edit).Clear();
            Driver.FindElement(autocomplete_edit).Clear();
            Thread.sleep(5000);
            Driver.FindElement(autocomplete_edit).SendKeys(item);
            Thread.sleep(2000);
            try
            {
                Driver.FindElement(autocomplete_edit).SendKeys(Keys.Enter);
            }catch(Exception e) { }
            Thread.sleep(2000);
        }

        public void EnterInAutocomple1(string item)
        {
            Driver.FindElement(autocomplete_edit).Clear();
            Driver.FindElement(autocomplete_edit).Clear();
            Thread.sleep(5000);
             Driver.FindElement(autocomplete_edit).SendKeys(item);
            Thread.sleep(2000);
            try
            {
              //  Driver.FindElement(autocomplete_edit).SendKeys(Keys.Enter);
            }
            catch (Exception e) { }
            Thread.sleep(2000);
        }
        public void Entertitlefiledownload(string item)
        {
            if (item.Contains("Data"))
            {
                Driver.FindElement(Import_File_editbox1).SendKeys(item);

            }
            else
            {
                Driver.FindElement(Import_File_editbox).SendKeys(item);
            }
        }
        public void SaveButton1_1()
        {
            try
            {
                Driver.FindElement(SaveButton1).Click();
            }catch(Exception e) {

                Driver.FindElement(SaveButton).Click();

            }
        }

        public void SelectDocument(string document)
        {
            _genericFunctions.ScrollDownToElement(Driver,By.Id("field-options-list"));
            var education = Driver.FindElement(By.Id("field-options-list"));
            //create select element object 
            var selectElement = new SelectElement(education);
            selectElement.SelectByText(document);
        }

        public void EnterNumberTriggervalue(string count)
        {
            Driver.FindElement(enterNumberTriggerValue).SendKeys(count);
        }

        public void EnterValues(int count)
        {
            for(int i = 0; i <= count; i++)
            {
                Driver.FindElement(enterMultilineValue).SendKeys("Testing multiline component");
                Driver.FindElement(enterTelephoneValue).SendKeys("42323232");
                Driver.FindElement(enterEmailAddressValue).SendKeys("test.user@gmail.com");
                if(Driver.FindElement(selectYesNoValue).Enabled)
                {
                    Driver.FindElement(selectYesNoValue).Click();
                }
            }

        }
        public void SelectSectionInEditPage(string repeatableSecName)
        {
            SelectElement selectDataset = new SelectElement(Driver.FindElement(selectSection));
            selectDataset.SelectByValue(repeatableSecName);
        }

        public void EnterDay(string day)
        {
            Driver.FindElement(DayEditBox).SendKeys(day);
        }
        public void EnterMonth(string month)
        {
            Driver.FindElement(MonthEditBox).SendKeys(month);
        }

        public void EnterYear(string year)
        {
            Driver.FindElement(YearEditBox).SendKeys(year);
        }
        public void EnterHour(string hour)
        {
            Driver.FindElement(HourEditBox).SendKeys(hour);
        }
        public void EnterMinute(string minute)
        {
            Driver.FindElement(MinuteEditBox).SendKeys(minute);
        }
        public void EnterEmail(string email)
        {
            Driver.FindElement(emailEditBox).Clear();
            Thread.sleep(3000);
            Driver.FindElement(emailEditBox).SendKeys(email);
        }
        public void EnterAddressLine1EditBox(string AddressLine1)
        {
            Driver.FindElement(AddressLine1EditBox).Clear();
            Thread.sleep(3000);
            Driver.FindElement(AddressLine1EditBox).SendKeys(AddressLine1);
        }

        public void EnterAddressLine2EditBox(string AddressLine2)
        {
            Driver.FindElement(AddressLine2EditBox).Clear();
            Thread.sleep(3000);
            Driver.FindElement(AddressLine2EditBox).SendKeys(AddressLine2);
        }
        public void EnterTownLine2EditBox(string TownLine2)
        {
            Driver.FindElement(TownLine2EditBox).Clear();
            Thread.sleep(3000);
            Driver.FindElement(TownLine2EditBox).SendKeys(TownLine2);
        }
        public void EnterPostCodeEditBox(string PostCode)
        {
            Driver.FindElement(PostCodeEditBox).Clear();
            Thread.sleep(3000);
            Driver.FindElement(PostCodeEditBox).SendKeys(PostCode);
        }
        public void Clean_component()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IList<IWebElement> all = Driver.FindElements(By.XPath("//div[@Class='component-item']"));
            if(all.Count > 0)
            {
                foreach (IWebElement element in all)
                {
                    ClickEditicon();
                    ClickDeletebutton();
                }
            }
        }
        public void WaitForFileToUpload()
        {

            Thread.sleep(30000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[text()='Your file was successfully selected and scanned']")));

        }

    }
}
