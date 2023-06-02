using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UrbonsolutionAutomationNunitProject
{
    internal class ErrorHandling
    {
        [Test, Category("Error Handling")]
        [Author("Deepak Mishra", "deepak123.dm98@gmail.com")]
        [Description("HomePageTesting")]
        public void Error()
            {
                IWebDriver driver = null;
                try
                {
                    driver = new ChromeDriver();
                    driver.Url = "https://www.urbonsolution.com/contacts/";
                    IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id=\"ff_1_emai\"]"));
                    EmailTextField.SendKeys("deepak123.dm98@gmail.com");
                    Thread.Sleep(5000);
                    driver.Quit();
                }
                catch (Exception e) //saving screen shot on error 
                {
                    ITakesScreenshot ts  = driver as ITakesScreenshot;
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
                    Console.Write("Excption Handling Working as Expected");
                }
            }

        }
    }

