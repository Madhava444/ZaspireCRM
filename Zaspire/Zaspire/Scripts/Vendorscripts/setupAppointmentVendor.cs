using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class SetupAppointmenttoVendors : DriverTestCase
    {
        [TestMethod]
        public void SetupappointmentVendor()
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

            //Click On record
            VendorHelper.ClickElement("Vendorview");

            //Select Moreaction
            VendorHelper.Mouseover("VedorMoreactions");

            //Select Add task
            VendorHelper.ClickElement("Setup Appointment");

            //select event type
            VendorHelper.Select("EventType", "Appointment");

            //Enter Location
            VendorHelper.TypeText("Location", "Secunderabad");

            //Enter subject
            VendorHelper.TypeText("Subject", "Add appointment");

            //Select start date
            VendorHelper.Select("StartDate", Startdate);

            //Click on start time
            VendorHelper.ClickElement("starttime");


            //Select end date
            VendorHelper.Select("EndDate", Enddate);

            //Select end time
            VendorHelper.ClickElement("Endtime");

            //Click on check box 
            VendorHelper.ClickElement("Reminders");

            //Click on check box 
            VendorHelper.Select("Popup", "1800");

            //Click on Email
            VendorHelper.ClickElement("Email");

            //Select reminder time
            VendorHelper.Select("ReminderTime", "1800");

            //Click on Recurring  button
            VendorHelper.ClickElement("Recurring");

            // Select a file
            VendorHelper.Select("RepeteonceinEvery", "1");

            // Select Type
            VendorHelper.Select("RepeatType", "Monthly");

            //Click on Check box sunday
            //VendorHelper.ClickElement("WeekUI");

            //Clcik on radio button
            VendorHelper.ClickElement("OnRadiobutton");

            //Click on Reports on month
            VendorHelper.ClickElement("Reportsofmonth");

            // Enter date of month
            VendorHelper.TypeText("Dateofthemonth", "2");

            //Click on radio button
            VendorHelper.ClickElement("OnRadiobutton");


            // Select Day type
            VendorHelper.Select("Daytype", "First");

            //Select monthday
            VendorHelper.Select("MonthDay", "2");


            //Select until
            VendorHelper.Select("Until", "30/12/2015");

            //Select invitees
            VendorHelper.Select("Inviteecontacts", "12");

            //Enter email id
            VendorHelper.TypeText("Email", "asd@gmail.com");

            // Enter  first name
            VendorHelper.TypeText("Firstname", FirstName);

            //Enter last name
            VendorHelper.TypeText("Lastname ", LastName);


            // Click on search 
            VendorHelper.ClickElement("Search");


            //Click on save 
            VendorHelper.ClickElement("Save");


        }
    }
}

