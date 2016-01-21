using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class SetupmeetingtoVendors : DriverTestCase
    {
        [TestMethod]
        public void SetupVendormeeting()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var VendorHelper = new VendorHelper(GetWebDriver());

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
            VendorHelper.ClickElement("vendor");

            //############### Add Appmentoint ################################################

            //Click On record
            VendorHelper.ClickElement("Clickonrecord");

            //mouse over on moreactions
            VendorHelper.Mouseover("VendorMoreactions");

            //Select Add meeting
            VendorHelper.ClickElement("Setup Meeting");

            //select type
            VendorHelper.Select("EventType", "Meeting");

            //Enter location
            VendorHelper.TypeText("Location", "Secunderabad");

            //Enter subject
            VendorHelper.TypeText("Subject", "Add meeting to related");

            //Select start date
            VendorHelper.Select("StartDate", Startdate);

            //click on start time
            VendorHelper.ClickElement("starttime");


            //Select End date
            VendorHelper.Select("EndDate", Enddate);

            //Select End time
            VendorHelper.ClickElement("Endtime");

            //Click on reminder checkbox
            VendorHelper.ClickElement("Reminders");

            //Select Category
            VendorHelper.Select("Popup", "1800");

            //Select a file
            VendorHelper.ClickElement("Email");

            //Select a file
            VendorHelper.Select("ReminderTime", "1800");

            //Click on Recurring  button
            VendorHelper.ClickElement("Recurring");

            // Select a RepeteonceinEvery
            VendorHelper.Select("RepeteonceinEvery", "1");

            // Select RepeatType
            VendorHelper.Select("RepeatType", "Monthly");

            //Click on Check box sunday
            //VendorHelper.ClickElement("WeekUI");

            //Click on radio button
            VendorHelper.ClickElement("OnRadiobutton");

            //Click  on Reportsofmonth
            VendorHelper.ClickElement("Reportsofmonth");

            //Enter date of month
            VendorHelper.TypeText("Dateofthemonth", "2");

            //Click on radio button
            VendorHelper.ClickElement("OnRadiobutton");


            // Select day type
            VendorHelper.Select("Daytype", "First");

            //Select monnth day 
            VendorHelper.Select("MonthDay", "2");


            //Select until
            VendorHelper.Select("Until", "30/10/2015");

            //Click on save button
            VendorHelper.ClickElement("Save");


        }
    }
}
