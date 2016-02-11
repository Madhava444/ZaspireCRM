using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts
{
    [TestClass]
    public class EditDepartment : DriverTestCase
    {
        [TestMethod]
        public void Editdepartment()
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

            //Click on department
            AdminDepartmentHelper.ClickElement("Department");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/department");


            //Click on edit icon
            AdminDepartmentHelper.ClickElement("EditIcon");

            //enter name
            AdminDepartmentHelper.TypeText("Name", Name);

            //select contact primary
            AdminDepartmentHelper.Select("PrimaryContact", "28");

            //Enter descriptions
            AdminDepartmentHelper.TypeText("Description","An Old department Editeded");

            //Click on save Button
            AdminDepartmentHelper.ClickElement("EditdepartmentSave");




        }
    }
}