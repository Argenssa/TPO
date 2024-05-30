using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace _10lab
{
    [TestClass]
    public class Tests
    {

        private IWebDriver driver;

        [TestInitialize]
        public void TestSetup()
        {
            driver = new EdgeDriver();
        }
        public class BamperPage
        {

            private readonly IWebDriver driver;

            public BamperPage(IWebDriver driver)
            {
                this.driver = driver;
            }
            [TestInitialize]
            public void GoToHomePage()
            {
                driver.Navigate().GoToUrl("https://bamper.by/");
            }

            public void OpenAuth()
            {
                driver.FindElement(By.XPath("//*[@id=\"wrapper\"]/div[1]/nav/div/div[2]/ul[1]/li/a")).Click();

         
            }

            public void InsertLogin(string s)
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/table/tbody/tr/td[1]/table/tbody/tr[1]/td[2]/input")).Click();
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/table/tbody/tr/td[1]/table/tbody/tr[1]/td[2]/input")).SendKeys(s);



            }
            public void InsertPassword(string s)
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/input")).Click();
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/input")).SendKeys(s);



            }


            public void SubmitAuth()
            {
             

                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/table/tbody/tr/td[1]/table/tbody/tr[4]/td[2]/input")).Click();
            }

           
           
        }

        [TestMethod]
        public void OpenItemTest()
        {






            BamperPage homePage = new BamperPage(driver);
            homePage.GoToHomePage();
            homePage.OpenAuth();

          
                       
               
            homePage.InsertLogin("375299714850");

            Thread.Sleep(3000);
            homePage.InsertPassword("Mark48");

           
            Thread.Sleep(2000);
            homePage.SubmitAuth();
            string expectedUrl = "https://bamper.by/personal/?login=yes"; 
            string actualUrl = driver.Url;
            Assert.AreEqual(expectedUrl, actualUrl, "The URL did not change to the expected URL after the button click.");


        }
    }
}