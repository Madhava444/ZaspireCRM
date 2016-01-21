using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateIndexPageActions : DriverTestCase
    {
        [TestMethod]
        public void candidateindexpageactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateIndexPageActionsHelper = new CandidateIndexPageActionsHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            candidateIndexPageActionsHelper.ClickElement("ClickOnLeads");
            candidateIndexPageActionsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //LeadsIndexPageActionsHelper.WaitForWorkAround(7000);


            //Click on Filter By Groups
            candidateIndexPageActionsHelper.ClickElement("ClickOnFilterByGroups");

            //Click on Back to Leads
            //candidateIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");

            //Select Filter By Groups
            candidateIndexPageActionsHelper.Select("SelectFilterByGroups", "");

            //Click On Custom Views
            candidateIndexPageActionsHelper.ClickElement("ClickOnCustomViews");

            //Click on Back to Leads
            //candidateIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");

            
            //Click on Back to Leads
            //LeadsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");

            //Select Custom Views
            candidateIndexPageActionsHelper.Select("SelectCustomViews", "");

            //Select Default Views
            candidateIndexPageActionsHelper.Select("SelectDefaultViews", "My Leads");

            //Enter Tags
            candidateIndexPageActionsHelper.TypeText("EnterTags", "New");

            //Clock On Tags Search
            candidateIndexPageActionsHelper.ClickElement("ClockOnTagsSearch");

            //Clock On Tags Reset
            candidateIndexPageActionsHelper.ClickElement("ClockOnTagsReset");

            //Enter Filter Search
            candidateIndexPageActionsHelper.TypeText("EnterFilterSearch", "New");
            candidateIndexPageActionsHelper.WaitForWorkAround(10000);

            //Clock On Filter Reset
            candidateIndexPageActionsHelper.ClickElement("ClockOnFilterReset");

            //Clock On Master Check Box
            candidateIndexPageActionsHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Master Uncheck Box
            candidateIndexPageActionsHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Lead Name Link
            candidateIndexPageActionsHelper.ClickElement("FirstLeadNameLink");

            //Click on Back to Leads
            //candidateIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");

            //Clock On Quick Look Mouse Over
            candidateIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            candidateIndexPageActionsHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look View
            candidateIndexPageActionsHelper.ClickElement("ClockOnQuickLookView");
            candidateIndexPageActionsHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            //candidateIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");

            //Clock On Quick Look Mouse Over
            candidateIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            candidateIndexPageActionsHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Edit
            candidateIndexPageActionsHelper.ClickElement("ClockOnQuickLookEdit");
            candidateIndexPageActionsHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            //candidateIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");

            //Clock On Quick Look Mouse Over
            candidateIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            candidateIndexPageActionsHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Delete
            candidateIndexPageActionsHelper.ClickElement("ClockOnQuickLookDelete");

            candidateIndexPageActionsHelper.AcceptAlert();
            candidateIndexPageActionsHelper.WaitForWorkAround(10000);








        }
    }
}