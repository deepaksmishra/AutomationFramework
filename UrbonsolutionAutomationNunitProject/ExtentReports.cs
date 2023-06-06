using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;

namespace UrbonsolutionAutomationNunitProject
{
    public class ExtentReport
        {
        ExtentReports extent = null;
        [Test, Category("Extent Report")]
        
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Deepak\Desktop\Automation_Testing\Automation_Framework\UrbonsolutionAutomationNunitProject\UrbonsolutionAutomationNunitProject\ExtentReport\demo.HTML");
            extent.AttachReporter(htmlReporter);

        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();

        }

        public void Reports()
            {
                IWebDriver driver = null;
                try
                {
                    ExtentTest test = extent.CreateTest("Reports").Info("Test Started");
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    test.Log(Status.Info, "Chrome Browser launched");
                    driver.Url = "https://www.urbonsolution.com/contacts/";
                    IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id=\"ff_1_email\"]"));
                    EmailTextField.SendKeys("deepak123.dm98@gmail.com");
                    test.Log(Status.Info, "Entered Email ID ");
                    Thread.Sleep(5000);
                    test.Log(Status.Pass, "Test Got Passed ");

                }
                catch (Exception e) //saving screen shot on error 
                {
                    ITakesScreenshot ts = driver as ITakesScreenshot;
                    Screenshot screenshot = ts.GetScreenshot();
                    screenshot.SaveAsFile("C:\\Users\\Deepak\\Desktop\\Automation_Testing\\Automation_Framework\\UrbonsolutionAutomationNunitProject\\UrbonsolutionAutomationNunitProject\\Screenshot\\screenshot01.Png", ScreenshotImageFormat.Png);
                    Console.WriteLine(e.StackTrace);
                    throw;
                }
                finally
                {
                    if (driver != null)
                    {
                        driver.Quit();
                    }
                    Console.Write("Exception Handling Working as Expected");
                }
            }

        }
    }

