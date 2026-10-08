using Digital_Form_builder_Test.DBHelper;
using Digital_Form_builder_Test.PageObjects;
using Digital_Form_builder_Test.PageObjects.ComponentPages;
using Digital_Form_builder_Test.PageObjects.RunnerPages;
using Digital_Form_builder_Test.Utilities;
using java.lang;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using javax.naming;
using SeleniumExtras.WaitHelpers;
using System.Data;
using System.Globalization;
using com.sun.xml.@internal.bind.v2.runtime.unmarshaller;
using java.nio.file;
using javax.sound.sampled;
using Digital_Form_builder_Test.Configrations;
using jdk.nashorn.@internal.objects.annotations;
using System.Threading;
using Thread = java.lang.Thread;
using static com.sun.tools.javac.util.Name;
using Exception = System.Exception;
using com.sun.org.apache.xml.@internal.resolver.helpers;
using System.Configuration;
using javax.xml.crypto;
using com.sun.tools.doclets.formats.html;
using java.lang.annotation;
using Reqnroll;
using Table = Reqnroll.Table;
using AngleSharp.Text;

namespace Digital_Form_builder_Test.stepsdef
{

    [Binding]

    public class RegressionStepDefinitions : BaseTest

    {
        public static string randomfilename;
        public RegressionStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            Random generator = new Random();
            r = generator.Next(0, 1000000);
        }
        ScenarioContext _scenarioContext;
        public IWebDriver Driver = GetDriver();
        ResultLinkComponentPage resultLinkComponent = new ResultLinkComponentPage(GetDriver());
        DashboardPage dashboardPage = new DashboardPage(GetDriver());
        ParentChildPage parentChildPage = new ParentChildPage(GetDriver());
        EnterTitlePage _EnterTitlePage = new EnterTitlePage(GetDriver());
        FormDesignerPage _formDesignerPage = new FormDesignerPage(GetDriver());
        ChangeFormStatusPage _changeFormStatusPage = new ChangeFormStatusPage(GetDriver());
        FirstPage firstpage = new FirstPage(GetDriver());
        GenericFunctions genericFunctions = new GenericFunctions();
        RunnerPage runnerPage = new RunnerPage(GetDriver());
        TableComponentPage tableComponentPage = new TableComponentPage(GetDriver());
        DataImport _dataimport = new DataImport(GetDriver());
        SummaryPage _summaryPage = new SummaryPage(GetDriver());
        YourDetailPage _yourDetailPage = new YourDetailPage(GetDriver());
        EditPage _editPage = new EditPage(GetDriver());
        NumberLinkComponentPage _numberLinkComponentPage = new NumberLinkComponentPage(GetDriver());
        MenuSectionsPage _menuSectionsPage = new MenuSectionsPage(GetDriver());
        public string formName;

        public static string workingdirectory = Environment.CurrentDirectory;
        public static string projectdirectory = Directory.GetParent(workingdirectory).Parent.Parent.FullName;
        public static string fileName = projectdirectory + "\\file_" + DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".txt";
        string b = projectdirectory.ToString();

        public static bool FlagsAttribute = true;
        public StreamWriter sw;

        public IJavaScriptExecutor executor;
        public static int r;
       
        private string runnerurl;

        [Given(@"User is on Dashboard Page")]
        public void GivenUserIsOnDashboardPage()
        {
            dashboardPage.WaitForDashboardPageToDisplay();


        }
        [Given(@"User Navigated to runner")]
        public void GivenUserNavigatedToRunner()
        {
            //var getcurrenttag=  _scenarioContext.ScenarioInfo.Tags;
            //var tags = getcurrenttag[0];

            if (ConfigurationManager.AppSettings["Enviornment"].Trim().ToLower() == "dev")
            {
                runnerurl = "https://uat." + ConfigurationManager.AppSettings["Enviornment"] + ".digital-forms.education.gov.uk/" + ConfigurationManager.AppSettings["Dev_FormId"].Trim();
            }
            else if (ConfigurationManager.AppSettings["Enviornment"].Trim().ToLower() == "test")
            {
                runnerurl = "https://uat." + ConfigurationManager.AppSettings["Enviornment"] + ".digital-forms.education.gov.uk/" + ConfigurationManager.AppSettings["Test_FormId"].Trim();

            }
            else if (ConfigurationManager.AppSettings["Enviornment"].ToLower() == "preprod")
            {
                runnerurl = "https://uat." + ConfigurationManager.AppSettings["Enviornment"] + ".digital-forms.education.gov.uk/" + ConfigurationManager.AppSettings["Preprod_FormId"].Trim();

            }
            Driver.Url = runnerurl;
        }

        [Given(@"User Navigated to pp runner")]
        public void GivenUserNavigatedppToRunner()
        {
                Driver.Url = "https://pp-services.signin.education.gov.uk/";
        }

        [Then(@"verify Digital Form Builder title")]
        public void ThenVerifyDigitalFormBuilderTitle()
        {
            Assert.AreEqual("GOV.UK Site - Digital Form Builder", Driver.Title);


        }


        [Then(@"Verify Start Now link")]
        public void ThenVerifyStartNowLink()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Thread.sleep(3000);
            Assert.AreEqual("Start now", dashboardPage.StartNow().Text);

        }

        [Then(@"click on Start Now link")]
        public void ThenClickOnStartNowLink()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            dashboardPage.StartNow().Click();
        }

        [Then(@"Verify '([^']*)'")]
        public void ThenVerify(string form)
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//h2[contains(text(),'" + form + "')]")).Displayed, form);
        }

        [Then(@"Verify '([^']*)' and '([^']*)' Form")]
        public void ThenVerifyAndForm(string myform, string colleagues)
        {
            By Preview = By.XPath("//a[text()='My forms']");
            genericFunctions.ScrollDownToElement(Driver, Preview);
            Assert.AreEqual(myform, dashboardPage.Myform().Text.Trim());
            Assert.IsTrue(dashboardPage.Collegueform().Text.Trim().Contains(colleagues), colleagues);


        }


        [Then(@"Verify Colleagues Form")]
        public void ThenVerifyColleaguesForm()
        {
            Assert.AreEqual("Colleagues' forms", dashboardPage.ColleguesForm().Text);


        }

        [Then(@"Click on create new form")]
        public void ThenClickOnCreateNewForm()
        {

            dashboardPage.ClickCreateFormBtn();

        }

        [Then(@"Click on create new form button")]
        public void ThenClickOnCreateNewFormButton(Table table)
        {
            var formData = table.CreateSet<Summaryvalues>();
            string filePath = b + "\\TestData\\file.txt";
            File.WriteAllText(filePath, string.Empty);
            foreach (Summaryvalues data in formData)
            {
                var formName = data.FormName.Trim() + DateTime.Now.ToString("s", CultureInfo.CreateSpecificCulture("en-US"));
                formName = Regex.Replace(formName, @"[):;.,'=-]", "");
                dashboardPage.ClickCreateFormBtn();
                dashboardPage.FormNameEditBox().SendKeys(formName);
                _EnterTitlePage.ClickNextBtnOnFormTitlePage();
                _formDesignerPage.GoToDashboard().Click();
                //Storing form name value in file.txt
                File.AppendAllText(filePath, formName + Environment.NewLine);
            }
        }

        [Then(@"User selects the form and click on edit button")]
        public void ThenUserSelectsTheFormAndClickOnEditButton()
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            List<string> arrayList = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                arrayList.Add(lines[i].ToString());
                dashboardPage.SearchForForm(lines[i].ToString());
                Assert.AreEqual(lines[i].ToString(), dashboardPage.GetFormNameinDashboard().Text);
                dashboardPage.UserSelectTheForm(lines[i]);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//button[contains(text(),'Edit form')])[1]")));
                Thread.sleep(5000);
                dashboardPage.ClickEditForm();
                break;
            }
        }

        [Then(@"user change page type of Parent form as ""([^""]*)""")]
        public void ThenUserChangePageTypeOfParentFormAs(string pageType)
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            List<string> arrayList = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                arrayList.Add(lines[i].ToString());
                dashboardPage.SearchForForm(lines[i].ToString());
                Assert.AreEqual(lines[i].ToString(), dashboardPage.GetFormNameinDashboard().Text);
                dashboardPage.UserSelectTheForm(lines[i]);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//button[contains(text(),'Edit form')])[1]")));
                Thread.sleep(5000);
                dashboardPage.ClickEditForm();
                _formDesignerPage.clickSummaryEditPage();
                _editPage.SelectPageTypeDropDown(pageType);
                _editPage.ClickSaveButton();
                Thread.sleep(3000);
                _formDesignerPage.GoToDashboard().Click();
                break;
            }
        }

        [Then(@"user should add a DSI component ""([^""]*)"" and  condition in parent form with ""([^""]*)"" and change page type of Parent form as ""([^""]*)""")]
        public void ThenUserShouldAddADSIComponentAndConditionInParentFormWithAndChangePageTypeOfParentFormAs(string dsiComponent, string ukprn, string pageType)
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            List<string> arrayList = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                arrayList.Add(lines[i].ToString());
                dashboardPage.SearchForForm(lines[i].ToString());
                Assert.AreEqual(lines[i].ToString(), dashboardPage.GetFormNameinDashboard().Text);
                dashboardPage.UserSelectTheForm(lines[i]);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//button[contains(text(),'Edit form')])[1]")));
                dashboardPage.ClickEditForm();
                _formDesignerPage.clickSummaryEditPage();
                _editPage.SelectPageTypeDropDown(pageType);
                _editPage.ClickSaveButton();
                Thread.sleep(3000);
                _formDesignerPage.Clean_component();
                _formDesignerPage.ClickPage01CreateComponentBtn();
                Driver.FindElement(By.XPath("//a[contains(text(),'DSI data access')]")).Click();
                _formDesignerPage.EnterTitle(dsiComponent);
                Thread.sleep(2000);
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                By ele = By.XPath("//button[text()='Save']");
                genericFunctions.ScrollDownToElement(Driver, ele);
                _formDesignerPage.savebutton().Click();
                _editPage.ConditionButton().Click();
                _editPage.addConditionWithCustomText("DSI Condition", dsiComponent, "is", ukprn);
                Thread.sleep(3000);
                genericFunctions.Click(Driver, _formDesignerPage.CloseIcon());
                _formDesignerPage.GoToDashboard().Click();
                break;
            }
        }

        [Then(@"user create parent child relationship between the created forms with condition")]
        public void ThenUserCreateParentChildRelationshipBetweenTheCreatedFormsWithCondition()
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            List<string> arrayList = new List<string>();
            foreach (var line in lines)
            {
                arrayList.Add(line.ToString());
            }
            for (int i = 0; i < arrayList.Count; i++)
            {
                dashboardPage.UserSelectTheForm(arrayList[i]);
                genericFunctions.Scrolldownpage();
                dashboardPage.ClickGroupFormButton();
                parentChildPage.ClickMarkThisAsParentFormCheckbox();
                parentChildPage.EnterDescriptionAndHeading();
                parentChildPage.SelectChildForm(arrayList[i + 1]);
                genericFunctions.Scrolldownpage();
                for (int j = i + 2; j < arrayList.Count; j++)
                {
                    parentChildPage.SelectDepedentForm(arrayList[j]);
                }

                break;
            }
            Thread.sleep(5000);
            parentChildPage.SelectDependentFormStatuses();
            parentChildPage.SelectCondition();
            parentChildPage.ClickAddChildButton();
            parentChildPage.ClickOnGroupFormButton();
            genericFunctions.Scrolldownpage();
            Thread.sleep(3000);
            parentChildPage.ConfirmParentChildGrouping();
        }


        [Then(@"Click on create new form link")]
        public void ThenClickOnCreateNewFormLink()
        {
            dashboardPage.ClickCreateNewFormButton();
        }

        [Then(@"Enter the form name '([^']*)'")]
        public void ThenEnterTheFormName(string formname)
        {
            dashboardPage.FormNameEditBox().SendKeys(formname);
        }
        [Then(@"Click on Next button")]
        public void ThenClickOnNextButton()
        {
            _EnterTitlePage.ClickNextBtnOnFormTitlePage();
        }

        [Then(@"user click on Summary Behaviour button and provide ""([^""]*)"" and ""([^""]*)"" details")]
        public void ThenUserClickOnSummaryBehaviourButtonAndProvideAndDetails(string declaration, string message)
        {
            _formDesignerPage.ClickSummaryBehaviourButton();
            _formDesignerPage.EnterDeclarationAndCustomiseSummaryMessage(declaration, message);
            _formDesignerPage.savebutton().Click();
        }

        [Then(@"user click on edit page of second page")]
        public void ThenUserClickOnEditPageOfSecondPage()
        {
            _formDesignerPage.ClickSecondPageEditBtn();
        }
        [Then(@"user change the page title ""([^""]*)""")]
        [Then(@"user change the page title ""([^""]*)""""")]
        public void ThenUserChangeThePageTitle(string newFormName)
        {
            _formDesignerPage.EditPageTitle(newFormName);
            _formDesignerPage.savebutton().Click();
        }
        [Then(@"verify page title in second page as ""([^""]*)""")]
        [Then(@"verify page title in second page as ""([^""]*)""""")]
        public void ThenVerifyPageTitleInSecondPageAs(string newFormName)
        {
            Assert.AreEqual(Driver.FindElement(By.XPath("//h1[@class='govuk-heading-xl']")).Text, newFormName);
        }

        [Then(@"user click on duplciate page button")]
        public void ThenUserClickOnDuplciatePageButton()
        {
            _formDesignerPage.ClickDuplciateButton();
            //_formDesignerPage.ClickCloseLink();
        }

        [Then(@"validate the newly created page in form designer")]
        public void ThenValidateTheNewlyCreatedPageInFormDesigner()
        {
            int count = _formDesignerPage.VerifyNewDuplicatePage();
            Assert.IsTrue(count == 2);
        }

        [Then(@"user clicks on edit page link of newly created page and deletes the page")]
        public void ThenUserClicksOnEditPageLinkOfNewlyCreatedPageAndDeletesThePage()
        {
            _formDesignerPage.ClickEditPageOfDuplicatePage();
            _formDesignerPage.ClickDeletebutton();
            genericFunctions.ClickAlert();
        }

        [Then(@"the user validates if page is deleted")]
        public void ThenTheUserValidatesIfPageIsDeleted()
        {
            Thread.sleep(7000);
            Assert.IsTrue(_formDesignerPage.VerifyNewDuplicatePage() == 1);
        }


        [Then(@"Verify label '([^']*)'")]
        public void ThenVerifyLabel(string Label)
        {
            Assert.AreEqual(Label, _formDesignerPage.VerifyLabel(Label).Text);

        }

        [Then(@"Verify '([^']*)' in results")]
        public void ThenVerifyInResults(string p0)
        {
            Assert.AreEqual(p0, dashboardPage.Noformsfoundlabel().Text);

        }

        [Then(@"go to Dashboard")]
        public void ThenGoToDashboard()
        {
            _formDesignerPage.GoToDashboard().Click();
        }
        [Then(@"Verify form name '([^']*)'")]
        public void ThenVerifyFormName(string formName)
        {
            By Preview = By.XPath("//a[text()='My forms']");
            genericFunctions.ScrollDownToElement(Driver, Preview);
            string A = dashboardPage.GetFormName().Text;
            Assert.AreEqual(formName, dashboardPage.GetFormName().Text);
            // public IJavaScriptExecutor executor;


        }

        [Then(@"Verify all forms in dashboard")]
        public void ThenVerifyAllFormsInDashboard()
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            List<string> arrayList = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                arrayList.Add(lines[i].ToString());
                dashboardPage.SearchForForm(lines[i].ToString());
                Assert.AreEqual(lines[i].ToString(), dashboardPage.GetFormNameinDashboard().Text);
            }

        }

        [Then(@"user create parent child relationship between the created forms")]
        public void ThenUserCreateParentChildRelationshipBetweenTheCreatedForms()
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            List<string> arrayList = new List<string>();
            foreach (var line in lines)
            {
                arrayList.Add(line.ToString());
            }
            for (int i = 0; i < arrayList.Count; i++)
            {
                dashboardPage.UserSelectTheForm(arrayList[i]);
                genericFunctions.Scrolldownpage();
                dashboardPage.ClickGroupFormButton();
                parentChildPage.ClickMarkThisAsParentFormCheckbox();
                parentChildPage.EnterDescriptionAndHeading();
                genericFunctions.Scrolldownpage();
                parentChildPage.SelectChildForm(arrayList[i + 1]);
                genericFunctions.Scrolldownpage();
                for (int j = i + 2; j < arrayList.Count; j++)
                {
                    parentChildPage.SelectDepedentForm(arrayList[j]);
                }

                break;
            }
            Thread.sleep(5000);
            parentChildPage.SelectDependentFormStatuses();
            parentChildPage.ClickAddChildButton();
            parentChildPage.ClickOnGroupFormButton();
            genericFunctions.Scrolldownpage();
            Thread.sleep(3000);
            parentChildPage.ConfirmParentChildGrouping();
        }

        [Then(@"user update child heading to validate the error message")]
        public void ThenUserUpdateChildHeadingToValidateTheErrorMessage()
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            List<string> arrayList = new List<string>();
            foreach (var line in lines)
            {
                arrayList.Add(line.ToString());
            }
            for (int i = 0; i < arrayList.Count; i++)
            {
                dashboardPage.UserSelectTheForm(arrayList[i]);
                genericFunctions.Scrolldownpage();
                dashboardPage.ClickGroupFormButton();
                parentChildPage.EnterlargeDescriptionAndHeading();
                genericFunctions.Scrolldownpage();
                break;
            }
            Thread.sleep(5000);
            parentChildPage.ClickOnGroupFormButton();
            genericFunctions.Scrolldownpage();
            Thread.sleep(3000);
            parentChildPage.ConfirmParentChildGrouping();
            Assert.AreEqual("Sorry, there is a problem with the service", Driver.FindElement(By.XPath("//h2[@class='govuk-error-summary__title']")).Text);
        }


        [Then(@"Verify the grouped parent child forms in dashboard")]
        public void ThenVerifyTheGroupedParentChildFormsInDashboard()
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                dashboardPage.SearchForForm(line.ToString());
                Assert.AreEqual(line.ToString(), dashboardPage.GetFormNameinDashboard().Text);
                Assert.IsTrue(parentChildPage.checkArrowForParent());
                break;
            }
        }

        [Then(@"user duplicates the parent child forms with new form names")]
        public void ThenUserDuplicatesTheParentChildFormsWithNewFormNames()
        {
            Thread.sleep(7000);
            Driver.Navigate().Refresh();
            Driver.Navigate().Refresh();
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                dashboardPage.UserSelectTheForm(lines[i]);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(dashboardPage.duplicateFormButton));
                dashboardPage.ClickDuplicateFormButton();
                dashboardPage.RenameParentForm(lines[i]);
                dashboardPage.CheckForDuplicate();
                dashboardPage.RenameChildForms(lines);
                genericFunctions.Scrolldownpage();
                dashboardPage.ClickOnDuplicateFormButton();
                break;
            }
        }

        [Then(@"user change switch access type to DFESignIn with ""([^""]*)"" for all the forms in parent group")]
        public void ThenUserChangeSwitchAccessTypeToDFESignInWithForAllTheFormsInParentGroup(string fileName)
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                dashboardPage.UserSelectTheForm(lines[i]);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(text(),'Switch access')]")));
                dashboardPage.ClickSwitchAccessButton().Click();
                dashboardPage.SelectParentAccessTypeCheckbox();
                dashboardPage.SelectDfESignInRadiobtn();
                dashboardPage.UploadCSVFile(fileName);
                genericFunctions.Scrolldownpage();
                dashboardPage.ClickOnSwitchAccessButton();
                dashboardPage.ClickConfirmation();
                break;
            }
        }

        [Then(@"user validates runner of the parent child form")]
        public void ThenUserValidatesRunnerOfTheParentChildForm()
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                dashboardPage.UserSelectTheForm(lines[i]);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                dashboardPage.ClickPreviewLink();
                Thread.sleep(7000);
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                string parentwindow = Driver.WindowHandles[0];
                string childwindow = Driver.WindowHandles[1];
                Driver.SwitchTo().Window(childwindow);
                dashboardPage.EnterUserNamePassword("digitalforms01+1@gmail.com");
                Thread.sleep(7000);
                Driver.FindElement(By.XPath("//button[contains(text(),'Continue')]")).Click();
                Thread.sleep(3000);
                firstpage.ClickContinueBtn();
                Thread.sleep(3000);
                firstpage.ClickContinueBtn();
                IList<IWebElement> firstColumn = Driver.FindElements(By.XPath("//tr[@class='govuk-table__row pc-row']/td[@class='govuk-table__cell pl cell1']"));
                IList<IWebElement> secondColumn = Driver.FindElements(By.XPath("//tr[@class='govuk-table__row pc-row']/td[@class='govuk-table__cell cell2']"));
                for (int j = 1; j < lines.Length; j++)
                {
                    Assert.AreEqual(lines[j].ToString(), firstColumn[j - 1].Text);
                    if (j == 1)
                        Assert.AreEqual(secondColumn[j - 1].Text, "CANNOT START YET");
                    else
                        Assert.AreEqual(secondColumn[j - 1].Text, "NOT STARTED");
                }
                break;
            }
        }

        [Then(@"user change status of parent and child forms to ""([^""]*)""")]
        public void ThenUserChangeStatusOfParentAndChildFormsTo(string status)
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                dashboardPage.UserSelectTheForm(lines[i]);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(text(),'Change status')]")));
                dashboardPage.ClickChangeStatusButton();
                dashboardPage.SelectParentAccessTypeCheckbox();
                genericFunctions.Scrolldownpage();
                dashboardPage.SelectStatus(status);
                dashboardPage.ClickChangeStatusButton();
                dashboardPage.ClickChangeStatusConfirmation();
                break;
            }
        }

        [Then(@"user deletes parent child forms from dashboard")]
        public void ThenUserDeletesParentChildFormsFromDashboard()
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                dashboardPage.UserSelectTheForm(lines[i]);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(text(),'Delete form')]")));
                dashboardPage.ClickDeleteFormButton();
                dashboardPage.SelectParentAccessTypeCheckbox();
                genericFunctions.Scrolldownpage();
                dashboardPage.ClickDeleteFormButton();
                dashboardPage.ClickDeleteFormConfirmation();
                break;
            }
        }

        [Then(@"user deletes duplicate parent child forms from dashboard")]
        public void ThenUserDeletesDuplicateParentChildFormsFromDashboard()
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            for (int i = lines.Length - 1; i < lines.Length; i++)
            {
                dashboardPage.UserSelectTheForm(lines[i]);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(text(),'Delete form')]")));
                dashboardPage.ClickDeleteFormButton();
                dashboardPage.SelectParentAccessTypeCheckbox();
                genericFunctions.Scrolldownpage();
                dashboardPage.ClickDeleteFormButton();
                dashboardPage.ClickDeleteFormConfirmation();
                break;
            }
        }


        [Then(@"Verify ""([^""]*)"" formname")]
        public void ThenVerifyFormname(string formname)
        {
            Assert.AreEqual(formname, dashboardPage.FormName());


        }
        [Then(@"User Search the form ""([^""]*)""")]
        public void ThenUserSearchTheForm(string FormName)
        {
            dashboardPage.SearchForm(FormName);
            dashboardPage.ScrollDownEditForm();
        }


        [Then(@"User Select the form ""([^""]*)""")]
        public void ThenUserSelectTheForm(string FormName)
        {
            Thread.sleep(5000);
            dashboardPage.UserSelectTheForm(FormName);
            Thread.sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.sleep(3000);
        }

        [Then(@"User Select the newly created form from the dashboard")]
        public void ThenUserSelectTheNewlyCreatedFormFromTheDashboard()
        {
            string filePath = b + "\\TestData\\file.txt";
            string formName = File.ReadAllText(filePath);
            dashboardPage.SearchForForm(formName);
            Thread.sleep(5000);
            Driver.FindElement(By.XPath("//*[@class='searchBox']")).Click();
            genericFunctions.Scrolldownpage();
            Thread.sleep(10000);
            dashboardPage.SelectForm();
        }

        [Then(@"User click on '([^']*)'")]
        public void ThenUserClickOn(string p0)
        {
            if (p0.Contains("Duplicate form"))
            {
                dashboardPage.ClickDuplicateForm();
            }
            else
            {
                dashboardPage.ClickChangeFormStatus();
            }
        }


        [Then(@"user change status to ""([^""]*)""")]
        public void ThenUserChangeStatusTo(string Status)
        {
            Thread.sleep(3000);
            if (Status.Equals("UAT"))
            {
                _changeFormStatusPage.SelectRdoBtnUAT();
            }
            else if (Status.Equals("Published"))
            {
                _changeFormStatusPage.SelectRdoBtnPublished();
            }
            else if (Status.Equals("In development"))
            {
                _changeFormStatusPage.SelectRdoBtnDevelopment();
            }
            else if (Status.Equals("Closed"))
            {
                _changeFormStatusPage.SelectRdoBtnClosed();
            }
            _changeFormStatusPage.SelectUpdateFromStatusBtn();
            _changeFormStatusPage.SelectConfirmCheckBoxOnAlert();
            _changeFormStatusPage.ChangeStatus_confirmButton();
            Thread.sleep(5000);
            //  _changeFormStatusPage.ClickBackBtnOnChangeStatusPage();
        }

        [Then(@"Verify the status ""([^""]*)""")]
        public void ThenVerifyTheStatus(string Status)
        {

        }
        [Then(@"Delete the form")]
        public void ThenDeleteTheForm()
        {
            dashboardPage.DeleteTheForm();
            dashboardPage.DeleteTheForm();
            _changeFormStatusPage.SelectConfirmCheckBoxOnAlert();
            // _changeFormStatusPage.SelectContinueBtnOnAlert();
            dashboardPage.ClickDeleteConfirm().Click();
            Thread.sleep(5000);
        }

        [Then(@"Verify the dashboard ""([^""]*)""")]
        public void ThenVerifyTheDashboard(string formName)
        {
            Assert.AreNotEqual(formName, dashboardPage.GetFormName().Text);

        }

        [Then(@"Verify button disabled in dashboard")]
        public void ThenVerifyButtonDisabledInDashboard()
        {
            Thread.sleep(5000);
            //dashboardPage.ScrollDownEditForm();
            Assert.IsTrue(!dashboardPage.EditForm().Enabled);
            Assert.IsTrue(!dashboardPage.DuplicateForm().Enabled);
            Assert.IsTrue(!dashboardPage.ChangeFormStatus().Enabled);
            //  Assert.IsTrue(!dashboardPage.DeleteForm().Enabled);

        }

        [Then(@"Verify button enabled in dashboard")]
        public void ThenVerifyButtonEnabledInDashboard()
        {
            Thread.sleep(3000);
            Assert.IsTrue(dashboardPage.EditForm().Enabled);
            Assert.IsTrue(dashboardPage.DuplicateForm().Enabled);
            Assert.IsTrue(dashboardPage.ChangeFormStatus().Enabled);
            // Assert.IsTrue(dashboardPage.ChangeFormStatus().Enabled);
            // Assert.IsTrue(dashboardPage.DeleteForm().Enabled);
        }



        [Then(@"Scrolldown to Collegues form status")]
        public void ThenScrolldownToColleguesFormStatus()
        {

            Thread.sleep(3000);
            dashboardPage.collegueformlink();
        }
        [Then(@"Select any form in collegues form")]
        public void ThenSelectAnyFormInColleguesForm()
        {
            dashboardPage.WaitForDashboardPageToDisplay();
            dashboardPage.SelectExistingColleaguesFormByStatus("AnyForm");
        }
        [Then(@"Select any form in collegues form in tab")]
        public void ThenSelectAnyFormInColleguesFormInTab()
        {
            dashboardPage.collegueformlink();
            dashboardPage.SelectFIrstItem().Click();
        }

        [Then(@"Verify button enabled in Colleagues dashboard")]
        public void ThenVerifyButtonEnabledInColleaguesDashboard()
        {
            Assert.IsTrue(dashboardPage.EditColleaguesForm().Enabled);
            Assert.IsTrue(dashboardPage.ColleaguesDuplicateForm().Enabled);
            Assert.IsTrue(dashboardPage.ColleaguesFormStatus().Enabled);
            Assert.IsTrue(dashboardPage.ColleaguesAccessTypeBtn().Enabled);
        }

        [Given(@"Navigate to Home page")]
        public void GivenNavigateToHomePage()
        {
            int a = Driver.WindowHandles.Count;
            if (a > 1)
            {
                string parentwindow = Driver.WindowHandles[0];
                string chindwindow = Driver.WindowHandles[1];
                Driver.Close();
                Driver.SwitchTo().Window(parentwindow);
            }
            Driver.Url = BaseTest.urlname;
            Serilog.Log.Debug("Navigated to url ");

        }
        [Then(@"User click on '([^']*)' in my form")]
        public void ThenUserClickOnInMyForm(string p0)
        {
            // dashboardPage.ScrollDownEditForm();
            genericFunctions.Scrolldownpage();
            Thread.sleep(5000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//button[contains(text(),'Edit form')])[1]")));
            dashboardPage.ClickEditForm();
            //dashboardPage.ClickEditForm();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


        }
        [Then(@"Click on preview button")]
        public void ThenClickOnPreviewButton()
        {
            Thread.sleep(3000);
            _formDesignerPage.ClickFirstPagepPreviewBtn();

        }
        [Then(@"Enter the number value '([^']*)' and '([^']*)' and verify '([^']*)' in Hideresult")]
        public void ThenEnterTheNumberValueAndAndVerifyInHideresult(string p0, string p1, string p2)
        {
            genericFunctions.SendKeys(Driver, resultLinkComponent.number1(), p0);
            genericFunctions.SendKeys(Driver, resultLinkComponent.number2(), p1);
            genericFunctions.Click(Driver, resultLinkComponent.number1());
            Thread.sleep(3000);
            string result = genericFunctions.GetText(Driver, resultLinkComponent.Result());
            if (result == null)
            {
                Assert.IsNull(result, "result is hidden on page");
            }
            else
            {
                Assert.IsNull(result, "result is not hidden on page");

            }

        }

        [Then(@"Enter the number value '([^']*)' and '([^']*)' and verify '([^']*)'")]
        public void ThenEnterTheNumberValueAndAndVerify(string p0, string p1, string p2)
        {
            genericFunctions.SendKeys(Driver, resultLinkComponent.number1(), p0);
            genericFunctions.SendKeys(Driver, resultLinkComponent.number2(), p1);
            genericFunctions.Click(Driver, resultLinkComponent.number1());
            Thread.sleep(3000);
            string result = genericFunctions.GetText(Driver, resultLinkComponent.Result());
            int varc = Int32.Parse(p0) + Int32.Parse(p1);
            int varc2 = Int32.Parse(result);
            if (varc == varc2)
            {
                Assert.AreEqual(p2, result, "Result");
            }


        }


        [Then(@"Verify Edited component name '([^']*)' in page")]
        public void ThenVerifyEditedComponentNameInPage(string element)
        {
            By elementxpath = By.XPath("//label[contains(text(),'" + element + "')]");
            genericFunctions.WaitForElement(Driver, elementxpath);
            Assert.IsTrue(Driver.FindElement(By.XPath("//label[contains(text(),'" + element + "')]")).Displayed, element);
        }

        [Then(@"Verify ""([^""]*)"" in page")]
        [Then(@"Verify '([^']*)' in page")]
        public void ThenVerifyInPage(string element)
        {
            By elementxpath = By.XPath("//h1[contains(text(),'" + element + "')]");
            genericFunctions.WaitForElement(Driver, elementxpath);
            Assert.IsTrue(Driver.FindElement(By.XPath("//h1[contains(text(),'" + element + "')]")).Displayed, element);

        }

        [Then(@"Verify ""([^""]*)"" and ""([^""]*)"" in page")]
        public void ThenVerifyAndInPage(string declaration, string message)
        {
            By declarationElement = By.XPath("//label[contains(text(),'" + declaration + "')]");
            By summaryMessageElement = By.XPath("//span[contains(text(),'" + message + "')]");
            genericFunctions.WaitForElement(Driver, declarationElement);
            genericFunctions.WaitForElement(Driver, summaryMessageElement);
            Assert.IsTrue(Driver.FindElement(By.XPath("//label[contains(text(),'" + declaration + "')]")).Displayed, declaration);
            Assert.IsTrue(Driver.FindElement(By.XPath("//span[contains(text(),'" + message + "')]")).Displayed, message);
        }


        [Then(@"Check the page ""([^""]*)""")]
        public void ThenCheckThePage(string Pagename)
        {
            By elementxpath = By.XPath("//h1[@class='govuk-heading-xl']");
            genericFunctions.WaitForElement(Driver, elementxpath);
            Assert.AreEqual(Driver.FindElement(elementxpath).Text, Pagename);

        }
        [Then(@"Check the URL ""([^""]*)""")]
        public void ThenCheckTheLabel(string labelname)
        {
            string Current_url = Driver.Url;
            Assert.AreEqual(Current_url, labelname);
        }
        [Then("Verify component label {string}")]
        public void ThenVerifyComponentLabel(string componentsubtitle)
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//div[contains(text(),'" + componentsubtitle + "')]")).Displayed, componentsubtitle);
        }


        [Then(@"I click on independent special schools subform link")]
        public void ThenIClickOnIndependentSpecialSchoolsSubformLink()
        {
            genericFunctions.Scrolldownpage();
            Driver.FindElement(By.XPath("//a[text()=\"NTP tutoring provided for pupils you've placed in independent special schools\"]")).Click();
        }

        [Then(@"I enter all the details of ""([^""]*)"" schools")]
        public void ThenIEnterAllTheDetailsOfSchools(string noOfSchools)
        {
            Thread.sleep(3000);
            genericFunctions.Scrolldownpage();
            _formDesignerPage.clicksaveandcontinue().Click();
            Driver.FindElement(By.XPath("//input[@value='Yes this is our NTP allocation for pupils in independent special school settings']")).Click();
            _formDesignerPage.clicksaveandcontinue().Click();
            Driver.FindElement(By.XPath("//label[contains(text(),'Yes')][@class='govuk-label govuk-radios__label']")).Click();
            _formDesignerPage.clicksaveandcontinue().Click();
            Driver.FindElement(By.XPath("//input[@type='number']")).Clear();
            Driver.FindElement(By.XPath("//input[@type='number']")).SendKeys(noOfSchools);
            _formDesignerPage.clicksaveandcontinue().Click();
            for (int i = 1; i <= Convert.ToInt32(noOfSchools); i++)
            {
                Random ran = new Random();

                string b = "bcdfghiklmnprstuvwy";
                string random = "a";

                for (int j = 0; j < 1; j++)
                {
                    int a = ran.Next(19);
                    random = random + b.ElementAt(a);
                }
                Driver.FindElement(By.XPath("//input[@role='combobox']")).Click();
                Actions actions = new Actions(Driver);
                actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control);
                actions.Perform();
                actions.SendKeys(Keys.Delete);
                actions.Perform();
                Driver.FindElement(By.XPath("//input[@role='combobox']")).SendKeys(random);
                actions.KeyDown(Keys.ArrowDown).KeyUp(Keys.ArrowDown);
                actions.KeyDown(Keys.Enter).KeyUp(Keys.Enter);
                actions.Perform();
                _formDesignerPage.clicksaveandcontinue().Click();
                Driver.FindElement(By.XPath("//input[@type='text']")).Click();
                Driver.FindElement(By.XPath("//input[@type='text']")).Clear();
                Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("1234");
                _formDesignerPage.clicksaveandcontinue().Click();
            }
            _formDesignerPage.clicksaveandcontinue().Click();
            Driver.FindElement(By.XPath("//input[@type='number']")).Clear();
            Driver.FindElement(By.XPath("//input[@type='number']")).SendKeys("2");
            _formDesignerPage.clicksaveandcontinue().Click();
            Driver.FindElement(By.XPath("//input[@value='Yes we spent NTP funding centrally']")).Click();
            _formDesignerPage.clicksaveandcontinue().Click();
            Driver.FindElement(By.XPath("//input[@type='number']")).Clear();
            Driver.FindElement(By.XPath("//input[@type='number']")).SendKeys("2");
            _formDesignerPage.clicksaveandcontinue().Click();
            Driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("3456");
            _formDesignerPage.clicksaveandcontinue().Click();
            Driver.FindElement(By.XPath("//input[@type='number']")).Clear();
            Driver.FindElement(By.XPath("//input[@type='number']")).SendKeys("2");
            _formDesignerPage.clicksaveandcontinue().Click();
            _formDesignerPage.clicksaveandcontinue().Click();
            Driver.FindElement(By.XPath("//input[@value='the LA has not used the Recovery Premium Grant to fund tutoring provided through the National Tutoring Programme']")).Click();
            _formDesignerPage.clicksaveandcontinue().Click();
            Driver.FindElement(By.XPath("//input[@id=\"email\"]")).Clear();
            Driver.FindElement(By.XPath("//input[@id=\"email\"]")).SendKeys("digitalforms01+41@gmail.com");
            _formDesignerPage.clicksaveandcontinue().Click();
            IList<IWebElement> all = Driver.FindElements(By.XPath("//div[@class=\"govuk-form-group\"]//input[@type=\"checkbox\"]"));
            if (all.Count > 0)
            {
                foreach (IWebElement element in all)
                {
                    if (!element.Selected)
                        element.Click();
                }
            }
            _formDesignerPage.clicksaveandcontinue().Click();

        }

        [Then(@"I Submit the form with given details")]
        public void ThenISubmitTheFormWithGivenDetails()
        {
            Thread.sleep(6000);
            genericFunctions.Scrolldownpage();
            Driver.FindElement(By.XPath("//button[@id='submit-form']")).Click();
        }


        [Then(@"Click on start Now if its displayed")]
        public void ThenClickOnStartNowIfItsDisplayed()
        {
            Thread.sleep(5000);
            try
            {
                genericFunctions.Scrolldownpage();
                if (_formDesignerPage.StartNow().Displayed)
                {
                    _formDesignerPage.StartNow().Click();
                }
            }
            catch (System.Exception e) { }
        }


        [Then(@"Click on start now")]
        public void ThenClickOnStartNow()
        {
            Thread.sleep(5000);
            _formDesignerPage.StartNow().Click();
        }

        [Then(@"Click on Save and continue")]
        public void ThenClickOnSaveAndContinue()
        {
            Thread.sleep(5000);
            try
            {
                _formDesignerPage.clicksaveandcontinue().Click();
            }
            catch (System.Exception e)
            {

                Driver.FindElement(By.XPath("//a[contains(text(),'Save and continue')]")).Click();
            }
        }
        [Then(@"Check the journey ""([^""]*)""")]
        public void ThenCheckTheJourney(string Journey)
        {
            genericFunctions.Scrolldownpage();
            Thread.sleep(2000);

            if (Journey.Equals("YYYYY"))
            {
                Assert.AreEqual("PC_Test_S151_FL_Core", Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_FL_Core']")).Text);
                Assert.AreEqual("PC_Test_S151_FL_TF", Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_FL_TF']")).Text);
                Assert.AreEqual("PC_Test_S151_FL_PPG", Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_FL_PPG']")).Text);
                Assert.AreEqual("PC_Test_S151_FL_PEandS", Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_FL_PEandS']")).Text);
                Assert.AreEqual("PC_Test_S151_Cadet", Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_Cadet']")).Text);
                string Declaration_Text;
                try
                {
                    Declaration_Text = Driver.FindElement(By.XPath("//div[text()='PC_Test_S151_Declaration']")).Text;
                }
                catch (Exception e)
                {
                    Declaration_Text = Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_Declaration']")).Text;

                }
                Assert.AreEqual("PC_Test_S151_Declaration", Declaration_Text);

            }
            if (Journey.Equals("YYYNN"))
            {
                Assert.AreEqual("PC_Test_S151_FL_Core", Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_FL_Core']")).Text);
                Assert.AreEqual("PC_Test_S151_FL_TF", Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_FL_TF']")).Text);
                Assert.AreEqual("PC_Test_S151_FL_PPG", Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_FL_PPG']")).Text);
                string Declaration_Text;
                try
                {
                    Declaration_Text = Driver.FindElement(By.XPath("//div[text()='PC_Test_S151_Declaration']")).Text;
                }
                catch (Exception e)
                {
                    Declaration_Text = Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_Declaration']")).Text;

                }
                Assert.AreEqual("PC_Test_S151_Declaration", Declaration_Text);
                bool PEandS = false;
                try
                {
                    PEandS = Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_FL_PEandS']")).Displayed;
                }
                catch (Exception e)
                {
                }

                if (PEandS)
                {
                    Assert.IsFalse(PEandS, "PC_Test_S151_FL_PEandS form");

                }

                bool Cadet = false;
                try
                {
                    Cadet = Driver.FindElement(By.XPath("//a[text()='PC_Test_S151_Cadet']")).Displayed;
                }
                catch (Exception e)
                {

                }
                if (Cadet)
                {
                    Assert.IsFalse(PEandS, "PC_Test_S151_Cadet form");

                }
            }

        }

        [Then(@"Enter the number value ""([^""]*)""")]
        public void ThenEnterTheNumberValue(string p0)
        {
            _formDesignerPage.NumberEdit().Clear();
            _formDesignerPage.NumberEdit().SendKeys(p0);
            Thread.sleep(3000);
            try
            {
                Driver.FindElement(By.XPath("(//h1)[2]")).Click();
            }
            catch (System.Exception e)
            {

            }
        }


        [Then(@"Click on '([^']*)' Button")]
        public void ThenClickOnButton(string continueB)
        {
            Thread.sleep(3000);
            firstpage.ClickContinueBtn();
            Thread.sleep(3000);

        }

        [Then(@"Click on '([^']*)' Button in first page")]
        public void ThenClickOnButtonInFirstPage(string @continue)
        {
            firstpage.ClickContinu();
        }


        [Then(@"Verify '([^']*)' Button")]
        public void ThenVerifyButton(string element)
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//button[contains(text(),'" + element + "')]")).Displayed, element);

        }

        [Then(@"Verify User able to save the PDF in ""([^""]*)""")]

        public void ThenVerifyUserAbleToSaveThePDF(string formname)
        {
            genericFunctions.Scrolldownpage();
            _summaryPage.pdftosummarybutton().Click();
            Thread.sleep(7000);
            string filename = genericFunctions.GetRecentDownloadedFILE();
            Assert.True(filename.ToLower().Trim().Contains(formname.ToLower().Trim()), filename);

        }


        [Then(@"Click on '([^']*)' button")]
        public void ClickOnButton(string submit)
        {
            runnerPage.Submitbutton().Click();
        }
        [Then(@"Verify submissionid in cosmdb in org ""([^""]*)"" in Prod")]
        public void ThenVerifySubmissionidInCosmdbInOrgInProd(string org)
        {
            string CurrentURL = Driver.Url;
            string[] id = CurrentURL.Split('/');
            string beforeSubmission = CosmosHelper.ReadDataDraftData(id[3] + org, "formDataId");
            runnerPage.Submitbutton().Click();
            string AfterSubmission = CosmosHelper.ReadDataDraftData(id[3] + org, "formDataId");
            string c = _summaryPage.LabelSubmissionID().Text.Trim();
            Assert.AreEqual(_summaryPage.LabelSubmissionID().Text.Trim(), AfterSubmission, "Verification of updated formid in new formsubmission id in cache data");
            string UATResponseData = CosmosHelper.ReadDataProd(AfterSubmission, "formId");
            Assert.AreEqual(id[3], UATResponseData, "Verification of updated formid in new formsubmission id in Response uat container");
            Assert.AreNotEqual(beforeSubmission, AfterSubmission, "Verification of submission ID with existing ID:" + AfterSubmission);

        }

        [Then(@"Verify submissionid in cosmdb in org ""([^""]*)"" in UAT")]
        public void ThenVerifySubmissionidInCosmdb(string org)
        {
            string CurrentURL = Driver.Url;
            string[] id = CurrentURL.Split('/');
            string beforeSubmission = CosmosHelper.ReadDataDraftData(id[3] + org + "UAT", "formDataId");
            runnerPage.Submitbutton().Click();
            string AfterSubmission = CosmosHelper.ReadDataDraftData(id[3] + org + "UAT", "formDataId");
            string c = _summaryPage.LabelSubmissionID().Text.Trim();
            Assert.AreEqual(_summaryPage.LabelSubmissionID().Text.Trim(), AfterSubmission, "Verification of updated formid in new formsubmission id in cache data");
            string UATResponseData = CosmosHelper.ReadDataUAT(AfterSubmission, "formId");
            Assert.AreEqual(id[3], UATResponseData, "Verification of updated formid in new formsubmission id in Response uat container");
            Assert.AreNotEqual(beforeSubmission, AfterSubmission, "Verification of submission ID with existing ID:" + AfterSubmission);

        }




        [Then(@"verify saved data in cosmodb ""([^""]*)"",""([^""]*)"",""([^""]*)"" ,""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)""")]
        public void ThenVerifySavedDataInCosmodb(string autocomplete, string DataImport, string Emailaddress, string multiline, string Number, string Telephonenumber, string text, string UKaddress, string Website, string Radio, string Select, string Checkbox, string YesNo, string Calculation)
        {
            string c = _summaryPage.LabelSubmissionID().Text.Trim();
            string AnswerValue, Title;
            for (int i = 0; i < 15; i++)
            {

                Title = CosmosHelper.ReadDataProd(c, "..questions[2].fields[" + i + "].title");
                AnswerValue = CosmosHelper.ReadDataProd(c, "..questions[2].fields[" + i + "].answer");

                if (Title.Trim().Contains("Autocomplete"))
                {
                    Assert.AreEqual(autocomplete, AnswerValue, "Verification of AnswerValue");
                }
                else if (Title.Trim().Contains("Data Import"))
                {
                    Assert.IsTrue(AnswerValue.Contains(DataImport));
                }
                else if (Title.Contains("Email address"))
                {
                    Assert.AreEqual(r + Emailaddress, AnswerValue, "Verification of Email address");
                }
                else if (Title.Contains("Multiline"))
                {
                    Assert.AreEqual(r + multiline, AnswerValue, "Verification of Multiline");
                }
                else if (Title.Contains("File upload"))
                {
                    Assert.IsTrue(AnswerValue.Contains("Regressionpack_ukprn_(15).pdf"), "File Upload");
                }
                else if (Title.Contains("Number"))
                {
                    Assert.AreEqual(r + Number, AnswerValue, "Verification of Number");
                }
                else if (Title.Contains("Telephone"))
                {
                    Assert.AreEqual(r + Telephonenumber, AnswerValue, "Verification of Number");
                }
                else if (Title.Contains("Text"))
                {
                    Assert.AreEqual(r + text, AnswerValue, "Verification of Number");
                }
                else if (Title.Contains("UK address"))
                {
                    Assert.AreEqual(UKaddress.Substring(0, 5), AnswerValue.Substring(0, 5), "Verification of UKaddress");
                }
                else if (Title.Contains("Website"))
                {
                    Assert.AreEqual(Website + r, AnswerValue, "Verification of Website");
                }
                else if (Title.Contains("Radios"))
                {
                    Assert.AreEqual(Radio, AnswerValue, "Verification of Website");
                }
                else if (Title.Contains("Select"))
                {
                    Assert.AreEqual(Select, AnswerValue, "Verification of Select");
                }
                else if (Title.Contains("Yes"))
                {
                    Assert.AreEqual(YesNo, AnswerValue, "Verification of yesno");
                }
                else if (Title.Contains("Checkboxes"))
                {
                    Assert.IsTrue(AnswerValue.Contains(Checkbox));
                }
                else if (Title.Contains("Calculation"))
                {
                    string calc = r + Number;
                    int cal = int.Parse(calc);
                    double ca = (double)cal;
                    ca = ca / 100;
                    Assert.AreEqual(ca.ToString(), AnswerValue, "Verification of Calculation");
                }



            }

        }


        [Then(@"Verify Cosmodb values '([^']*)' and '([^']*)'")]
        public void ThenVerifyCosmodbValuesAnd(string email, string text)
        {
            string c = _summaryPage.LabelSubmissionID().Text.Trim();
            // string c = "LGkbc8-kKT";
            string AnswerValue, Title;
            for (int i = 0; i < 5; i++)
            {
                Title = CosmosHelper.ReadDataUAT(c, "..questions[1].fields[" + i + "].title");
                AnswerValue = CosmosHelper.ReadDataUAT(c, "..questions[1].fields[" + i + "]..answer");

                if (Title.Contains("Email address"))
                {
                    Assert.AreEqual(email, AnswerValue, "Verification of Email address");
                }

                if (Title.Contains("Text"))
                {
                    Assert.AreEqual(text, AnswerValue, "Verification of Number");
                }
            }
        }


        [Then(@"Click on '([^']*)' button in the summary")]
        public void ThenClickOnButtonInTheSummary(string submit)
        {
            runnerPage.Submitbutton().Click();
        }

        [Then(@"Verify '([^']*)' text")]
        [Then(@"Verify the '([^']*)' file")]
        public void ThenVerifyText(string label)
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//a[contains(text(),'" + label + "')]")).Displayed, label);
        }
        [Then(@"close the runner window")]
        public void ThenCloseTheRunnerWindow()
        {
            string parentwindow = Driver.WindowHandles[0];
            string chindwindow = Driver.WindowHandles[1];
            Driver.Close();
            Driver.SwitchTo().Window(parentwindow);
            //       _formDesignerPage.GoToDashboard().Click();

        }

        [Then(@"Verify UAT environment runner URL")]
        public void ThenVerifyUATEnvironmentRunnerURL()
        {
            Assert.IsTrue((Driver.Url).Contains("uat"));
        }

        [Then(@"Verify prod environment runner URL")]
        public void ThenVerifyProdEnvironmentRunnerURL()
        {
            Assert.IsTrue(!Driver.Url.Contains("uat"), "Prodction");
        }

        [Then(@"Enter to duplicate form")]
        public void ThenEnterToDuplicateForm()
        {
            Random rnd = new Random();
            int num = rnd.Next(1024);
            string formName = "TestForm" + num;
            dashboardPage.ToDuplicateFo(formName);
        }

        [Then(@"Click on duplicate form")]
        public void ThenClickOnDuplicateForm()
        {
            dashboardPage.ClickDuplicateButton();
        }

        [Then(@"create components in first page")]
        public void ThenCreateComponentsInFirstPage(Table table)
        {
            var componentData = table.CreateSet<Summaryvalues>();
            foreach (Summaryvalues data in componentData)
            {
                _formDesignerPage.ClickStartPageCreateComponentBtn();
                Driver.FindElement(By.XPath("//a[contains(text(),'" + data.ComponentName.Trim() + "')]")).Click();
                _formDesignerPage.EnterTitle(data.ComponentValue.Trim());
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                By ele = By.XPath("//button[text()='Save']");
                genericFunctions.ScrollDownToElement(Driver, ele);
                _formDesignerPage.savebutton().Click();
            }
        }

        [Then(@"create components in second page")]
        public void ThenCreateComponentsInSecondPage(Table table)
        {
            var componentData = table.CreateSet<Summaryvalues>();
            foreach (Summaryvalues data in componentData)
            {
                _formDesignerPage.ClickPage01CreateComponentBtn();
                Driver.FindElement(By.XPath("//a[contains(text(),'" + data.ComponentName.Trim() + "')]")).Click();
                _formDesignerPage.EnterTitle(data.ComponentValue.Trim());
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                By ele = By.XPath("//button[text()='Save']");
                genericFunctions.ScrollDownToElement(Driver, ele);
                _formDesignerPage.savebutton().Click();
            }
        }

        [Then(@"Click on create component")]
        public void ThenClickOnCreateComponent()
        {
            _formDesignerPage.Clean_component();
            _formDesignerPage.ClickPage01CreateComponentBtn();

        }

        [Then(@"I click on second page create component link")]
        public void ThenIClickOnSecondPageCreateComponentLink()
        {
            _formDesignerPage.Clean_component();
            _formDesignerPage.ClickPage02CreateComponentBtn();
        }

        [Then(@"remove the calculation component")]
        public void ThenRemoveTheCalculationComponent()
        {
            _formDesignerPage.ClickEditicon();
            genericFunctions.Click(Driver, _formDesignerPage.YesRadiocheckbox());
            _formDesignerPage.ClickDeletebutton();
            string Popup = Driver.FindElement(By.XPath("(//h3)[3]")).Text;
            if (Popup.Contains("Are you sure?"))
            {
                Driver.FindElement(By.XPath("//input[@id='confirm1']")).Click();
                Thread.sleep(2000);
                Driver.FindElement(By.XPath("//button[text()='Continue']")).Click();
                Thread.sleep(2000);
            }
            _formDesignerPage.GoToDashboard().Click();
        }

        [Then(@"Click on add new component")]
        public void ThenClickOnAddNewComponent()
        {
            _formDesignerPage.ClickPage01CreateComponentBtn();
        }

        [Then(@"Verify '([^']*)' component")]
        public void ThenVerifyComponent(string componentName)
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//a[contains(text(),'" + componentName + "')]")).Displayed, componentName);

        }

        [Then(@"select the dataset")]
        public void ThenSelectTheDataset()
        {
            genericFunctions.SelectElementByText(Driver, tableComponentPage.DesignDataset(), "testdata2");
        }

        [Then(@"Click on '([^']*)' link")]
        [Then(@"Click on on the '([^']*)' Component")]
        public void ThenClickOnOnTheComponent(string componentName)
        {
            Driver.FindElement(By.XPath("//a[contains(text(),'" + componentName + "')]")).Click();
        }
        [Then(@"Enter Title '([^']*)' and content '([^']*)'")]
        public void ThenEnterTitleAndContent(string title, string content)
        {
            _formDesignerPage.EnterTitleAndContent(title, content);
        }

        [Then(@"Click on save button")]
        public void ThenClickOnSaveButton()
        {
            Thread.sleep(2000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            By ele = By.XPath("//button[text()='Save']");
            genericFunctions.ScrollDownToElement(Driver, ele);
            _formDesignerPage.savebutton().Click();
        }
        [Then(@"Select the '([^']*)' in dropdown")]
        public void ThenSelectTheInDropdown(string list)
        {
            _formDesignerPage.SelectTheInDropdown(list);
        }

        [Then(@"Verify '([^']*)' in detail link")]
        public void ThenVerifyInDetailLink(string title)
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//span[contains(text(),'" + title + "')]")).Displayed, title);

        }
        [Then(@"clean the component")]
        public void ThenCleanTheComponent()
        {
            try
            {
                Thread.sleep(10000);
                _formDesignerPage.ClickEditicon();
                _formDesignerPage.ClickDeletebutton();
                string Popup = Driver.FindElement(By.XPath("(//h3)[3]")).Text;
                if (Popup.Contains("Are you sure?"))
                {
                    Driver.FindElement(By.XPath("//input[@id='confirm']")).Click();
                    Thread.sleep(2000);
                    Driver.FindElement(By.XPath("//button[text()='Delete component']")).Click();
                    Thread.sleep(2000);
                }
                //  _formDesignerPage.GoToDashboard().Click();
                Thread.sleep(10000);
            }
            catch (Exception e) { }
        }

        [Then(@"Enter Title '([^']*)'")]
        public void ThenEnterTitle(string Title)
        {

            _formDesignerPage.EnterTitle(Title);
        }

        [Then(@"Enter the Title ""([^""]*)""")]
        public void ThenEnterTheTitle(string title)
        {
            _formDesignerPage.EnterTitle(title);
        }

        [Then(@"verify ""([^""]*)"" in summary page")]
        public void ThenVerifyInSummaryPage(string title)
        {
            IWebElement body = Driver.FindElement(By.TagName("body"));
            Assert.IsTrue(body.Text.Contains(title));
        }


        [Then(@"User Select number of sections as ""([^""]*)"" for that component")]
        public void ThenUserSelectNumberOfSectionsAsForThatComponent(string number)
        {
            By select_fields = By.XPath("//select[@class='govuk-select']");
            genericFunctions.SelectElementByText(Driver, select_fields, number);
        }

        [Then(@"User clicks on Generate structure button")]
        public void ThenUserClicksOnGenerateStructureButton()
        {
            _formDesignerPage.ClickGenerateStructureButton();
        }

        [Then(@"User clicks on each block and enters data")]
        public void ThenUserClicksOnEachBlockAndEntersData()
        {
            _formDesignerPage.SelectTabData();
        }

        [Then(@"Enter Add New List ""([^""]*)"" and ""([^""]*)""")]
        public void ThenEnterAddNewListAnd(string ListTitle, string ListValue)
        {
            _formDesignerPage.EnterAddNewList(ListTitle, ListValue);
            Thread.sleep(5000);

        }
        [Then(@"Select the ""([^""]*)""")]
        public void ThenSelectThe(string ListTitle)
        {
            var list = Driver.FindElement(By.XPath("//select[@id='field-options-list']"));
            var seletuklist = new SelectElement(list);
            Thread.sleep(2000);
            seletuklist.SelectByText(ListTitle);
            Thread.sleep(2000);
            Driver.FindElement(By.XPath("//label[text()='Bullets']/parent::div/input")).Click();
            Thread.sleep(2000);
            Driver.FindElement(By.XPath("//button[text()='Save']")).Click();
            Thread.sleep(2000);

        }

        [Then(@"Verify the List values ""([^""]*)""")]
        public void ThenVerifyTheListValues(string ListValue)
        {
            string[] subs = ListValue.Split(',');
            Assert.AreEqual(subs[0], _formDesignerPage.VerifyList(subs[0]).Text.Trim());
            Assert.AreEqual(subs[1], _formDesignerPage.VerifyList(subs[1]).Text.Trim());

        }

        [Then(@"Click on continue button in list")]
        public void ThenClickOnContinueButtonInList()
        {
            _formDesignerPage.ContinueButtonInList();
        }

        [Then(@"Enter multiline text value '([^']*)'")]
        [Then(@"Enter content in HTML content '([^']*)'")]
        public void ThenEnterContentInHTMLContent(string textContent)
        {
            _formDesignerPage.EnterContentInHTMLContent(textContent);
        }

        [Then(@"Verify '([^']*)' in html")]
        public void ThenVerifyInHtml(string textContent)
        {
            if (textContent.Contains("Paragraph"))
            {
                Assert.AreEqual(textContent, Driver.FindElement(By.XPath("(//p)[5]")).Text.Trim());

            }
            else
            {
                Assert.AreEqual(textContent, Driver.FindElement(By.XPath("//button[@id='submit']/preceding::p[1]")).Text.Trim());

            }
        }
        [Then(@"Enter '([^']*)' in autocomplete")]
        [Then(@"Enter Website value '([^']*)'")]
        [Then(@"Enter time value '([^']*)'")]
        [Then(@"Enter text value '([^']*)'")]
        [Then(@"Enter telephone number '([^']*)'")]
        [Then(@"Enter '([^']*)' in date")]
        [Then(@"Enter ""([^""]*)"" in autocomplete")]

        public void ThenEnterInAutocomplete(string itemvalue)
        {
            _formDesignerPage.EnterInAutocomple(itemvalue);
            //  firstpage.ClickContinueBtn();

        }
        [Then(@"Verify '([^']*)' in title")]
        public void ThenVerifyInTitle(string autocomplete)
        {
            Assert.AreEqual(autocomplete, _formDesignerPage.VerifyInTitle().Text.Trim());
        }


        [Then(@"Enter Title '([^']*)' in import document")]
        public void ThenEnterTitleInImportDocument(string testDocument)
        {

            _formDesignerPage.Entertitlefiledownload(testDocument);
        }

        [Then(@"User click on button '([^']*)'")]
        public void ThenUserClickOnButton(string p0)
        {

            Driver.FindElement(By.XPath("//button[text()='" + p0 + "']")).Click();
        }
        [Then(@"Upload backup file '([^']*)'")]
        public void ThenUploadBackupFile(string filename)
        {

            string fileName = b + "\\TestData\\" + filename;
            Driver.FindElement(By.XPath("//input[@class='govuk-file-upload']")).SendKeys(fileName);
            Driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(fileName);
            //  _formDesignerPage.SaveButton1_1();

        }

        [Then(@"Upload the file '([^']*)'")]
        public void ThenUploadTheFile(string filename)
        {
            string workingdirectory = Environment.CurrentDirectory;
            var projectdirectory = Directory.GetParent(workingdirectory).Parent.Parent.FullName;
            string b = projectdirectory.ToString();
            string fileName = b + "\\TestData\\" + filename;
            Driver.FindElement(By.XPath("(//input[@type='file'])[2]")).SendKeys(fileName);
            _formDesignerPage.SaveButton1_1();
        }
        [Then(@"Upload the file '([^']*)' the Fileupload component")]
        public void ThenUploadTheFileTheFileuploadComponent(string filename)
        {
            string workingdirectory = Environment.CurrentDirectory;
            var projectdirectory = Directory.GetParent(workingdirectory).Parent.Parent.FullName;
            string b = projectdirectory.ToString();
            string fileName = b + "\\TestData\\" + filename;
            Driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(fileName);
        }

        [Then(@"import the document '([^']*)'")]
        public void ThenImportTheDocument(string filename)
        {
            string workingdirectory = Environment.CurrentDirectory;
            var projectdirectory = Directory.GetParent(workingdirectory).Parent.Parent.FullName;
            string b = projectdirectory.ToString();
            string fileName = b + "\\TestData\\" + filename;
            Driver.FindElement(By.XPath("//input[@type='file'][@id='document-upload']")).SendKeys(fileName);
            _formDesignerPage.SaveButton1_1();
        }

        [Then(@"Validate the file and messages")]
        public void ThenValidateTheFileAndMessages()
        {
            Thread.sleep(25000);
            genericFunctions.Click(Driver, _dataimport.ValidateFile());
            Thread.sleep(25000);
            Assert.AreEqual(genericFunctions.GetText(Driver, _formDesignerPage.SuccessCheck()), "Your file was successfully selected and all checks are done");
            Assert.AreEqual(genericFunctions.GetText(Driver, _formDesignerPage.SuccessCheck1()), "No virus found");
            Assert.AreEqual(genericFunctions.GetText(Driver, _formDesignerPage.SuccessCheck2()), "All the columns are available");
            Assert.AreEqual(genericFunctions.GetText(Driver, _formDesignerPage.SuccessCheck3()), "No missing data found");
            Assert.AreEqual(genericFunctions.GetText(Driver, _formDesignerPage.SuccessCheck4()), "Data validation completed");


        }

        [Then(@"Verify the file size error message")]
        public void ThenVerifyTheFileSizeErrorMessage()
        {
            Thread.sleep(10000);
            Assert.IsTrue(_formDesignerPage.fileMoreThan10MB.Text.Equals("The file must be smaller than 10MB"));
        }

        [Then(@"select '([^']*)' document")]
        public void ThenSelectDocument(string document)
        {
            Thread.sleep(2000);
            genericFunctions.Scrolldownpage();
            Thread.sleep(5000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _formDesignerPage.SelectDocument(document);
        }

        [Then(@"select '([^']*)' document in Data import")]
        public void ThenSelectDocumentInDataImport(string dataDocument)
        {
            Thread.sleep(3000);
            _dataimport.SelectDocumentInDataImport(dataDocument);
            Thread.sleep(3000);
            _dataimport.SelectDocumentInDataImport(dataDocument);

        }


        [Then(@"Enter Date value in ""([^""]*)""")]
        public void ThenEnterDateValueIn(string datevalue)
        {
            string[] datesplit = datevalue.Split('-');
            if (datesplit.Length == 2)
            {
                _formDesignerPage.EnterMonth(datesplit[0]);
                _formDesignerPage.EnterYear(datesplit[1]);
            }
            else
            {
                _formDesignerPage.EnterDay(datesplit[0]);
                _formDesignerPage.EnterMonth(datesplit[1]);
                _formDesignerPage.EnterYear(datesplit[2]);
                if (datesplit.Length > 3)
                {
                    _formDesignerPage.EnterHour(datesplit[3]);
                    _formDesignerPage.EnterMinute(datesplit[4]);
                }
            }
        }

        [Then(@"Enter email ""([^""]*)""")]
        public void ThenEnterEmail(string email)
        {
            _formDesignerPage.EnterEmail(email);
        }

        [Then(@"Enter UK Address '([^']*)'")]
        public void ThenEnterUKAddress(string address)
        {
            string[] addressplit = address.Split(',');
            _formDesignerPage.EnterAddressLine1EditBox(addressplit[0]);
            _formDesignerPage.EnterAddressLine2EditBox(addressplit[1]);
            _formDesignerPage.EnterTownLine2EditBox(addressplit[2]);
            _formDesignerPage.EnterPostCodeEditBox(addressplit[3]);

        }

        [Then(@"Click on Design Data set")]
        public void ThenClickOnDesignDataSet()
        {
            tableComponentPage.ClickDesignDataSetButton();
        }

        [Then(@"Click on Design Data set link")]
        public void ThenClickOnDesignDataSetLink()
        {
            tableComponentPage.ClickDesignDataSetButton1();
        }
        [Then(@"Design Data Set from (.*) to (.*) in data table ""([^""]*)""")]
        public void ThenDesignDataSetFromToInDataTable(int columns, int rows, string p2)
        {
            tableComponentPage.DesignDataSetFromToInDataTable1(columns, rows, p2);

        }

        [Then(@"Wait for file to upload")]
        public void ThenWaitForFileToUpload()
        {
            _formDesignerPage.WaitForFileToUpload();
        }
        [Then(@"Click on Import Data set ""([^""]*)""")]
        public void ThenClickOnImportDataSet(string dataSetName)
        {
            tableComponentPage.ClickImportDataset(dataSetName);

        }
        [Then(@"Click on Import Data set")]
        public void ThenClickOnImportDataSet()
        {
            genericFunctions.Click(Driver, _formDesignerPage.Importdataset());
        }

        [Then(@"upload the '([^']*)' for import dataset")]
        public void ThenUploadTheForImportDataset(string file)
        {
            tableComponentPage.importdataset(file);

        }
        [Then(@"close the button")]
        public void ThenCloseTheButton()
        {
            Driver.FindElement(By.XPath("//a[text()='Close']")).Click();

        }

        [Then(@"Click on prod link in dashboard in ""([^""]*)""")]
        public void ThenClickOnProdLinkInDashboardIn(string formname)
        {
            Thread.sleep(7000);
            Driver.FindElement(By.XPath("((//span[contains(text(),'" + formname + "')])[1]/following::a[text()='Prod'])[1]")).Click();
            Thread.sleep(7000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            string parentwindow = Driver.WindowHandles[0];
            string chindwindow = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(chindwindow);
        }
        [Then(@"Click on test link in dashboard in Latest form")]
        public void ThenClickOnTestLinkInDashboardInLatestForm()
        {

            string filePath = b + "\\TestData\\file.txt";
            string formName = File.ReadAllText(filePath);
            Thread.sleep(7000);
            Driver.FindElement(By.XPath("((//span[text()='" + formName + "'])[1]/following::a[text()='Test'])[1]")).Click();
            Thread.sleep(7000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            string parentwindow = Driver.WindowHandles[0];
            string chindwindow = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(chindwindow);
        }


        [Then(@"Click on test link in dashboard in ""([^""]*)""")]
        public void ThenClickOnTestLinkInDashboardIn(string formname)
        {
            Thread.sleep(7000);
            Driver.FindElement(By.XPath("((//span[text()='" + formname + "'])[1]/following::a[text()='Test'])[1]")).Click();
            Thread.sleep(7000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            string parentwindow = Driver.WindowHandles[0];
            string chindwindow = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(chindwindow);
        }

        [Then(@"Enter ""([^""]*)"" and ""([^""]*)"" and select the ""([^""]*)"" in ""([^""]*)""")]
        public void ThenEnterAndAndSelectTheIn(string dFEUserName, string password, string dfesign, string org)
        {
            string Page_Title = Driver.FindElement(By.XPath("(//h1)[1]")).Text;
            if (Page_Title.Trim().Equals("Access the DfE Sign-in service"))
            {
                dashboardPage.EnterUserNamePassword(dFEUserName);
            }
            Thread.sleep(15000);
            string Page_Title1 = Driver.FindElement(By.XPath("(//h1)[1]")).Text;
            if (org.Trim().Contains("Authority"))
            {
                Driver.FindElement(By.XPath("//span[contains(text(),'" + org + "')]")).Click();
                genericFunctions.Scrolldownpage();
                Thread.sleep(5000);
                genericFunctions.Clickwebelement(Driver, "//input[@type='submit']");
            }
            else
            {
                if (Page_Title1.Trim().Equals("Select your organisation"))
                {

                    dashboardPage.ChooseDFEandOrg(dfesign, org);
                }
            }
        }

        [Then(@"verify Organization  ""([^""]*)"" and ""([^""]*)"" in your detail page")]
        public void ThenVerifyOrganizationAndInYourDetailPage(string Org, string formname)
        {
            // Assert.IsTrue(_yourDetailPage.UKPRNValue().Text.Trim().Contains(Org));
            //Assert.AreEqual(formname, _yourDetailPage.YourTitle().Text.Trim());
            Thread.sleep(20000);
            if (Driver.FindElement(By.XPath("(//div[@class='govuk-body']/div)[1]")).Text.Equals("Your details"))
            {
                _yourDetailPage.Continue().Click();
            }
            // formDesignerPage.clicksaveandcontinue().Click();


        }

        [Then(@"Verify '([^']*)' in label")]
        public void ThenVerifyInLabel(string label)
        {
            Assert.AreEqual(label, dashboardPage.VerifyLabel().Text.Trim());

        }


        [Then(@"Select '([^']*)' in '([^']*)' with helptext '([^']*)' in ""([^""]*)""")]
        public void ThenSelectIn(string field, string Checkboxcompoent, string Checkboxhelptext, string org)
        {
            //   Assert.AreEqual(Checkboxcompoent, _summaryPage.LabelCheckboxtitle().Text.Trim());
            //  Assert.AreEqual(Checkboxhelptext, _summaryPage.LabelCheckboxhelptext(Checkboxhelptext).Text.Trim());
            By select_fields = By.XPath("//select[@class='govuk-select']");
            genericFunctions.SelectElementByText(Driver, select_fields, field);



        }
        [Then(@"Select '([^']*)' in selectbox")]
        public void ThenSelectInSelectbox(string field)
        {
            By select_fields = By.XPath("//select[@class='govuk-select']");
            genericFunctions.SelectElementByText(Driver, select_fields, field);

        }


        [Then(@"Verify component name '([^']*)' and value '([^']*)'")]
        public void ThenVerifyComponentNameAndValue(string compoentName, string compoentValue)
        {
            Assert.AreEqual(compoentName, _summaryPage.VerifyComponentName().Text.Trim());
            Assert.AreEqual(compoentValue, _summaryPage.VerifyComponentValue().Text.Trim());

        }
        [Then(@"Check Footer ""([^""]*)"" and URL ""([^""]*)""")]
        public void ThenCheckFooterAndURL(string name, string link)
        {
            string text = Driver.FindElement(By.XPath("//a[contains(text(),'" + name + "')]")).GetAttribute("href");
            Assert.IsTrue(text.Contains(link));


        }

        [Then(@"Check Footer link '([^']*)' section")]
        public void ThenCheckFooterLinkSection(string footersection)
        {
            Console.WriteLine("testing writeline");
            Console.WriteLine("testing writeline1");

            Thread.sleep(5000);
            genericFunctions.Scrolldownpage();
            Thread.sleep(5000);
            if (footersection.Contains("Information guide"))
            {
                Assert.AreEqual("Introductory videos", dashboardPage.LinkIntroductoryvideos().Text.Trim());
            }
            else if (footersection.Contains("Support shortcuts"))
            {
                Assert.AreEqual("Contacts", dashboardPage.LinkContacts().Text.Trim());
                Assert.AreEqual("Wishlist", dashboardPage.LinkWishList().Text.Trim());
                Assert.AreEqual("Submit a bug", dashboardPage.LinkSubmitBug().Text.Trim());

            }
            else
            {

                Assert.AreEqual("All content is available under the Open Government Licence v3.0, except where otherwise stated", dashboardPage.LabelContentDesc().Text.Trim());
                Assert.AreEqual("© Crown copyright", dashboardPage.LinkCopyright().Text.Trim());

            }
        }



        [Then(@"verify '([^']*)' in Detail component")]
        public void ThenVerifyInDetailComponent(string value)
        {
            Assert.AreEqual("Detail component", dashboardPage.Detail_link().Text.Trim());


        }

        [Then(@"Verify condition button in form")]
        public void ThenVerifyConditionButtonInForm()
        {
            Assert.AreEqual("Conditions", _editPage.ConditionButton().Text.Trim());

        }
        [Then(@"Select '([^']*)' in checkbox")]
        public void ThenSelectInCheckbox(string item)
        {
            By Select_Item = By.XPath("//label[contains(text(),'" + item + "')]");
            genericFunctions.Click(Driver, Select_Item);

        }

        [Then(@"Select '([^']*)' in yes no buttons")]
        public void ThenSelectInYesNoButtons(string yesno)
        {
            By yesno_Item = By.XPath("//label[@class='govuk-label govuk-radios__label'][contains(text(),'" + yesno + "')]");
            genericFunctions.Click(Driver, yesno_Item);
        }

        [Then(@"Verify the form status '([^']*)'")]
        public void ThenVerifyTheFormStatus(string status)
        {
            Thread.sleep(3000);
            genericFunctions.Scrolldownpage();
            Thread.sleep(8000);
            By Element = By.XPath("(//tbody[@class='govuk-table__body']/tr/td[5])[1]/div");
            Assert.AreEqual(genericFunctions.GetText(Driver, Element), status);
        }


        [Then(@"User Click on switch access and change to dfesignin")]
        public void ThenUserClickOnSwitchAccessAndChangeToDfesignin()
        {
            Thread.sleep(5000);
            genericFunctions.Scrolldownpage();
            Thread.sleep(3000);
            dashboardPage.ClickSwitchAccessButton().Click();
            dashboardPage.SelectDfESignInRadiobtn();
            dashboardPage.UploadCSVFile("ukprnalone.csv");
            genericFunctions.Scrolldownpage();
            dashboardPage.ClickOnSwitchAccessButton();
            Thread.sleep(3000);
            _changeFormStatusPage.SelectConfirmCheckBoxOnAlert();
            dashboardPage.SwitcAccessconfirm();
            // _changeFormStatusPage.ClickBackBtnOnChangeStatusPage();



        }

        [Then(@"User Click on switch access and change to dfesignin with file""([^""]*)""")]
        public void ThenUserClickOnSwitchAccessAndChangeToDfesigninWithFile(string file)
        {
            genericFunctions.Scrolldownpage();
            Thread.sleep(3000);
            dashboardPage.ClickSwitchAccessButton().Click();
            dashboardPage.SelectDfESignInRadiobtn();
            dashboardPage.UploadCSVFile(file);
            genericFunctions.Scrolldownpage();
            dashboardPage.ClickOnSwitchAccessButton();
            Thread.sleep(3000);
            _changeFormStatusPage.SelectConfirmCheckBoxOnAlert();
            dashboardPage.SwitcAccessconfirm();
        }

        [Then(@"user validates runner of the form for error message for user ""([^""]*)""")]
        public void ThenUserValidatesRunnerOfTheFormForErrorMessageForUser(string userName)
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                dashboardPage.UserSelectTheForm(lines[i]);
                Thread.sleep(4000);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                dashboardPage.ClickProdLink();
                Thread.sleep(7000);
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                string parentwindow = Driver.WindowHandles[0];
                string childwindow = Driver.WindowHandles[1];
                Driver.SwitchTo().Window(childwindow);
                dashboardPage.EnterUserNamePassword(userName);
                Thread.sleep(7000);
                if (userName == "digitalforms01+103@gmail.com")
                    Assert.AreEqual("Your account needs approving before you can access this form. We will email you when it is ready.", Driver.FindElement(By.XPath("//h1[@class='govuk-heading-xl']")).Text);
                else if (userName == "digitalforms01+102@gmail.com")
                    Assert.AreEqual("Christ The King Catholic School, Amesbury (UKPRN 10092115) does not have access to this form", Driver.FindElement(By.XPath("//h1[@class='govuk-heading-xl']")).Text);
                break;
            }
            try
            {
                genericFunctions.Click(Driver, _summaryPage.SignoutLink());
                genericFunctions.Click(Driver, _summaryPage.ConfirmSelectionBox());
                genericFunctions.Click(Driver, _summaryPage.SignoutButton());
            }
            catch (Exception e) { }
        }

        [Then(@"user validates runner of the form for error message for user ""([^""]*)"" with UKPRN as ""([^""]*)""")]
        public void ThenUserValidatesRunnerOfTheFormForErrorMessageForUserWithUKPRNAs(string userName, string ukprn)
        {
            string filePath = b + "\\TestData\\file.txt";
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                dashboardPage.UserSelectTheForm(lines[i]);
                genericFunctions.Scrolldownpage();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                dashboardPage.ClickProdLink();
                Thread.sleep(7000);
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                string parentwindow = Driver.WindowHandles[0];
                string childwindow = Driver.WindowHandles[1];
                Driver.SwitchTo().Window(childwindow);
                dashboardPage.EnterUserNamePassword(userName);
                Thread.sleep(4000);
                dashboardPage.ChooseDFEandOrg("UKPRN", ukprn);
                Thread.sleep(7000);
                Assert.AreEqual("Hargrave Park Primary School (UKPRN 10078001) does not have access to this form", Driver.FindElement(By.XPath("//h1[@class='govuk-heading-xl']")).Text);
                break;
            }
        }


        [Then(@"User Click on switch access and change to public")]
        public void ThenUserClickOnSwitchAccessAndChangeToPublic()
        {
            Thread.sleep(5000);
            dashboardPage.colleguesFormeditform().Click();
            dashboardPage.PublicCheckboxClick();
            genericFunctions.Scrolldownpage();
            Thread.sleep(5000);
            dashboardPage.colleguesFormeditform().Click();
            _changeFormStatusPage.SelectConfirmCheckBoxOnAlert();
            dashboardPage.SwitcAccessconfirm();
        }
        [Then(@"Make component is optional")]
        public void ThenMakeComponentIsOptional()
        {
            _dataimport.ClickOptional().Click();
        }
        [Then(@"User click on Edit component")]
        public void ThenUserClickOnEditComponent()
        {

            _formDesignerPage.ClickEditicon();

        }
        [Then(@"Click on Condition button and verify Add or edit condition")]
        public void ThenClickOnConditionButtonAndVerifyAddOrEditCondition()
        {
            _editPage.ConditionButton().Click();
            Assert.AreEqual("Add or edit condition", _editPage.Addoreditcondition().Text.Trim());

        }

        [Then(@"Delete ""([^""]*)"" in condition")]
        public void ThenDeleteInCondition(string condition)
        {
            _editPage.Conditionvalue().Click();
            _editPage.ClickOnDelete();

        }

        [Then(@"verify ""([^""]*)"" in condition")]
        public void ThenVerifyInCondition(string condition)
        {
            Assert.AreEqual(condition, _editPage.Conditionvalue().Text.Trim());
        }

        [Then(@"Add condition value ""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)""")]
        public void ThenAddConditionValue(string DisplayName, string Componentname, string condition, string value)
        {

            _editPage.ConditionValue(DisplayName, Componentname, condition, value);
        }

        [Then(@"Add condition wiht import dataset ""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)""")]
        public void ThenAddConditionWihtImportDataset(string DisplayName, string uKPRN, string condition, string conditionList)
        {
            _editPage.ImportDataSetWithCondition(DisplayName, uKPRN, condition, conditionList);
        }
        [Then(@"Check the file uploaded file")]
        public void ThenCheckTheFileUploadedFile()
        {
            string fromapp = Driver.FindElement(By.XPath("(//dt[contains(text(),'File upload component')])[1]/following-sibling::dd[1]")).Text.Trim();
            Assert.AreEqual(randomfilename, fromapp, "File name ");
        }


        [Then(@"Verify Summary page with optinal fields")]
        public void ThenVerifySummaryPageWithOptinalFields(Table table)
        {
            Thread.sleep(5000);
            genericFunctions.Scrolldownpage();
            var Summaryvaluesdata = table.CreateSet<Summaryvalues>();
            foreach (Summaryvalues data in Summaryvaluesdata)
            {
                By element = By.XPath("(//dt[contains(text(),'" + data.ComponentName.Trim() + "')])[1]");
                genericFunctions.ScrollDownToElement(Driver, element);
                string fromapp = Driver.FindElement(By.XPath("(//dt[contains(text(),'" + data.ComponentName.Trim() + "')])[1]/following-sibling::dd[1]")).Text.Trim();
                string fromdata = data.ComponentValue.Trim();
                Assert.AreEqual(data.ComponentValue.Trim(), Driver.FindElement(By.XPath("(//dt[contains(text(),'" + data.ComponentName.Trim() + "')])[1]/following-sibling::dd[1]")).Text.Trim(), data.ComponentName.Trim(), data.ComponentName.Trim());

            }
            genericFunctions.Scrolldownpage();
        }

        [Then(@"User Select ColumnName and ColumnType")]
        public void ThenIHaveAMusicCollection(Table table)
        {
            Thread.sleep(5000);
            var DataImportTable = table.CreateSet<DataImportschema>();
            foreach (DataImportschema DataItem in DataImportTable)
            {
                Thread.sleep(3000);
                _dataimport.UserSelect(DataItem.Name.Trim(), DataItem.Type.Trim());
                if (DataItem.Type.Equals("Date"))
                {
                    _dataimport.Max_Feature_Days(DataItem.Maxdays_Past, DataItem.Maxdays_Future);
                }
                else if (DataItem.Type.Equals("Text"))
                {
                    _dataimport.Max_Length(DataItem.Maxlength.Trim());
                }
                else if (DataItem.Type.Equals("Number"))
                {
                    _dataimport.EnterNumberSchema(DataItem.Min.Trim(), DataItem.Max.Trim(), DataItem.Precision.Trim());

                }
                _dataimport.Click_Add();
            }

        }
        [Then(@"Enter all the fields in page ""([^""]*)"" ,""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)""")]
        public void ThenEnterAllTheFieldsInPage(string Emailaddress, string multiline, string Number, string Telephonenumber, string text, string UKaddress, string Website)
        {

            string a = r.ToString();
            genericFunctions.ScrollDownToElement(Driver, _formDesignerPage.EnterEmailement());
            _formDesignerPage.EnterEmailement();
            _formDesignerPage.EnterEmail(r + Emailaddress);
            _formDesignerPage.EnterContentInHTMLContent(r + multiline);
            genericFunctions.ScrollDownToElement(Driver, _formDesignerPage.NumberComponentelement());
            genericFunctions.SendKeys(Driver, _formDesignerPage.NumberComponentelement(), r + Number);
            genericFunctions.ScrollDownToElement(Driver, _formDesignerPage.Telephonecomponentelement());
            genericFunctions.SendKeys(Driver, _formDesignerPage.Telephonecomponentelement(), r + Telephonenumber);
            genericFunctions.ScrollDownToElement(Driver, _formDesignerPage.textcomponentelement());
            genericFunctions.SendKeys(Driver, _formDesignerPage.textcomponentelement(), r + text);
            ThenEnterUKAddress(UKaddress);
            genericFunctions.ScrollDownToElement(Driver, _formDesignerPage.Websitecomponentelement());
            genericFunctions.SendKeys(Driver, _formDesignerPage.Websitecomponentelement(), Website + r);
            // genericFunctions.Click(Driver, _formDesignerPage.radiocomponentelement("Mandatory Fields"));
            By select_fields = By.XPath("//select[@class='govuk-select']");
            genericFunctions.SelectElementByText(Driver, select_fields, "Mandatory Fields");
            // genericFunctions.Click(Driver, _formDesignerPage.checkboxcomponentelement("Mandatory Fields"));

        }



        [Then(@"Check all component in '([^']*)' page ""([^""]*)""")]
        public void ThenCheckAllComponentInPage(string optionalFields, string org)
        {
            // Assert.AreEqual("Optional section", Driver.FindElement(By.XPath("//h2[text()='Optional section']")).Text.Trim(), "Optional section");
            Assert.AreEqual("OptionalFields", Driver.FindElement(By.XPath("//h1[contains(text(),'OptionalFields')]")).Text.Trim());
            Assert.AreEqual("Details component", Driver.FindElement(By.XPath("//span[contains(text(),'Details component')]")).Text.Trim());
            Assert.AreEqual("File download component", Driver.FindElement(By.XPath("//label[contains(text(),'File download component')]")).Text.Trim(), "File download component title");
            Assert.AreEqual("File download component Help text (optional)", Driver.FindElement(By.XPath("//div[contains(text(),'File download component Help text (optional)')]")).Text.Trim(), "File download component help text");
            Assert.AreEqual("HTMLcomponent", Driver.FindElement(By.XPath("//strong[text()='HTMLcomponent']")).Text.Trim(), "HTMLcomponent");
            Assert.AreEqual("Inset text component", Driver.FindElement(By.XPath("//p[text()='Inset text component']")).Text.Trim(), "Inset text component");
            Assert.AreEqual("List component", Driver.FindElement(By.XPath("//label[contains(text(),'List component')]")).Text.Trim(), "List component");
            Assert.AreEqual("Mandatory Fields", Driver.FindElement(By.XPath("//li[text()='Mandatory Fields']")).Text.Trim(), "List component value -Mandatory Fields");
            Assert.AreEqual("Optional Fields", Driver.FindElement(By.XPath("//li[text()='Optional Fields']")).Text.Trim(), "List component value -Mandatory Fields");
            Assert.AreEqual("Mixed Fields", Driver.FindElement(By.XPath("//li[text()='Mixed Fields']")).Text.Trim(), "List component value -Mandatory Fields");
            Assert.AreEqual("Paragraph component Enter the text you want to show. You can apply basic HTML, such as text formatting and hyperlinks.", Driver.FindElement(By.XPath("//p[contains(text(),'Paragraph component')]")).Text.Trim(), "List component value -Mandatory Fields");
            By Autocomplete = By.XPath("//label[contains(text(),'Autocomplete component (Optional)')]");
            genericFunctions.ScrollDownToElement(Driver, Autocomplete);
            Assert.AreEqual("Table component", Driver.FindElement(By.XPath("//label[contains(text(),'Table component')]")).Text.Trim(), "List component value -Mandatory Fields");
            Assert.AreEqual("Table component", Driver.FindElement(By.XPath("//label[contains(text(),'Table component')]")).Text.Trim(), "Table component");
            Assert.AreEqual("Table component Help text (optional)", Driver.FindElement(By.XPath("//div[contains(text(),'Table component')]")).Text.Trim(), "List component value -Mandatory Fields");
            //input[@type='file']
            Random rnd = new Random();
            string filevalue = rnd.Next(1, 6).ToString();
            if (filevalue == "1")
            {
                randomfilename = "conditionImport.csv";
            }
            else if (filevalue == "2")
            {
                randomfilename = "Data.xlsx";

            }
            else if (filevalue == "3")
            {
                randomfilename = "Dataset examplesUKPRN test.csv";

            }
            else if (filevalue == "4")
            {
                randomfilename = "Datasetexamples.csv";

            }
            else if (filevalue == "5")
            {
                randomfilename = "ListItems.csv";

            }
            else if (filevalue == "6")
            {
                randomfilename = "ukprnalone.csv";

            }
            string workingdirectory = Environment.CurrentDirectory;
            var projectdirectory = Directory.GetParent(workingdirectory).Parent.Parent.FullName;
            string b = projectdirectory.ToString();
            string fileName = b + "\\TestData\\" + randomfilename;
            Driver.FindElement(By.XPath("(//input[@type='file'])[2]")).SendKeys(fileName);
            Thread.sleep(15000);
            genericFunctions.Scrolldownpage();
        }


        [Then(@"Click on close button")]
        public void ThenClickOnCloseButton()
        {
            Thread.sleep(5000);
            genericFunctions.Click(Driver, _formDesignerPage.CloseIcon());

        }
        [Then(@"Enter Add New List ""([^""]*)""")]
        public void ThenEnterAddNewList(string listTitle)
        {
            _formDesignerPage.AddListTitle(listTitle);
        }

        [Then(@"Click on List")]
        public void ThenClickOnList()
        {
            genericFunctions.Click(Driver, _formDesignerPage.Listicon());
        }
        [Then(@"Edit the List ""([^""]*)""")]
        public void ThenEditTheList(string ListTitle)
        {
            genericFunctions.Click(Driver, _formDesignerPage.ListCheckBoxEdit(ListTitle));
        }
        [Then(@"Click on edit icon")]
        public void ThenClickOnEditIcon()
        {
            genericFunctions.Click(Driver, _formDesignerPage.EditList());
        }
        [Then(@"Click on delete icon")]
        public void ThenClickOnDeleteIcon()
        {
            genericFunctions.Click(Driver, _formDesignerPage.DelteList());
            genericFunctions.Click(Driver, _formDesignerPage.CheckboxAlert());
            genericFunctions.Click(Driver, _formDesignerPage.DelteList());
        }

        [Then(@"Verify The value in list ""([^""]*)""")]
        public void ThenVerifyTheValueInList(string ListTitle)
        {
            var listvalue = Driver.FindElements(By.XPath("//p[@class='list-table-cell govuk-!-margin-0']"));
            Console.WriteLine(listvalue.Count);
            int i;
            for (i = 1; i < listvalue.Count; i += 4)
            {
                string a = Driver.FindElement(By.XPath("//p[@class='list-table-cell govuk-!-margin-0']/span[" + i + "]")).Text;
            }
        }


        [Then(@"Select DataSet ""([^""]*)""")]
        public void ThenSelectDataSet(string dataList)
        {

            genericFunctions.SelectElementByText(Driver, _formDesignerPage.Selectdropdown(), dataList);
            Thread.sleep(5000);
            genericFunctions.Scrolldownpage();
            Thread.sleep(5000);
            genericFunctions.WaitForElement(Driver, _formDesignerPage.AddList());
            genericFunctions.Click(Driver, _formDesignerPage.AddList());

        }
        [Then(@"Verify List Title ""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)""")]
        public void ThenVerifyListTitle(string ListTitle, string noOfItem, string datasetavailable, string linksavailable)
        {
            Assert.AreEqual(ListTitle, genericFunctions.GetText(Driver, _formDesignerPage.ListTitle_Label(ListTitle)), ListTitle);
            Assert.AreEqual(noOfItem, genericFunctions.GetText(Driver, _formDesignerPage.NoOfItems(ListTitle)), noOfItem);
            Assert.AreEqual(datasetavailable, genericFunctions.GetText(Driver, _formDesignerPage.Datasetavailable(ListTitle)), datasetavailable);
            Assert.AreEqual(linksavailable, genericFunctions.GetText(Driver, _formDesignerPage.Linksavailable(ListTitle)), linksavailable);


        }
        [Then(@"edit the values ""([^""]*)""")]
        public void ThenEditTheValues(string Item)
        {
            genericFunctions.Click(Driver, _formDesignerPage.EditItem(Item));

        }
        [Then(@"Update the values ""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)""")]
        public void ThenUpdateTheValues(string itemtext, string updatedHelptext, string updatedvalue, string Enterlink)
        {

            genericFunctions.SendKeys(Driver, _formDesignerPage.itemtext(), itemtext);
            genericFunctions.SendKeys(Driver, _formDesignerPage.Helptext(), updatedHelptext);
            genericFunctions.SendKeys(Driver, _formDesignerPage.Value(), updatedvalue);
            genericFunctions.SendKeys(Driver, _formDesignerPage.Enterlink(), Enterlink);
            genericFunctions.Scrolldownpage();
            Thread.sleep(3000);
            genericFunctions.Click(Driver, _formDesignerPage.SaveListItem());

        }
        [Then(@"Verify the values ""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)""")]
        public void ThenVerifyTheValues(string itemtext, string updatedHelptext, string updatedvalue, string Enterlink)
        {
            Assert.AreEqual(itemtext, genericFunctions.GetValue(Driver, _formDesignerPage.itemtext()), itemtext);
            Assert.AreEqual(updatedHelptext, genericFunctions.GetValue(Driver, _formDesignerPage.Helptext()), updatedHelptext);
            Assert.AreEqual(updatedvalue, genericFunctions.GetValue(Driver, _formDesignerPage.Value()), updatedvalue);
            Assert.AreEqual(Enterlink, genericFunctions.GetValue(Driver, _formDesignerPage.Enterlink()), Enterlink);
            genericFunctions.Scrolldownpage();
            Thread.sleep(3000);
            genericFunctions.Click(Driver, _formDesignerPage.SaveListItem());
            Thread.sleep(3000);
            genericFunctions.Scrolldownpage();
            Thread.sleep(5000);
            Driver.FindElement(By.XPath("//button[text()='Save list']")).Click();

        }


        [Then(@"Remove the item ""([^""]*)""")]
        public void ThenRemoveTheItem(string item1)
        {
            genericFunctions.Scrolldownpage();
            Thread.sleep(5000);
            genericFunctions.Click(Driver, _formDesignerPage.RemoveItem(item1));
            genericFunctions.WaitForElement(Driver, _formDesignerPage.Removelist());
            genericFunctions.Click(Driver, _formDesignerPage.CheckboxAlert());
            genericFunctions.Click(Driver, _formDesignerPage.Removelist());
            Thread.sleep(5000);
            genericFunctions.Click(Driver, _formDesignerPage.SaveList());



        }


        [Then(@"Then Verify dashboard every ""([^""]*)"" min")]
        public void ThenThenVerifyDashboardEveryMin(string Min)
        {
            Thread.sleep(5000);
            Driver.Navigate().Refresh();

            for (int i = 0; i < 2; i++)
            {
                int min1 = int.Parse(Min);
                DateTime currentDateTime = DateTime.Now;
                Console.WriteLine("Current date and time before wait: " + currentDateTime);
                int secon = min1 * 60 * 1000;
                Thread.sleep(secon);
                DateTime currentDateTime1 = DateTime.Now;
                Console.WriteLine("Current date and time: after wait " + currentDateTime1);
                Assert.AreEqual(Driver.FindElement(By.XPath("//h1[text()='Digital Form Builder Dashboard']")).Text, "Digital Form Builder Dashboard");


            }
        }
        [Then(@"Write the submission id in notepad")]
        public void ThenWriteTheSubmissionIdInNotepad()
        {
            if (FlagsAttribute == true)
            {
                sw = File.CreateText(fileName);
                FlagsAttribute = false;
                sw.WriteLine("New file created: {0}", DateTime.Now.ToString());


            }
            else
            {
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine("New file created: {0}", DateTime.Now.ToString());


            }

            sw.Close();




        }
        [Then(@"Click on Signout Button")]
        public void ThenClickOnSignoutButton()
        {
            try
            {
                genericFunctions.Click(Driver, _summaryPage.SignoutLink());
                genericFunctions.Click(Driver, _summaryPage.ConfirmSelectionBox());
                genericFunctions.Click(Driver, _summaryPage.SignoutButton());
            }
            catch (Exception e) { }

        }

        [Then(@"Navigate to form url '([^']*)'")]
        public void ThenNavigateToFormUrl(string p0)
        {
            Driver.Url = "https://preprod.digital-forms.education.gov.uk//4sguto3dwg";
        }

        [Then(@"connect to sql")]
        public void ThenConnectToSql()
        {
            System.Data.DataTable dataTable1 = SQLHelper.ExecuteStoredProceduretoDataTable("select TOP(50) * from [dbo].[Responses] order by 1 desc");
            SQLHelper.ReadDataSQL1("select TOP(50) * from [dbo].[Responses] order by 1 desc");
        }
        [Then(@"Enter the values in NTP form for ""([^""]*)""")]
        public void ThenEnterTheValuesInNTPFormFor(string p0)
        {
            string filePath = b + "\\TestData\\SchoolName.txt";
            var lines = File.ReadAllLines(filePath);
            List<string> arrayList = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                arrayList.Add(lines[i]);
            }
            Random rnd = new Random();

            int num = rnd.Next(1, 750);

            genericFunctions.Click(Driver, _formDesignerPage.YesRadiocheckbox());
            _formDesignerPage.clicksaveandcontinue().Click();
            genericFunctions.Click(Driver, _formDesignerPage.YesRadiocheckbox());
            _formDesignerPage.clicksaveandcontinue().Click();
            _formDesignerPage.NumberEdit().Clear();
            _formDesignerPage.NumberEdit().Clear();
            _formDesignerPage.NumberEdit().SendKeys(p0);
            _formDesignerPage.clicksaveandcontinue().Click();
            for (int i=1;i<= Int32.Parse(p0); i++)
            {

                Driver.FindElement(By.XPath("//input[@role='combobox']")).Clear();
                Thread.sleep(2000);
                Driver.FindElement(By.XPath("//input[@role='combobox']")).SendKeys(lines[rnd.Next(1, 750)]);
                Thread.sleep(2000);
                try
                {
                    Driver.FindElement(By.XPath("//li[@role='option']")).Click();
                }
                catch (Exception e) { }
                Thread.sleep(7000);
                try
                {
                    Driver.FindElement(By.XPath("//input[@role='combobox']")).SendKeys(Keys.Enter);
                }
                catch (Exception e) { }
                _formDesignerPage.clicksaveandcontinue().Click();
                _formDesignerPage.NumberEdit().Clear();
                _formDesignerPage.NumberEdit().SendKeys(rnd.Next(1, 750).ToString());
                Thread.sleep(2000);

                _formDesignerPage.clicksaveandcontinue().Click();


                //additional
                Driver.FindElement(By.XPath("//input[@role='combobox']")).Clear();
                Thread.sleep(2000);
                Driver.FindElement(By.XPath("//input[@role='combobox']")).SendKeys(lines[rnd.Next(1, 750)]);
                Thread.sleep(2000);
                try
                {
                    Driver.FindElement(By.XPath("//li[@role='option']")).Click();
                }
                catch (Exception e) { }
                Thread.sleep(7000);
                //try
                //{
                //    Driver.FindElement(By.XPath("//input[@role='combobox']")).SendKeys(Keys.Enter);
                //}
               // catch (Exception e) { }
                _formDesignerPage.clicksaveandcontinue().Click();
                _formDesignerPage.NumberEdit().Clear();
                _formDesignerPage.NumberEdit().SendKeys(rnd.Next(1, 750).ToString());
                _formDesignerPage.clicksaveandcontinue().Click();
                _formDesignerPage.NumberEdit().Clear();
                _formDesignerPage.NumberEdit().SendKeys(rnd.Next(1, 750).ToString());
                if (i == Int32.Parse(p0))
                {
                   // genericFunctions.Click(Driver, _formDesignerPage.NoRadiocheckbox());
                }
                _formDesignerPage.clicksaveandcontinue().Click();

            }

            _formDesignerPage.clicksaveandcontinue().Click();
            _formDesignerPage.NumberEdit().Clear();
            _formDesignerPage.NumberEdit().SendKeys(rnd.Next(1, 1300).ToString());
            _formDesignerPage.clicksaveandcontinue().Click();
            genericFunctions.Click(Driver, _formDesignerPage.NoRadiocheckbox());
            _formDesignerPage.clicksaveandcontinue().Click();


            genericFunctions.Click(Driver, _formDesignerPage.YesRadiocheckbox());
            _formDesignerPage.clicksaveandcontinue().Click();
            _formDesignerPage.EnterEmail("digitalforms01+1@gmail.com");
            _formDesignerPage.clicksaveandcontinue().Click();

            IList<IWebElement> allnumbercomponentOnOnePage = Driver.FindElements(By.XPath("//input[@class='govuk-checkboxes__input']"));
            foreach (var eachnumbercomponentOnOnePage in allnumbercomponentOnOnePage)
            {
                try
                {
                    eachnumbercomponentOnOnePage.Click();
                }
                catch (Exception e) { }
            }
            Thread.sleep(7000);

            // (//input[@class='govuk-checkboxes__input'])[2]
            _formDesignerPage.clicksaveandcontinue().Click();
            genericFunctions.Scrolldownpage();

        }

        [Then(@"Enter the values in NTP form")]
        public void ThenEnterTheValuesInNTPForm()
        {
            string filePath = b + "\\TestData\\SchoolName.txt";
            var lines = File.ReadAllLines(filePath);
            List<string> arrayList = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                arrayList.Add(lines[i]);
            }
            Random rnd = new Random();

            int num = rnd.Next(1, 750);
            string aa= lines[rnd.Next(1, 750)];
                genericFunctions.Click(Driver, _formDesignerPage.YesRadiocheckbox());
            _formDesignerPage.clicksaveandcontinue().Click();
            genericFunctions.Click(Driver, _formDesignerPage.YesRadiocheckbox());
            _formDesignerPage.clicksaveandcontinue().Click();
            _formDesignerPage.NumberEdit().Clear();
            _formDesignerPage.NumberEdit().Clear();
            _formDesignerPage.NumberEdit().SendKeys("2");
            _formDesignerPage.clicksaveandcontinue().Click();

            _formDesignerPage.NumberEdit().Clear();

            _formDesignerPage.NumberEdit().SendKeys(rnd.Next(1, 750).ToString());
            _formDesignerPage.clicksaveandcontinue().Click();

            genericFunctions.Click(Driver, _formDesignerPage.YesRadiocheckbox());
            _formDesignerPage.clicksaveandcontinue().Click();
            _formDesignerPage.NumberEdit().Clear();

            _formDesignerPage.NumberEdit().SendKeys(rnd.Next(1, 1300).ToString());
            _formDesignerPage.clicksaveandcontinue().Click();
            _formDesignerPage.NumberEdit().Clear();

            _formDesignerPage.NumberEdit().SendKeys(rnd.Next(1, 1455000).ToString());
            _formDesignerPage.clicksaveandcontinue().Click();
            _formDesignerPage.NumberEdit().Clear();

            _formDesignerPage.NumberEdit().SendKeys(rnd.Next(1, 10400).ToString());
            _formDesignerPage.clicksaveandcontinue().Click();
            _formDesignerPage.clicksaveandcontinue().Click();
            genericFunctions.Click(Driver, _formDesignerPage.YesRadiocheckbox());
            _formDesignerPage.clicksaveandcontinue().Click();
            genericFunctions.Click(Driver, _formDesignerPage.YesRadiocheckbox());
            _formDesignerPage.clicksaveandcontinue().Click();


        }
        [Given(@"I have landed on create component page")]
        public void GivenIHaveLandedOnCreateComponentPage()
        {
            _formDesignerPage.Removelist();
            Driver.FindElement(_formDesignerPage.Removelist()).Click();

            genericFunctions.WaitForElement(Driver, _formDesignerPage.Removelist());
        }


        [Then(@"User Select ""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)""")]
        public void ThenUserSelect(string Prefix, string Suffix, string Addprefix, string prefixcurrency, string Entercustomprefix, string Addsuffix_value, string Min, string Max, string Precison)
        {

            if (Prefix.Equals("Yes", StringComparison.InvariantCultureIgnoreCase))
            {
                genericFunctions.Click(Driver, _numberLinkComponentPage.Prefix());
                if (Addprefix.Equals("Yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (prefixcurrency.Equals("pounds", StringComparison.InvariantCultureIgnoreCase))
                    {
                        genericFunctions.Click(Driver, _numberLinkComponentPage.PrefixSelectBox());
                        genericFunctions.SelectElementByText(Driver, _numberLinkComponentPage.PrefixSelect(), "Pounds(£)");
                    }
                    else if (prefixcurrency.Equals("Euros", StringComparison.InvariantCultureIgnoreCase))
                    {
                        genericFunctions.Click(Driver, _numberLinkComponentPage.PrefixSelectBox());
                        genericFunctions.SelectElementByText(Driver, _numberLinkComponentPage.PrefixSelect(), "Euros(€)");
                    }
                    else if (Entercustomprefix.Trim() != "")
                    {
                        genericFunctions.Click(Driver, _numberLinkComponentPage.CustomSelectBox());
                        genericFunctions.SendKeys(Driver, _numberLinkComponentPage.CustomTextBox(), Entercustomprefix);

                    }


                }




            }
            if (Addsuffix_value.Trim() != "")
            {
                genericFunctions.Click(Driver, _numberLinkComponentPage.SuffixCheckBox());
                genericFunctions.SendKeys(Driver, _numberLinkComponentPage.SuffixTextBox(), Addsuffix_value);
            }
            genericFunctions.Click(Driver, _numberLinkComponentPage.AdditionalSettingLink());

            if (Min.Trim() != "")
            {
                genericFunctions.SendKeys(Driver, _numberLinkComponentPage.MinEditBox(), Min);


            }
            if (Max.Trim() != "")
            {
                genericFunctions.SendKeys(Driver, _numberLinkComponentPage.MaxEditBox(), Max);


            }
            if (Precison.Trim() != "")
            {
                genericFunctions.SendKeys(Driver, _numberLinkComponentPage.PrecisionEditBox(), Precison);


            }

        }
        [Then(@"Hide the result component")]
        public void ThenHideTheResultComponent()
        {
            string getresult = genericFunctions.GetValue(Driver, resultLinkComponent.HideResult());
            if (getresult.Equals("false") || getresult.Equals(""))
            {
                genericFunctions.Click(Driver, resultLinkComponent.HideResult());
            }
        }


        [Then(@"Enter calculation name '([^']*)','([^']*)','([^']*)'")]
        public void ThenEnterCalculationName(string name, string title, string helptext)
        {

            genericFunctions.SendKeys(Driver, resultLinkComponent.calculationName(), name);
            genericFunctions.Click(Driver, resultLinkComponent.continuebutton());
            genericFunctions.SendKeys(Driver, resultLinkComponent.title(), title);
            genericFunctions.SendKeys(Driver, resultLinkComponent.helpText(), helptext);

        }
        [Then(@"Click on save calculation")]
        public void ThenClickOnSaveCalculation()
        {
            genericFunctions.Click(Driver, resultLinkComponent.savecalc());
            Thread.sleep(3000);
            genericFunctions.Click(Driver, resultLinkComponent.Close());

        }


        [Then(@"Add New calculation with page '([^']*)' with variable '([^']*)' and '([^']*)' using '([^']*)'")]
        public void ThenAddNewCalculationWithPageWithVariableAndUsing(string Page, string var1, string var2, string operat)
        {
            resultLinkComponent.ClickAddNewCalculationbutton();
            genericFunctions.SelectElementByText(Driver, resultLinkComponent.SelectPage(), Page);
            genericFunctions.Click(Driver, resultLinkComponent.component_name(var1));
            genericFunctions.Click(Driver, resultLinkComponent.component_name(var2));
            genericFunctions.Click(Driver, resultLinkComponent.Addvariable());
            string getvalue = genericFunctions.GetText(Driver, resultLinkComponent.Textara());
            getvalue = getvalue.Replace(" ", operat);
            genericFunctions.SendKeys(Driver, resultLinkComponent.Textara(), getvalue);
        }

        [Then(@"user clicks on import saved form link")]
        public void ThenUserClicksOnImportSavedFormLink()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            dashboardPage.ImportSavedFormLink().Click();
        }

        [Then(@"verify that system gives import json modal window")]
        public void ThenVerifyThatSystemGivesImportJsonModalWindow()
        {
            Assert.AreEqual("Import saved forms", dashboardPage.ValidateImportSavedFormPopUp());
        }
        [Then(@"Import the json ""([^""]*)"" with ""([^""]*)""")]
        public void ThenImportTheJsonWith(string JsonFile, string Name)
        {
            var formName = "TestForm" + DateTime.Now.ToString("s", CultureInfo.CreateSpecificCulture("en-US"));
            formName = Regex.Replace(formName, @"[):;.,'=-]", "");
            dashboardPage.EnterImportFormTitle().SendKeys(Name);
            string fileName = b + "\\TestData\\" + JsonFile;
            Driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(fileName);
            //Storing form name value in file.txt
            string filePath = b + "\\TestData\\file.txt";
            File.WriteAllText(filePath, Name);
        }

        [Then(@"user enters unique form title and upload form json file ""([^""]*)""")]
        public void ThenUserEntersUniqueFormTitleAndUploadFormJsonFile(string filename)
        {

            var formName = "TestForm" + DateTime.Now.ToString("s", CultureInfo.CreateSpecificCulture("en-US"));
            formName = Regex.Replace(formName, @"[):;.,'=-]", "");
            dashboardPage.EnterImportFormTitle().SendKeys(formName);
            string fileName = b + "\\TestData\\" + filename;
            Driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(fileName);

            //Storing form name value in file.txt
            string filePath = b + "\\TestData\\file.txt";
            File.WriteAllText(filePath, formName);
        }

        [Then(@"Enter the form name")]
        public void ThenEnterTheFormName()
        {
            formName = "TestForm" + DateTime.Now.ToString("s", CultureInfo.CreateSpecificCulture("en-US"));
            formName = Regex.Replace(formName, @"[):;.,'=-]", "");
            dashboardPage.FormNameEditBox().SendKeys(formName);

            //Storing form name value in file.txt
            string filePath = b + "\\TestData\\file.txt";
            File.WriteAllText(filePath, formName);
        }


        [Then(@"user clicks on import \.json button")]
        public void ThenUserClicksOnImport_JsonButton()
        {
            dashboardPage.ClickImportFormButton();
        }

        [Then(@"verify that a form is created")]
        public void ThenVerifyThatAFormIsCreated()
        {
            string filePath = b + "\\TestData\\file.txt";
            string formName = File.ReadAllText(filePath);
            bool formExists;
            dashboardPage.ClickCreateNewFormButton();
            formExists = dashboardPage.VerifyFormInDashboard(formName);
            if (formExists == false)
            {
                dashboardPage.collegueformlink();
                formExists = dashboardPage.VerifyFormInDashboard(formName);
            }

            Assert.True(formExists, "Imported form is displayed in dashboard");
        }

        [Then(@"the user uploads form json file ""([^""]*)""")]
        public void ThenTheUserUploadsFormJsonFile(string filename)
        {
            string fileName = b + "\\TestData\\" + filename;
            Driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(fileName);
        }

        [Then(@"verify that imported form with form name ""([^""]*)"" is displayed in dashboard")]
        public void ThenVerifyThatImportedFormWithFormNameIsDisplayedInDashboard(string formName)
        {
            dashboardPage.ClickCreateNewFormButton();
            bool formExists = dashboardPage.VerifyFormInDashboard(formName);
         //   Assert.True(formExists, "Imported form is displayed in dashboard");
        }
        [Then(@"Add a page name")]
        public void ThenAddAPageName(Table table)
        {
            Thread.sleep(5000);
            var AddPagesdata = table.CreateSet<AddPage>();
            foreach (AddPage data in AddPagesdata)
            {
                _formDesignerPage.ClickMenuAddPageBtn();
                if (data.PageName != "")
                {
                    genericFunctions.SelectElementByText(Driver, _formDesignerPage.LinkFrom(), data.PageName);

                }
                if (data.ConditionName != "")
                {
                    genericFunctions.SelectElementByText(Driver, _formDesignerPage.LinkCondition(), data.ConditionName);
                }
                if (data.PageType != "")
                {
                    genericFunctions.SelectElementByText(Driver, _formDesignerPage.PageType(), data.PageType);
                }
                genericFunctions.SendKeys(Driver, _formDesignerPage.PageTitle(), data.Page);
                _formDesignerPage.SaveButton1_1();
                Thread.sleep(10000);
            }
        }
        [Then(@"Remove the page '([^']*)'")]
        public void ThenRemoveThePage(string summary)
        {
            genericFunctions.Click(Driver, _formDesignerPage.removethepage(summary));
            _formDesignerPage.ClickDeletebutton();
            genericFunctions.ClickAlert();
            Thread.sleep(15000);
            try
            {
                genericFunctions.Click(Driver, _formDesignerPage.Close());
            }
            catch (Exception e) { }

        }


        [Then(@"add link from '([^']*)' to '([^']*)'")]
        public void ThenAddLinkFromTo(string from, string to)
        {
            Thread.sleep(5000);
            genericFunctions.Click(Driver, _formDesignerPage.Addlink());
            Thread.sleep(5000);
            genericFunctions.SelectElementByText(Driver, _formDesignerPage.LinkfromSelect(), from);
            Thread.sleep(5000);
            genericFunctions.SelectElementByText(Driver, _formDesignerPage.LinktoSelect(), to);
            Thread.sleep(5000);
            _formDesignerPage.SaveButton1_1();
            Thread.sleep(5000);
        }
        [Then(@"remove the calculation component teejjj")]
        public void ThenRemoveTheCalculationComponentTeejjj()
        {
            ScenarioContext.Current["Category"] = "categoryName";
            FeatureContext.Current["Category1"] = "categoryName1";

        }

        [Then(@"remove the calculation component teejjjrterter")]
        public void ThenRemoveTheCalculationComponentTeejjjrterter()
        {
            //  var var = ScenarioContext.Current["Category"];
            var var1 = FeatureContext.Current["Category1"];
            Console.WriteLine(var1);
        }


        [Then(@"Click on add section")]
        public void ThenClickOnAddSection()
        {
            genericFunctions.Click(Driver, _formDesignerPage.Section());
        }

        [Then(@"Check the design in Add section")]
        public void ThenCheckTheDesignInAddSection()
        {
            bool a=genericFunctions.isDisplayed(Driver, _menuSectionsPage.Back());
            Assert.IsTrue(genericFunctions.isDisplayed(Driver, _menuSectionsPage.Back()),"Backbutton");
            Assert.AreEqual("Add or edit sections", genericFunctions.GetText(Driver, _menuSectionsPage.heading()), "Heading");
            Assert.IsTrue(genericFunctions.isDisplayed(Driver, _menuSectionsPage.addsection()), "addsection button");
            Assert.IsTrue(genericFunctions.isDisplayed(Driver, _menuSectionsPage.Sectiont()), "Section title");
            Assert.IsTrue(genericFunctions.isDisplayed(Driver, _menuSectionsPage.Repeatableavailable_l()), "Repeatable section available");
         //   Assert.IsTrue(genericFunctions.isDisplayed(Driver, _menuSectionsPage.Nosectionfound()), "No section found");
        }


        [Then(@"Add section with Name ""([^""]*)""")]
        public void ThenAddSectionWithName(string sectionName)
        {
            genericFunctions.Click(Driver, _menuSectionsPage.addsection());
            genericFunctions.SendKeys(Driver, _menuSectionsPage.SectionTitle(), sectionName);
            genericFunctions.Click(Driver, _menuSectionsPage.AddSection());
          
        }
        [Then(@"Verify the  Name ""([^""]*)""")]
        public void ThenVerifyTheName(string sectionName)
        {
            By SectionTitle = By.XPath("//span[@title='"+ sectionName + "']");
            string str_title = genericFunctions.GetText(Driver, SectionTitle);
            Assert.AreEqual(sectionName, str_title);

        }

        [Then(@"Add repeatable section with Name ""([^""]*)"" and  number trigger ""([^""]*)"" and Yes no Trigger ""([^""]*)""")]
        public void ThenAddRepeatableSectionWithNameAndNumberTriggerAndYesNoTrigger(string sectionName, string numTrigger, string yesnoTrigger)
        {
            genericFunctions.Click(Driver, _menuSectionsPage.addsection());
            genericFunctions.SendKeys(Driver, _menuSectionsPage.SectionTitle(), sectionName);
            genericFunctions.Click(Driver, _menuSectionsPage.checkMarkSectionRepeatable());
            genericFunctions.Click(Driver, _menuSectionsPage.selectNumberTrigger(numTrigger));
            genericFunctions.Click(Driver, _menuSectionsPage.selectYesnoTrigger(yesnoTrigger));
            Thread.sleep(3000);
            genericFunctions.Scrolldownpage();
            Thread.sleep(3000);
            genericFunctions.Click(Driver, _menuSectionsPage.AddSection());
            genericFunctions.Click(Driver, _menuSectionsPage.Back());
        }

        [Then("add repeatable section {string} to the second page")]
        public void ThenAddRepeatableSectionToTheSecondPage(string repeatableTitle)
        {
            _formDesignerPage.ClickSecondPageEditBtn();
            _formDesignerPage.SelectSectionInEditPage(repeatableTitle);
            _formDesignerPage.SaveButton1_1();
        }

        [Then("I enter repeatable number trigger value as {string} and click save and continue")]
        public void ThenIEnterRepeatableNumberTriggerValueAsAndClickSaveAndContinue(string count)
        {
            _formDesignerPage.EnterNumberTriggervalue(count);
            _formDesignerPage.clicksaveandcontinue().Click();
        }

        [Then("I iterate through the repatable pages {string} times and navigate to summary")]
        public void ThenIIterateThroughTheRepatablePagesTimesAndNavigateToSummary(string iterations)
        {
            _formDesignerPage.EnterValues(Convert.ToInt32(iterations));
        }

        [Then(@"Edit section with Name ""([^""]*)"" with ""([^""]*)""")]
        public void ThenEditSectionWithNameWith(string sectionName, string NewSectionName)
        {
            By radioButton_section = By.XPath("//span[@title='"+ sectionName+"']/preceding::input");
            genericFunctions.Click(Driver, radioButton_section);
            genericFunctions.Click(Driver, _menuSectionsPage.EditSection());
            genericFunctions.SendKeys(Driver, _menuSectionsPage.SectionTitle(), NewSectionName);
            genericFunctions.Click(Driver, _menuSectionsPage.SaveSection());
        }
        [Then(@"Delete the section ""([^""]*)""")]
        public void ThenDeleteTheSection(string sectionNameupdated)
        {
            By radioButton_section = By.XPath("//span[@title='" + sectionNameupdated + "']/preceding::input");
            genericFunctions.Click(Driver, radioButton_section);
            genericFunctions.Click(Driver, _menuSectionsPage.DeleteSection());
            genericFunctions.Click(Driver, _menuSectionsPage.DeleteSection_pop());
            genericFunctions.Click(Driver, _menuSectionsPage.DeleteSection1());
        }


    }
}
