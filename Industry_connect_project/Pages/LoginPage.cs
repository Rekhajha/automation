using Industry_connect_project.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Industry_connect_project.Pages
{
    class LoginPage 
    {
        public void loginsteps(IWebDriver driver)
        {
            try
            {
                // Maximize window

                driver.Manage().Window.Maximize();

                // Launch turnup portal

                driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

                // Identify username textbox and enter valid username
               
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");

                // Identify password textbox and enter valid password
                
                IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");


                // Idenify login button and click
                
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup portal home page didnt open", ex.Message);
            }

            // Check if user has logged in successfully
            
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Assert.That(helloHari.Text == "Hello hari!", "Login failed");
        }    
    }
}
