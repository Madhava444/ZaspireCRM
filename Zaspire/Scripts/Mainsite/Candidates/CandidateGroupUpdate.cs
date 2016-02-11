using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateGroupUpdate : DriverTestCase
    {
        [TestMethod]
        public void CandidatesGroupUpdate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CandidateGroupUpdateHelper = new CandidateGroupUpdateHelper(GetWebDriver());


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
            CandidateGroupUpdateHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //CandidateGroupUpdateHelper.WaitForWorkAround(7000);


            //Click On Groups
            //CandidateGroupUpdateHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups");
            CandidateGroupUpdateHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            CandidateGroupUpdateHelper.MouseOver("locator");

            //Click On Quick Link
            CandidateGroupUpdateHelper.ClickElement("ClickOnQuickLink");


            //Click On Edit
            CandidateGroupUpdateHelper.ClickElement("ClickOnEdit");

//################### GROUP UPDATE #########################


            //Enter Group Name
            CandidateGroupUpdateHelper.TypeText("EnterGroupName", TestGroup);

            //Enter City
            CandidateGroupUpdateHelper.TypeText("EnterCity", TestCity);

            //Select State
            CandidateGroupUpdateHelper.Select("SelectState", "CA");

            //Select Country
            CandidateGroupUpdateHelper.Select("SelectCountry", "USA");

            //Enter Zip Code
            CandidateGroupUpdateHelper.TypeText("EnterZipCode", "74123");




            //Click On Groups
            CandidateGroupUpdateHelper.ClickElement("ClickOnSave");
            CandidateGroupUpdateHelper.WaitForWorkAround(10000);




        }
    }
}
