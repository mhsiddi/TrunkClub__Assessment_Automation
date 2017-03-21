using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trunk_Club_Assessment.Helpers
{
    public class TestHelper
    {

        public static void SwitchTabs(IWebDriver Driver, int tabNum)
        {
            IList<string> tabs = Driver.WindowHandles;

            if (tabs.Count > 1)
            {
                Driver.SwitchTo().Window(tabs[tabNum - 1]);
            }

            else
            {
                return;
            }
        }

        
    }
}
