using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddGroupsForLeadsView : DriverTestCase
    {
        [TestMethod]
        public void addgroupsforleadsview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsViewPageHelper = new LeadsViewPageHelper(GetWebDriver());

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            LeadsViewPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsViewPageHelper.WaitForWorkAround(7000);


            //Open Lead
            LeadsViewPageHelper.ClickElement("FirstLeadNameLink");


//################### ADD GROUPS #########################


            //Select Add To Group
            LeadsViewPageHelper.Select("SelectAddToGroup", "13");

            //Click on Save Group
            LeadsViewPageHelper.ClickElement("ClickOnSaveGroup");

            //Select Add To Group
            LeadsViewPageHelper.Select("SelectAddToGroup", "15");

            //Click On Cancel Group
            LeadsViewPageHelper.ClickElement("ClickOnCancelGroup");

            //Select Add To Group
            LeadsViewPageHelper.Select("SelectAddToGroup", "16");

            //Click on Save Group
            LeadsViewPageHelper.ClickElement("ClickOnSaveGroup");

            //Click on Remove Group
            LeadsViewPageHelper.ClickElement("ClickOnRemoveGroup");
            LeadsViewPageHelper.WaitForWorkAround(10000);
            
            

        }
    }
}