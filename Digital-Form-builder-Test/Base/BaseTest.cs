using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;
using System.IO;
using WebDriverManager.DriverConfigs.Impl;
using Digital_Form_builder_Test.Utilities;
using Digital_Form_builder_Test.CustomeException;
using AventStack.ExtentReports.Gherkin.Model;
using System.Text.RegularExpressions;
using Serilog.Core;
using Serilog.Events;
using Serilog;
using WebDriverManager.Helpers;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static System.Net.Mime.MediaTypeNames;
using Reqnroll;

namespace Digital_Form_builder_Test
{
    [Binding]
    public class BaseTest
    {

        public static string browsername = ConfigurationManager.AppSettings["BROWSER"];
        public static string urlname = "https://" + ConfigurationManager.AppSettings["Enviornment"] + ".designer.digital-forms.education.gov.uk/app/";
        private static IWebDriver Driver;
        public static ExtentReports _extentReports;
        public static ExtentTest test;
        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static string Report_Direct = projectDirectory + "/Report/";
        public static string logs = projectDirectory + "/logs/";
        [OneTimeSetUp]
        [BeforeTestRun]
        public static void StartReport()
        {

            string workingdirectory = Environment.CurrentDirectory;
            string projectdirectory = Directory.GetParent(workingdirectory).Parent.Parent.FullName;
            string reportpath = projectdirectory + "//DigitalFormReport.html";
            var htmlReporter = new ExtentHtmlReporter(reportpath);
            _extentReports = new ExtentReports();
            _extentReports.AddSystemInfo("Browser Vesion", ConfigurationManager.AppSettings["BROWSER"]);
            _extentReports.AnalysisStrategy = AnalysisStrategy.BDD;
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            _extentReports.AttachReporter(htmlReporter);
            InitBrowser(browsername);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.Manage().Window.Maximize();
            Driver.Url = urlname;
            LoggingLevelSwitch levelswitch = new LoggingLevelSwitch(LogEventLevel.Debug);
            Serilog.Log.Logger = new LoggerConfiguration()
                        .MinimumLevel.ControlledBy(levelswitch)
                        .WriteTo.File(logs + "/logs", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message}{NewLine} ", rollingInterval: RollingInterval.Day).CreateLogger();

        }



        public static void InitBrowser(string browsername)
        {
            switch (browsername)
            {
                case "chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
                    Driver = new ChromeDriver();
                    break;

                case "edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig(), VersionResolveStrategy.MatchingBrowser);
                    Driver = new EdgeDriver();
                    break;
                case "headless":
                    ChromeOptions Options = new ChromeOptions();
                    Options.AddArguments("headless");
                    Driver = new ChromeDriver(Options);

                    break;
                default:
                    throw new NoSuitableDriverFound("Choose the correct driver from edge or chrome" + browsername);

            }
        }

        public static IWebDriver GetDriver()
        {
            return Driver;
        }

        [BeforeScenario]
        public static void BeforeScenarioStart(ScenarioContext scenariocontext)
        {
            if (null != scenariocontext)
            {
                _scenarioContext = scenariocontext;
                _scenario = _feature.CreateNode<Scenario>(scenariocontext.ScenarioInfo.Title,
                    scenariocontext.ScenarioInfo.Description);
                Serilog.Log.Information("Selecting sceanrio {0} file to run", scenariocontext.ScenarioInfo.Title);
                TestContext.Progress.WriteLine("****-------------------------------------------------------------------****");
                TestContext.Progress.WriteLine("Started--Executing " + scenariocontext.ScenarioInfo.Title);

            }

        }
        [AfterScenario]
        public static void AfterScenarioStart(ScenarioContext scenariocontext)
        {

            TestContext.Progress.WriteLine("Ended  --Executing " + scenariocontext.ScenarioInfo.Title);
            Serilog.Log.Information("Executed sceanrio {0} ", scenariocontext.ScenarioInfo.Title);

        }
        [TearDown]
        [Reqnroll.AfterStep]
        public static void TearDown()
        {


            DateTime time = DateTime.Now;
            String filename = "Screenshot" + time.ToString("h_mm_ss") + ".png";
            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;
            Console.WriteLine(scenarioBlock);
            string[] variable_name = _scenarioContext.ScenarioInfo.CombinedTags;
            Console.WriteLine(variable_name[0]);
            switch (scenarioBlock)
            {
                case ScenarioBlock.Given:
                    CreateNode<Given>();
                    break;
                case ScenarioBlock.When:
                    CreateNode<When>();
                    break;
                case ScenarioBlock.Then:
                    CreateNode<Then>();
                    break;
                default:
                    CreateNode<And>();
                    break;
            }

        }


        public static void CreateNode<T>() where T : IGherkinFormatterModel
        {
            string[] variable_name = _scenarioContext.ScenarioInfo.CombinedTags;
            DateTime time = DateTime.Now;
            String filename = "Screenshot" + time.ToString("h_mm_ss") + ".png";
            if (_scenarioContext.TestError != null)
            {
                string name = _scenarioContext.StepContext.StepInfo.Text;
                name = Regex.Replace(name, @"[^0-9a-zA-Z\._]", "");
                _scenario.CreateNode<T>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message).AddScreenCaptureFromPath(name);
                _scenario.AssignCategory(variable_name[0]);


            }
            else
            {
                string name = _scenarioContext.StepContext.StepInfo.Text;
                name = Regex.Replace(name, @"[^0-9a-zA-Z\._]", "");
                _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Pass("Passed", GetScreenshot(Driver));
            }
        }
        public static MediaEntityModelProvider GetScreenshot(IWebDriver webDriver)
        {
            var screenshot = ((ITakesScreenshot)webDriver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot).Build();
        }
        public static MediaEntityModelProvider CaptureScreenShot(IWebDriver Driver, String screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)Driver;
            String screenShot = ts.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenShot, screenShotName).Build();

        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featurecontext)
        {
            if (null != featurecontext)
            {
                _feature = _extentReports.CreateTest<Feature>(featurecontext.FeatureInfo.Title,
                    featurecontext.FeatureInfo.Description);
            }
            Serilog.Log.Information("Selecting feature {0} file to run", featurecontext.FeatureInfo.Title);

        }
        [OneTimeTearDown]
        [AfterTestRun]
        public static void GenerateReport()
        {
            _extentReports.Flush();
            Driver.Quit();
            TestContext.Progress.WriteLine("****-------------------------------------------------------------------****");
            TestContext.Progress.WriteLine("****------------------------Execution Finished------------------------****");
        }

    }
}