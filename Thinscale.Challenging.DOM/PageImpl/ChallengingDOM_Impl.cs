using System;
using System.Threading;
using AventStack.ExtentReports;
using Microsoft.Extensions.Logging.Console.Internal;
using NUnit.Framework;
using OpenQA.Selenium;
using ReportingLibrary;
using SeleniumHelperLibrary;
using Test;
using Thinscale.Challenging.DOM.Utils;

namespace Thinscale.Challenging.DOM.PageImpl

{
    public class ChallengingDOM_Impl
    {
        IWebDriver driver;
        Browsers _browser { get; }
        ExtentReportsHelper _extentReportsHelper { get; set; }


        // overloading the ChallengingDOM_Impl method

        public ChallengingDOM_Impl()
        {
            driver = null;
        }
        
        public ChallengingDOM_Impl(Browsers browser, ExtentReportsHelper extentReportsHelper, IWebDriver webDriver)
        {
            _browser = browser;
            _extentReportsHelper = extentReportsHelper;
            driver = webDriver;
        }
        
        



        public void verifyPageHeader()
        {
            ElementFetch elementFetch = new ElementFetch();
            var pageHeader = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.pageHeader, driver);

            String expectedHeader = "Challenging DOM";
            _extentReportsHelper.LogInfo("The page header is: " + pageHeader.GetAttribute("innerHTML"));

            Assert.IsTrue(pageHeader.GetAttribute("innerHTML") == expectedHeader);
        }

        public void verifyPageTitle()
        {
            
            var title = _browser.Title;
            _extentReportsHelper.LogInfo("The Title for the website is: " + title);

            Assert.IsTrue(driver.Title.Equals("The Internet"));

        }

        public void clickOnBlueButton()
        {
            ElementFetch elementFetch = new ElementFetch();
            var blueButton = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.blueButton, driver);

            var idOld = blueButton.GetAttribute("id");
            

            WebElementHelper.ElementlIsClickable(blueButton, driver, _extentReportsHelper, "Blue button", 30);
            _extentReportsHelper.LogInfo("The ID is " + idOld);

            blueButton.Click();
            _extentReportsHelper.SetStepStatusPass("The blue button has been clicked");

            var blueButtonNew = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.blueButton, driver);
            var idNew = blueButtonNew.GetAttribute("id");
            _extentReportsHelper.LogInfo("The updated ID is " + idNew);


            Assert.IsTrue(idOld != idNew, "The ID's match!" + "\n");


        }

        public void clickOnRedButton()
        {
            ElementFetch elementFetch = new ElementFetch();
            var redButton = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.redButton, driver);

            var idOld = redButton.GetAttribute("id");

            WebElementHelper.ElementlIsClickable(redButton, driver, _extentReportsHelper, "Red button", 30);
            _extentReportsHelper.LogInfo("The ID is " + idOld);

            redButton.Click();
            _extentReportsHelper.SetStepStatusPass("The red button has been clicked");

            var redButtonNew = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.redButton, driver);
            var idNew = redButtonNew.GetAttribute("id");
            _extentReportsHelper.LogInfo("The updated ID is " + idNew);


            Assert.IsTrue(idOld != idNew, "The ID's match!" + "\n");
        }

        public void clickOnGreenButton()
        {
            ElementFetch elementFetch = new ElementFetch();
            var greenButton = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.greenButton, driver);

            var idOld = greenButton.GetAttribute("id");

            WebElementHelper.ElementlIsClickable(greenButton, driver, _extentReportsHelper, "Green button", 30);
            _extentReportsHelper.LogInfo("The ID is " + idOld);

            greenButton.Click();
            _extentReportsHelper.SetStepStatusPass("The green button has been clicked");

            var greenButtonNew = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.greenButton, driver);
            var idNew = greenButtonNew.GetAttribute("id");
            _extentReportsHelper.LogInfo("The updated ID is " + idNew);


            Assert.IsTrue(idOld != idNew, "The ID's match!" + "\n");
        }

    }
}

