using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class Setupmeetingtocampaign : DriverTestCase
    {
        [TestMethod]
        public void Addmeetingcampaign()
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

            var FirstName = "mortin" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var Campaigname = "Jobfair" + RandomNumber(1, 10);
            var Startdate = "2016-02-" + RandomNumber(1, 28);
            var Enddate = "2016-02-" + RandomNumber(1, 28);
            var Until = "2016-02-" + RandomNumber(1, 28);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            addcampaignHelper.ClickElement("ClickCampaignsTab");

            //############### AddTask ################################################

            //Click On record
            addcampaignHelper.ClickElement("Clickonrecord");

            //Select Moreaction
            addcampaignHelper.MouseOver2("locator");

            //Select Add meeting
            addcampaignHelper.ClickElement("Setupmeeting");

            //Enter type
            //addcampaignHelper.Select("EventType", "Meeting");

            //Enter Category
            addcampaignHelper.TypeText("Location", "Delhi");

            //Enter a file
            addcampaignHelper.TypeText("Subject", "Add meeting");

            //Enter Start date
            addcampaignHelper.TypeText("EventStartDate", Startdate);

            //Select start time
           // addcampaignHelper.ClickElement("starttime");


            //Select End date
            addcampaignHelper.TypeText("EventEndDate", Enddate);

            //Select Endtime
            //addcampaignHelper.ClickElement("Endtime");

            //select reminder
            addcampaignHelper.ClickElement("Reminders");

            //Select popup
            addcampaignHelper.Select("Popup", "3600");

            //Click on check box
            addcampaignHelper.ClickElement("Email");

            //Select reminder time
            addcampaignHelper.Select("ReminderTime", "1800");

            //Click on Recurring  button
            addcampaignHelper.ClickElement("Recurring");

            // Select REPEATE IN EVERY
            addcampaignHelper.Select("RepeateonceinEvery", "3");

            // Select repeat Type
            addcampaignHelper.Select("RepeatType", "Daily");

            //Click on Check box sunday
            //addcampaignHelper.ClickElement("WeekUI");

            


            //Select until date
            addcampaignHelper.TypeText("Until", Until);

            //Select invitee
            addcampaignHelper.Select("Inviteecontacts", "Contacts");

            //Enter email
            addcampaignHelper.TypeText("Email1", "asd@gmail.com");

            // Enter first name
            addcampaignHelper.TypeText("Firstname", FirstName);

            //Enter last name
            addcampaignHelper.TypeText("Lastname ", LastName);


            // click on search button
            addcampaignHelper.ClickElement("Search");

            //Click on add
            //addcampaignHelper.ClickElement("Addinvitee");

            //click on save
            addcampaignHelper.ClickElement("EventSave");


        }
    }
}

