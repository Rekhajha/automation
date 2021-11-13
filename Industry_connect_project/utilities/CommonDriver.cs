using Industry_connect_project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Industry_connect_project.utilities
{
    class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void LoginAction()
        {

            driver = new ChromeDriver();

            //Login page object intialization and defination
            LoginPage loginPage = new LoginPage();
            loginPage.loginsteps(driver);

            //Home page object intialization and defination
            HomePage homePage = new HomePage();
            homePage.gotoTMpage(driver);
        }

        [OneTimeTearDown]
        public void ClosingTestRun()
        {

        }

    }
}
