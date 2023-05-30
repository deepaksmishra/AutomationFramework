using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunit

namespace UrbonsolutionAutomationNunitProject.BaseClass
{
   public class BaseTest
    {
        public IwebDriver driver;

        [Setup]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.urbonsolution.com/contacts/";
        }
        [TearDown]
        { 
        public void close()
        {
            driver.Quit();
        }
        }
    }
}
