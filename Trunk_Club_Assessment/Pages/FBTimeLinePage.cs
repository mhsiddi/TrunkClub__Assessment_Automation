using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trunk_Club_Assessment.Pages
{
    public class FBTimeLinePage
    {
        public IWebDriver Driver { get; private set; }

        public IWebElement ProfilePageLink { get { return Driver.FindElement(By.XPath("//*[@id='u_0_4']/div[1]/div[1]/div/a")); } }

        public IWebElement HomeLink { get { return Driver.FindElement(By.Id("u_0_5")); } }

        
        public FBTimeLinePage(IWebDriver _driver)
        {
            Driver = _driver;
        }
    }
}
