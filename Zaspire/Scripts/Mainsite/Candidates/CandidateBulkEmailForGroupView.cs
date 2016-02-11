using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateBulkEmailForGroupView : DriverTestCase
    {
        [TestMethod]
        public void candidatebulkemailforgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateBulkActionsForGroupViewHelper = new CandidatesBulkActionsForGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            candidateBulkActionsForGroupViewHelper.ClickElement("ClickOnCandidates");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //candidateBulkActionsForGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            //candidateBulkActionsForGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates/groups");
            candidateBulkActionsForGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            candidateBulkActionsForGroupViewHelper.ClickElement("FirstCandidateGroupNameLink");


//################### BULK UPDATE LEADS FOR GROUPS VIEW  #########################


            //Click on Master Check Box
            candidateBulkActionsForGroupViewHelper.ClickElement("CheckMasterCheckBox");

            //Mouse Over
            candidateBulkActionsForGroupViewHelper.MouseOver("locator");

            //Click on Bulk Email
            candidateBulkActionsForGroupViewHelper.ClickElement("ClickOnBulkEmail");
            candidateBulkActionsForGroupViewHelper.WaitForWorkAround(4000);

            //Enter Email Cc Address
            candidateBulkActionsForGroupViewHelper.TypeText("EnterEmailCcAddress", "");

            //Enter Email Bcc Address
            candidateBulkActionsForGroupViewHelper.TypeText("EnterEmailBccAddress", "");

            //Enter Email Subject
            candidateBulkActionsForGroupViewHelper.TypeText("EnterEmailSubject", "Test Email");

            //Click On Prioroty
            candidateBulkActionsForGroupViewHelper.ClickElement("ClickOnPriority");

            //Click On Copy To CC Check Box
            candidateBulkActionsForGroupViewHelper.ClickElement("ClickOnCopyToCCCheckBox");

            //Select Copy To CC
            candidateBulkActionsForGroupViewHelper.Select("SelectCopyToCC", "owners");

            //Click On Copy To BCC Check Box
            candidateBulkActionsForGroupViewHelper.ClickElement("ClickOnCopyToBCCCheckBox");

            //Select Copy To BCC
            candidateBulkActionsForGroupViewHelper.Select("SelectCopyToBCC", "Managers");

            //Select Email Signature
            candidateBulkActionsForGroupViewHelper.Select("SelectEmailSignature", "");

            //Click On Send Button
            candidateBulkActionsForGroupViewHelper.ClickElement("ClickOnSendButton");
            candidateBulkActionsForGroupViewHelper.WaitForWorkAround(10000);







        }
    }
}