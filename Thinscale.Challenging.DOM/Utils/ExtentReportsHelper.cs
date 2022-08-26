using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using Test;

namespace ReportingLibrary
{
    public class ExtentReportsHelper
    {
        public ExtentReports extent { get; set; }
        public ExtentV3HtmlReporter reporter { get; set; }
        public ExtentTest test { get; set; }
        public Browsers browser { get; }

        public ExtentV3HtmlReporter reporter2 { get; set; }


        public ExtentReportsHelper()
        {
            browser = new Browsers();

            // Uncomment 1 for Online Reports or 2 for Local Reports

            // Report that gets published to GitHub Pages
            extent = new ExtentReports();
            reporter = new ExtentV3HtmlReporter(@"./Reports/index.html");
            reporter.Config.ReportName = "Automated Testing";
            reporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent.AttachReporter(reporter);
            extent.AddSystemInfo("Application Under Test", "Challenging DOM");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Machine", Environment.MachineName);
            extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);
            extent.AddSystemInfo("BrowserPlatform", browser.browserPlatform);
            extent.Stats.ChildPercentagePass.ToString();

            //// Save locally (to solution structure)
            //reporter2 = new ExtentV3HtmlReporter(@"/Users/daviddonaghy/Documents/GitHub/Thinscale.Challenging.DOM/Thinscale.Challenging.DOM/Reports/" + DateTime.Now.ToString("MM_dd_yy" + " / " + "HH_mm_ss") + "_ExtentReport.HTML");
            //reporter2.Config.ReportName = "Regression Testing";
            //reporter2.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            //extent.AttachReporter(reporter2);
            //extent.AddSystemInfo("Application Under Test", "Challenging DOM");
            //extent.AddSystemInfo("Environment", "QA");
            //extent.AddSystemInfo("Machine", Environment.MachineName);
            //extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);
            //extent.AddSystemInfo("BrowserPlatform", browser.browserPlatform);



        }


        public void CreateTest(string testName) // Creates a Test
        {
            test = extent.CreateTest(testName);
        }


        public void SetStepStatusPass(string stepDescription) // Sets Test Step Status to PASS
        {
            test.Log(Status.Pass, stepDescription); // logs on html report
            Console.WriteLine("Step Pass: " + stepDescription); // logs to console in realtime
        }


        public void SetStepStatusWarning(string stepDescription) // Sets Test Step Status to WARNING
        {
            test.Log(Status.Warning, stepDescription);
            Console.WriteLine("Step Warning: " + stepDescription);
        }


        public void SetTestStatusPass() // Sets Overall Test status to PASS
        {
            test.Pass("Test Executed Sucessfully!");
        }


        public void SetTestStatusFail(string message = null)  // Sets overall Test status to FAIL with an Error message
        {
            var printMessage = "<p><b>Test FAILED!</b></p>";
            if (!string.IsNullOrEmpty(message))
            {
                printMessage += $"Message: <br>{message}<br>";
            }
            test.Fail(printMessage);
        }


        public void AddTestFailureScreenshot(string base64ScreenCapture) // adds exception screenshot to Extent Report
        {
            test.AddScreenCaptureFromBase64String(base64ScreenCapture, "Screenshot on Error:");
        }


        public void SetTestStatusSkipped() // sets overall test status to Skipped
        {
            test.Skip("Test skipped!");
        }

        public void LogInfo(String info)
        {
            test.Log(Status.Info, info);
            Console.WriteLine("info: " + info);
        }


        public void Close() // writes or updates all the information to our reporter
        {
            extent.Flush();
        }
    }
}