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
            //click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            //click on typecode dropdown and select time
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            Thread.Sleep(500);

            IWebElement timeOption = driver.FindElement(By.Id("TypeCode_option_selected"));
            timeOption.Click();

            //enter code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("November5");

            //enter description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("November5");

            //enter price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("20");

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //go to the last page
            IWebElement gotoLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastpageButton.Click();
            Thread.Sleep(2000);

            //check if time record is present in the table and has expexted values
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (actualCode.Text == "November5")
            {
                Console.WriteLine("Time record created successfully");
            }
            else
            {
                Console.WriteLine("Test failed");
            }


        }
        public void EditTM(IWebDriver driver)
        {
            //go to the edit button

            IWebElement gotoEditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            gotoEditButton.Click();


            //click on typecode dropdown and change option
            IWebElement typeEditCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeEditCodeDropdown.Click();
            IWebElement timeEditOption = driver.FindElement(By.Id("TypeCode_option_selected"));


            if (timeEditOption.Selected)
            {
                IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
                materialOption.Click();
            }
            else
            {
                timeEditOption.Click();
            }


            //change code
            IWebElement codeEditTextbox = driver.FindElement(By.Id("Code"));
            codeEditTextbox.Clear();
            codeEditTextbox.SendKeys("Edit5");

            //change description
            IWebElement descriptionEditTextbox = driver.FindElement(By.Id("Description"));
            descriptionEditTextbox.Clear();
            descriptionEditTextbox.SendKeys("NovemberEdit5");

            //change price
            IWebElement priceEditTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceEditTag.Click();
            IWebElement priceEditTextbox = driver.FindElement(By.Id("Price"));
            priceEditTextbox.Clear();
            priceEditTag.Click();
            priceEditTextbox.SendKeys("40");


            //click on save button
            IWebElement saveEditButton = driver.FindElement(By.Id("SaveButton"));
            saveEditButton.Click();
            Thread.Sleep(2000);
            IWebElement gotoeditLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoeditLastpageButton.Click();
            Thread.Sleep(2000);

            //check if record has been updated
            IWebElement editRow = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            string editCode = editRow.GetAttribute("Code");
            string editDescription = editRow.GetAttribute("Description");
            string editPrice = editRow.GetAttribute("Price");
            Console.WriteLine(editCode);
            if ((editCode == "Edit5") && (editDescription == "NovemberEdit5") && (editPrice == "40"))
            {
                Console.WriteLine("record updated");
            }
            else
            {
                Console.WriteLine("test Failed");
                Console.WriteLine(editCode);
                Console.WriteLine(editDescription);
                Console.WriteLine(editPrice);
            }


        }
        public void DeleteTM(IWebDriver driver)
        {

            //click on delete button
            IWebElement gotodeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
            gotodeleteButton.Click();
            //var rowId = gotodeleteButton.GetAttribute("data-uid");              

            //click ok on popup window
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(500);
            alert.Accept();
            Console.WriteLine("record deleted");
            
        }
    }
}
