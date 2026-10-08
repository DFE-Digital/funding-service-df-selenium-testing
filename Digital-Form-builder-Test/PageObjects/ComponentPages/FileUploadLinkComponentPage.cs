using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects.ComponentPages
{
    public class FileUploadLinkComponentPage
    {

        private IWebDriver Driver;


        public FileUploadLinkComponentPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }


    }
}
