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
    public class FacebookLoginPageTests
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

        public void UserCanLoginWithValidCredentials()
        {
            facebookPage.Login("ztsaan07@gmail.com", "Automation2017");

            Assert.True(fbTimeLine.ProfilePageLink.Displayed, "User did not login.");
        }

        [Test]
        [Ignore("Need to figure out why it won't find the arrow drop down")]
        public void UserShouldNotLoginWithInvalidCredentials()
        {
            if (fbTimeLine.HomeLink.Displayed)
            {
                facebookPage.LogOut();
            }

            facebookPage.Login("ztsaan07@gmail.com", "badpassw");

            Assert.True(Driver.Url.Contains("login"), "User was able to login with bad password.");
        }

        [OneTimeTearDown]

        public void CloseTest()
        {
            Driver.Quit();
        }
    }
}
