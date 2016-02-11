using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddToCampaignForLead : DriverTestCase
    {
        [TestMethod]
        public void addtocampaignforlead()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddEventsForLeadHelper = new AddEventsForLeadHelper(GetWebDriver());

                              

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForLeadHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //AddEventsForLeadHelper.WaitForWorkAround(7000);


            //Open Lead
            AddEventsForLeadHelper.ClickElement("FirstLeadNameLink");
            AddEventsForLeadHelper.WaitForWorkAround(10000);

            //Click on Move over
            AddEventsForLeadHelper.MouseOver("locator");
            AddEventsForLeadHelper.WaitForWorkAround(5000);


//###################  LEADS ADD TO CAMPAIGN   #########################

            
            //Click on Add To Campaign
            AddEventsForLeadHelper.ClickElement("ClickOnAddToCampaign");
            AddEventsForLeadHelper.WaitForWorkAround(5000);

            //Click on Merge Button
            AddEventsForLeadHelper.ClickElement("ClickOnMergeButton");

            //Click On Campaign Name
            AddEventsForLeadHelper.ClickElement("ClickOnCampaignName");

            //Select Campaign Group
            //AddEventsForLeadHelper.Select("SelectCampaignGroup", "10");

            //Enter Add New Campaign Group Name
            AddEventsForLeadHelper.TypeText("EnterCampaignGroupName", "Test Group");

            //Click On Add Leads
            AddEventsForLeadHelper.ClickElement("ClickOnAddLeads");
            AddEventsForLeadHelper.WaitForWorkAround(10000);

            
        }
    }
}
