using Digital_Form_builder_Test.PageObjects.ComponentPages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.PageObjects
{
    public class CreateComponentPage
    {
        private IWebDriver Driver;
        public IJavaScriptExecutor executor;
        public CreateComponentPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        //Page objects 
      

        [FindsBy(How = How.LinkText, Using = "Details")]
        private IWebElement DetailsLink;

        [FindsBy(How = How.LinkText, Using = "Flash card")]
        private IWebElement FlashCardLink;

        [FindsBy(How = How.LinkText, Using = "HTML")]
        private IWebElement HTMLLink;

        [FindsBy(How = How.LinkText, Using = "Inset text")]
        private IWebElement InsettextLink;

        [FindsBy(How = How.LinkText, Using = "List")]
        private IWebElement ListLink;

        [FindsBy(How = How.LinkText, Using = "Paragraph")]
        private IWebElement ParagraphLink;

        [FindsBy(How = How.LinkText, Using = "Result")]
        private IWebElement ResultLink;

        [FindsBy(How = How.LinkText, Using = "Autocomplete")]
        private IWebElement AutocompleteLink;

        [FindsBy(How = How.LinkText, Using = "Date")]
        private IWebElement DateLink;

        [FindsBy(How = How.LinkText, Using = "Date parts")]
        private IWebElement DatePartsLink;

        [FindsBy(How = How.LinkText, Using = "Date time")]
        private IWebElement DateTimeLink;

        [FindsBy(How = How.LinkText, Using = "Date time parts")]
        private IWebElement DateTimePartsLink;

        [FindsBy(How = How.LinkText, Using = "Email address")]
        private IWebElement EmailAddressLink;

        [FindsBy(How = How.LinkText, Using = "File upload")]
        private IWebElement FileUploadLink;

        [FindsBy(How = How.LinkText, Using = "Month year parts")]
        private IWebElement MonthYearPartsLink;

        [FindsBy(How = How.LinkText, Using = "Multiline text")]
        private IWebElement MultiLineTextLink;

        [FindsBy(How = How.LinkText, Using = "Number")]
        private IWebElement NumberLink;

        [FindsBy(How = How.LinkText, Using = "Telephone number")]
        private IWebElement TelephoneNumberLink;

        [FindsBy(How = How.LinkText, Using = "Text")]
        private IWebElement TextLink;

        [FindsBy(How = How.LinkText, Using = "Time")]
        private IWebElement TimeLink;

        [FindsBy(How = How.LinkText, Using = "UK address")]
        private IWebElement UKAddressLink;

        [FindsBy(How = How.LinkText, Using = "Website")]
        private IWebElement WebsiteLink;

        [FindsBy(How = How.LinkText, Using = "Checkboxes")]
        private IWebElement CheckboxesLink;

        [FindsBy(How = How.LinkText, Using = "Radios")]
        private IWebElement RadiosLink;

        [FindsBy(How = How.LinkText, Using = "Select")]
        private IWebElement SelectLink;

        [FindsBy(How = How.LinkText, Using = "YesNo")]
        private IWebElement YesNoLink;



        //Methods to access page objects


        public DetailsLinkComponentPage ClickDetailsLink()
        {
            DetailsLink.Click();
            return new DetailsLinkComponentPage(Driver);
        }

        public FlashCardLinkComponentPage ClickFlashCardLink()
        {
            FlashCardLink.Click();
            return new FlashCardLinkComponentPage(Driver);
        }

        public HTMLLinkComponentPage ClickHTMLLink()
        {
            HTMLLink.Click();
            return new HTMLLinkComponentPage(Driver);
        }

        public InsetTextLinkComponentPage ClickInsetTextLink()
        {
            InsettextLink.Click();
            return new InsetTextLinkComponentPage(Driver);
        }

        public ListLinkComponentPage ClickListLink()
        {
            ListLink.Click();
            return new ListLinkComponentPage(Driver);
        }

        public ParagraphLinkComponentPage ClickParagraphLink()
        {
            ParagraphLink.Click();
            return new ParagraphLinkComponentPage(Driver);
        }

        public ResultLinkComponentPage ClickResultLink()
        {
            ResultLink.Click();
            return new ResultLinkComponentPage(Driver);
        }

        public IWebElement IsDisplayedResultLink()
        {

            return ResultLink;
        }


        public AutocompleteLinkComponentPage ClickAutocompleteLink()
        {
            AutocompleteLink.Click();
            return new AutocompleteLinkComponentPage(Driver);
        }

        public DateLinkComponentPage ClickDateLink()
        {
            DateLink.Click();
            return new DateLinkComponentPage(Driver);
        }

        public DatePartsLinkComponentPage ClickDatePartsLink()
        {
            DatePartsLink.Click();
            return new DatePartsLinkComponentPage(Driver);
        }

        public DateTimeLinkComponentPage ClickDateTimeLink()
        {
            DateTimeLink.Click();
            return new DateTimeLinkComponentPage(Driver);
        }

        public DateTimePartsLinkComponentPage ClickDateTimePartsLink()
        {
            DateTimePartsLink.Click();
            return new DateTimePartsLinkComponentPage(Driver);
        }

        public EmailAddressLinkComponentPage ClickEmailAddressLink()
        {
            EmailAddressLink.Click();
            return new EmailAddressLinkComponentPage(Driver);
        }

        public FileUploadLinkComponentPage ClickFileUploadLink()
        {
            FileUploadLink.Click();
            return new FileUploadLinkComponentPage(Driver);
        }

        public MonthYearPartsLinkComponentPage ClickMonthYearPartsLink()
        {
            MonthYearPartsLink.Click();
            return new MonthYearPartsLinkComponentPage(Driver);
        }

        public MultilineTextLinkComponentPage ClickMultilineTextLink()
        {
            MultiLineTextLink.Click();
            return new MultilineTextLinkComponentPage(Driver);
        }

        public NumberLinkComponentPage ClickNumberLink()
        {
            try
            {
                NumberLink.Click();
                return new NumberLinkComponentPage(Driver);
            }
            catch (Exception ex)
            {

                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", NumberLink);
                return new NumberLinkComponentPage(Driver);

            }
            
        }

        public TelephoneNumberLinkComponentPage ClickTelephonenumberLink()
        {
            TelephoneNumberLink.Click();
            return new TelephoneNumberLinkComponentPage(Driver);
        }

        public TextLinkComponentPage ClickTextLink()
        {

            try
            {
                TextLink.Click();
                return new TextLinkComponentPage(Driver);
            }
            catch (Exception ex)
            {

                executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", TextLink);
                return new TextLinkComponentPage(Driver);

            }

           
            
        }

        public TimeLinkComponentPage ClickTimeLink()
        {
            TimeLink.Click();
            return new TimeLinkComponentPage(Driver);
        }

        public UKAddressLinkComponentPage ClickUKAddressLink()
        {
            UKAddressLink.Click();
            return new UKAddressLinkComponentPage(Driver);
        }

        public WebsiteLinkComponentPage ClickWebsiteLink()
        {
            WebsiteLink.Click();
            return new WebsiteLinkComponentPage(Driver);
        }

        public CheckboxesLinkComponentPage ClickCheckboxesLink()
        {
            CheckboxesLink.Click();
            return new CheckboxesLinkComponentPage(Driver);
        }

        public RadiosLinkComponentPage ClickRadiosLink()
        {
            RadiosLink.Click();
            return new RadiosLinkComponentPage(Driver);
        }

        public SelectLinkComponentPage ClickSelectLink()
        {
            SelectLink.Click();
            return new SelectLinkComponentPage(Driver);
        }

        public YesNoLinkComponentPage ClickYesNoLink()
        {
            YesNoLink.Click();
            return new YesNoLinkComponentPage(Driver);
        }


        

    }
}
