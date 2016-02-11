using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EmployeesCustomViewUpdate : DriverTestCase
    {
        [TestMethod]
        public void employeescustomviewupdate()
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

            //Click on Custom Views
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Click on Edit
            EmployeesCustomViewsHelper.ClickElement("ClickOnEdit");

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
            EmployeesCustomViewsHelper.Select("SelectCreatedDate", "");

            //Select Modified Date
            EmployeesCustomViewsHelper.Select("SelectModifiedDate", "");


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
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViewUpdateSave");
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);


                        
        }
    }
}