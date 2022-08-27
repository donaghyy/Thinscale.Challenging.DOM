using System;
using System.Threading;
using AventStack.ExtentReports;
using Microsoft.Extensions.Logging.Console.Internal;
using NUnit.Framework;
using OpenQA.Selenium;
using ReportingLibrary;
using SeleniumFramework.Utils;
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
        ElementFetch elementFetch;


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





        public void verifyAnswerRefreshes()
        {



        }




        public void verifyDeleteButton()
        {

            elementFetch = new ElementFetch();
            var deleteButton = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.deleteButtonRow1, driver);

            deleteButton.Click();
            _extentReportsHelper.SetStepStatusPass("Delete button has been clicked");

            Assert.IsTrue(WebElementHelper.ValidateURLContains(driver, _extentReportsHelper, "#delete", 30), "URL Does not contain #delete");

        }

        public void verifyTableColumns()
        {
            String expectedValue1 = "Iuvaret0";
            String expectedValue2 = "Iuvaret1";
            String expectedValue3 = "Iuvaret2";
            String expectedValue4 = "Iuvaret3";
            String expectedValue5 = "Iuvaret4"; 
            String expectedValue6 = "Iuvaret5";
            String expectedValue7 = "Iuvaret6";
            String expectedValue8 = "Iuvaret7";
            String expectedValue9 = "Iuvaret8";
            String expectedValue10 = "Iuvaret9";


            elementFetch = new ElementFetch();
            var tableColumn1 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableColumn1, driver);
            var tableColumn2 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableColumn2, driver);
            var tableColumn3 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableColumn3, driver);
            var tableColumn4 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableColumn4, driver);
            var tableColumn5 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableColumn5, driver);
            var tableColumn6 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableColumn6, driver);
            var tableColumn7 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableColumn7, driver);
            var tableColumn8 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableColumn8, driver);
            var tableColumn9 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableColumn9, driver);
            var tableColumn10 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableColumn10, driver);


            String tableColumn1_text = tableColumn1.GetAttribute("innerHTML");
            String tableColumn2_text = tableColumn2.GetAttribute("innerHTML");
            String tableColumn3_text = tableColumn3.GetAttribute("innerHTML");
            String tableColumn4_text = tableColumn4.GetAttribute("innerHTML");
            String tableColumn5_text = tableColumn5.GetAttribute("innerHTML");
            String tableColumn6_text = tableColumn6.GetAttribute("innerHTML");
            String tableColumn7_text = tableColumn7.GetAttribute("innerHTML");
            String tableColumn8_text = tableColumn8.GetAttribute("innerHTML");
            String tableColumn9_text = tableColumn9.GetAttribute("innerHTML");
            String tableColumn10_text = tableColumn10.GetAttribute("innerHTML");

            _extentReportsHelper.test.Log(Status.Info, "Elements aquired, running assertions...");

            Assert.AreEqual(tableColumn1_text, expectedValue1, "Table column 1 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table column 1 as expected: " + tableColumn1_text);

            Assert.AreEqual(tableColumn2_text, expectedValue2, "Table column 2 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table column 2 as expected: " + tableColumn2_text);

            Assert.AreEqual(tableColumn3_text, expectedValue3, "Table column 3 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table column 3 as expected: " + tableColumn3_text);

            Assert.AreEqual(tableColumn4_text, expectedValue4, "Table column 4 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table column 4 as expected: " + tableColumn4_text);

            Assert.AreEqual(tableColumn5_text, expectedValue5, "Table column 5 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table column 5 as expected: " + tableColumn5_text);

            Assert.AreEqual(tableColumn6_text, expectedValue6, "Table column 6 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table column 6 as expected: " + tableColumn6_text);

            Assert.AreEqual(tableColumn7_text, expectedValue7, "Table column 7 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table column 7 as expected: " + tableColumn7_text);

            Assert.AreEqual(tableColumn8_text, expectedValue8, "Table column 8 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table column 8 as expected: " + tableColumn8_text);

            Assert.AreEqual(tableColumn9_text, expectedValue9, "Table column 9 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table column 9 as expected: " + tableColumn9_text);

            Assert.AreEqual(tableColumn10_text, expectedValue10, "Table column 10 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table column 10 as expected: " + tableColumn10_text);

        }

        public void verifyEditButton()
        {

            elementFetch = new ElementFetch(); 
            var editButton = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.editButtonRow1, driver);

            editButton.Click();
            _extentReportsHelper.SetStepStatusPass("Edit button has been clicked");

            Assert.IsTrue(WebElementHelper.ValidateURLContains(driver, _extentReportsHelper, "#edit", 30), "URL Does not contain #edit");
            
        }

        public void verifyTableHeaders()
        {
            String expectedValue1 = "Lorem";
            String expectedValue2 = "Ipsum";
            String expectedValue3 = "Dolor";
            String expectedValue4 = "Sit";
            String expectedValue5 = "Amet"; 
            String expectedValue6 = "Diceret";
            String expectedValue7 = "Action";


            elementFetch = new ElementFetch();
            var tableHeader1 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableHeader1, driver);
            var tableHeader2 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableHeader2, driver);
            var tableHeader3 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableHeader3, driver);
            var tableHeader4 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableHeader4, driver);
            var tableHeader5 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableHeader5, driver);
            var tableHeader6 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableHeader6, driver);
            var tableHeader7 = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.tableHeader7, driver);


            String tableHeader1_text = tableHeader1.GetAttribute("innerHTML");
            String tableHeader2_text = tableHeader2.GetAttribute("innerHTML");
            String tableHeader3_text = tableHeader3.GetAttribute("innerHTML");
            String tableHeader4_text = tableHeader4.GetAttribute("innerHTML");
            String tableHeader5_text = tableHeader5.GetAttribute("innerHTML");
            String tableHeader6_text = tableHeader6.GetAttribute("innerHTML");
            String tableHeader7_text = tableHeader7.GetAttribute("innerHTML");

            _extentReportsHelper.test.Log(Status.Info, "Elements aquired, running assertions...");

            Assert.AreEqual(tableHeader1_text, expectedValue1, "Table header 1 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table heading 1 as expected: " + tableHeader1_text);

            Assert.AreEqual(tableHeader2_text, expectedValue2, "Table header 2 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table heading 2 as expected: " + tableHeader2_text);

            Assert.AreEqual(tableHeader3_text, expectedValue3, "Table header 3 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table heading 3 as expected: " + tableHeader3_text);

            Assert.AreEqual(tableHeader4_text, expectedValue4, "Table header 4 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table heading 4 as expected: " + tableHeader4_text);

            Assert.AreEqual(tableHeader5_text, expectedValue5, "Table header 5 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table heading 5 as expected: " + tableHeader5_text);

            Assert.AreEqual(tableHeader6_text, expectedValue6, "Table header 6 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table heading 6 as expected: " + tableHeader6_text);

            Assert.AreEqual(tableHeader7_text, expectedValue7, "Table header 7 doesnt match!" + "\n");
            _extentReportsHelper.SetStepStatusPass("Table heading 7 as expected: " + tableHeader7_text);

        }

        public void verifyPageHeader()
        {
            elementFetch = new ElementFetch();
            var pageHeader = elementFetch.getWebElement("XPATH", PageObjects.ChallengingDOM_Objects.pageHeader, driver);

            String expectedHeader = "Challenging DOM";
            _extentReportsHelper.LogInfo("The page header is: " + pageHeader.GetAttribute("innerHTML"));

            Assert.AreEqual(pageHeader.GetAttribute("innerHTML"), expectedHeader, "Header does not match!" + "\n");
        }

        public void verifyPageTitle()
        {
            
            var title = _browser.Title;
            _extentReportsHelper.LogInfo("The Title for the website is: " + title);

            Assert.IsTrue(driver.Title.Equals("The Internet"));

        }

        public void clickOnBlueButton()
        {
            elementFetch = new ElementFetch();
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
            elementFetch = new ElementFetch();
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
            elementFetch = new ElementFetch();
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

