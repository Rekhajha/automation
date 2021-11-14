using Industry_connect_project.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Industry_connect_project.Pages
{
    class HomePage
    {
        public void gotoTMpage(IWebDriver driver)
        {
            // Go to administration tab
           
            IWebElement adminstrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationTab.Click();
                        
            Wait.WaitToBEClickable(driver, "Xpath", "/ html / body / div[3] / div / div / ul / li[3] / a", 3);

            // Select time and material from dropdown

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }

        public void gotoEmployeePage(IWebDriver driver)
        {
            // Go to administration tab
           
            IWebElement adminstrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationTab.Click();

            Wait.WaitToBEClickable(driver, "Xpath", "/ html / body / div[3] / div / div / ul / li[2] / a", 2);

            // Select employee from dropdown

            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click();
            
        }

    }
}
