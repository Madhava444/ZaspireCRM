using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesGroupUpdate : DriverTestCase
    {
        [TestMethod]
        public void opportunitiesgroupupdate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesGroupCreateHelper = new OpportunitiesGroupCreateHelper(GetWebDriver());


            //Variable

            var TestGroup = "Test Group" + RandomNumber(1, 99);
            var TestCity = "Test City" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            OpportunitiesGroupCreateHelper.ClickElement("ClickOnOpportunities");

            //Click On Groups
            OpportunitiesGroupCreateHelper.ClickElement("ClickOnGroups");
            OpportunitiesGroupCreateHelper.WaitForWorkAround(7000);

//################### ADD NEW GROUP #########################


            //Click on Groups Add New
            OpportunitiesGroupCreateHelper.ClickElement("ClickOnGroupsAddNew");

            //Enter Group Name
            OpportunitiesGroupCreateHelper.TypeText("EnterGroupName", TestGroup);

            //Enter City
            OpportunitiesGroupCreateHelper.TypeText("EnterCity", TestCity);

            //Select State
            OpportunitiesGroupCreateHelper.Select("SelectState", "CO");

            //Select Country
            OpportunitiesGroupCreateHelper.Select("SelectCountry", "USA");

            //Enter Zip Code
            OpportunitiesGroupCreateHelper.TypeText("EnterZipCode", "85143");


            //Click On Groups
            OpportunitiesGroupCreateHelper.ClickElement("ClickOnSave");
            OpportunitiesGroupCreateHelper.WaitForWorkAround(10000);


//################### GROUP INDEX   #########################


            //Click On Mouse Over
            OpportunitiesGroupCreateHelper.MouseOver("locator");
            OpportunitiesGroupCreateHelper.WaitForWorkAround(5000);

            //Click On Quick Link
            OpportunitiesGroupCreateHelper.ClickElement("ClickOnQuickLink");


            //Click On Edit
            OpportunitiesGroupCreateHelper.ClickElement("ClickOnEdit");



//################### UPDATE GROUP #########################


            //Enter Group Name
            OpportunitiesGroupCreateHelper.TypeText("EnterGroupName", TestGroup);

            //Enter City
            OpportunitiesGroupCreateHelper.TypeText("EnterCity", TestCity);

            //Select State
            OpportunitiesGroupCreateHelper.Select("SelectState", "CT");

            //Select Country
            OpportunitiesGroupCreateHelper.Select("SelectCountry", "USA");

            //Enter Zip Code
            OpportunitiesGroupCreateHelper.TypeText("EnterZipCode", "85843");


            //Click On Groups
            OpportunitiesGroupCreateHelper.ClickElement("ClickOnSave");
            OpportunitiesGroupCreateHelper.WaitForWorkAround(10000);




        }
    }
}
