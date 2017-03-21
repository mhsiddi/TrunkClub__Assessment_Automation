using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trunk_Club_Assessment.Pages
{
    public class FacebookPage
    {
        public IWebDriver Driver { get; private set; }
        public IWebElement EmailTxtBox { get { return Driver.FindElement(By.Id("email")); } }

        public IWebElement PasswordTxtBox { get { return Driver.FindElement(By.Id("pass")); } }

        public IWebElement LoginBtn { get { return Driver.FindElement(By.Id("u_0_q")); } }

        public IWebElement FBLogoHyperLink { get { return Driver.FindElement(By.XPath("//*[@id='blueBarDOMInspector']/div/div/div/div[1]/h1/a/i")); } }

        public IWebElement FirstNameTxtBox { get { return Driver.FindElement(By.Id("u_0_1")); } }

        public IWebElement LastNameTxtBox { get { return Driver.FindElement(By.Id("u_0_2")); } }

        public FacebookPage(IWebDriver _driver)
        {
            Driver = _driver;
        }

        public void Login(string email, string password)
        {
            EmailTxtBox.SendKeys(email);
            PasswordTxtBox.SendKeys(password);

            LoginBtn.Click();
        }

        public void LogOut()
        {
            IWebElement downBtn = Driver.FindElement(By.Id("pageLoginAnchor"));

            downBtn.Click();

            Thread.Sleep(5000);

            IWebElement logOutBtn = Driver.FindElement(By.XPath("//*[@id='BLUE_BAR_ID_DO_NOT_USE']/div/div/div[1]/div/div/ul/li[12]/a"));

            logOutBtn.Click();
        }
    }
}
