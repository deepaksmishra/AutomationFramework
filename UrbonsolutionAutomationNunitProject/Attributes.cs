using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UrbonsolutionAutomationNunitProject
{
    internal class Attributes
    {
        [TestFixture]
        public class TestClass
        {
            [Test]
            [Author("Deepak Mishra","deepak123.dm98@gmail.com")]
            [Description("HomePageTesting")]
            [TestCaseSource("DataDrivenTesting")]
            public void TestMethod1(String UrlName)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Url = UrlName;
                //driver.Url = "https://www.urbonsolution.com/contacts/";
                IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id=\"ff_1_email\"]"));
                EmailTextField.SendKeys("deepak123.dm98@gmail.com");
                Thread.Sleep(5000);
                driver.Quit();

            }
            [Test]
            [Author("Deepak Mishra", "deepak123.dm98@gmail.com")]
            [Description("Dropdown List Verify")]
            public void SelectByMethod()
            {
                IWebDriver driver = new ChromeDriver();
                driver.Url = "https://www.w3schools.com/tags/tryit.asp?filename=tryhtml_optgroup";
                IWebElement Monthdropdownlist = driver.FindElement(By.XPath("//*[@id=\"cars\"]"));
                SelectElement element = new SelectElement(Monthdropdownlist);
                //element.SelectByIndex(2);
                element.SelectByText("Saab");
                Thread.Sleep(5000);

            }
            //Test Case Source Attribute - data Driven Testing
            static IList DataDrivenTesting()
            {
                ArrayList List = new ArrayList();
                List.Add("https://www.google.co.in");
                List.Add("https://urbonsolution.com");
                List.Add("https://www.costweeet.com");

                return List;
            }
            
        }
    }
}
