using Industry_connect_project.Pages;
using Industry_connect_project.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Industry_connect_project
{
    [TestFixture]
    class TM_Tests : CommonDriver
    {
        [Test, Order(1), Description("check if user is able to create time record with valid data")]
        public void CreateTMTest()
        {
            //TM Page object intialization and defination
            TM_Page tm_Page = new TM_Page();
            //create TM
            tm_Page.CreateTM(driver);
        }

        [Test,Order(2),Description("Check if user is able to update Time record")]

        public void EditTMTest()
        {
            //TM Page object intialization and defination
            TM_Page tm_Page = new TM_Page();
            //edit TM
            tm_Page.EditTM(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete Time record")]

        public void DeleteTMTest()
        {
            //TM Page object intialization and defination
            TM_Page tm_Page = new TM_Page();
            
            //Delete TM
            tm_Page.DeleteTM(driver);

        }
            
    }

}
