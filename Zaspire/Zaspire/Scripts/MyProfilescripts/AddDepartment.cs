using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium.Interactions;

namespace Zaspire.Scripts
{
    [TestClass]
    public class DetailsandChangepassword : DriverTestCase
    {
        [TestMethod]
        public void Detailandchangepassword()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AdminMyProfileHelper = new AdminMyProfileHelper(GetWebDriver());

            //Variable

            var Name = "Department" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Mouse over on Profile
            AdminMyProfileHelper.Mouseover("locator");

            //click on admin
            AdminMyProfileHelper.ClickElement("ClickonAdmin");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            //Click on Department
            AdminMyProfileHelper.ClickElement("Department");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/department");


            //Click on add new
            AdminMyProfileHelper.ClickElement("DepartmentAddNew");

            //enter name
            AdminMyProfileHelper.TypeText("Name", Name);

            //Select  Primary contact
            AdminMyProfileHelper.Select("PrimaryContact", "17");

            //Enter Description
            AdminMyProfileHelper.TypeText("Description","New department created");

            //Click on save Button
            AdminMyProfileHelper.ClickElement("SaveDepartment");




        }
    }
}