using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts
{
    [TestClass]
    public class ViewDepartment : DriverTestCase
    {
        [TestMethod]
        public void Viewdepartment()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AdminDepartmentHelper = new AdminDepartmentHelper(GetWebDriver());

            //Variable

            var Name = "Department" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Mouse over on Profile
            AdminDepartmentHelper.Mouseover("locator");

            //click on admin
            AdminDepartmentHelper.ClickElement("ClickonAdmin");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            //Click on Departments
            AdminDepartmentHelper.ClickElement("Department");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/department");


            //Click on record
            AdminDepartmentHelper.ClickElement("DepartmentView");

            //Click on back
            AdminDepartmentHelper.ClickElement("Back");

            //Click on  department
            AdminDepartmentHelper.ClickElement("DepartmentView");

            //Click on edit button
            AdminDepartmentHelper.ClickElement("Edit");

            //Click on save Button
            AdminDepartmentHelper.ClickElement("EditdepartmentSave");

            //Click on  department
            AdminDepartmentHelper.ClickElement("DepartmentView");

            //Click on Delete
            AdminDepartmentHelper.ClickElement("Delete");

            //Click on  department
            AdminDepartmentHelper.ClickElement("DepartmentView");

            //Click on New 
            AdminDepartmentHelper.ClickElement("DepartmentAddNew");

            //Click on Cancel
            AdminDepartmentHelper.ClickElement("CancelDeptment");




        }
    }
}