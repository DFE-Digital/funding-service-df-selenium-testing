using Digital_Form_builder_Test;
using Digital_Form_builder_Test.PageObjects;
using Digital_Form_builder_Test.PageObjects.ComponentPages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Digital_Form_builder_Test.Test
{
    class DashBoardTest :BaseTest
    {

        ResultLinkComponentPage calculationpage;
        FormDesignerPage formDesignerPage;
        CreateComponentPage createcomponentPage;

        /*[Test]
        public void CreateForm()
        {
            DashboardPage dashboardPage = new DashboardPage(GetDriver());
            dashboardPage.GetExistingFrom("Closed");
            dashboardPage.ClickChangeFormStatus();
            /*dashboardPage.ClickCreateFormBtn();
            string URL = GetDriver().Url;
            Assert.AreEqual("https://b105d01as-df-designer.azurewebsites.net/app/new", URL);
        }

        [Test]
        public void SelectForm()
        {
            StartPage startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            dashboardPage.SelectAnyExistingFormByStatus("Published");
            //dashboardPage.SelectAnyExistingFormByStatus("Published");
            //ChangeFormStatusPage changeformstatuspage = dashboardPage.ClickChangeFormStatus();
            //changeformstatuspage.ChangeFromStatusToUAT();
            //changeformstatuspage.SelectBackBtn();*/

        [Test, Category("Regression2343")]
        public void VerifyMyFormsAllButtonDisable()
        {
            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            Assert.IsTrue(!dashboardPage.EditForm().Enabled);
            Assert.IsTrue(!dashboardPage.DuplicateForm().Enabled);
            Assert.IsTrue(!dashboardPage.ChangeFormStatus().Enabled);
            //Assert.IsTrue(!dashboardPage.AccessTypeBtn().Enabled);
            Assert.IsTrue(!dashboardPage.DeleteForm().Enabled);

        }

        [Test, Category("Regression23443")]
        public void VerifyMyFormsAllButtonEnabled()
        {
            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            dashboardPage.SelectExistingMyFormByStatus("AnyForm");
            Assert.IsTrue(dashboardPage.EditForm().Enabled);
            Assert.IsTrue(dashboardPage.DuplicateForm().Enabled);
            Assert.IsTrue(dashboardPage.ChangeFormStatus().Enabled);
           // Assert.IsTrue(dashboardPage.AccessTypeBtn().Enabled);
            Assert.IsTrue(dashboardPage.DeleteForm().Enabled);

        }


        [Test, Category("Regression2343")]
        public void VerifyColleagueFormsAllButtonDisable()
        {
            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            Assert.IsTrue(!dashboardPage.EditColleaguesForm().Enabled);
            Assert.IsTrue(!dashboardPage.ColleaguesDuplicateForm().Enabled);
            Assert.IsTrue(!dashboardPage.ColleaguesFormStatus().Enabled);
            Assert.IsTrue(!dashboardPage.ColleaguesAccessTypeBtn().Enabled);
           

        }

        [Test, Category("Regression2343")]
        public void VerifyColleagueFormsAllButtonEnabled()
        {
            StartPage Startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = Startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            dashboardPage.SelectExistingColleaguesFormByStatus("AnyForm");
            Assert.IsTrue(dashboardPage.EditColleaguesForm().Enabled);
            Assert.IsTrue(dashboardPage.ColleaguesDuplicateForm().Enabled);
            Assert.IsTrue(dashboardPage.ColleaguesFormStatus().Enabled);
            Assert.IsTrue(dashboardPage.ColleaguesAccessTypeBtn().Enabled);

        }




    }

}

