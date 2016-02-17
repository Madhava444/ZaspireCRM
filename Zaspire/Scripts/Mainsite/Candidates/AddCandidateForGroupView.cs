using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddCandidateForGroupView : DriverTestCase
    {
        [TestMethod]
        public void addcandidateforgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var canidateGroupViewHelper = new CandidateGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            canidateGroupViewHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //canidateGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            //canidateGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups");
            canidateGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            canidateGroupViewHelper.ClickElement("FirstLeadGroupNameLink");


//################### ADD LEADS FOR GROUPS VIEW PAGE  #########################


            //Click on Add Leads
            canidateGroupViewHelper.ClickElement("ClickOnAddLeads");

            //Select Pageination
            canidateGroupViewHelper.Select("SelectPagination", "20");

            //Click on Master Check Box
            canidateGroupViewHelper.ClickElement("SelectMasterCheckBox");

            //Click on Add To Group
            canidateGroupViewHelper.ClickElement("ClickOnAddToGroup");


        }
    }
}