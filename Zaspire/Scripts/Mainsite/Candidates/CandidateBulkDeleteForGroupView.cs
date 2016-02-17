using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidatesBulkDeleteForGroupView : DriverTestCase
    {
        [TestMethod]
        public void Candidatebulkdeleteforgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidatesBulkActionsForGroupViewHelper = new CandidatesBulkActionsForGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            candidatesBulkActionsForGroupViewHelper.ClickElement("ClickOnCandidates");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //candidatesBulkActionsForGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            //candidatesBulkActionsForGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates/groups");
            candidatesBulkActionsForGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            candidatesBulkActionsForGroupViewHelper.ClickElement("FirstCandidateGroupNameLink");


//################### BULK DELETE LEADS FOR GROUPS VIEW  #########################


            //Click on Master Check Box
            candidatesBulkActionsForGroupViewHelper.ClickElement("CheckMasterCheckBox");

            //Mouse Over
            candidatesBulkActionsForGroupViewHelper.MouseOver("locator");

            //Click on Delete Leads
            candidatesBulkActionsForGroupViewHelper.ClickElement("ClickOnDeleteLeads");

            candidatesBulkActionsForGroupViewHelper.AcceptAlert();
            candidatesBulkActionsForGroupViewHelper.WaitForWorkAround(4000);




//################### DELETE LEAD FOR GROUPS VIEW  #########################


            //Click on Delete Lead
            candidatesBulkActionsForGroupViewHelper.ClickElement("ClickOnDeleteCandidates");

            candidatesBulkActionsForGroupViewHelper.AcceptAlert();
            candidatesBulkActionsForGroupViewHelper.WaitForWorkAround(4000);



        }
    }
}