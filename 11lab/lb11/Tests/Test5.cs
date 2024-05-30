using lb11.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lb11.DriverManager.DriverMaganer;
using Assert = NUnit.Framework.Assert;

namespace lb11.Tests
{
    [TestClass]
    public class Test5
    {
        private MainPage _mainPage;
        private TiresPage _tiresPage;


        [SetUp]
        public void Setup()
        {
            _mainPage = new MainPage(Driver);
            _tiresPage = new(Driver);
    

        }

        [Test]
        public void Test()
        {
            _mainPage.Open();
            _tiresPage.OpenTiresTap();
            _tiresPage.selectFirstTireType();
        
        }

        [TestCleanup]
        public void Cleanup()
        {
            QuitDriver();
        }
    }
}
