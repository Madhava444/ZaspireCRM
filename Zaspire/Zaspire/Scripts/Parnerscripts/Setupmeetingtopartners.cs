using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class SetupmeetingtoParntners : DriverTestCase
    {
        [TestMethod]
        public void SetupMeetingtoPartner()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var addpartnerHelper = new PartnerHelper(GetWebDriver());

            //Variable

            var FirstName = "mark" + RandomNumber(1, 99);
            var LastName = "master" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var Partnername = "Partner" + RandomNumber(1, 20);
            var Companyname = "Company" + RandomNumber(1, 10);
            var Startdate = "2015-12-" + RandomNumber(1, 30);
            var Enddate = "2015-12-" + RandomNumber(1, 30);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            addpartnerHelper.ClickElement("partners");

            //Click On record
            addpartnerHelper.ClickElement("Clickonrecord");

            //Select Moreaction
            addpartnerHelper.MouseOver2("locator");

            //mouAdd task
            addpartnerHelper.ClickElement("Setupmeeting");

            //select meeting type
            //addpartnerHelper.Select("EventType", "Meetimg");

            //Enter location
            addpartnerHelper.TypeText("Location", "Begumpet");

            //Enter a subject
            addpartnerHelper.TypeText("Subject", "Add appointment");

            //Enter description
            addpartnerHelper.TypeText("StartDate", Startdate);

            //Click On record
            //addpartnerHelper.ClickElement("starttime");


            //Select Moreaction
            addpartnerHelper.TypeText("EndDate", Enddate);

            //Select Add task
            //addpartnerHelper.ClickElement("Endtime");

            //Enter Status
            addpartnerHelper.ClickElement("Reminders");

            //Select Category
            addpartnerHelper.Select("Popup", "1800");

            //Select a file
            addpartnerHelper.ClickElement("Emailcheckbox");

            //Select a file
            addpartnerHelper.Select("ReminderTime", "900");

            //Click on Recurring  button
            addpartnerHelper.ClickElement("Recurring");

            // Select a file
            addpartnerHelper.Select("RepeateonceinEvery", "1");

            // Select Type
            addpartnerHelper.Select("RepeatType", "Monthly");

            //Click on Check box sunday
            //addpartnerHelper.ClickElement("WeekUI");

            //Select a file
            addpartnerHelper.ClickElement("OnRadiobutton");

            //Click on Recurring  button
            addpartnerHelper.ClickElement("Reportsofmonth");

            // Select a file
            addpartnerHelper.TypeText("Dateofthemonth", "2");

            //Enter description
            addpartnerHelper.ClickElement("OnRadiobutton");


            // Select a file
            addpartnerHelper.Select("Daytype", "first");

            //Enter description
            addpartnerHelper.Select("MonthDay", "2");


            //Select on Save button
            addpartnerHelper.TypeText("Until", "2016-02-08");

            //Select a file
            addpartnerHelper.Select("Inviteecontacts", "5");

            //Click on Recurring  button
            addpartnerHelper.TypeText("InviteeEmail", "asd@gmail.com");

            // Select a file
            addpartnerHelper.TypeText("Firstname", "mark");

            //Enter description
            addpartnerHelper.TypeText("Lastname ", "master");


            // Select a file
            addpartnerHelper.ClickElement("Search");


            //Select Moreaction
            addpartnerHelper.ClickElement("EventSave");


        }
    }
}

