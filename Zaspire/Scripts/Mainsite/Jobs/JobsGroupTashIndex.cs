using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsGroupTashIndex : DriverTestCase
    {
        [TestMethod]
        public void jobsgrouptrashindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var jobsGroupTrashIndexHelper = new JobsGroupTrashIndexHelper(GetWebDriver());
            var JobsGroupIndexPageHelper = new JobsGroupIndexPageHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            JobsGroupIndexPageHelper.ClickElement("Clickonjobs4");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups");
            JobsGroupIndexPageHelper.WaitForWorkAround(7000);

            //Enter Search Filter Box 
           // JobsGroupIndexPageHelper.TypeText("EnterSearchFilterBox", "Test");
            //JobsGroupIndexPageHelper.WaitForWorkAround(3000);

            //Click On Filter Reset Button
           // JobsGroupIndexPageHelper.ClickElement("ClickOnFilterResetButton");
           // JobsGroupIndexPageHelper.WaitForWorkAround(3000);

            //Check Master Check Box
            JobsGroupIndexPageHelper.ClickElement("CheckMasterCheckBox");


            //Click On Mouse Over
            JobsGroupIndexPageHelper.MouseHover("locator");

            //Click On Delete Lead Groups
            JobsGroupIndexPageHelper.ClickElement("ClickOnDeleteJobsGroups");

             //Click on Alert
            JobsGroupIndexPageHelper.AcceptAlert();
            JobsGroupIndexPageHelper.WaitForWorkAround(3000);

            //Click on Trash
            jobsGroupTrashIndexHelper.ClickElement("ClickOnTrashG");
            jobsGroupTrashIndexHelper.WaitForWorkAround(2000);

            //Click on Trash
            jobsGroupTrashIndexHelper.ClickElement("ClickOnGroupTrashG");
            jobsGroupTrashIndexHelper.WaitForWorkAround(2000);

            //Enter Filter Search
           // jobsGroupTrashIndexHelper.TypeText("EnterFilterSearch", "Test");
           // jobsGroupTrashIndexHelper.WaitForWorkAround(7000);

            //Click On Reset Button
            //jobsGroupTrashIndexHelper.ClickElement("ClickOnReset");

            //Click On Master Check Box
            jobsGroupTrashIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On MouseHover
            jobsGroupTrashIndexHelper.MouseHover("locator");

            //Click On Delete Forever
            jobsGroupTrashIndexHelper.ClickElement("ClickOnDeleteForever");

            jobsGroupTrashIndexHelper.AcceptAlert();
            jobsGroupTrashIndexHelper.WaitForWorkAround(2000);

            //Here we should have the records in group trash index page  for futher execution

            //Enter Filter Search
           // jobsGroupTrashIndexHelper.TypeText("EnterFilterSearch", "");
           // jobsGroupTrashIndexHelper.WaitForWorkAround(2000);
            
            //Click On Master Check Box
            jobsGroupTrashIndexHelper.ClickElement("ClickOnMasterCheckBox");



            //Click On MouseHover
            jobsGroupTrashIndexHelper.MouseHover("locator");

            //Click On Restore Leads
            jobsGroupTrashIndexHelper.ClickElement("ClickOnRestorejobgroup");

            jobsGroupTrashIndexHelper.DismissAlert();
            jobsGroupTrashIndexHelper.WaitForWorkAround(2000);

          

            //Click On Mouseover
            jobsGroupTrashIndexHelper.MouseOver("locator");

            //Click On Quick Link
            jobsGroupTrashIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On Delete
            jobsGroupTrashIndexHelper.ClickElement("ClickOnDelete");

            jobsGroupTrashIndexHelper.AcceptAlert();
            jobsGroupTrashIndexHelper.WaitForWorkAround(2000);

            //Click On Mouseover
            jobsGroupTrashIndexHelper.MouseOver("locator");

            //Click On Quick Link
            jobsGroupTrashIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On Restore
            jobsGroupTrashIndexHelper.ClickElement("ClickOnRestore");

            jobsGroupTrashIndexHelper.AcceptAlert();
            jobsGroupTrashIndexHelper.WaitForWorkAround(2000);



        }
    }
}


