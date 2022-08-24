﻿//Browsers.cs
using AventStack.ExtentReports.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using ReportingLibrary;
using System.Configuration;


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
