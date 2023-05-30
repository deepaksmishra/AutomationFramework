using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UrbonsolutionAutomationNunitProject
{
    public class ParellelTesting
    {
        [Test, Category("Parellel Testing")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.urbonsolution.com/contacts/";
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id=\"ff_1_email\"]"));
            EmailTextField.SendKeys("deepak123.dm98@gmail.com");
            Thread.Sleep(5000);
            driver.Quit();

        }
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.urbonsolution.com/contacts/";
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id=\"ff_1_email\"]"));
            EmailTextField.SendKeys("deepak123.dm98@gmail.com");
            Thread.Sleep(5000);
            driver.Quit();

        }
    }
}
