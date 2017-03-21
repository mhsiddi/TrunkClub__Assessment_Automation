using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trunk_Club_Assessment.Pages;

namespace Trunk_Club_Assessment.Tests
{
    [TestFixture]
    public class FBRegistrationPage
    {
        public const string URL = "https://www.facebook.com/";

        IWebDriver Driver;

        public FacebookPage facebookPage;

        public FBTimeLinePage fbTimeLine;

        [OneTimeSetUp]

        public void InitializeTest()
        {
            Driver = new ChromeDriver();

            facebookPage = new FacebookPage(Driver);
            fbTimeLine = new FBTimeLinePage(Driver);

            Driver.Navigate().GoToUrl(URL);
        }
        
        [Test]

        public void FBLogoExists()
        {
            Assert.True(facebookPage.FBLogoHyperLink.Displayed, "FB Logo is not displaying");
        }

        [Test]

        public void FirstNameTxtBoxExists()
        {
            Assert.True(facebookPage.FirstNameTxtBox.Displayed, "First Name textbox not displaying");
        }

        [Test]

        public void LastNameTxtBoxExists()
        {
            Assert.True(facebookPage.LastNameTxtBox.Displayed, "Last Name textbox not displaying");
        }

        [OneTimeTearDown]

        public void CloseTest()
        {
            Driver.Quit();
        }
        
    }
}
