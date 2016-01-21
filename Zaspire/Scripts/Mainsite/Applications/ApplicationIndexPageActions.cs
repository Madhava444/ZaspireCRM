using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class ApplicationIndexPageActions : DriverTestCase
    {
        [TestMethod]
        public void Applicationsindexpageactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var ApplicationsIndexPageActionsHelper = new ApplicationsindexpageHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            ApplicationsIndexPageActionsHelper.ClickElement("ClickOnApplication");
            ApplicationsIndexPageActionsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //LeadsIndexPageActionsHelper.WaitForWorkAround(7000);


            //Enter Tags
            ApplicationsIndexPageActionsHelper.TypeText("EnterTags", "New");

            //Clock On Tags Search
            ApplicationsIndexPageActionsHelper.ClickElement("ClockOnTagsSearch");

            //Clock On Tags Reset
            ApplicationsIndexPageActionsHelper.ClickElement("ClockOnTagsReset");

            

            //Select Custom Views
            ApplicationsIndexPageActionsHelper.Select("SelectCustomViews", "105");


            //Click On Set As Default Custom View
            ApplicationsIndexPageActionsHelper.ClickElement("ClickOnSetAsDefault");
            ApplicationsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Click On Unset Default Custom View
            ApplicationsIndexPageActionsHelper.ClickElement("ClickOnUnsetDefault");
            ApplicationsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Clock On Edit Custom View
            ApplicationsIndexPageActionsHelper.ClickElement("ClickOnEdit");

            //back to applications
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/applications/");

            //Clock On Edit Custom View cancel button
            //ApplicationsIndexPageActionsHelper.ClickElement("ClickOnEditCancel");


            //Select Custom View
            ApplicationsIndexPageActionsHelper.Select("SelectCustomViews", "105");

            //Clock On New Custom View
            ApplicationsIndexPageActionsHelper.ClickElement("ClickOnNew");

            //Clock On New Custom View cancel button
            //ApplicationsIndexPageActionsHelper.ClickElement("ClickOnNewCancel");

            //back to applications
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/applications/");

            //Select Custom View
            ApplicationsIndexPageActionsHelper.Select("SelectCustomView", "105");

            //Clock On Delete Custom View
            ApplicationsIndexPageActionsHelper.ClickElement("ClickOnDelete");


            ApplicationsIndexPageActionsHelper.AcceptAlert();
            ApplicationsIndexPageActionsHelper.WaitForWorkAround(10000);

            

            

            //Enter Filter Search
            ApplicationsIndexPageActionsHelper.TypeText("EnterFilterSearch", "New");
            ApplicationsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Clock On Filter Reset
            ApplicationsIndexPageActionsHelper.ClickElement("ClockOnFilterReset");

            //Clock On Master Check Box
            ApplicationsIndexPageActionsHelper.ClickElement("ClockOnMasterCheckBox");

            //Bulkupdate
            //ApplicationsIndexPageActionsHelper.MouseHover("locator");

            //bulkupdate status
            //ApplicationsIndexPageActionsHelper.ClickElement("Bulkupdateapplications");

           //Clock On Lead Name Link
            ApplicationsIndexPageActionsHelper.ClickElement("FirstApplicationNameLink");

            //Click on Back to Leads
            //ApplicationsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");

            //Clock On Quick Look Mouse Over
            ApplicationsIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            ApplicationsIndexPageActionsHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look View
            ApplicationsIndexPageActionsHelper.ClickElement("ClockOnQuickLookView");
            ApplicationsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            //ApplicationsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");

            //Clock On Quick Look Mouse Over
            ApplicationsIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            ApplicationsIndexPageActionsHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Edit
            ApplicationsIndexPageActionsHelper.ClickElement("ClockOnQuickLookEdit");
            ApplicationsIndexPageActionsHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            //ApplicationsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");

            //Clock On Quick Look Mouse Over
            ApplicationsIndexPageActionsHelper.MouseOver("locator");

            //Clock On Quick Look
            ApplicationsIndexPageActionsHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Delete
            ApplicationsIndexPageActionsHelper.ClickElement("ClickOnQuickLookSetupinterview");

            ApplicationsIndexPageActionsHelper.AcceptAlert();
            ApplicationsIndexPageActionsHelper.WaitForWorkAround(10000);












        }
    }
}