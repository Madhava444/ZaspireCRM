using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsIndexPageActions : DriverTestCase
    {
        [TestMethod]
        public void jobsindexpageactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var jobsIndexPageActionsHelper = new JobsIndexPageActionsHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            jobsIndexPageActionsHelper.ClickElement("ClickonJobs");
            jobsIndexPageActionsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/jobs");
            //LeadsIndexPageActionsHelper.WaitForWorkAround(7000);


            //Click on Filter By Groups
            jobsIndexPageActionsHelper.ClickElement("ClickOnFilterByGroups");

            //Click on Back to Leads
            //jobsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs");

            //Select Filter By Groups
            jobsIndexPageActionsHelper.Select("SelectFilterByGroups", "");

            //Click On Custom Views
            jobsIndexPageActionsHelper.ClickElement("ClickOnCustomViews");

            //Click on Back to Leads
            //jobsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs");


            //Click on Back to Leads
            //LeadsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

          

            //Select Custom Views
            jobsIndexPageActionsHelper.Select("SelectCustomViews", "117");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs");

            //Select Default Views
            jobsIndexPageActionsHelper.Select("SelectDefaultViews", "Recently Modified");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs");

            //Enter Tags
            jobsIndexPageActionsHelper.TypeText("EnterTags", "New");

            //Clock On Tags Search
            jobsIndexPageActionsHelper.ClickElement("ClockOnTagsSearch");

            //Clock On Tags Reset
            jobsIndexPageActionsHelper.ClickElement("ClockOnTagsReset");

            //Enter Filter Search
            jobsIndexPageActionsHelper.TypeText("EnterFilterSearch", "Confidential");
            jobsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Clock On Filter Reset
            jobsIndexPageActionsHelper.ClickElement("ClockOnFilterReset");

            //Clock On Master Check Box
            jobsIndexPageActionsHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Master Uncheck Box
            jobsIndexPageActionsHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Lead Name Link
            jobsIndexPageActionsHelper.ClickElement("FirstJobsNameLink");

            //Click on Back to Leads
            //jobsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs");

            //Clock On Quick Look Mouse Over
            jobsIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            jobsIndexPageActionsHelper.ClickElement("ClickOnQuickLook");

            //Clock On Quick Look View
            jobsIndexPageActionsHelper.ClickElement("ClickOnQuickLookView");
            jobsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            //jobsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs");

            //Clock On Quick Look Mouse Over
            jobsIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            jobsIndexPageActionsHelper.ClickElement("ClickOnQuickLook");

            //Clock On Quick Look Edit
            jobsIndexPageActionsHelper.ClickElement("ClickOnQuickLookEdit");
            jobsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            //jobsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs");

            //Clock On Quick Look Mouse Over
            jobsIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            jobsIndexPageActionsHelper.ClickElement("ClickOnQuickLook");

            //Clock On Quick Look Delete
            jobsIndexPageActionsHelper.ClickElement("ClickOnQuickLookDelete");

            jobsIndexPageActionsHelper.AcceptAlert();
            jobsIndexPageActionsHelper.WaitForWorkAround(10000);








        }
    }
}
