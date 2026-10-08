using Digital_Form_builder_Test.PageObjects;
using Digital_Form_builder_Test.PageObjects.RunnerPages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.Test
{
    public class ChangeFormStatusTest : BaseTest
    {
        [Test]
        public void VerifyClosedFormNotAccessiable()
        {
            StartPage startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            dashboardPage.SelectExistingMyFormByStatus("Closed");
            FormDesignerPage formdesignerPage = dashboardPage.ClickEditForm();
            RunnerStartPage runnerStartpage = formdesignerPage.ClickFirstPagepPreviewBtn();
            //Assert.AreEqual("Applications have closed", runnerStartpage.ApplicationClosed());

        }
        /*
        [Test]
        public void VerifyClosedFormNotAccessiable()
        {
            StartPage startpage = new StartPage(GetDriver());
            DashboardPage dashboardPage = startpage.ClickStartNowBtn();
            dashboardPage.WaitForDashboardPageToDisplay();
            dashboardPage.SelectAnyExistingFormByStatus("Closed");
            FormDesignerPage formdesignerPage = dashboardPage.ClickEditForm();
            RunnerPage  runnerpage = formdesignerPage.ClickFirstPagePreviewBtn();
            Assert.AreEqual("Applications have closed", runnerpage.ApplicationClosed());

        }


        [Test]
        public void VerifyChangeFromStatusDevToUAT()
        {
            try
            {
                DashboardPage dashboardPage = new DashboardPage(GetDriver());
                dashboardPage.GetExistingFrom("In development");
                ChangeFormStatusPage changeformstatusPage = dashboardPage.ClickChangeFormStatus();
                changeformstatusPage.SelectRdoBtnUat();
                changeformstatusPage.SelectUpdateFormStatusBtn();
                changeformstatusPage.SelectConfirmCheckBox();
                changeformstatusPage.SelectContinueBtnOnAlert();
                changeformstatusPage.SelectBackBtn();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            

        }

        [Test]
        public void VerifyChangeFromStatusUatToDev()
        {
            try
            {
                DashboardPage dashboardPage = new DashboardPage(GetDriver());
                dashboardPage.GetExistingFrom("UAT");
                ChangeFormStatusPage changeformstatusPage = dashboardPage.ClickChangeFormStatus();
                changeformstatusPage.SelectRdoBtnDevelopment();
                changeformstatusPage.SelectUpdateFormStatusBtn();
                changeformstatusPage.SelectConfirmCheckBox();
                changeformstatusPage.SelectContinueBtnOnAlert();
                changeformstatusPage.SelectBackBtn();
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
           
        }


        [Test]
        public void VerifyChangeFromStatusUatToPublished()
        {

            try
            {
                DashboardPage dashboardPage = new DashboardPage(GetDriver());
                dashboardPage.GetExistingFrom("UAT");
                ChangeFormStatusPage changeformstatusPage = dashboardPage.ClickChangeFormStatus();
                changeformstatusPage.SelectRdoBtnPublished();
                changeformstatusPage.SelectUpdateFormStatusBtn();
                changeformstatusPage.SelectConfirmCheckBox();
                changeformstatusPage.SelectContinueBtnOnAlert();
                changeformstatusPage.SelectBackBtn();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            

        }

        [Test]
        public void VerifyChangeFromStatusPublishedToUat()
        {

            try
            {
                DashboardPage dashboardPage = new DashboardPage(GetDriver());
                dashboardPage.GetExistingFrom("Published");
                ChangeFormStatusPage changeformstatusPage = dashboardPage.ClickChangeFormStatus();
                changeformstatusPage.SelectRdoBtnUat();
                changeformstatusPage.SelectUpdateFormStatusBtn();
                changeformstatusPage.SelectConfirmCheckBox();
                changeformstatusPage.SelectContinueBtnOnAlert();
                changeformstatusPage.SelectBackBtn();
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            

        }

        [Test]
        public void VerifyChangeFromStatusPublishedToClosed()
        {

            try
            {
                DashboardPage dashboardPage = new DashboardPage(GetDriver());
                dashboardPage.GetExistingFrom("Published");
                ChangeFormStatusPage changeformstatusPage = dashboardPage.ClickChangeFormStatus();
                changeformstatusPage.SelectRdoBtnClosed();
                changeformstatusPage.SelectUpdateFormStatusBtn();
                changeformstatusPage.SelectConfirmCheckBox();
                changeformstatusPage.SelectContinueBtnOnAlert();
                changeformstatusPage.SelectBackBtn();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            

        }

        [Test]
        public void VerifyChangeFromStatusClosedtoDev()
        {

            try
            {
                DashboardPage dashboardPage = new DashboardPage(GetDriver());
                dashboardPage.GetExistingFrom("Closed");
                ChangeFormStatusPage changeformstatusPage = dashboardPage.ClickChangeFormStatus();
                changeformstatusPage.SelectRdoBtnDevelopment();
                changeformstatusPage.SelectUpdateFormStatusBtn();
                changeformstatusPage.SelectConfirmCheckBox();
                changeformstatusPage.SelectContinueBtnOnAlert();
                changeformstatusPage.SelectBackBtn();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

        [Test]
        public void VerifyStaticErrorPage()
        {
            
        }*/
    }
}
