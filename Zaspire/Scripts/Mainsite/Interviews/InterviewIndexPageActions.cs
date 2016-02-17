using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class InterviewsIndexPageActions : DriverTestCase
    {
        [TestMethod]
        public void Interviewsindexpageactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var InterviewsindexpageHelper = new InterviewsindexpageHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            InterviewsindexpageHelper.ClickElement("ClickOnInterviewtab");
            InterviewsindexpageHelper.WaitForWorkAround(10000);


            //Click on Calendarview
            //InterviewsindexpageHelper.ClickElement("ClickonCalendarview");
           // InterviewsindexpageHelper.WaitForWorkAround(10000);

            //Click on Calendarview
           // InterviewsindexpageHelper.ClickElement("ClickonListiew");
            //InterviewsindexpageHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/interviews");
            //LeadsIndexPageActionsHelper.WaitForWorkAround(7000);


            
            //Select Custom Views
            InterviewsindexpageHelper.Select("ClickOnCustomViews", "105");


            //Click On Set As Default Custom View
            InterviewsindexpageHelper.ClickElement("ClickOnSetAsDefault");
            InterviewsindexpageHelper.WaitForWorkAround(10000);

            //Click On Unset Default Custom View
            InterviewsindexpageHelper.ClickElement("ClickOnUnsetDefault");
            InterviewsindexpageHelper.WaitForWorkAround(10000);

            //Clock On Edit Custom View
            InterviewsindexpageHelper.ClickElement("ClickOnEdit");

            //back to applications
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/interviews");

            //Clock On Edit Custom View cancel button
            //ApplicationsIndexPageActionsHelper.ClickElement("ClickOnEditCancel");


            //Select Custom View
            InterviewsindexpageHelper.Select("SelectCustomViews", "105");

            //Clock On New Custom View
            InterviewsindexpageHelper.ClickElement("ClickOnNew");

            //Clock On New Custom View cancel button
            //ApplicationsIndexPageActionsHelper.ClickElement("ClickOnNewCancel");

            //back to applications
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/interviews");

            //Select Custom View
            InterviewsindexpageHelper.Select("SelectCustomView", "105");

            //Clock On Delete Custom View
            InterviewsindexpageHelper.ClickElement("ClickOnDelete");


            InterviewsindexpageHelper.AcceptAlert();
            InterviewsindexpageHelper.WaitForWorkAround(10000);

            

            

            //Enter Filter Search
            InterviewsindexpageHelper.TypeText("EnterFilterSearch", "New");
            InterviewsindexpageHelper.WaitForWorkAround(10000);

            //Clock On Filter Reset
            InterviewsindexpageHelper.ClickElement("ClockOnFilterReset");

            //Clock On Master Check Box
            InterviewsindexpageHelper.ClickElement("ClockOnMasterCheckBox");

            //Bulkupdate
            //ApplicationsIndexPageActionsHelper.MouseHover("locator");

            //bulkupdate status
            //ApplicationsIndexPageActionsHelper.ClickElement("Bulkupdateapplications");

           //Clock On Lead Name Link
            InterviewsindexpageHelper.ClickElement("FirstInterviewNameLink");

            //Click on Back to Leads
            //ApplicationsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/interviews");

            //Clock On Quick Look Mouse Over
            InterviewsindexpageHelper.MouseOver("locator");

            //Clock On Quick Look
            InterviewsindexpageHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look View
            InterviewsindexpageHelper.ClickElement("ClockOnQuickLookView");
            InterviewsindexpageHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            //ApplicationsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/interviews");

            //Clock On Quick Look Mouse Over
            InterviewsindexpageHelper.MouseOver("locator");

            //Clock On Quick Look
            InterviewsindexpageHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Edit
            InterviewsindexpageHelper.ClickElement("ClockOnQuickLookEdit");
            InterviewsindexpageHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            //ApplicationsIndexPageActionsHelper.ClickElement("ClickOnBackToLeads");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/interviews");

            //Clock On Quick Look Mouse Over
            InterviewsindexpageHelper.MouseOver("locator");

            //Clock On Quick Look
            InterviewsindexpageHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Delete
            InterviewsindexpageHelper.ClickElement("ClickOnQuickLookSetupinterview");

            InterviewsindexpageHelper.AcceptAlert();
            InterviewsindexpageHelper.WaitForWorkAround(10000);
  }
    }
}