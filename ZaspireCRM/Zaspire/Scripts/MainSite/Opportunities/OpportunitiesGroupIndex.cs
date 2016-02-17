using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesGroupIndex : DriverTestCase
    {
        [TestMethod]
        public void opportunitiesgroupindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesGroupIndexHelper = new OpportunitiesGroupIndexHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesGroupIndexHelper.WaitForWorkAround(7000);


            //Click On Groups
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnGroups");
             

//################### GROUPS INDEX PAGE ACTIONS #########################


            //Click on Groups Add New
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnGroupsAddNew");

            //Click on Back To Opportunities Groups Index page
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnBackToOpportunityGroups");
            OpportunitiesGroupIndexHelper.WaitForWorkAround(7000);

            //Enter Search Filter Box 
            OpportunitiesGroupIndexHelper.TypeText("EnterSearchFilterBox", "Test Group");
            OpportunitiesGroupIndexHelper.WaitForWorkAround(7000);

            //Click On Filter Reset Button
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnReset");
            OpportunitiesGroupIndexHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            OpportunitiesGroupIndexHelper.MouseHover("locator");

            //Click On Delete Opportunities Groups
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnDeleteOpportunityGroups");

            OpportunitiesGroupIndexHelper.AcceptAlert();
            OpportunitiesGroupIndexHelper.WaitForWorkAround(5000);

            //Check Master Check Box
            OpportunitiesGroupIndexHelper.ClickElement("CheckMasterCheckBox");

            //Uncheck Master Check Box
            OpportunitiesGroupIndexHelper.ClickElement("CheckMasterCheckBox");

            //Click On Mouse Over
            OpportunitiesGroupIndexHelper.MouseOver("locator");
            
            //Click On Quick Link
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On View
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnView");

            //Click on Back To Opportunities Groups Index page
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnBackToOpportunityGroups");
            OpportunitiesGroupIndexHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            OpportunitiesGroupIndexHelper.MouseOver("locator");
            
            //Click On Quick Link
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnQuickLink");


            //Click On Edit
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnEdit");

            //Click on Back To Opportunities Groups Index page
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnBackToOpportunityGroups");
            OpportunitiesGroupIndexHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            OpportunitiesGroupIndexHelper.MouseOver("locator");

            //Click On Quick Link
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnQuickLink");


            //Click On Delete
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnDelete");

            //Click On First Group Name
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnFirstGroupName");

            //Click on Back To Opportunities Groups Index page
            OpportunitiesGroupIndexHelper.ClickElement("ClickOnBackToOpportunityGroups");
            OpportunitiesGroupIndexHelper.WaitForWorkAround(10000);





        }
    }
}