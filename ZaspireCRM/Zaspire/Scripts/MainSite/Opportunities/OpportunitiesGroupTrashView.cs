using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesGroupTrashView : DriverTestCase
    {
        [TestMethod]
        public void opportunitiesgrouptrashview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesGroupTrashIndexHelper = new OpportunitiesGroupTrashIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Opportunities
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click On Opportunities Trash
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnOpportunitiesTrash");

            //Click On Opportunities Group Trash
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnGroupTarsh");
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click On Opportunities Group View
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnOpportunityGroupView");

            //Click On Back To Group
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnBackToGroup");

            //Click On Opportunities Group View
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnOpportunityGroupView");

            //Click On Restore
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnRestoreGroup");

            OpportunitiesGroupTrashIndexHelper.AcceptAlert();
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(5000);
            
            //Click On Opportunities Group View
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnOpportunityGroupView");

            //Click On Delete
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnDeleteGroup");

            OpportunitiesGroupTrashIndexHelper.AcceptAlert();
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(5000);

            
        }
    }
}