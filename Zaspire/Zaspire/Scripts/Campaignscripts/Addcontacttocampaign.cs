using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddContacttocampaign : DriverTestCase
    {
        [TestMethod]
        public void Addcontacttocampaign()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var addcampaignHelper = new CampaignHelper(GetWebDriver());

            //Variable

            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var Campaigname = "Jobfair" + RandomNumber(1, 10);
            var Startdate = "2015-10-" + RandomNumber(1, 30);
            var Enddate = "2015-10-" + RandomNumber(1, 30);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            addcampaignHelper.ClickElement("ClickCampaignsTab");



           
            //Add Contact to campaign

            //Clcick on Record view 
            addcampaignHelper.ClickElement("Clickonrecord");

            //Click on moreAction
            addcampaignHelper.MouseOver2("locator");

            //selectAdd Contact
            addcampaignHelper.ClickElement("AddContact");

            //Select Result per page
            addcampaignHelper.Select("ContactResultperpage", "20");

            //Click on master checkbox
            addcampaignHelper.ClickElement("ContactMasterCheckbox");

            //Click on Add Compaign
            addcampaignHelper.ClickElement("ContactAddtocampaigns");








        }
    }
}


