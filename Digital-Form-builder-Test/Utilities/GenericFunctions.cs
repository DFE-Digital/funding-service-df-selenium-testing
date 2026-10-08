using AventStack.ExtentReports;
using java.util.concurrent;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Form_builder_Test.Utilities
{
    public class GenericFunctions
    {
        public IJavaScriptExecutor executor;
        public IWebDriver Driver = BaseTest.GetDriver();

        public void ScrollDownToElement(IWebDriver Driver,By element)
        {
            var K = Driver.FindElement(element);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", K);

        }
        
        public void WaitForElement(IWebDriver Driver,By element)
        {
           // element = By.XPath(element);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }
        public void ClickAlert()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.Accept();
        }
        public void Click(IWebDriver Driver,By element)
        {
            try
            {
               // WaitForElement(Driver, element);
                Driver.FindElement(element).Click();
            }
            catch(Exception e)
            {
              executor.ExecuteScript("arguments[0].click();", Driver.FindElement(element));
            }
        }
        public bool isDisplayed(IWebDriver Driver, By element)
        {
            bool flag;
            try
            {
                // WaitForElement(Driver, element);
               flag= Driver.FindElement(element).Displayed;
            }
            catch (Exception e)
            {
                flag= false;
            }
            return flag;
        }
        public void Clickwebelement(IWebDriver Driver, string element)
        {
            try
            {
                // WaitForElement(Driver, element);
                Driver.FindElement(By.XPath(element)).Click();
            }
            catch (Exception e)
            {
                executor.ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath(element)));
            }
        }
        public void SelectElementByText(IWebDriver Driver, By element,String text)
        {
            var selectElement = new SelectElement(Driver.FindElement(element));
            selectElement.SelectByText(text.Trim());
       }
        public void Scrolldownpage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        public void SendKeys(IWebDriver Driver, By element, String text)
        {
            try
            {   
                WaitForElement(Driver,element);
                Driver.FindElement(element).Clear();
                Driver.FindElement(element).SendKeys(text.Trim());
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string GetText(IWebDriver Driver, By element)
        {
            try
            {
                WaitForElement(Driver, element);
                return Driver.FindElement(element).Text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;    
            }
        }
        public string GetValue(IWebDriver Driver, By element)
        {
            try
            {
              //  WaitForElement(Driver, element);
                return Driver.FindElement(element).GetAttribute("value");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public void WaitForPageToLoad(IWebElement element)
        {
            IWebElement oldPage = Driver.FindElement(By.XPath("(//a[@title='Preview page'])[1]"));
           // doing();
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 20));
            try
            {
                wait.Until(driver => ExpectedConditions.StalenessOf(element)(Driver) &&
                    ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
            }
            catch (Exception e)
            {

            }
        }

        public string GetRecentDownloadedFILE()
        {
            string Folder = Environment.GetEnvironmentVariable("USERPROFILE") + @"\OneDrive - Department for Education\" + "Downloads";
            var files = new DirectoryInfo(Folder).GetFiles("*.*");
            string latestfile = "";
            DateTime lastModified = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastModified)
                {
                    lastModified = file.LastWriteTime;
                    latestfile = file.Name;

                }
            }
            return latestfile;
        }
    
    }
}
