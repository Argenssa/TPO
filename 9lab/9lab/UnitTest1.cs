using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Diagnostics;
using System.Threading;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace _9lab
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BamperTest()
        {
            WebDriver driver = new EdgeDriver();

            try
            {
                driver.Navigate().GoToUrl("https://bamper.by/");
                driver.FindElement(By.XPath("//*[@id=\"select2-marka-container\"]/span")).Click();
                driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1]")).Click();

                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"select2-model-container\"]/span")).Click();
                driver.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li[1]")).Click();
                Thread.Sleep(3000);

                driver.FindElement(By.XPath("//button[contains(@class, 'btn-success')]")).Click();

                Thread.Sleep(3000);

                string expectedUrl = "https://bamper.by/zchbu/marka_acura/model_cl/"; 
                string actualUrl = driver.Url;
                Assert.AreEqual(expectedUrl, actualUrl, "The URL did not change to the expected URL after the button click.");

            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
