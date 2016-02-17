using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddGroupsForCanidateView : DriverTestCase
    {
        [TestMethod]
        public void addgroupsforcandidatesview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var canidateViewPageHelper = new CanidateViewPageHelper(GetWebDriver());

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            canidateViewPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsViewPageHelper.WaitForWorkAround(7000);


            //Open Lead
            canidateViewPageHelper.ClickElement("FirstLeadNameLink");


//################### ADD GROUPS #########################


            //Select Add To Group
            canidateViewPageHelper.Select("SelectAddToGroup", "13");

            //Click on Save Group
            canidateViewPageHelper.ClickElement("ClickOnSaveGroup");

            //Select Add To Group
            canidateViewPageHelper.Select("SelectAddToGroup", "15");

            //Click On Cancel Group
            canidateViewPageHelper.ClickElement("ClickOnCancelGroup");

            //Select Add To Group
            canidateViewPageHelper.Select("SelectAddToGroup", "16");

            //Click on Save Group
            canidateViewPageHelper.ClickElement("ClickOnSaveGroup");

            //Click on Remove Group
            canidateViewPageHelper.ClickElement("ClickOnRemoveGroup");
            canidateViewPageHelper.WaitForWorkAround(10000);
            
            

        }
    }
}