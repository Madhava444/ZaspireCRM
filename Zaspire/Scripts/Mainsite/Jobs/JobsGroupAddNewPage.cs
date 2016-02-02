using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsGroupAddNewPage : DriverTestCase
    {
        [TestMethod]
        public void jobsGroupAddNewPage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var JobsGroupAddNewPageHelper = new JobsGroupAddNewPageHelper(GetWebDriver());


            //Variable

            var TestGroup = "JobTestGroup" + RandomNumber(1, 99);
            var TestCity = "Test City" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            JobsGroupAddNewPageHelper.ClickElement("Clickonjobs");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/jobs");
            //LeadGroupAddNewPageHelper.WaitForWorkAround(7000);


            //Click On Groups
            //LeadGroupAddNewPageHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups");
            JobsGroupAddNewPageHelper.WaitForWorkAround(3000);

            //################### ADD NEW GROUP #########################


            //Click on Groups Add New
            JobsGroupAddNewPageHelper.ClickElement("ClickOnGroupsAddNew");

            //Enter Group Name
            JobsGroupAddNewPageHelper.TypeText("EnterGroupName", TestGroup);

            //Enter City
            JobsGroupAddNewPageHelper.TypeText("EnterCity", "Boston");

            //Select State
            JobsGroupAddNewPageHelper.Select("SelectState", "CT");

            //Select Country
            JobsGroupAddNewPageHelper.Select("SelectCountry", "USA");

            //Enter Zip Code
            JobsGroupAddNewPageHelper.TypeText("EnterZipCode", "85611");




            //Click On Groups
            JobsGroupAddNewPageHelper.ClickElement("ClickOnSave");
            JobsGroupAddNewPageHelper.WaitForWorkAround(10000);

            //Verify title
            VerifyTitle("Job Groups");
            

           



        }
    }
}

