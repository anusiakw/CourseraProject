using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace CourseraProject
{
    [TestClass]
    public class UnitTest1
    {

        IWebDriver driver;


        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            //wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
        }

        [TestMethod]
        public void FirstTest()
        {
            driver.Url = "https://www.bing.com/";

        }

        [TearDown]
        public void Quit()
        {
            driver.Quit();
        }
    }

}
