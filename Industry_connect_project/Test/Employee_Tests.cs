using Industry_connect_project.Pages;
using Industry_connect_project.utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Industry_connect_project.Test
{
    [TestFixture]
    [Parallelizable]
    class Employee_Tests : CommonDriver
    {
        [Test, Order(1), Description("check if user is able to create employee record with valid data")]
        public void CreateEmployeeTest()
        {
            // Home page object intialization and defination
           
            HomePage homePage = new HomePage();
            homePage.gotoEmployeePage(driver);

            // Employee Page object intialization and defination

            Employee_Page employee_Page = new Employee_Page();

            // Create Employee

            employee_Page.CreateEmployee(driver);
        }

        [Test, Order(2), Description("Check if user is able to update employee record")]

        public void EditEmployeeTest()
        {
            // Employee Page object intialization and defination

            Employee_Page employee_Page = new Employee_Page();

            // Edit Employee

            employee_Page.EditEmployee(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete employee record")]

        public void DeleteEmployeeTest()
        {
                       
            // Employee Page object intialization and defination

            Employee_Page employee_Page = new Employee_Page();

            // Delete Employee

            employee_Page.DeleteEmployee(driver);

        }

    }
}
