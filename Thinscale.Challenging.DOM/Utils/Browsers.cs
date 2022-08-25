//Browsers.cs
using AventStack.ExtentReports.Configuration;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using ReportingLibrary;
using System;
using System.Configuration;
using Thinscale.Challenging.DOM.Utils;


namespace Test
{
    public class Browsers
    {
        public Browsers(ExtentReportsHelper reportsHelper)
        {
            baseURL = "https://the-internet.herokuapp.com/challenging_dom";               //ConfigurationManager.AppSettings["url"];           find out how to setup app config file 
            browser = "Chrome";                                                           // ConfigurationManager.AppSettings["browser"];
            extentReportsHelper = reportsHelper;
        }
        public Browsers() // Overloading method so that variables can be used in ExtentReports without extentReportsHelper
        {
            baseURL = "https://the-internet.herokuapp.com/challenging_dom";               //ConfigurationManager.AppSettings["url"];           find out how to setup app config file 
            browser = "Chrome";                 
        }

        private IWebDriver webDriver;
        private string baseURL;
        private string browser;
        private ExtentReportsHelper extentReportsHelper;

        public void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--no-sandbox"); // Bypass OS security model
                    options.AddArguments("--headless");
                    options.AddArguments("disable-infobars"); // disabling infobars
                    options.AddArguments("--disable-extensions"); // disabling extensions
                    options.AddArguments("--disable-dev-shm-usage"); // overcome limited resource problems
                    
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }

            extentReportsHelper.SetStepStatusPass("Browser started.");
            webDriver.Manage().Window.Maximize();
            extentReportsHelper.SetStepStatusPass("Browser maximized.");
            Goto(baseURL);

        }

        public string Title
        {
            get { return webDriver.Title; }
        }

        public IWebDriver getDriver
        {
            get { return webDriver; }
        }

        public String browserPlatform
        {
            get { return browser; }
        }

        //common operations

        

        public void Goto(string url)
        {
            webDriver.Url = url;
            extentReportsHelper.SetStepStatusPass($"Browser navigated to the url [{url}].");
        }
        public void Close()
        {
            webDriver.Quit();
            extentReportsHelper.SetStepStatusPass($"Browser closed.");
        }
    }
}
