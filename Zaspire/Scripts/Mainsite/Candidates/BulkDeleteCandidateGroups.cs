using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class BulkDeleteCandidatesGroups : DriverTestCase
    {
        [TestMethod]
        public void bulkdeleteCandidatesgroups()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateGroupAddNewPageHelper = new CandidateGroupAddNewPageHelper(GetWebDriver());
            var candidateGroupIndexPageHelper = new CandidateGroupIndexPageHelper(GetWebDriver());


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
            candidateGroupAddNewPageHelper.ClickElement("ClickOnCandidates");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //candidateGroupAddNewPageHelper.WaitForWorkAround(7000);


            //Click On Groups
            //candidateGroupAddNewPageHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates/groups");
            candidateGroupAddNewPageHelper.WaitForWorkAround(7000);

//################### ADD NEW GROUP #########################


            //Click on Groups Add New
            candidateGroupAddNewPageHelper.ClickElement("ClickOnGroupsAddNew");

            //Enter Group Name
            candidateGroupAddNewPageHelper.TypeText("EnterGroupName", TestGroup);

            //Enter City
            candidateGroupAddNewPageHelper.TypeText("EnterCity", TestCity);

            //Select State
            candidateGroupAddNewPageHelper.Select("SelectState", "CT");

            //Select Country
            candidateGroupAddNewPageHelper.Select("SelectCountry", "USA");

            //Enter Zip Code
            candidateGroupAddNewPageHelper.TypeText("EnterZipCode", "85623");


            
            //Click On Groups
            candidateGroupAddNewPageHelper.ClickElement("ClickOnSave");
            candidateGroupAddNewPageHelper.WaitForWorkAround(10000);



//################### BULK DELETE GROUPS #########################


            //Search Company Name
            candidateGroupAddNewPageHelper.TypeText("Groupfilter", TestGroup);
            candidateGroupAddNewPageHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            candidateGroupAddNewPageHelper.ClickElement("CheckMasterCheckBox");

            //Click On Mouse Over
            candidateGroupAddNewPageHelper.MouseOver("locator");

            //Click On Delete Lead Groups
            candidateGroupAddNewPageHelper.ClickElement("ClickOnDeleteCandidateGroups");
            candidateGroupAddNewPageHelper.WaitForWorkAround(4000);

            candidateGroupAddNewPageHelper.AcceptAlert();
            candidateGroupAddNewPageHelper.WaitForWorkAround(10000);






        }
    }
}
