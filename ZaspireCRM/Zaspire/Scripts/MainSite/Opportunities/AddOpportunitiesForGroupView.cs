using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddOpportunitiesForGroupView : DriverTestCase
    {
        [TestMethod]
        public void addopportunitiesforgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesGroupViewHelper = new OpportunitiesGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            OpportunitiesGroupViewHelper.ClickElement("ClickOnOpportunities");

            //Click On Groups
            OpportunitiesGroupViewHelper.ClickElement("ClickOnGroups");
            OpportunitiesGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            OpportunitiesGroupViewHelper.ClickElement("FirstOpportunityGroupNameLink");


//################### ADD OPPORTUNITIES FOR GROUPS VIEW PAGE  #########################


            //Click on Add Opportunities
            OpportunitiesGroupViewHelper.ClickElement("ClickOnAddOpportunities");

            //Select Pageination
            OpportunitiesGroupViewHelper.Select("SelectPagination", "20");

            //Click on Master Check Box
            OpportunitiesGroupViewHelper.ClickElement("SelectMasterCheckBox");

            //Click on Add To Group
            OpportunitiesGroupViewHelper.ClickElement("ClickOnAddToGroup");


        }
    }
}