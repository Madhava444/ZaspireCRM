using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts
{
    [TestClass]
    public class AddAdmindashboard : DriverTestCase
    {
        [TestMethod]
        public void addAdmindashboard()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AdminDashboardHelper = new AdminDashboardHelper(GetWebDriver());

            //Variable

            var Name = "Team" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Mouse over on Profile
            AdminDashboardHelper.Mouseover("locator");

            //click on admin
            //AdminDashboardHelper.ClickElement("ClickonAdmin");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            //Click on Usermanagement
            AdminDashboardHelper.ClickElement("Usermanagement");

          
            //Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");

            //Click on AdminProfile1
            AdminDashboardHelper.ClickElement("AdminProfile");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            //Click on back to home
            //AdminDashboardHelper.ClickElement("BacktoHome");


            //Click  on  OrganizationProfile
            AdminDashboardHelper.ClickElement("OrganizationProfile");

            //Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");


            //Click on TeamManagement
            AdminDashboardHelper.ClickElement("TeamManagement");

            // Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");


            //Click on Adminreport
            //AdminDashboardHelper.ClickElement("Adminreport");

            //Click on back to home
            //AdminDashboardHelper.ClickElement("BacktoHome");


            //Click on AuditTrails
            AdminDashboardHelper.ClickElement("AuditTrails");

            //Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");


            //Click on OrganizationSettings
            AdminDashboardHelper.ClickElement("OrganizationSettings");

            //Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");


            //Click on AccessProfile
            AdminDashboardHelper.ClickElement("AccessProfile");

            //Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");


            //Click on RoleManagement
            AdminDashboardHelper.ClickElement("RoleManagement");

            //Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");


            //Click on MenuManagement
            AdminDashboardHelper.ClickElement("MenuManagement");

            //Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");


            //Click on Alertmanagement
            AdminDashboardHelper.ClickElement("Alertmanagement");

            //Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");


            //Click on TagsManagement
            AdminDashboardHelper.ClickElement("TagsManagement");

            //Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");


            //Click on PicklistManagement
            AdminDashboardHelper.ClickElement("PicklistManagement");

            //Click on back to home
            AdminDashboardHelper.ClickElement("BacktoHome");

        }
    }
}