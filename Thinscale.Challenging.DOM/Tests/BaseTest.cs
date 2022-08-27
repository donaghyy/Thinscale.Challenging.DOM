using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.MarkupUtils;
using NUnit.Framework.Interfaces;
using ReportingLibrary;
using Test;
using SeleniumHelperLibrary;
using Thinscale.Challenging.DOM.PageImpl;

namespace Thinscale.Challenging.DOM
{
    [TestFixture] // Denotes this is a test suite
    public abstract class BaseTest
    {
        protected IWebDriver driver;
        protected Browsers browser;
        protected ChallengingDOM_Impl Page;
        protected ExtentReportsHelper extent;


        [OneTimeSetUp]
        public void BeforeClass() // executes once before the test class is ran
        {
            extent = new ExtentReportsHelper();

        }




        [SetUp]
        public void BeforeTest() // Triggered before every test 
        {
            extent.CreateTest(TestContext.CurrentContext.Test.Name);
            browser = new Browsers(extent);
            browser.Init();
            driver = browser.getDriver;
            Page = new ChallengingDOM_Impl(browser, extent, driver);

        }

        [TearDown]
        public void AfterTest() // Triggered after every test case
        {
            try
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stacktrace = TestContext.CurrentContext.Result.StackTrace;
                var errorMessage = "<pre>" + TestContext.CurrentContext.Result.Message + "</pre>";
                switch (status)
                {
                    case TestStatus.Failed:
                        extent.SetTestStatusFail($"<br>{errorMessage}<br>Stack Trace: <br>{stacktrace}<br>");
                        extent.AddTestFailureScreenshot(browser.getDriver.ScreenCaptureAsBase64String());
                        extent.LogInfo("Screenshot captured");
                        break;
                    case TestStatus.Skipped:
                        extent.SetTestStatusSkipped();
                        break;
                    default:
                        extent.SetTestStatusPass();
                        break;
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
            finally
            {
                browser.Close();
            }
        }




        

        [OneTimeTearDown]
        public void AfterClass() // Executes after the class has been ran
        {
            try
            {
                extent.Close();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }



      
    }
}
