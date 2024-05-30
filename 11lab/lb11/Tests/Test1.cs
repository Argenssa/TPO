﻿using lb11.Pages;
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
    public class Test1
    {
        private MainPage _mainPage;
        //private SearchPage _searchPage;
       // private ProductPage _productPage;

        [SetUp]
        public void Setup()
        {
            _mainPage = new MainPage(Driver);
           // _searchPage = new SearchPage(Driver);
           // _productPage = new ProductPage(Driver);
          
        }

        [Test]
        public void Test()
        {
            _mainPage.Open();

            _mainPage.SelectCarMake();

            _mainPage.SelectCarModel();


            _mainPage.SubmitSearch();

        //    _mainPage.ClickOnCarDetails();

            //Assert.IsTrue(_mainPage.isFound());

        }

        [TestCleanup]
        public void Cleanup()
        {
            QuitDriver();
        }
    }
}
