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
            VendorHelper.ClickElement("Vendor");

            //############### Add Appmentoint ################################################

            //Click On record
            VendorHelper.ClickElement("Vendorview");

            //mouse over on moreactions
            VendorHelper.MouseOver2("locator");

            //Select Add meeting
            VendorHelper.ClickElement("VendorSetupmeeting");

            //select type
            //VendorHelper.Select("EventType", "Meeting");

            //Enter location
            VendorHelper.TypeText("Location", "Sec-bad");

            //Enter subject
            VendorHelper.TypeText("Subject", "Add meeting to related");

            //Select start date
            VendorHelper.TypeText("StartDate", Startdate);

            //click on start time
            //VendorHelper.ClickElement("starttime");


            //Select End date
            VendorHelper.TypeText("EndDate", Enddate);

            //Select End time
            //VendorHelper.ClickElement("Endtime");

            //Click on reminder checkbox
            VendorHelper.ClickElement("Reminders");

            //Select Category
            VendorHelper.Select("Popup", "1800");

            //Select a file
            VendorHelper.ClickElement("EventEmail");

            //Select a file
            VendorHelper.Select("ReminderTime", "1800");

            //Click on Recurring  button
            VendorHelper.ClickElement("Recurring");

            // Select a RepeteonceinEvery
            VendorHelper.Select("RepeateonceinEvery", "1");

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
            VendorHelper.Select("Daytype", "first");

            //Select monnth day 
            VendorHelper.Select("MonthDay", "1");


            //Select until
            VendorHelper.TypeText("Until", "2016-02-09");

            //Click on save button
            VendorHelper.ClickElement("EventSave");


        }
    }
}
