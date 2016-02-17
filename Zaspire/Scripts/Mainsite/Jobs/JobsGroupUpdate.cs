using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsGroupUpdate : DriverTestCase
    {
        [TestMethod]
        public void JobsgroupUpdate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var JobsGroupUpdateHelper = new JobsGroupUpdateHelper(GetWebDriver());


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
            JobsGroupUpdateHelper.ClickElement("ClickonjobsU");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/jobs");
            //JobsGroupUpdateHelper.WaitForWorkAround(7000);


            //Click On Groups
            //JobsGroupUpdateHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups");
            JobsGroupUpdateHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            JobsGroupUpdateHelper.MouseOver("locator");


            //Click On Quick Link
            JobsGroupUpdateHelper.ClickElement("ClickonTooptip");


            //Click On Edit
            JobsGroupUpdateHelper.ClickElement("Tooltipedit");
            JobsGroupUpdateHelper.WaitForWorkAround(3000);

            //################### GROUP UPDATE #########################


            //Enter Group Name
            JobsGroupUpdateHelper.TypeText("EnterGroupNameU", TestGroup);

            //Enter City
            JobsGroupUpdateHelper.TypeText("EnterCityu", TestCity);

            //Select State
            JobsGroupUpdateHelper.Select("SelectStateu", "AL");

            //Select Country
            JobsGroupUpdateHelper.Select("SelectCountryu", "USA");

            //Enter Zip Code
            JobsGroupUpdateHelper.TypeText("EnterZipCodeu", "72563");




            //Click On Groups
            JobsGroupUpdateHelper.ClickElement("ClickOnSaveu");
            JobsGroupUpdateHelper.WaitForWorkAround(10000);




        }
    }
}

