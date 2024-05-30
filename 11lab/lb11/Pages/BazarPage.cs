using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lb11.Loger.Loger;

namespace lb11.Pages
{
    internal class BazarPage : PageBase.PageBase
    {
        public BazarPage(IWebDriver driver) : base(driver) { }

        public void Search(string searchText)
        {
            Driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div[1]/form/div/input")).SendKeys(searchText);
            Info("Count products increase in basket");
        }

        public void AudioFilterClick()
        {
            Driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div[2]/div/a[8]")).Click();
            Info("Select audio filter");
        }

        public void FirstItemClick()
        {
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div[6]/div[1]/div[1]/a/img")).Click();
            Info("Select First Item");
        }


    }
}
