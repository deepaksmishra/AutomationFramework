using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UrbonsolutionAutomationNunitProject.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver Init(IWebDriver driver)
        {
           driver = new ChromeDriver();
           driver.Manage().Window.Maximize();
           driver.Url = "";
           return driver;

        }
    }
}
