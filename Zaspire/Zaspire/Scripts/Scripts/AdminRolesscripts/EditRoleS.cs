using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EditRole : DriverTestCase
    {
        [TestMethod]
        public void editrole()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AdminRolesHelper = new AdminRolesHelper(GetWebDriver());

            //Variable

            var Name = "Role" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Mouse over on Profile
            AdminRolesHelper.Mouseover("locator");

            //click on admin
            AdminRolesHelper.ClickElement("ClickonAdmin");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            //Click on teams
            AdminRolesHelper.ClickElement("Roles");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/roles");


            //Click on add new
            AdminRolesHelper.ClickElement("RoleEdit");

            //enter name
            AdminRolesHelper.TypeText("RoleName1", "test");

            //Select  department
            AdminRolesHelper.Select("RoleDepartment", "36");

            //Click on save button
            AdminRolesHelper.ClickElement("Rolemanagercheckbox");

            //Click on Cancel Button
            AdminRolesHelper.ClickElement("RoleEditsave");




        }
    }
}