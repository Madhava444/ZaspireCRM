using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsBulkDeleteForGroupView : DriverTestCase
    {
        [TestMethod]
        public void Jobsbulkdeleteforgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var jobsBulkActionsForGroupViewHelper = new JobsBulkActionsForGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnCandidates");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/jobs");
            // jobsBulkActionsForGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            // jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups");
            jobsBulkActionsForGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            jobsBulkActionsForGroupViewHelper.ClickElement("FirstCandidateGroupNameLink");


            //################### BULK DELETE LEADS FOR GROUPS VIEW  #########################


            //Click on Master Check Box
            jobsBulkActionsForGroupViewHelper.ClickElement("CheckMasterCheckBox");

            //Mouse Over
            jobsBulkActionsForGroupViewHelper.MouseOver("locator");

            //Click on Delete Leads
            jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnDeleteLeads");

            jobsBulkActionsForGroupViewHelper.AcceptAlert();
            jobsBulkActionsForGroupViewHelper.WaitForWorkAround(4000);




            //################### DELETE LEAD FOR GROUPS VIEW  #########################


            //Click on Delete Lead
            jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnDeleteCandidates");

            jobsBulkActionsForGroupViewHelper.AcceptAlert();
            jobsBulkActionsForGroupViewHelper.WaitForWorkAround(4000);



        }
    }
}
