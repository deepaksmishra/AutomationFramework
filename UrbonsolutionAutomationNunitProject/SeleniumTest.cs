//Inside SeleniumTest.cs

using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;

using System;

using System.Collections.ObjectModel;

using System.IO;

 namespace UrbonsolutionAutomationNunitProject


{

    public class Tests

    {

        IWebDriver driver;

        [OneTimeSetUp]

        public void Setup()

        {

            //Below code is to get the drivers folder path dynamically.

            //You can also specify chromedriver.exe path dircly ex: C:/MyProject/Project/drivers

           // string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            //Creates the ChomeDriver object, Executes tests on Google Chrome

            driver = new ChromeDriver(@"C:\Users\Deepak\Desktop\Automation_Testing\Automation_Framework\UrbonsolutionAutomationNunitProject\UrbonsolutionAutomationNunitProject\drivers");

            //If you want to Execute Tests on Firefox uncomment the below code

            // Specify Correct location of geckodriver.exe folder path. Ex: C:/Project/drivers

            //driver= new FirefoxDriver(path + @"\drivers\");

        }

        [Test]

        public void verifyLogo()
        {

            driver.Navigate().GoToUrl("https://www.urbonsolution.com/");
            bool logoPresent = driver.FindElement(By.XPath("//*[@id=\"site-header\"]/div[1]/div/section[2]/div/div[1]/div")).Displayed;
            Assert.IsTrue(logoPresent);

            //Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"site-header\"]/div[2]/div/section/div/div[1]/div/div/div/div/a/img")).Displayed);

        }

        [Test]

        public void verifyMenuItemcount()

        {

            ReadOnlyCollection<IWebElement> menuItem = driver.FindElements(By.XPath("//*[@id=\"primary-menu\"]"));

           // Assert.AreEqual(menuItem.Count, 4);

        }

        [Test]

        public void verifyPricingPage()

        {

            driver.Navigate().GoToUrl("https://browserstack.com/pricing");

            IWebElement contactUsPageHeader = driver.FindElement(By.TagName("h1"));

            Assert.IsTrue(contactUsPageHeader.Text.Contains("Real device cloud of 20,000 + real iOS & Android devices, instantly accessible"));

        }




        [OneTimeTearDown]

        public void TearDown()

        {

            driver.Quit();

        }

    }

}
