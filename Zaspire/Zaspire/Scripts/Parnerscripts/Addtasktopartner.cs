using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddtaskParntners : DriverTestCase
    {
        [TestMethod]
        public void AddtaskPartner()
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

            //############### AddTask ################################################

            //Click On record
            addpartnerHelper.ClickElement("Clickonrecord");

            //Select Moreaction
            addpartnerHelper.MouseOver2("locator");

            //Select Add task
            addpartnerHelper.ClickElement("Addtask");

            //Enter type default
           // addpartnerHelper.Select("EventType", "Task");

            //Enter location
            addpartnerHelper.TypeText("Location", "Secunderabad");

            //Enter a file
            addpartnerHelper.TypeText("Subject", "Add Task");

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
            addpartnerHelper.Select("Popup", "900");

            //Select a file
            addpartnerHelper.ClickElement("Emailcheckbox");

            //Select a file
            addpartnerHelper.Select("ReminderTime", "900");

            //Click on Recurring  button
            addpartnerHelper.ClickElement("Recurring");

            // Select a file
            addpartnerHelper.Select("RepeateonceinEvery", "1");

            // Select Type
            addpartnerHelper.Select("RepeatType", "Weekly");

            //Click on Check box sunday
            addpartnerHelper.ClickElement("WeekUI");

            /*Select a file
            //addpartnerHelper.ClickElement("OnRadiobutton");

            //Click on Recurring  button
            //addpartnerHelper.ClickElement("Reportsofmonth");

            // Select a file
            addpartnerHelper.ClickElement("Dateofthemonth");

            //Enter description
            addpartnerHelper.TypeText("OnRadiobutton", "This is a file to campaign");


            // Select a file
            addpartnerHelper.ClickElement("Daytype");

            //Enter description
            addpartnerHelper.TypeText("MonthDay", "This is a file to campaign");*/


            //Enter date 
            addpartnerHelper.TypeText("Until", "07-02-2016");

            //Select save button
            addpartnerHelper.ClickElement("EventSave");


        }
    }
}