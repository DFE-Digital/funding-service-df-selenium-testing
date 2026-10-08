using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using sun.tools.java;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using WindowsInput.Native;
using WindowsInput;
using static com.sun.tools.javac.tree.DCTree;
using sun.nio.cs.ext;
using Microsoft.Extensions.Primitives;
using System.Diagnostics;
using Digital_Form_builder_Test.Utilities;

namespace Digital_Form_builder_Test.PageObjects.ComponentPages
{
    public class DataImport
    {

        private IWebDriver Driver;
        GenericFunctions _genericFunctions = new GenericFunctions();

        public DataImport(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        private By SelectColumnCheckBox = By.XPath("//input[@name='select_column']");
        private By ColumnName = By.Id("column-names");
        private By DocumentSelect = By.Id("document-selection");
        private By Savebutton = By.XPath("//button[text()='Save']");
        private By ColumnType = By.Id("column-type");
        private By MaxDays_Past = By.Id("field-options-maxDaysInPast");
        private By MaxDays_Feature = By.Id("field-options-maxDaysInFuture");
        private By Addbutton = By.XPath("//button[text()='Add']");
        private By MaxDays_Length = By.Id("field-schema-max");
        private By Min = By.Id("field-schema-min");
        private By Max = By.Id("field-schema-max");
        private By precision = By.Id("field-schema-precision");
        private By Optional = By.XPath("//label[@for='field-options-required']/preceding-sibling::input");
        private By ValidateFile_Button = By.XPath("//button[contains(text(),'Validate Your File')]");


        
        public void UserSelect(string columnName, string columnType)
        {
            _genericFunctions.ScrollDownToElement(Driver, SelectColumnCheckBox);
           // var Add_DisabledButton= Driver.FindElement(By.XPath("//BUTTON[text()='Add']")).GetDomAttribute("disabled");
            Driver.FindElement(SelectColumnCheckBox).Click();
            _genericFunctions.SelectElementByText(Driver, ColumnName, columnName);
            _genericFunctions.SelectElementByText(Driver, ColumnType, columnType);  

      
         }
        public void SelectDocumentInDataImport(string dataDocument)
        {
            Thread.Sleep(20000);
            _genericFunctions.SelectElementByText(Driver, DocumentSelect, dataDocument);
            Thread.Sleep(6000);
        }

        public void Max_Feature_Days(string MaxPast,string MaxFeature)
        {
            _genericFunctions.SendKeys(Driver, MaxDays_Past, MaxPast);
            _genericFunctions.SendKeys(Driver, MaxDays_Feature, MaxFeature);
        }

        public void Max_Length(string MaxLength)
        {
            _genericFunctions.SendKeys(Driver, MaxDays_Length, MaxLength);
            _genericFunctions.Click(Driver, Addbutton);

        }
        public void Click_Add()
        {
            _genericFunctions.Click(Driver, Addbutton);

        }
        public void EnterNumberSchema(string Minvalue,String Maxvalue,String Precisionvalue)
        {
            _genericFunctions.SendKeys(Driver, Min, Minvalue);
            _genericFunctions.SendKeys(Driver, Max, Maxvalue);
            _genericFunctions.SendKeys(Driver, precision, Precisionvalue);
        }
        public By ValidateFile()
        {
            return ValidateFile_Button;
        }

        public IWebElement ClickOptional()
        {
            return Driver.FindElement(Optional);
        }


    }
}
