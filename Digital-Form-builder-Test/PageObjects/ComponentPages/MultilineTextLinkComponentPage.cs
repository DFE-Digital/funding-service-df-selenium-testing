using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects.ComponentPages
{
    public class MultilineTextLinkComponentPage
    {

        private IWebDriver Driver;


        public MultilineTextLinkComponentPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }


    }
}
