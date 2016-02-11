using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class AccessProfileCreate : DriverTestCase
    {
        [TestMethod]
        public void accessprofilescreate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AccessProfilesIndexHelper = new AccessProfilesIndexHelper(GetWebDriver());

            //Variable
            var TestUser = "Test User" + RandomNumber(1, 99);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            //MouseOver
            AccessProfilesIndexHelper.MouseOver("locator");

            //Click on Admin
            AccessProfilesIndexHelper.ClickElement("ClickOnAdmin");
            AccessProfilesIndexHelper.WaitForWorkAround(10000);

            //Click on Access Profiles
            //AccessProfilesIndexHelper.ClickElement("ClickOnAccessProfiles");
            //AccessProfilesIndexHelper.WaitForWorkAround(10000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/access_profiles");
            AccessProfilesIndexHelper.WaitForWorkAround(10000);

            //Click on Add New
            AccessProfilesIndexHelper.ClickElement("ClickOnAddNew");

            //Enter Access Profile Name
            AccessProfilesIndexHelper.TypeText("EnterName", TestUser);

            //Select User Type
            AccessProfilesIndexHelper.Select("SelectUserType", "1");

            //Select Status
            AccessProfilesIndexHelper.Select("SelectStatus", "0");

            //Click on Modules
            AccessProfilesIndexHelper.ClickElement("ClickOnModules");

            //Click on Organizations
            AccessProfilesIndexHelper.ClickElement("ClickOnOrganizations");

            //Click on Menus
            AccessProfilesIndexHelper.ClickElement("ClickOnMenus");

            //Click on Email Templates
            AccessProfilesIndexHelper.ClickElement("ClickOnEmailTemplates");

            //Click on Employees
            AccessProfilesIndexHelper.ClickElement("ClickOnEmployees");

            //Click on Consultants
            AccessProfilesIndexHelper.ClickElement("ClickOnConsultants");


            //Click on System Level Privilege
            AccessProfilesIndexHelper.ClickElement("ClickOnSystemLevelPrivilege");

            //Click on Settings
            AccessProfilesIndexHelper.ClickElement("ClickOnSettings");

            //Click on Pick Lists
            AccessProfilesIndexHelper.ClickElement("ClickOnPickLists");

            //Click on Users
            AccessProfilesIndexHelper.ClickElement("ClickOnUsers");

            //Click on Custom Fields
            AccessProfilesIndexHelper.ClickElement("ClickOnCustomFields");


            //Click on Core Level Privilege
            AccessProfilesIndexHelper.ClickElement("ClickOnCoreLevelPrivilege");

            //Click on Leads
            AccessProfilesIndexHelper.ClickElement("ClickOnLeads");

            //Click on Accounts
            AccessProfilesIndexHelper.ClickElement("ClickOnAccounts");

            //Click on Opportunities
            AccessProfilesIndexHelper.ClickElement("ClickOnOpportunities");

            //Click on Contacts
            AccessProfilesIndexHelper.ClickElement("ClickOnContacts");

            //Click on Reports
            AccessProfilesIndexHelper.ClickElement("ClickOnReports");

            //Click on Email Accounts
            AccessProfilesIndexHelper.ClickElement("ClickOnEmailAccounts");

            //Click on Bulk Emails
            AccessProfilesIndexHelper.ClickElement("ClickOnBulkEmails");

            //Click on Campaigns
            AccessProfilesIndexHelper.ClickElement("ClickOnCampaigns");

            //Click on Partners
            AccessProfilesIndexHelper.ClickElement("ClickOnPartners");

            //Click on Vendors
            AccessProfilesIndexHelper.ClickElement("ClickOnVendors");


            //Click on Activities Level Privilege
            AccessProfilesIndexHelper.ClickElement("ClickOnActivitiesLevelPrivilege");

            //Click on Files
            AccessProfilesIndexHelper.ClickElement("ClickOnFiles");

            //Click on Notes
            AccessProfilesIndexHelper.ClickElement("ClickOnNotes");

            //Click on Libraries
            AccessProfilesIndexHelper.ClickElement("ClickOnLibraries");

            //Click on Emails
            AccessProfilesIndexHelper.ClickElement("ClickOnEmails");

            //Click on Events 
            AccessProfilesIndexHelper.ClickElement("ClickOnEvents");

            //Click on Calls 
            AccessProfilesIndexHelper.ClickElement("ClickOnCalls");


            //ClickOn Save
            AccessProfilesIndexHelper.ClickElement("ClickOnCreateSave");
            AccessProfilesIndexHelper.WaitForWorkAround(10000);










        }
    }
}