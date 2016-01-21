using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddtasktoVendor : DriverTestCase
    {
        [TestMethod]
        public void Vendortask()
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
            VendorHelper.ClickElement("VendorView");

            //Click on more action
            VendorHelper.MouseOver("VedorMoreactions");

            //Select Add task
            VendorHelper.ClickElement("Add task");

            //Select type
            VendorHelper.Select("EventType", "Task");

            //Enter Location
            VendorHelper.TypeText("Location", "Secunderabad");

            //Enter  Subject
            VendorHelper.TypeText("Subject", "Add appointment");

            //Select start date
            VendorHelper.Select("StartDate", Startdate);

            //Click On record
            VendorHelper.ClickElement("starttime");


            //Select Moreaction
            VendorHelper.Select("EndDate", Enddate);

            //Select Add task
            VendorHelper.ClickElement("Endtime");

            //Enter Status
            VendorHelper.ClickElement("Reminders");
            
            //Select Category
            VendorHelper.Select("Popup", "1800");

            //Select a file
            VendorHelper.ClickElement("Email");

            //Select a file
            VendorHelper.Select("ReminderTime", "1800");

            //Click on Recurring  button
            VendorHelper.ClickElement("Recurring");

            // Select a file
            VendorHelper.Select("RepeteonceinEvery", "1");

            // Select Type
            VendorHelper.Select("RepeatType", "Monthly");

            //Click on Check box sunday
            //addpartnerHelper.ClickElement("WeekUI");

            //Select a file
            VendorHelper.ClickElement("OnRadiobutton");

            //Click on Recurring  button
            VendorHelper.ClickElement("Reportsofmonth");

            // Select a file
            VendorHelper.TypeText("Dateofthemonth", "2");

            //Enter description
            VendorHelper.ClickElement("OnRadiobutton");


            // Select a file
            VendorHelper.Select("Daytype", "First");

            //Enter description
            VendorHelper.Select("MonthDay", "2");


            //Select on Save button
            VendorHelper.Select("Until", "30/10/2015");

            //Select Moreaction
            VendorHelper.ClickElement("Save");


        }
    }
}
