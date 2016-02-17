using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateGroupView : DriverTestCase
    {
        [TestMethod]
        public void candidatesGroupView()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CandidateGroupViewHelper = new CandidateGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            CandidateGroupViewHelper.ClickElement("ClickOnCandidates");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates");
            //CandidateGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            //CandidateGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates/groups");
            CandidateGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            CandidateGroupViewHelper.ClickElement("FirstCandidateGroupNameLink");

            
//################### GROUPS VIEW PAGE ACTIONS  #########################


            //Click on Add New
            CandidateGroupViewHelper.ClickElement("ClickonAddcandidates");

            //Mousehover
            CandidateGroupViewHelper.ClickElement("SelectMasterCheckBox");

            //Click On Add New To Groups
            CandidateGroupViewHelper.ClickElement("ClickOnAddToGroups");
            CandidateGroupViewHelper.WaitForWorkAround(3000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups");
            //CandidateGroupViewHelper.WaitForWorkAround(7000);

            //Click on Edit
            CandidateGroupViewHelper.ClickElement("ClickOnEdit");

            //Click on Cancel
            CandidateGroupViewHelper.ClickElement("ClickOnCancelongroupedit");


            //Click on Candidatebulkaction view page
            CandidateGroupViewHelper.ClickElement("Mastercheckbox1");

            //Mousehover on bulkactions
            CandidateGroupViewHelper.MouseHover("locator");

            //Click on Candidatebulkaction view page
            CandidateGroupViewHelper.ClickElement("Bulkemail1");

            //Click on BUlkemail Cancel
            CandidateGroupViewHelper.ClickElement("");



            

            //Click On Edit To Groups
            CandidateGroupViewHelper.MouseOver("locator");

            //Click on Delete Groups
            CandidateGroupViewHelper.ClickElement("ClickOnDelete");

            //Accept alert
            CandidateGroupViewHelper.AcceptAlert();


            




        }
    }
}
