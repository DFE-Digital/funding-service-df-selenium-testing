using Digital_Form_builder_Test.CustomeException;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects.ComponentPages
{
    public class ResultLinkComponentPage
    {
        private IWebDriver Driver;
        public IJavaScriptExecutor executor;
        int total;
        int count = 0;
        IList<String> variableList = new List<String>();
        public List<String> allnumbercomponentFromTextArea = new List<String>();
        //IList<String> arg = new List<String>();



        public ResultLinkComponentPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }



        [FindsBy(How = How.XPath, Using = "//a[.='Back to create component list']")]
        private IWebElement backtocreatecomponentlistlink;

        [FindsBy(How = How.XPath, Using = "(//span[.='Help with components'])[1]")]
        private IWebElement Helpwithcomponents;

        [FindsBy(How = How.XPath, Using = "//a[.='Close']")]
        public IWebElement closelink;

        [FindsBy(How = How.XPath, Using = "//h4[@class='govuk-heading-m']")]
        private IWebElement calculationbuilderheader;

        [FindsBy(How = How.XPath, Using = "//span[.='Help with components']")]
        private IWebElement helpwithcomponentslink;

        [FindsBy(How = How.XPath, Using = "//th[.='Calculation name']")]
        private IWebElement calculationname;

        [FindsBy(How = How.XPath, Using = "//th[.='Calculation variable']")]
        private IWebElement calculationvariable;

        [FindsBy(How = How.XPath, Using = "//th[.='Page location']")]
        private IWebElement PageLocation;

        [FindsBy(How = How.XPath, Using = "//th[.='Component variables']")]
        private IWebElement componentvariables;

        [FindsBy(How = How.XPath, Using = "//button[@id='add-calculation']")]
        private IWebElement AddNewCalculationBtn;


        [FindsBy(How = How.XPath, Using = "//button[@id='edit-calculation']")]
        private IWebElement EditCalculationBtn;

        [FindsBy(How = How.XPath, Using = "//button[@id='delete-calculation']")]
        private IWebElement DeleteCalculationBtn;


        //***************************************************************************************

        [FindsBy(How = How.XPath, Using = "//h4[.='Calculation builder']")]
        private IWebElement CalculationbuilderLabel;

        [FindsBy(How = How.XPath, Using = "(//span[.='Help with components'])[2]")]
        private IWebElement HelpwithComponentsLink;

        [FindsBy(How = How.XPath, Using = "(//a[.='Close'])[2]")]
        private IWebElement closeLink;

        [FindsBy(How = How.XPath, Using = "//label[.='Select calculation page']")]
        private IWebElement SelectCalculationPageLabel;

        [FindsBy(How = How.XPath, Using = "//select[@id='page']")]
        private IWebElement SelectCalculationPageDropDown;

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Add component variable to text area')]")]
        private IWebElement AddComponentVariableToTextAreaLabel;

        [FindsBy(How = How.XPath, Using = "//th[contains(.,'Component name')]")]
        private IWebElement ComponentNameUnderAddComponentLabel;

        [FindsBy(How = How.XPath, Using = "(//th[contains(.,'Variable name')])[1]")]
        private IWebElement VariableNameUnderAddComponentLabel;

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Add saved calculation variable to text area')]")]
        private IWebElement AddSavedCalculationVariableToTextAreaLabel;

        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Calculation name')]")]
        private IWebElement CalculationNameUnderSavedComponentLabel;

        [FindsBy(How = How.XPath, Using = "(//th[contains(.,'Variable name')])[2]")]
        private IWebElement VariableNameLabelUnderSavedComponentLabel;

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Result based on calculation below:')]")]
        private IWebElement ResultBasedOnCalculationBelowLabel;

        [FindsBy(How = How.XPath, Using = "(//span[@class='govuk-right-arrow-1'])[1]")]
        private IWebElement AddcomponentBtnOne;

        [FindsBy(How = How.XPath, Using = "(//span[@class='govuk-right-arrow-1'])[2]")]
        private IWebElement AddcomponentBtnTwo;

        [FindsBy(How = How.XPath, Using = "(//textarea)[1]")]
        private IWebElement CalCulationEditorAreaTextField;

        [FindsBy(How = How.XPath, Using = "//input[@id='calculationName']")]
        private IWebElement GiveCalculationNameTextField;



        [FindsBy(How = How.XPath, Using = "//input[@id='title']")]
        private IWebElement TitleTextField;

        [FindsBy(How = How.XPath, Using = "//label[.='Help text(optional)']")]
        private IWebElement HelptextLabel;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='helpText']")]
        private IWebElement HelpTextfieldTextField;


        [FindsBy(How = How.XPath, Using = "//button[@id='calc-continue']")]
        private IWebElement ContinueButton;


        [FindsBy(How = How.XPath, Using = "//button[@id='save-calculation']")]
        private IWebElement SaveCalculationButton;

        [FindsBy(How = How.XPath, Using = "//input[@id='hideResult']")]
        private IWebElement HideResultCheckBox;


        [FindsBy(How = How.XPath, Using = "(//div[@class='govuk-form-group calculations__ml'])[2]")]
        private IWebElement HelpwithComponentsTextUnderLink;


        [FindsBy(How = How.XPath, Using = "//span[@id='calculationName-error']")]
        private IWebElement CalculationNameError;


        [FindsBy(How = How.XPath, Using = "//span[@id='title-error']")]
        private IWebElement CalculationTitleError;

        private By SelectPage_select = By.XPath("//select[@id='pageOrDataset']");
        private By Add_variable = By.XPath("//button[@id='add-component']");

        private By calculationName_TextBox = By.XPath("//input[@name='calculationName']");

        private By continue_Button = By.XPath("//button[@id='calc-continue']");
        private By title_TextBox = By.XPath("//input[@name='title']");

        private By helpText_editbox = By.Id("helpText");
        private By save_calc = By.XPath("//button[@id='save-calculation']");

        private By number1_editbox = By.XPath("(//input[@inputmode='numeric'])[1]");
        private By number2_editbox = By.XPath("(//input[@inputmode='numeric'])[2]");
        private By Result_label = By.XPath("//div[@class='Result']/h2");
        private By Close_Button = By.XPath("//a[text()='Close']");
        private By HideResult_option = By.XPath("//input[@id='hideResult']");

        public By HideResult()
        {
            return HideResult_option;
        }


        public By Close()
        {
            return Close_Button;
        }


        public By Result()
        {
            return Result_label;
        }

        public By number1()
        {
            return number1_editbox;
        }
        public By number2()
        {
            return number2_editbox;
        }


        public By savecalc()
        {
            return save_calc;
        }


        public By helpText()
        {
            return helpText_editbox;
        }
        public By title()
        {
            return title_TextBox;
        }
        public By calculationName()
        {
            return calculationName_TextBox;
        }

        public By continuebutton()
        {
            return continue_Button;
        }


        public By Textara()
        {
            return By.XPath("(//textarea)[1]");
        }

        public By Addvariable()
        {
            return Add_variable;
        }
        
        public By component_name(string var)
        {
            return By.XPath("//span[@title='"+ var+"']/preceding::input[1]");
        }
        public By SelectPage()
        {
            return SelectPage_select;
        }

        //****************************************************************************************

        public CreateComponentPage ClickBackToCreateComponentListLink()
        {
            backtocreatecomponentlistlink.Click();
            return new CreateComponentPage(Driver);
        }
        public FormDesignerPage ClickCloseLink()
        {
            closelink.Click();
            return new FormDesignerPage(Driver);
        }
        public IWebElement ClickHelpWithComponentsLink()
        {
            helpwithcomponentslink.Click();
            return helpwithcomponentslink;
        }
        public string CheckCalculationBuilderHeaderDisplayed()
        {
            string name = calculationbuilderheader.Text;
            return name;
        }
        public string CheckCalculationNameDisplayed()
        {
            string name = calculationname.Text;
            return name;
        }
        public string CheckCalculationVariableDisplayed()
        {
            string name = calculationvariable.Text;
            return name;
        }
        public string CheckPageLocationDisplayed()
        {
            return PageLocation.Text;

        }
        public string CheckComponentVariableDisplayed()
        {
            string name = componentvariables.Text;
            return name;
        }
        public void ClickAddNewCalculationbutton()
        {
            try
            {
                AddNewCalculationBtn.Click();
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", AddNewCalculationBtn);
            }
        }



        public void ClickEditCalculationbutton()
        {
            try
            {
                EditCalculationBtn.Click();
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", EditCalculationBtn);
            }
        }


        public void ClickDeleteCalculationbutton()
        {
            try
            {
                DeleteCalculationBtn.Click();
            }
            catch (Exception ex)
            {
                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", DeleteCalculationBtn);
            }
        }


        //***************************************************************************************

        public String ValidateCalculationbuilderLabel()
        {
            return CalculationbuilderLabel.Text;
        }
        public IWebElement ValidateHelpwithComponentsLink()
        {
            return HelpwithComponentsLink;
        }
        public IWebElement ValidatecloseLink()
        {
            return closeLink;
        }
        public String ValidateSelectCalculationPageLabel()
        {
            return SelectCalculationPageLabel.Text;
        }
        public IWebElement ValidateSelectcalculationpageDropDown()
        {
            return SelectCalculationPageDropDown;
        }
        public String ValidateAddComponentVariableToTextAreaLabel()
        {
            return AddComponentVariableToTextAreaLabel.Text;
        }
        public String ValidateComponentNameUnderAddComponentLabel()
        {
            return ComponentNameUnderAddComponentLabel.Text;
        }
        public String ValidateVariableNameUnderAddComponentLabel()
        {
            return VariableNameUnderAddComponentLabel.Text;
        }
        public String ValidateAddSavedCalculationVariableToTextAreaLabel()
        {
            return AddSavedCalculationVariableToTextAreaLabel.Text;
        }
        public String ValidateCalculationNameUnderSavedComponentLabel()
        {
            return CalculationNameUnderSavedComponentLabel.Text;
        }
        public String ValidateVariableNameLabelUnderSavedComponentLabel()
        {
            return VariableNameLabelUnderSavedComponentLabel.Text;
        }
        public String ValidateResultBasedOnCalculationBelowLabel()
        {
            return ResultBasedOnCalculationBelowLabel.Text;
        }
        public IWebElement ValidateAddcomponentBtnOne()
        {
            return AddcomponentBtnOne;
        }
        public IWebElement ValidateAddcomponentBtnTwo()
        {
            return AddcomponentBtnTwo;
        }
        public IWebElement ValidateCalCulationEditorAreaTextField()
        {
            return CalCulationEditorAreaTextField;
        }
        public IWebElement GiveCalculationName()
        {
            return GiveCalculationNameTextField;
        }
        public IWebElement EnterTitleTextField()
        {
            return TitleTextField;
        }
        public String ValidateHelptextlabel()
        {
            return HelptextLabel.Text;
        }
        public IWebElement ValidateHelpTextfieldTextField()
        {
            return HelpTextfieldTextField;
        }

        public IWebElement ValidateContinueButton()
        {
            return ContinueButton;
        }

        public void ClickContinueButton()
        {
            ContinueButton.Click();
        }
        public void ClickSaveCalculationButton()
        {
            SaveCalculationButton.Click();
        }

        public IWebElement ValidateHideResultCheckBox()
        {
            return HideResultCheckBox;
        }

        public void ClickHideResultCheckBox()
        {
            HideResultCheckBox.Click();
        }

        public String GetHelpwithComponentsTextUnderLink()
        {
            return HelpwithComponentsTextUnderLink.Text;
        }

        public void ClickHelpwithComponentsLink()
        {
            HelpwithComponentsLink.Click();
        }


        public string DisplayCalculationNameError()
        {
            return CalculationNameError.Text;
        }

        public string DisplayCalculationTitleError()
        {
            return CalculationTitleError.Text;
        }


        public void SelectCalculationFromDashboard(string calculationTitle)
        {
            int totalcalculationcomponent = Driver.FindElements(By.XPath("(//table[@class='govuk-table'])/tbody/tr")).Count;


            if (totalcalculationcomponent >= 1)
            {
                for (int i = 1; i <= totalcalculationcomponent; i++)
                {
                    if ((Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[" + i + "]/td[2]/span")).Text) == calculationTitle)
                    {
                        Driver.FindElement(By.XPath("(//table[@class='govuk-table'])[1]/tbody/tr[" + i + "]/td[1]/div/div/input")).Click();
                        break;
                    }
                }

            }
            else
            {
                
                throw new NoCalculationFound("Choose the correct driver from edge or chrome");
            }

        }

        public void SelectCalculationPageFromDropDown(String PageTitle)
        {
            var SelectPageTypeDropDown = new SelectElement(SelectCalculationPageDropDown);
            IList<IWebElement> PagesInDropDown = SelectPageTypeDropDown.Options;

            foreach (var Page in PagesInDropDown)
            {

                if ((PageTitle) == (Page.Text))
                {
                    SelectPageTypeDropDown.SelectByText(PageTitle);
                    break;
                }
            }

        }

        public int CountNumberComponentFromSelectedPage()
        {

            int NumberComponentCount = Driver.FindElements(By.XPath("(//table[@class='govuk-table'])/tbody/tr")).Count;
            return NumberComponentCount;

        }

        public void AddNumberComponentFromOnePageToTextArea()
        {
            int i = 1;
            IList<IWebElement> allnumbercomponent = Driver.FindElements(By.XPath("(//table[@class='govuk-table'])/tbody/tr"));
            foreach (var element in allnumbercomponent)
            {
                Driver.FindElement(By.XPath("(//table[@class='govuk-table'])/tbody/tr[" + i + "]/td/div/div/input")).Click();
                i++;
            }
            AddcomponentBtnOne.Click();
            i = 1;
        }


        public IList<String> CreateListUsingNumberComponent()
        {
            int i = 1;

            IList<IWebElement> allnumbercomponentOnOnePage = Driver.FindElements(By.XPath("(//table[@class='govuk-table'])/tbody/tr"));
            foreach (var eachnumbercomponentOnOnePage in allnumbercomponentOnOnePage)
            {
                String variablewithoutbraces = "(" + Driver.FindElement(By.XPath("(//table[@class='govuk-table'])/tbody/tr[" + i + "]/td[3]")).Text + ")";
                variableList.Add(variablewithoutbraces);
                i++;
            }
            i = 1;
            return variableList;
        }

        public IList<String> ReadNumberComponentFromTextArea()
        {
            String Name = CalCulationEditorAreaTextField.Text;
            allnumbercomponentFromTextArea.AddRange(Name.Split(' ').ToList());
            return allnumbercomponentFromTextArea;

        }

        public void AddOpratorInVariables()
        {
            CalCulationEditorAreaTextField.Clear();
            int i = 1;
            foreach (String onenumber in allnumbercomponentFromTextArea)
            {
                CalCulationEditorAreaTextField.SendKeys(onenumber);

            }
            CalCulationEditorAreaTextField.SendKeys(Keys.End + "+" + 100);
        }


        public void AddOprator(IList<String> arg, string opt, int index)
        {
            arg.Insert(index, opt);
        }

        public int TotalNumberComponentInForm()
        {

            var selectPageTypeDropDown = new SelectElement(SelectCalculationPageDropDown);
            IList<IWebElement> PagesInDropDown = selectPageTypeDropDown.Options;

            for (int i = 2; i < PagesInDropDown.Count; i++)
            {
                selectPageTypeDropDown.SelectByIndex(i);
                count = Driver.FindElements(By.XPath("(//table[@class='govuk-table'])/tbody/tr")).Count;
                total = total + count;

            }
            return total;

        }

    }
}
