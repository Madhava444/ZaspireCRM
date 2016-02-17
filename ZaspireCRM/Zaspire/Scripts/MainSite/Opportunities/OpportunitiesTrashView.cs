using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesTrashView : DriverTestCase
    {
        [TestMethod]
        public void opportunitiestrashview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesTrashViewHelper = new OpportunitiesTrashViewHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Opportunities
            OpportunitiesTrashViewHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesTrashViewHelper.WaitForWorkAround(10000);

            //Click on Trash
            OpportunitiesTrashViewHelper.ClickElement("ClickOnTrash");
            OpportunitiesTrashViewHelper.WaitForWorkAround(10000);

            //Click On Opportunity View
            OpportunitiesTrashViewHelper.ClickElement("ClickOnOpportunityView");

            //Click on Job Positions tab
            OpportunitiesTrashViewHelper.ClickElement("ClickOnJobPositionstab");

            //Click on Activities tab
            OpportunitiesTrashViewHelper.ClickElement("ClickOnActivitiestab");

            //Click on Contact Info tab
            OpportunitiesTrashViewHelper.ClickElement("ClickOnContactInfotab");

            //Click on Campaigns tab
            OpportunitiesTrashViewHelper.ClickElement("ClickOnCampaignstab");

            //Click on Description tab
            OpportunitiesTrashViewHelper.ClickElement("ClickOnDescriptiontab");

            //Click on Account Contacts tab
            OpportunitiesTrashViewHelper.ClickElement("ClickOnAccountContactstab");

            //Click on Timeline tab
            OpportunitiesTrashViewHelper.ClickElement("ClickOnTimeLinetab");

            //Click on Delete
            OpportunitiesTrashViewHelper.ClickElement("ClickOnDelete");

            OpportunitiesTrashViewHelper.AcceptAlert();
            OpportunitiesTrashViewHelper.WaitForWorkAround(5000);

            //Click On Opportunity View
            OpportunitiesTrashViewHelper.ClickElement("ClickOnOpportunityView");

            //Click on Restore
            OpportunitiesTrashViewHelper.ClickElement("ClickOnRestore");

            OpportunitiesTrashViewHelper.AcceptAlert();
            OpportunitiesTrashViewHelper.WaitForWorkAround(5000);

            //Click On Opportunity View
            OpportunitiesTrashViewHelper.ClickElement("ClickOnOpportunityView");

            //Click on Back
            OpportunitiesTrashViewHelper.ClickElement("ClickOnBack");



        }
    }
}