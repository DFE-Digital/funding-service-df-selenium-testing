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
using jdk.nashorn.@internal.ir;

namespace Digital_Form_builder_Test.PageObjects.ComponentPages
{
    public class TableComponentPage
    {

        private IWebDriver Driver;
        FormDesignerPage formDesignerPage = new FormDesignerPage(BaseTest.GetDriver());


        public TableComponentPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        private By DesignDataSetButton = By.XPath("//button[text()='Design data set']");
        private By DesignDataSetButton1 = By.XPath("(//button[text()='Design data set'])[2]");
        private By Datasetname = By.XPath("//input[@id='design-data-set-name']");
        private By GenerateStructure = By.XPath("//button[text()='Generate structure']");
        private By importdatasetlink = By.XPath("//button[text()='Import data set']");
        private By importdatasettitle = By.XPath("//input[@id='file-title']");
        private By DesignDataset_Select = By.ClassName("govuk-select");

        public By DesignDataset()
        {
            return DesignDataset_Select;
        }
        

        //input[contains(@name,'addressLine1')]

        public void ClickDesignDataSetButton()
        {
            Driver.FindElement(DesignDataSetButton).Click();
        }
        public void ClickDesignDataSetButton1()
        {
            Driver.FindElement(DesignDataSetButton1).Click();
        }

        
        public void ClickImportDataset(string dataSetName)
        {
            Thread.Sleep(5000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.FindElement(importdatasetlink).Click();
            Thread.Sleep(5000);
            Driver.FindElement(By.XPath("(//button[text()='Import data set'])[2]")).Click();
            Driver.FindElement(importdatasettitle).SendKeys(dataSetName);


        }

        public void importdataset(string file)
        {

            try
            {
                Driver.FindElement(By.XPath("(//button[text()='Import data set'])[2]")).Click();
            }
            catch (Exception ex)
            {
            }
            string workingdirectory = System.Environment.CurrentDirectory;
            Driver.FindElement(importdatasettitle).Clear();
            Driver.FindElement(importdatasettitle).SendKeys("dataset");
            var projectdirectory = Directory.GetParent(workingdirectory).Parent.Parent.FullName;
            string b = projectdirectory.ToString();
            string fileName = b + "\\TestData\\" + file;
            Driver.FindElement(By.XPath("//input[@id='file-upload-1']")).SendKeys(fileName);
            Thread.Sleep(17000);
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath("//button[text()='Save']")).Click();
            Thread.Sleep(10000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            By ele = By.XPath("//a[text()='Close']");
            GenericFunctions genericFunctions = new GenericFunctions();
            genericFunctions.WaitForElement(Driver, ele);   
            Driver.FindElement(By.XPath("//a[text()='Close']")).Click();
         
        }

        public void importdataset1(string file)
        {
            try
            {
                Driver.FindElement(By.XPath("(//button[text()='Import data set'])[2]")).Click();
            }
            catch (Exception ex)
            {
            }
            Driver.FindElement(importdatasettitle).SendKeys("dataset");
            Driver.FindElement(By.XPath("//label[text()='Choose file']")).Click();
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
            sim.Keyboard.TextEntry(file.ToString());
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath("//button[text()='Save']")).Click();
            Thread.Sleep(10000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            By ele = By.XPath("//a[text()='Close']");
            GenericFunctions genericFunctions = new GenericFunctions();
            genericFunctions.WaitForElement(Driver, ele);
            Driver.FindElement(By.XPath("//a[text()='Close']")).Click();

        }
        public void DesignDataSetFromToInDataTable1(int columns, int rows, string p2)
        {
            Driver.FindElement(Datasetname).SendKeys("testdata"+columns.ToString());
            var columnsval = Driver.FindElement(By.Id("design-data-set-dropdown-column"));
            var selectElement = new SelectElement(columnsval);
            selectElement.SelectByText(columns.ToString());
            Driver.FindElement(By.Id("design-data-set-dropdown-row")).SendKeys(rows.ToString());
            Driver.FindElement(GenerateStructure).Click();
            var importcsv = Driver.FindElement(By.Id("imported-dataset-select"));
            var seleccsv = new SelectElement(importcsv);
            seleccsv.SelectByText("dataset");
            var UKPRN = Driver.FindElement(By.XPath("//select[@name='key-identifier-select']"));
            var seletukprn = new SelectElement(UKPRN);
            seletukprn.SelectByText("UKPRN");
            int k = 1;
            for(int i = 1; i <= rows; i++)
            {
                int j = 1;
                int m=0;
                Random rnd = new Random();
                for (j = 1; j <= columns; j++)
                {
                    int nd = rnd.Next(6);
                    Thread.Sleep(1000);
                    Driver.FindElement(By.XPath("(//div[@class='dynamic-table-row'])[" + i + "]/div[" + j + "]")).Click();
                    Thread.Sleep(5000);
                    Thread.Sleep(1000);
                    Driver.FindElement(By.XPath("//input[@id='design-table-input-select-radio']")).Click();
                    Thread.Sleep(5000);
                    var Selectheader = Driver.FindElement(By.XPath("//select[@name='design-table-input-select-radio-select']"));
                    var seletheadervalue = new SelectElement(Selectheader);
                    seletheadervalue.SelectByIndex(k);
                    string val = Driver.FindElement(By.XPath("(//div[@class='dynamic-table-row'])[" + i + "]/div[" + j + "]")).GetAttribute("class");
                    if(val.Contains("cell cell-active"))
                    {
                        string hh;
                        hh = "70";
                    }
                    k = k + 1;
                    if(i == 1)
                    {
                        Driver.FindElement(By.XPath("//input[@id='design-table-input-bold-checkbox']")).Click();
                    }
                              
                }

             
            }

            

        }


   
        //public void DesignDataSetFromToInDataTable1(int columns, int rows, string p2)
        //{
        //    Driver.FindElement(Datasetname).SendKeys("testdata" + columns.ToString());
        //    var columnsval = Driver.FindElement(By.Id("design-data-set-dropdown-column"));
        //    var selectElement = new SelectElement(columnsval);
        //    selectElement.SelectByText(columns.ToString());
        //    Driver.FindElement(By.Id("design-data-set-dropdown-row")).SendKeys(rows.ToString());
        //    Driver.FindElement(GenerateStructure).Click();
        //    var importcsv = Driver.FindElement(By.Id("imported-dataset-select"));
        //    var seleccsv = new SelectElement(importcsv);
        //    seleccsv.SelectByText("dataset");
        //    var UKPRN = Driver.FindElement(By.XPath("//select[@name='key-identifier-select']"));
        //    var seletukprn = new SelectElement(UKPRN);
        //    seletukprn.SelectByText("UKPRN");
        //    int k = 1;
        //    for (int i = 1; i <= rows; i++)
        //    {
        //        int j = 1;
        //        int m = 0;
        //        for (j = 1; j <= columns; j++)
        //        {
        //            Driver.FindElement(By.XPath("(//div[@class='dynamic-table-row'])[" + i + "]/div[" + j + "]")).Click();
        //            Driver.FindElement(By.XPath("//input[@id='design-table-input-select-radio']")).Click();
        //            var Selectheader = Driver.FindElement(By.XPath("//select[@name='design-table-input-select-radio-select']"));
        //            var seletheadervalue = new SelectElement(Selectheader);
        //            seletheadervalue.SelectByIndex(k);
        //            k = k + 1;
        //            if (i == 1)
        //            {
        //                Driver.FindElement(By.XPath("//input[@id='design-table-input-bold-checkbox']")).Click();
        //            }

        //        }


        //    }



        //}
    }
}
