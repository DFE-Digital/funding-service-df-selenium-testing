using System;
using System.Collections.Generic;
using System.Text;
using Digital_Form_builder_Test.PageObjects;
using Digital_Form_builder_Test.PageObjects.ComponentPages;
using Digital_Form_builder_Test.PageObjects.RunnerPages;
using Digital_Form_builder_Test.Utilities;
using NUnit.Framework;

namespace Digital_Form_builder_Test.Test
{
    public class RunnerTest : BaseTest
    {
        ResultLinkComponentPage calculationpage;
        FormDesignerPage formDesignerPage;
        CreateComponentPage createcomponentPage;


        [Test, Category("Regression234")]
        public void VerifySubmissionCompletePage()
        {   

            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            formDesignerPage = dashboardPage.OpenAnyExistingForm("cal-test-final");
            RunnerStartPage runnerStartPage = formDesignerPage.ClickFirstPagepPreviewBtn();
            FirstPage firstPage = runnerStartPage.ClickStartNowBtn();
            firstPage.EnterValueInFieldOne(RandomNumberGenerator.RandomNumber());
            firstPage.EnterValueInFieldTwo(RandomNumberGenerator.RandomNumber());
            firstPage.EnterValueInFieldThree(RandomNameGenerator.RandomString(5));
            firstPage.EnterValueInFieldFour(RandomNameGenerator.RandomString(5));
            SecondPage secondPage = firstPage.ClickContinueBtn();
            secondPage.EnterValueInFieldOne(RandomNumberGenerator.RandomNumber());
            secondPage.EnterValueInFieldTwo(RandomNumberGenerator.RandomNumber());
            secondPage.EnterValueInFieldThree(RandomNameGenerator.RandomString(5));
            SummaryPage summaryPage = secondPage.ClickContinueBtn();
            SubmissionCompletePage submissionCompletePage = summaryPage.ClickSubmitBtn();
            Assert.AreEqual("Submission complete", submissionCompletePage.SubmissionComplete().Text);
            Assert.AreNotEqual("Application complete", submissionCompletePage.SubmissionComplete().Text);
        }
    }
}
