using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class BulkDeleteJobsGroups : DriverTestCase
    {
        [TestMethod]
        public void bulkdeleteJobsgroups()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var jobsGroupAddNewPageHelper = new JobsGroupAddNewPageHelper(GetWebDriver());
            var jobsIndexPageHelper = new JobsGroupIndexPageHelper(GetWebDriver());


            //Variable

            var TestGroup = "Test Group" + RandomNumber(1, 99);
            var TestCity = "Test City" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            jobsGroupAddNewPageHelper.ClickElement("ClickOnCandidates");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //jobsGroupAddNewPageHelper.WaitForWorkAround(7000);


            //Click On Groups
            //jobsGroupAddNewPageHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates/groups");
            jobsGroupAddNewPageHelper.WaitForWorkAround(7000);

            //################### ADD NEW GROUP #########################


            //Click on Groups Add New
            jobsGroupAddNewPageHelper.ClickElement("ClickOnGroupsAddNew");

            //Enter Group Name
            jobsGroupAddNewPageHelper.TypeText("EnterGroupName", TestGroup);

            //Enter City
            jobsGroupAddNewPageHelper.TypeText("EnterCity", TestCity);

            //Select State
            jobsGroupAddNewPageHelper.Select("SelectState", "CT");

            //Select Country
            jobsGroupAddNewPageHelper.Select("SelectCountry", "USA");

            //Enter Zip Code
            jobsGroupAddNewPageHelper.TypeText("EnterZipCode", "85623");



            //Click On Groups
            jobsGroupAddNewPageHelper.ClickElement("ClickOnSave");
            jobsGroupAddNewPageHelper.WaitForWorkAround(10000);



            //################### BULK DELETE GROUPS #########################


            //Search Company Name
            jobsGroupAddNewPageHelper.TypeText("Groupfilter", TestGroup);
            jobsGroupAddNewPageHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            jobsGroupAddNewPageHelper.ClickElement("CheckMasterCheckBox");

            //Click On Mouse Over
            jobsGroupAddNewPageHelper.MouseOver("locator");

            //Click On Delete Lead Groups
            jobsGroupAddNewPageHelper.ClickElement("ClickOnDeleteCandidateGroups");
            jobsGroupAddNewPageHelper.WaitForWorkAround(4000);

            jobsGroupAddNewPageHelper.AcceptAlert();
            jobsGroupAddNewPageHelper.WaitForWorkAround(10000);






        }
    }
}
