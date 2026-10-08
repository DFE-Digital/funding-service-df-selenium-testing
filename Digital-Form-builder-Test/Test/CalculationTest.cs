using Digital_Form_builder_Test.PageObjects.ComponentPages;
using Digital_Form_builder_Test.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Digital_Form_builder_Test.Utilities;
using Microsoft.Azure.Cosmos;
using System.Threading.Tasks;
using Digital_Form_builder_Test.DBHelper;
using System.Configuration;
using System.Threading;

namespace Digital_Form_builder_Test.Test
{
    public class CalculationTest : BaseTest
    {

        ResultLinkComponentPage calculationpage;
        FormDesignerPage formDesignerPage;
        CreateComponentPage createcomponentPage;
        string calculationName = ConfigurationManager.AppSettings["FormName"];



        [Test, Order(1), Category("In-Sprint")]
        public void CheckResultLinkDisplayed()
        {
            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm("cal-testing");
            createcomponentPage = formDesignerPage.ClickPage01CreateComponentBtn();
            Assert.IsTrue(createcomponentPage.IsDisplayedResultLink().Displayed);
            calculationpage = createcomponentPage.ClickResultLink();
            Assert.AreEqual("Calculation builder", calculationpage.CheckCalculationBuilderHeaderDisplayed());
            Assert.AreEqual("Calculation name", calculationpage.CheckCalculationNameDisplayed());
            Assert.AreEqual("Calculation variable", calculationpage.CheckCalculationVariableDisplayed());
            Assert.AreEqual("Page location", calculationpage.CheckPageLocationDisplayed());
            Assert.AreEqual("Component variables", calculationpage.CheckComponentVariableDisplayed());
            createcomponentPage = calculationpage.ClickBackToCreateComponentListLink();
            Assert.IsTrue(createcomponentPage.IsDisplayedResultLink().Displayed);
            calculationpage = createcomponentPage.ClickResultLink();
            formDesignerPage = calculationpage.ClickCloseLink();
            createcomponentPage = formDesignerPage.ClickPage01CreateComponentBtn();
            Assert.IsTrue(createcomponentPage.IsDisplayedResultLink().Displayed);


        }

        [Test, Order(2), Category("In-Sprint")]
        public void CheckCalculationDashboardDisplayed()
        {
            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm("cal-testing");
            createcomponentPage = formDesignerPage.ClickPage01CreateComponentBtn();
            Assert.IsTrue(createcomponentPage.IsDisplayedResultLink().Displayed);
            calculationpage = createcomponentPage.ClickResultLink();
            Assert.AreEqual("Calculation builder", calculationpage.CheckCalculationBuilderHeaderDisplayed());
            Assert.AreEqual("Calculation name", calculationpage.CheckCalculationNameDisplayed());
            Assert.AreEqual("Calculation variable", calculationpage.CheckCalculationVariableDisplayed());
            Assert.AreEqual("Page location", calculationpage.CheckPageLocationDisplayed());
            Assert.AreEqual("Component variables", calculationpage.CheckComponentVariableDisplayed());



        }

        [Test, Order(3), Category("In-Sprint")]
        public void CheckStaticCalculationScreenDisplayedOnAddCalculationBtn()
        {

            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm("cal-testing");
            createcomponentPage = formDesignerPage.ClickPage01CreateComponentBtn();
            //Assert.IsTrue(createcomponentPage.Resultlink().Displayed);
            calculationpage = createcomponentPage.ClickResultLink();
            calculationpage.ClickAddNewCalculationbutton();
            Assert.AreEqual("Calculation builder", calculationpage.CheckCalculationBuilderHeaderDisplayed());
            Assert.AreEqual("Calculation builder", calculationpage.ValidateCalculationbuilderLabel());
            Assert.IsTrue(calculationpage.ValidateHelpwithComponentsLink().Displayed);
            calculationpage.ClickHelpwithComponentsLink();
            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla tincidunt ultricies porttitor. In faucibus ex id nunc viverra tincidunt. Morbi condimentum consequat tellus, at pellentesque lorem euismod ac.", calculationpage.GetHelpwithComponentsTextUnderLink());
            Assert.AreEqual("Select calculation page", calculationpage.ValidateSelectCalculationPageLabel());
            Assert.IsTrue(calculationpage.ValidateSelectcalculationpageDropDown().Displayed);
            Assert.AreEqual("Add component variable to text area", calculationpage.ValidateAddComponentVariableToTextAreaLabel());
            Assert.AreEqual("Component name", calculationpage.ValidateComponentNameUnderAddComponentLabel());
            Assert.AreEqual("Variable name", calculationpage.ValidateVariableNameUnderAddComponentLabel());
            Assert.AreEqual("Add saved calculation variable to text area", calculationpage.ValidateAddSavedCalculationVariableToTextAreaLabel());
            Assert.AreEqual("Calculation name", calculationpage.ValidateCalculationNameUnderSavedComponentLabel());
            Assert.AreEqual("Variable name", calculationpage.ValidateVariableNameLabelUnderSavedComponentLabel());
            Assert.IsTrue(calculationpage.ValidateAddcomponentBtnOne().Displayed);
            Assert.IsTrue(calculationpage.ValidateAddcomponentBtnTwo().Displayed);
            Assert.IsTrue(calculationpage.ValidateCalCulationEditorAreaTextField().Displayed);
            Assert.IsTrue(calculationpage.GiveCalculationName().Displayed);
            Assert.IsTrue(calculationpage.ValidateContinueButton().Displayed);
            calculationpage.ClickContinueButton();
            Assert.IsTrue(calculationpage.EnterTitleTextField().Displayed);
            Assert.AreEqual("Help text(optional)", calculationpage.ValidateHelptextlabel());
            Assert.IsTrue(calculationpage.ValidateHelpTextfieldTextField().Displayed);
            //Assert.IsTrue(calculationpage.ValidateHideResultCheckBox().Displayed);
            Assert.IsFalse(calculationpage.ValidateHideResultCheckBox().Selected);
            calculationpage.ClickHideResultCheckBox();
            Assert.IsTrue(calculationpage.ValidateHideResultCheckBox().Selected);


        }

        [Test, Order(4), Category("In-Sprint")]

        public void ValidateTotalNumberComponentInFormDisplayed()
        {
            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm("cal-testing");
            createcomponentPage = formDesignerPage.ClickPage01CreateComponentBtn();
            calculationpage = createcomponentPage.ClickResultLink();
            calculationpage.ClickAddNewCalculationbutton();
            Assert.AreEqual(4, calculationpage.TotalNumberComponentInForm());

        }

        [Test, Order(5), Category("In-Sprint")]
        public void DragNumberComponentFromOnePageToTextArea()
        {
            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm("cal-testing");
            createcomponentPage = formDesignerPage.ClickPage01CreateComponentBtn();
            calculationpage = createcomponentPage.ClickResultLink();
            calculationpage.ClickAddNewCalculationbutton();
            calculationpage.SelectCalculationPageFromDropDown("Page01");
            calculationpage.CreateListUsingNumberComponent();
            calculationpage.AddNumberComponentFromOnePageToTextArea();
            calculationpage.SelectCalculationPageFromDropDown("Page02");
            calculationpage.CreateListUsingNumberComponent();
            calculationpage.AddNumberComponentFromOnePageToTextArea();
            calculationpage.ReadNumberComponentFromTextArea();
            calculationpage.ReadNumberComponentFromTextArea().SequenceEqual(calculationpage.CreateListUsingNumberComponent());

        }


        [Test, Order(6), Category("In-Sprint")]
        public void InsertingOpratorInBetweenVariablesInTextArea()
        {
            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm("cal-testing");
            createcomponentPage = formDesignerPage.ClickPage03CreateComponentBtn();
            calculationpage = createcomponentPage.ClickResultLink();
            calculationpage.ClickAddNewCalculationbutton();
            calculationpage.SelectCalculationPageFromDropDown("Page01");
            calculationpage.AddNumberComponentFromOnePageToTextArea();
            calculationpage.SelectCalculationPageFromDropDown("Page02");
            calculationpage.AddNumberComponentFromOnePageToTextArea();
            calculationpage.ReadNumberComponentFromTextArea();
            calculationpage.AddOpratorInVariables();

        }


        [Test, Order(7), Category("In-Sprint")]
        public void CalculationNameAndTitleValidation()
        {

            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm("cal-testing");
            createcomponentPage = formDesignerPage.ClickPage03CreateComponentBtn();
            calculationpage = createcomponentPage.ClickResultLink();
            calculationpage.ClickAddNewCalculationbutton();
            calculationpage.SelectCalculationPageFromDropDown("Page01");
            calculationpage.AddNumberComponentFromOnePageToTextArea();
            calculationpage.SelectCalculationPageFromDropDown("Page02");
            calculationpage.AddNumberComponentFromOnePageToTextArea();
            calculationpage.ReadNumberComponentFromTextArea();
            calculationpage.AddOpratorInVariables();
            calculationpage.ClickContinueButton();
            calculationpage.ValidateHelpTextfieldTextField().SendKeys("Any costs calimed for additional space");
            calculationpage.ClickSaveCalculationButton();
            Assert.AreEqual("Error:\r\nEnter Calculation Name", calculationpage.DisplayCalculationNameError());
            Assert.AreEqual("Error:\r\nEnter Title", calculationpage.DisplayCalculationTitleError());

            

        }


        [Test, Order(8), Category("Regression12333")]
        public void CreatingCalculationComponentOnFrom()
        {

            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm(calculationName);
            createcomponentPage = formDesignerPage.ClickPage02CreateComponentBtn();
            calculationpage = createcomponentPage.ClickResultLink();
            calculationpage.ClickAddNewCalculationbutton();
            calculationpage.SelectCalculationPageFromDropDown("Page01");
            calculationpage.AddNumberComponentFromOnePageToTextArea();
            calculationpage.SelectCalculationPageFromDropDown("Page02");
            calculationpage.AddNumberComponentFromOnePageToTextArea();
            calculationpage.ReadNumberComponentFromTextArea();
            calculationpage.AddOprator(calculationpage.allnumbercomponentFromTextArea, "+", 1);
            calculationpage.AddOprator(calculationpage.allnumbercomponentFromTextArea, "+", 3);
            calculationpage.AddOprator(calculationpage.allnumbercomponentFromTextArea, "+", 5);
            calculationpage.AddOpratorInVariables();
            calculationpage.GiveCalculationName().SendKeys("Claim-for-exceptional-costs");
            calculationpage.ClickContinueButton();
            calculationpage.EnterTitleTextField().SendKeys("Total costs claimed");
            calculationpage.ValidateHelpTextfieldTextField().SendKeys("Any costs calimed for additional space");
            calculationpage.ClickSaveCalculationButton();
            Assert.IsTrue(calculationpage.closelink.Displayed);
            Assert.AreEqual("Calculation builder", calculationpage.CheckCalculationBuilderHeaderDisplayed());

        }

        [Test, Order(9), Category("Regression12333")]
        public void EditCalculationValidation()
        {

            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm(calculationName);
            string beforetitle = CosmosHelper.ReadData(GetFormID.GetFormIDFromUrl(GetDriver().Url), "calculations[0].title");
            createcomponentPage = formDesignerPage.ClickPage03CreateComponentBtn();
            calculationpage = createcomponentPage.ClickResultLink();
            calculationpage.SelectCalculationFromDashboard("Claim-for-exceptional-costs");
            calculationpage.ClickEditCalculationbutton();
            calculationpage.EnterTitleTextField().Clear();
            calculationpage.EnterTitleTextField().SendKeys(RandomNameGenerator.RandomString(5));
            calculationpage.ClickSaveCalculationButton();
            Thread.Sleep(2000);
            string aftertitle= CosmosHelper.ReadData(GetFormID.GetFormIDFromUrl(GetDriver().Url), "calculations[0].title");
            Assert.AreNotEqual(beforetitle, aftertitle);

        }

        [Test, Order(10), Category("Regression123333")]

        public void DeleteCalculationValidation()
        {
            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm(calculationName);
            createcomponentPage = formDesignerPage.ClickPage03CreateComponentBtn();
            calculationpage = createcomponentPage.ClickResultLink();
            calculationpage.SelectCalculationFromDashboard("Claim-for-exceptional-costs");
            calculationpage.ClickDeleteCalculationbutton();
            ChangeFormStatusPage changeFormStatus = new ChangeFormStatusPage(GetDriver());
            changeFormStatus.SelectConfirmCheckBoxOnAlert();
            changeFormStatus.SelectContinueBtnOnAlert();
            calculationpage.ClickCloseLink();


        }
    }
}
