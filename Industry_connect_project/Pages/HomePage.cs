using Industry_connect_project.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Industry_connect_project.Pages
{
    class HomePage
    {
        public void gotoTMpage(IWebDriver driver)
        {
            //click on Adminstration tab
            IWebElement adminstrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Wait.WaitToBEClickable(driver, "Xpath", "/ html / body / div[3] / div / div / ul / li[5] / a", 3);
            adminstrationTab.Click();
                   
             //select time and material from dropdown
             IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
             tmOption.Click();
            
            

        }
    }
}
