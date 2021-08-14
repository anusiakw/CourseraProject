using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseraProject
{
    [TestClass]
    public class LoginTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
           // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            string url = "http://localhost/litecart/admin/login.php";
            driver.Navigate().GoToUrl(url);
        }

        [Test]
        public void CorrectLoginCorrectPssword()
        {
            
            string login = "admin";
            string password = "admin";          

            IWebElement LoginTxt = driver.FindElement(By.CssSelector("input[name='username'][data-type='text']"));
            IWebElement PasswordTxt = driver.FindElement(By.CssSelector("input[name='password'][type='password']"));
            IWebElement SubmitBtn = driver.FindElement(By.Name("login"));
            LoginTxt.Clear();
            LoginTxt.SendKeys(login);
            PasswordTxt.Clear();
            PasswordTxt.SendKeys(password);
            SubmitBtn.Click();     
        }

        [TearDown]
        public void Quit()
        {
            driver.Quit();
        }
    }
}

