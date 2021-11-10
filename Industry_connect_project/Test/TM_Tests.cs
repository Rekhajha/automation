using Industry_connect_project.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Industry_connect_project
{
    class TM_Tests
    {
        static void Main(string[] args)
        {
            //open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           
            //Login page object intialization and defination
            LoginPage loginPage = new LoginPage();
            loginPage.loginsteps(driver);

            //Home page object intialization and defination
            HomePage homePage = new HomePage();
            homePage.gotoTMpage(driver);

            //TM Page object intialization and defination
            TM_Page tm_Page = new TM_Page();

            //create TM
            tm_Page.CreateTM(driver);

            //edit TM
            tm_Page.EditTM(driver);

            //Delete TM
            tm_Page.DeleteTM(driver);




        }
    }

    
}
