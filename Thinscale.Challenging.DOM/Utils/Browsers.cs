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
using Thinscale.Challenging.DOM;
using Microsoft.Extensions.Configuration;


namespace Test
{
    public class Browsers
    { 
        public Browsers(ExtentReportsHelper reportsHelper)
        {
            baseURL = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["url"];
            browser = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["browser"];
            extentReportsHelper = reportsHelper;
        }
        public Browsers() // Overloading method so that variables can be used in ExtentReports without extentReportsHelper
        {
            baseURL = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["url"];
            browser = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["browser"];
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

                    Console.WriteLine("SELECTED BROWSER: " + browser);
                    webDriver = new ChromeDriver(GetBrowserOptions(browser));
                    webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                    break;

                case "Firefox":

                    Console.WriteLine("SELECTED BROWSER: " + browser);
                    webDriver = new FirefoxDriver(GetBrowserOptions(browser));
                    webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                    break;

                default:

                    webDriver = new ChromeDriver(GetBrowserOptions(browser));
                    break;
            }

            Console.WriteLine("\n" + "\n" + "====================================================================" + "\n");
            extentReportsHelper.SetStepStatusPass("Browser started.");
            webDriver.Manage().Window.Maximize();
            extentReportsHelper.SetStepStatusPass("Browser maximized.");
            Goto(baseURL);

        }

        private dynamic GetBrowserOptions(string browser)
        {
            if (browser == "Chrome") {
                var options = new ChromeOptions();
                options.AddArguments("--no-sandbox"); // Bypass OS security model
                options.AddArguments("--headless");
                options.AddArguments("disable-infobars"); // disabling infobars
                options.AddArguments("--disable-extensions"); // disabling extensions
                options.AddArguments("--disable-dev-shm-usage"); // overcome limited resource problems
                return options;
            }
            else if (browser == "Firefox") {
                var options = new FirefoxOptions();
                options.AddArguments("--no-sandbox"); // Bypass OS security model
                options.AddArguments("--headless");
                options.AddArguments("disable-infobars"); // disabling infobars
                options.AddArguments("--disable-extensions"); // disabling extensions
                options.AddArguments("--disable-dev-shm-usage"); // overcome limited resource problems
                return options;
            }

            return new ChromeOptions();
            
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
