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
        public void ValidatePageHeader()
        {
            Page.verifyPageHeader();

        }

        [Test]
        public void ValidateBlueButtonOperation()
        {
            Page.clickOnBlueButton();

        }

        [Test]
        public void ValidateRedButtonOperation()
        {
            Page.clickOnRedButton();
        }

        [Test]
        [Ignore("ignore this")]
        public void ValidateGreenButtonOperation()
        {
            Page.clickOnGreenButton();

            //Thread.Sleep(2000);
        }

        [Test]
        public void ValidateStaticTableHeader()
        {
            Page.verifyTableHeaders();
        }

        [Test]
        public void ValidateRandomTableCollumn()
        {
            Page.verifyTableColumns();
        }

        [Test]
        public void ValidateRandomEditButton()
        {
            Page.verifyEditButton();
        }

        [Test]
        public void ValidateRandomDeleteButton()
        {
            Page.verifyDeleteButton();
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

