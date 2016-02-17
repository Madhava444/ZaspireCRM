using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunityViewPage : DriverTestCase
    {
        [TestMethod]
        public void opportunityviewpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunityViewPageHelper = new OpportunityViewPageHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            OpportunityViewPageHelper.ClickElement("ClickOnOpportunities");
            OpportunityViewPageHelper.WaitForWorkAround(7000);


            //Open Opportunity
            OpportunityViewPageHelper.ClickElement("FirstOpportunityNameLink");
            
            //Click on Job Positions tab
            OpportunityViewPageHelper.ClickElement("ClickOnJobPositionstab");

            //Click on Activities tab
            OpportunityViewPageHelper.ClickElement("ClickOnActivitiestab");

            //Click on Contact Info tab
            OpportunityViewPageHelper.ClickElement("ClickOnContactInfotab");

            //Click on Campaigns tab
            OpportunityViewPageHelper.ClickElement("ClickOnCampaignstab");

            //Click on Description tab
            OpportunityViewPageHelper.ClickElement("ClickOnDescriptiontab");

            //Click on Account Contacts tab
            OpportunityViewPageHelper.ClickElement("ClickOnAccountContactstab");

            //Click on Timeline tab
            OpportunityViewPageHelper.ClickElement("ClickOnTimeLinetab");




        }
    }
}
