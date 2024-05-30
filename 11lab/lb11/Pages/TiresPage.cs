using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lb11.Loger.Loger;

namespace lb11.Pages
{
    internal class TiresPage:PageBase.PageBase
    {
        public TiresPage(IWebDriver driver): base(driver) { }

        public void OpenTiresTap()
        {
            Driver.FindElement(By.XPath("/html/body/div[3]/div[1]/nav/div/div[2]/ul[2]/li[2]/a/span")).Click();
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath("/html/body/div[3]/div[1]/nav/div/div[2]/ul[2]/li[2]/ul/li[8]/a")).Click();
            Info("Open tires tab");
        }
        public void selectFirstTireType()
        {
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div[2]/div/div[2]/div/div/div[1]/div/ul[1]/li[1]/a")).Click();
            Info("SelectFirstTireType");
        }

    }
}
