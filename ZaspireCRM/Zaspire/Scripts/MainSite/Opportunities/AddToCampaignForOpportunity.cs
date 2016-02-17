using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddToCampaignForOpportunity : DriverTestCase
    {
        [TestMethod]
        public void addtocampaignforopportunity()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddEventsForOpportunityHelper = new AddEventsForOpportunityHelper(GetWebDriver());

                              

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            AddEventsForOpportunityHelper.ClickElement("ClickOnOpportunities");
            AddEventsForOpportunityHelper.WaitForWorkAround(7000);


            //Open Opportunity
            AddEventsForOpportunityHelper.ClickElement("FirstOpportunityNameLink");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);

            //Click on Move over
            AddEventsForOpportunityHelper.MouseOver("locator");
            AddEventsForOpportunityHelper.WaitForWorkAround(5000);


//###################  OPPORTUNITY ADD TO CAMPAIGN   #########################

            
            //Click on Add To Campaign
            AddEventsForOpportunityHelper.ClickElement("ClickOnAddToCampaign");
            AddEventsForOpportunityHelper.WaitForWorkAround(4000);

            //Click on Merge Button
            AddEventsForOpportunityHelper.ClickElement("ClickOnMergeButton");

            //Click On Campaign Name
            AddEventsForOpportunityHelper.ClickElement("ClickOnCampaignName");

            //Select Campaign Group
            //AddEventsForOpportunityHelper.Select("SelectCampaignGroup", "10");

            //Enter Add New Campaign Group Name
            AddEventsForOpportunityHelper.TypeText("EnterCampaignGroupName", "Test Group");

            //Click On Add Leads
            AddEventsForOpportunityHelper.ClickElement("ClickOnAddOpportunities");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);

            
        }
    }
}
