using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EmployeesCustomViewActions : DriverTestCase
    {
        [TestMethod]
        public void employeescustomviewactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var EmployeesCustomViewsHelper = new EmployeesCustomViewsHelper(GetWebDriver());

            //Variable
            var CustomView = "Test Custom View" + RandomNumber(1, 99);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            
            //Click on Employees
            EmployeesCustomViewsHelper.ClickElement("ClickOnEmployees");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees");
            //EmployeesCustomViewsHelper.WaitForWorkAround(7000);

            
//#########################  CREATE CUSTOM VIEW #################################


            //Click on Custom Views
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Click on New Button
            EmployeesCustomViewsHelper.ClickElement("ClickOnNewButton");

            //Enter Custom View Name
            EmployeesCustomViewsHelper.TypeText("EnterCustomViewName", CustomView);

            //Select Result per Page
            EmployeesCustomViewsHelper.Select("SelectResultPerPage", "20");

            //Select Sort By
            EmployeesCustomViewsHelper.Select("SelectSortBy", "Modified");

            //Select Department
            EmployeesCustomViewsHelper.Select("SelectDepartment", "Department6");

            //Select Role
            EmployeesCustomViewsHelper.Select("SelectRole", "Role10");

            //Select Created By
            EmployeesCustomViewsHelper.Select("SelectCreatedBy", "Ranjith");

            //Select Modified By
            EmployeesCustomViewsHelper.Select("SelectModifiedBy", "Ranjith");

            //Select Created Date
            //EmployeesCustomViewsHelper.Select("SelectCreatedDate", "");

            //Select Modified Date
            //EmployeesCustomViewsHelper.Select("SelectModifiedDate", "");


            //Select Additional Field1
            EmployeesCustomViewsHelper.Select("SelectAdditionalField1", "d.city:string");

            //Select Operator1
            EmployeesCustomViewsHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value1
            EmployeesCustomViewsHelper.TypeText("EnterAdditionalValue1", "Kansus");

            //Click On Add New Field 
            EmployeesCustomViewsHelper.ClickElement("ClickOnAddNewField");

            //Select Additional Field2
            EmployeesCustomViewsHelper.Select("SelectAdditionalField2", "d.postal_code:string");

            //Select Operator2
            EmployeesCustomViewsHelper.Select("SelectOperator2", "cn");

            //Enter Additional Value2
            EmployeesCustomViewsHelper.TypeText("EnterAdditionalValue2", "87452");


            //Click On Save
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViewNewSave");
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);



//######################  CUSTOM VIEW ACTIONS   #################################


            
                       
            //Click On Set As Default Custom View
            EmployeesCustomViewsHelper.ClickElement("ClickOnSetAsDefault");
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);

            //Click On Unset Default Custom View
            EmployeesCustomViewsHelper.ClickElement("ClickOnUnsetDefault");
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);

            //Clock On Edit Custom View
            EmployeesCustomViewsHelper.ClickElement("ClickOnEditLink");

            //Clock On Edit Custom View cancel button
            EmployeesCustomViewsHelper.ClickElement("ClickOnEditCancel");


            //Click on Custom Views Dropdown
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViewsDropdown");
            EmployeesCustomViewsHelper.WaitForWorkAround(5000);

            //Enter Search Custom Views Name
            EmployeesCustomViewsHelper.TypeText("EnterSearchCustomViewsName", CustomView);
            EmployeesCustomViewsHelper.WaitForWorkAround(5000);

            //Click on Custom Views Dropdown
            EmployeesCustomViewsHelper.ClickElement("ClickOnFirstCustomViewName");
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);

            
            //Clock On New Custom View
            EmployeesCustomViewsHelper.ClickElement("ClickOnNew");

            //Clock On New Custom View cancel button
            EmployeesCustomViewsHelper.ClickElement("ClickOnNewCancel");


            //Click on Custom Views Dropdown
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViewsDropdown");
            EmployeesCustomViewsHelper.WaitForWorkAround(5000);

            //Enter Search Custom Views Name
            EmployeesCustomViewsHelper.TypeText("EnterSearchCustomViewsName", CustomView);
            EmployeesCustomViewsHelper.WaitForWorkAround(5000);

            //Click on Custom Views Dropdown
            EmployeesCustomViewsHelper.ClickElement("ClickOnFirstCustomViewName");
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);


            //Clock On Delete Custom View
            EmployeesCustomViewsHelper.ClickElement("ClickOnDeleteLink");


            EmployeesCustomViewsHelper.AcceptAlert();
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);


        }
    }
}