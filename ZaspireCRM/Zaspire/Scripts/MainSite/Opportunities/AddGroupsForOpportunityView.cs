using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddGroupsForOpportunityView : DriverTestCase
    {
        [TestMethod]
        public void addgroupsforopportunityview()
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


//################### ADD GROUPS #########################


            //Select Add To Group
            OpportunityViewPageHelper.Select("SelectAddToGroup", "4");

            //Click on Save Group
            OpportunityViewPageHelper.ClickElement("ClickOnSaveGroup");

            //Select Add To Group
            OpportunityViewPageHelper.Select("SelectAddToGroup", "14");

            //Click On Cancel Group
            OpportunityViewPageHelper.ClickElement("ClickOnCancelGroup");

            //Select Add To Group
            OpportunityViewPageHelper.Select("SelectAddToGroup", "7");

            //Click on Save Group
            OpportunityViewPageHelper.ClickElement("ClickOnSaveGroup");

            //Click on Remove Group
            OpportunityViewPageHelper.ClickElement("ClickOnRemoveGroup");
            OpportunityViewPageHelper.WaitForWorkAround(10000);
            
            

        }
    }
}