using Industry_connect_project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Industry_connect_project.utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        
        [OneTimeSetUp]
        public void LoginAction()
        {
            driver = new ChromeDriver();

            // Login page object intialization and defination

            LoginPage loginPage = new LoginPage();
            loginPage.loginsteps(driver);

        }

        [OneTimeTearDown]
        public void ClosingTestRun()
        {
            driver.Close();
        }

    }
}
