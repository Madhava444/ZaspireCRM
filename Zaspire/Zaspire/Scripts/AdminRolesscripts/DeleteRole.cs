using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts
{
    [TestClass]
    public class DeleteRole : DriverTestCase
    {
        [TestMethod]
        public void Deleterole()
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

            //Click on role
            AdminRolesHelper.ClickElement("Roles");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/roles");


            //Click on delete role
            AdminRolesHelper.ClickElement("RoleDelete");
            
            
            




        }
    }
}