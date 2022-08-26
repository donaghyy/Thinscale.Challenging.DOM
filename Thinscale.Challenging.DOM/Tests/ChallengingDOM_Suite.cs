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
        [Category("StaticElement")]
        public void ValidatePageHeader()
        {
            Page.verifyPageHeader();

        }

        [Test, Category("Buttons")]
        public void ValidateBlueButtonOperation()
        {
            Page.clickOnBlueButton();

        }

        [Test, Category("Buttons")]
        public void ValidateRedButtonOperation()
        {
            Page.clickOnRedButton();
        }

        [Test, Category("Buttons")]
        public void ValidateGreenButtonOperation()
        {
            Page.clickOnGreenButton();

        }

        [Test, Category("Static_Elements")]
        public void ValidateStaticTableHeader()
        {
            Page.verifyTableHeaders();
        }

        [Test, Category("Static_Elements")]
        public void ValidateRandomTableCollumn()
        {
            Page.verifyTableColumns();
        }

        [Test, Category("Buttons")]
        public void ValidateRandomEditButton()
        {
            Page.verifyEditButton();
        }

        [Test, Category("Buttons")]
        public void ValidateRandomDeleteButton()
        {
            Page.verifyDeleteButton();
        }

        [Test, Category("Static_Elements")]
        [Ignore("x")]
        public void ValidateAnswerFieldRefreshes()
        {

        }

        [Test, Category("Static_Elements")]
        //[Ignore("x")]
        public void ValidatePageTitle()
        {
            Page.verifyPageTitle();
        }


    }
}

