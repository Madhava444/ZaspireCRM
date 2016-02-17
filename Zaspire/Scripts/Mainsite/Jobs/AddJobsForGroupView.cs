using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddJobsForGroupView : DriverTestCase
    {
        [TestMethod]
        public void addJobsforgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var JobsGroupViewHelper = new JobsGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            JobsGroupViewHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //JobsGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            //JobsGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups");
            JobsGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            JobsGroupViewHelper.ClickElement("FirstLeadGroupNameLink");


            //################### ADD LEADS FOR GROUPS VIEW PAGE  #########################


            //Click on Add Leads
            JobsGroupViewHelper.ClickElement("ClickOnAddLeads");

            //Select Pageination
            JobsGroupViewHelper.Select("SelectPagination", "20");

            //Click on Master Check Box
            JobsGroupViewHelper.ClickElement("SelectMasterCheckBox");

            //Click on Add To Group
            JobsGroupViewHelper.ClickElement("ClickOnAddToGroup");


        }
    }
}
