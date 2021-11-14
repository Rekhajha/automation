using Industry_connect_project.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Industry_connect_project.Pages
{
    class TM_Page
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on create new button

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Click on typecode dropdown and select time

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeOption.Click();

            // Enter code

            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("November5");

            // Enter description

            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("November5");

            // Enter price

            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));

            priceTag.Click();
            priceTextbox.SendKeys("20");

            // Click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);
            
            // Go to the last page

            IWebElement gotoLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastpageButton.Click();
            Thread.Sleep(2000);

            // Check if time record is present in the table and has expexted values            
            
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(actualCode.Text == "November5", "actual code and expected code is not same.");
            Assert.That(actualTypeCode.Text == "T", "actual typecode and expected typecode is not same.");
            Assert.That(actualDescription.Text == "November5", "actual description and expected decription is not same.");
            Assert.That(actualPrice.Text == "$20.00", "actual price and expected price is not same.");

        }

        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement findCreatedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findCreatedRecord.Text == "November5")
            {
                // Go to the edit button

                IWebElement gotoEditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                gotoEditButton.Click();

                // Change code

                IWebElement codeEditTextbox = driver.FindElement(By.Id("Code"));
                codeEditTextbox.Clear();
                codeEditTextbox.SendKeys("Edit5");

                // Change description

                IWebElement descriptionEditTextbox = driver.FindElement(By.Id("Description"));
                descriptionEditTextbox.Clear();
                descriptionEditTextbox.SendKeys("NovemberEdit5");

                // Change price

                IWebElement priceEditTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                IWebElement priceEditTextbox = driver.FindElement(By.Id("Price"));

                priceEditTag.Click();
                priceEditTextbox.Clear();
                priceEditTag.Click();
                priceEditTextbox.SendKeys("40");

                // Click on save button

                IWebElement saveEditButton = driver.FindElement(By.Id("SaveButton"));
                saveEditButton.Click();
                Thread.Sleep(2000);

                // Go to the last page

                IWebElement gotoLastpageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                gotoLastpageButton1.Click();
                Thread.Sleep(2000);

                //Check if record has been updated

                IWebElement editCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement editTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
                IWebElement editDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement editPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

                Assert.That(editCode.Text == "Edit5", "code hasn't been edited.");
                Assert.That(editTypeCode.Text == "T", "typecode hasn't been edited.");
                Assert.That(editDescription.Text == "NovemberEdit5", "decription hasn't been edited.");
                Assert.That(editPrice.Text == "$40.00", "price hasn't been edited.");
            }
            else
            {
                Assert.Fail("Record to be edidted hasn't been found.Record not edited");
            }
        }
        
    
        public void DeleteTM(IWebDriver driver)
        {
            // Click on last page

            Thread.Sleep(2000);
            IWebElement gotoLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastpageButton.Click();
            Thread.Sleep(2000);

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (findEditedRecord.Text == "Edit5")
            {
                // Click on delete button

                IWebElement gotodeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                gotodeleteButton.Click();

                // Click ok on popup window

                IAlert alert = driver.SwitchTo().Alert();
                Thread.Sleep(1000);
                alert.Accept();
                Thread.Sleep(2000);

                // Check record is deleted

                IWebElement deleteCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement deleteTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
                IWebElement deleteDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement deletePrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

                Assert.That(deleteCode.Text != "Edit5", "Code hasn't been deleted.");
                Assert.That(deleteDescription.Text != "NovemberEdit5", "description record hasn't been deleted.");
                Assert.That(deletePrice.Text != "40", "price record hasn't been deleted.");
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found.Record not deleted.");
            }
                                   
        }
    }
}
