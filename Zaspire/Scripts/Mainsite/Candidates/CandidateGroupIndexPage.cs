using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateGroupIndexPage : DriverTestCase
    {
        [TestMethod]
        public void candidategroupindexpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CandidateGroupIndexPageHelper = new CandidateGroupIndexPageHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            CandidateGroupIndexPageHelper.ClickElement("ClickOnCandidates");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates");
            //CandidateGroupIndexPageHelper.WaitForWorkAround(7000);


            //Click On Groups
            //CandidateGroupIndexPageHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates/groups");
            CandidateGroupIndexPageHelper.WaitForWorkAround(7000);

//################### GROUPS INDEX PAGE ACTIONS #########################


            //Click on Groups Add New
            //CandidateGroupIndexPageHelper.ClickElement("ClickOnGroupsAddNew");

            //Click on Back To Lead Groups Index page
            //CandidateGroupIndexPageHelper.ClickElement("ClickOnGroupsAddNew");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups");
            //CandidateGroupIndexPageHelper.WaitForWorkAround(7000);

            //Enter Search Filter Box 
            CandidateGroupIndexPageHelper.TypeText("EnterSearchFilterBox", "Test Group");
            CandidateGroupIndexPageHelper.WaitForWorkAround(7000);

            //Click On Filter Reset Button
            CandidateGroupIndexPageHelper.ClickElement("ClickOnFilterResetButton");
            CandidateGroupIndexPageHelper.WaitForWorkAround(7000);

            //Check Master Check Box
            CandidateGroupIndexPageHelper.ClickElement("CheckMasterCheckBox");


            //Click On Mouse Over
            CandidateGroupIndexPageHelper.MouseHover("locator");

            //Click On Delete Lead Groups
            CandidateGroupIndexPageHelper.ClickElement("ClickOnDeleteCandidateGroups");


            //Click on Alert
            CandidateGroupIndexPageHelper.AcceptAlert();

            

            //Click On Mouse Over
            CandidateGroupIndexPageHelper.MouseOver("locator");
            
            //Click On Quick Link
            CandidateGroupIndexPageHelper.ClickElement("ClickOnQuickLink");

            //Click On View
            CandidateGroupIndexPageHelper.ClickElement("ClickOnView");

            //Click on Back To Lead Groups Index page
            //LeadsGroupIndexPageHelper.ClickElement("ClickOnBackToLeadGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups");
            CandidateGroupIndexPageHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            CandidateGroupIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            CandidateGroupIndexPageHelper.ClickElement("ClickOnQuickLink");


            //Click On Edit
            CandidateGroupIndexPageHelper.ClickElement("ClickOnEdit");

            //Click on Back To Lead Groups Index page
            //LeadsGroupIndexPageHelper.ClickElement("ClickOnBackToLeadGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups");
            CandidateGroupIndexPageHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            CandidateGroupIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            CandidateGroupIndexPageHelper.ClickElement("ClickOnQuickLink");


            //Click On Delete
            CandidateGroupIndexPageHelper.ClickElement("ClickOnDelete");

            //Click On First Group Name
            CandidateGroupIndexPageHelper.ClickElement("ClickOnFirstGroupName");

            //Click on Back To Lead Groups Index page
            CandidateGroupIndexPageHelper.ClickElement("ClickOnBackToCandidateGroups");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups");
            //CandidateGroupIndexPageHelper.WaitForWorkAround(7000);





        }
    }
}