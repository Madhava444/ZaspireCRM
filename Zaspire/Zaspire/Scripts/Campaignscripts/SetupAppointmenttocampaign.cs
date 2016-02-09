using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class Setupappointmenttocampaign : DriverTestCase
    {
        [TestMethod]
        public void Addappointmentcampaign()
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
            var Startdate = "2016-02-" + RandomNumber(1, 30);
            var Enddate = "2016-02-" + RandomNumber(1, 30);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            addcampaignHelper.ClickElement("ClickCampaignsTab");

            //############### Add Appmentoint ################################################

            //Click On record
            addcampaignHelper.ClickElement("Clickonrecord");

            //Select Moreaction
            addcampaignHelper.MouseOver2("locator");

            //Select Add appoinment
            addcampaignHelper.ClickElement("Addappointment");

            //Enter event type
            //addcampaignHelper.Select("EventType", "Appointment");

            //Enter locations
            addcampaignHelper.TypeText("Location", "Hyderabad");

            //Enter subject
            addcampaignHelper.TypeText("Subject", "  appointment");

            // Select start date
            //addcampaignHelper.Select("StartDate", "2016-02-05");

            //Select state time
            //addcampaignHelper.ClickElement("starttime");


            //Selectend date
           //addcampaignHelper.Select("EndDate", "2016-02-06");

            //Select End time
            //addcampaignHelper.ClickElement("Endtime");

            //Click on check box
            addcampaignHelper.ClickElement("Reminders");

            //Select popup time
            addcampaignHelper.Select("Popup", "1800");

            //Click on Email check box
            addcampaignHelper.ClickElement("Email");

            //Select reminder time
            addcampaignHelper.Select("ReminderTime", "1800");

            //Click on Recurring  button
            addcampaignHelper.ClickElement("Recurring");

            // Select repeate once in every
            addcampaignHelper.Select("RepeateonceinEvery", "2");

            // Select repeate Type
            addcampaignHelper.Select("RepeatType", "Monthly");

            //Click on Check box sunday
            //addcampaignHelper.ClickElement("WeekUI");

            //Enter r select until
            //addcampaignHelper.Select("Until", "05/02/2015");


            //Click on radio button
            addcampaignHelper.ClickElement("OnRadiobutton");

            //Enter report month
            addcampaignHelper.ClickElement("Reportsofmonth");

            //Enter date 
            addcampaignHelper.TypeText("Dateofthemonth","2");
            
            //Click on radio button
            addcampaignHelper.ClickElement("OnRadiobutton1");


            // Select a daytype
            addcampaignHelper.Select("Daytype", "first");
             
            //Select month day
            addcampaignHelper.Select("MonthDay", "2");


           
            //Click  on Save button
            addcampaignHelper.ClickElement("EventSave");


        }
    }
}
