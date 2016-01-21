using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateGroupAddNewPage : DriverTestCase
    {
        [TestMethod]
        public void candidateGroupAddNewPage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CandidateGroupAddNewPageHelper = new CandidateGroupAddNewPageHelper(GetWebDriver());


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
            CandidateGroupAddNewPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //LeadGroupAddNewPageHelper.WaitForWorkAround(7000);


            //Click On Groups
            //LeadGroupAddNewPageHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups");
            CandidateGroupAddNewPageHelper.WaitForWorkAround(7000);

//################### ADD NEW GROUP #########################


            //Click on Groups Add New
            CandidateGroupAddNewPageHelper.ClickElement("ClickOnGroupsAddNew");

            //Enter Group Name
            CandidateGroupAddNewPageHelper.TypeText("EnterGroupName", TestGroup);

            //Enter City
            CandidateGroupAddNewPageHelper.TypeText("EnterCity", TestCity);

            //Select State
            CandidateGroupAddNewPageHelper.Select("SelectState", "CT");

            //Select Country
            CandidateGroupAddNewPageHelper.Select("SelectCountry", "USA");

            //Enter Zip Code
            CandidateGroupAddNewPageHelper.TypeText("EnterZipCode", "85623");




            //Click On Groups
            CandidateGroupAddNewPageHelper.ClickElement("ClickOnSave");
            CandidateGroupAddNewPageHelper.WaitForWorkAround(10000);




        }
    }
}
