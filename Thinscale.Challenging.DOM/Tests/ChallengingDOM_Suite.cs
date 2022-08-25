using System;
using NUnit.Framework;
using Thinscale.Challenging.DOM.PageObjects;
using Thinscale.Challenging.DOM.PageImpl;
using System.Threading;
using AventStack.ExtentReports;

namespace Thinscale.Challenging.DOM.Tests
{
    [TestFixture]
    public class ChallengingDOM_Suite : BaseTest
	{

        [Test]
        //[Ignore("x")]
        public void ValidatePageHeader()
        {
            Page.verifyPageHeader();

        }

        [Test]
        //[Ignore("x")]
        public void ValidateBlueButtonOperation()
        {
            Page.clickOnBlueButton();

        }

        [Test]
        //[Ignore("x")]
        public void ValidateRedButtonOperation()
        {
            Page.clickOnRedButton();
        }

        [Test]
        //[Ignore("x")]
        public void ValidateGreenButtonOperation()
        {
            Page.clickOnGreenButton();

            //Thread.Sleep(2000);
        }

        [Test]
        //[Ignore("x")]
        public void ValidateStaticTableHeader()
        {
            Page.verifyTableHeaders();
        }

        [Test]
        [Ignore("x")]
        public void ValidateRandomTableCollumn()
        {

        }

        [Test]
        //[Ignore("x")]
        public void ValidateRandomEditButton()
        {
            Page.verifyEditButton();
        }

        [Test]
        [Ignore("x")]
        public void ValidateRandomDeleteButton()
        {

        }

        [Test]
        [Ignore("x")]
        public void ValidateAnswerFieldRefreshes()
        {

        }

        [Test]
        //[Ignore("x")]
        public void ValidatePageTitle()
        {
            Page.verifyPageTitle();
        }


    }
}

