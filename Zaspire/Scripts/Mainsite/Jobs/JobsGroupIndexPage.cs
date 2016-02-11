using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsGroupIndexPage : DriverTestCase
    {
        [TestMethod]
        public void jobsgroupindexpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var JobsGroupIndexPageHelper = new JobsGroupIndexPageHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            JobsGroupIndexPageHelper.ClickElement("Clickonjobs4");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates");
            //JobsGroupIndexPageHelper.WaitForWorkAround(7000);


            //Click On Groups
            //JobsGroupIndexPageHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups");
            JobsGroupIndexPageHelper.WaitForWorkAround(7000);

            //################### GROUPS INDEX PAGE ACTIONS #########################


            //Click on Groups Add New
            //JobsGroupIndexPageHelper.ClickElement("ClickOnGroupsAddNew");

            //Click on Back To Lead Groups Index page
            //JobsGroupIndexPageHelper.ClickElement("ClickOnGroupsAddNew");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups");
            //JobsGroupIndexPageHelper.WaitForWorkAround(7000);

            //Enter Search Filter Box 
            JobsGroupIndexPageHelper.TypeText("EnterSearchFilterBox", "JobTestGroup");
            JobsGroupIndexPageHelper.WaitForWorkAround(3000);

            //Click On Filter Reset Button
            JobsGroupIndexPageHelper.ClickElement("ClickOnFilterResetButton");
            JobsGroupIndexPageHelper.WaitForWorkAround(3000);

            //Check Master Check Box
            JobsGroupIndexPageHelper.ClickElement("CheckMasterCheckBox");


            //Click On Mouse Over
            JobsGroupIndexPageHelper.MouseHover("locator");

            //Click On Delete Lead Groups
            JobsGroupIndexPageHelper.ClickElement("ClickOnDeleteJobsGroups");

            //Dismiss Alert
            JobsGroupIndexPageHelper.DismissAlert();


            //Click on Alert
            //JobsGroupIndexPageHelper.AcceptAlert();



            //Click On Mouse Over
            JobsGroupIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            JobsGroupIndexPageHelper.ClickElement("ClickOnQuickLink");

            //Click On View
            JobsGroupIndexPageHelper.ClickElement("ClickOnView");

            //Click on Back To Lead Groups Index page
            //LeadsGroupIndexPageHelper.ClickElement("ClickOnBackToLeadGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups");
            JobsGroupIndexPageHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            JobsGroupIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            JobsGroupIndexPageHelper.ClickElement("ClickOnQuickLink");


            //Click On Edit
            JobsGroupIndexPageHelper.ClickElement("ClickOnEdit");

            //Click on Back To Lead Groups Index page
            //LeadsGroupIndexPageHelper.ClickElement("ClickOnBackToLeadGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups");
            JobsGroupIndexPageHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            JobsGroupIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            JobsGroupIndexPageHelper.ClickElement("ClickOnQuickLink");


            //Click On Delete
            JobsGroupIndexPageHelper.ClickElement("ClickOnDelete");

            //Dismiss alert
            JobsGroupIndexPageHelper.DismissAlert();

            //Accept Alert
            //JobsGroupIndexPageHelper.AcceptAlert();


            //Click On First Group Name
            JobsGroupIndexPageHelper.ClickElement("ClickOnFirstGroupName");

            //Click on Back To Lead Groups Index page
            //JobsGroupIndexPageHelper.ClickElement("ClickOnBackToJobsGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups");
            JobsGroupIndexPageHelper.WaitForWorkAround(3000);


            




        }
    }
}
