using lb11.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;
using static lb11.DriverManager.DriverMaganer;

namespace lb11.Tests
{
    [TestClass]
    public class Test4
    {
        private MainPage _mainPage;
        private BazarPage _bazarPage;


        [SetUp]
        public void Setup()
        {
            _mainPage = new MainPage(Driver);           
            _bazarPage = new(Driver);

        }

        [Test]
        public void Test()
        {
            _mainPage.Open();
            _mainPage.OpenBAZAR();
            _bazarPage.AudioFilterClick();
            _bazarPage.FirstItemClick();

        }

        [TestCleanup]
        public void Cleanup()
        {
            QuitDriver();
        }
    }
}
