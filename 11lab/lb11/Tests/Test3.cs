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
    public class Test3
    {
        private MainPage _mainPage;
        private BazarPage _bazarPage;

        [SetUp]
        public void Setup()
        {
            _mainPage = new  (Driver);
            _bazarPage = new (Driver);

        }

        [Test]
        public void Test()
        {
            _mainPage.Open();
            _mainPage.OpenBAZAR();
            _bazarPage.Search("аккумулятор");


        }

        [TestCleanup]
        public void Cleanup()
        {
            QuitDriver();
        }
    }
}
