using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium.Interactions;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddDepartment : DriverTestCase
    {
        [TestMethod]
        public void adddepartment()
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

            //Click on Department
            AdminDepartmentHelper.ClickElement("Department");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/department");


            //Click on add new
            AdminDepartmentHelper.ClickElement("DepartmentAddNew");

            //enter name
            AdminDepartmentHelper.TypeText("Name", Name);

            //Select  Primary contact
            AdminDepartmentHelper.Select("PrimaryContact", "17");

            //Enter Description
            AdminDepartmentHelper.TypeText("Description","New department created");

            //Click on save Button
            AdminDepartmentHelper.ClickElement("SaveDepartment");




        }
    }
}