using System;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddNewAppointment : DriverTestCase
    {
        [TestMethod]
        public void addnewappointment()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var EventHelper = new EventHelper(GetWebDriver());

            //Variable

            var Subject = "Test Appointment" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Events

            //EventHelper.ClickElement("Selectevents");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/events");
            EventHelper.WaitForWorkAround(3000);


            //#################### CREATE A APPOINTMENT   #####################################

            //Create on Task
            //EventHelper.ClickElement("Clickonnew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/events/addnew");
            EventHelper.WaitForWorkAround(2000);


            //################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Related To
            EventHelper.Select("SelectRelatedTo", "11");

            //Click On Merge Button
            EventHelper.ClickElement("SelectMergeRecords");

            //Select Related To Record
            EventHelper.ClickElement("SelectRelatedname");


            //Select Event Category
            EventHelper.Select("EventCategory","12502");

            //Select Event Priority
            EventHelper.Select("EventPriority", "High");

            //Select Owner  
            EventHelper.Select("EventAssignedUser", "102");

            //Select Event Type
            EventHelper.Select("SelectEventType", "Appointment");

            //Select Event Status
            EventHelper.Select("SelectEventStatus", "In Progress");

            //Enter Event Subject
            EventHelper.TypeText("EnterSubject", Subject);

            //Enter Event Location
            EventHelper.TypeText("EnterEventLocation", "Test City");

            //Enter Event Start Date
            EventHelper.TypeText("SelectEventStartDate", "2016-01-21");

            //Click On Start Time
            EventHelper.ClickElement("Selectstarttime");

            //Enter Event Due Date
            EventHelper.TypeText("SelectEventEndDate", "2016-01-21");

            //Click On End Time
            EventHelper.ClickElement("Selectendtime");
            
            //Click On Starting Time
            //EventHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //EventHelper.ClickElement("ClickOnMinutes");


            //Click On Starting Time
            //EventHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //EventHelper.ClickElement("ClickOnMinutes");

            //Click On Check Reminder Check Box
            EventHelper.ClickElement("CheckReminder");

            //Select Reminder Time
            EventHelper.ClickElement("SelectreminderTime");

            //Click On Check Email Check Box
            EventHelper.ClickElement("Emailpopup");

            //Select Email Reminder Time
            EventHelper.ClickElement("SelectemailReminderTime");


            //Click on Recurring checkbox
            EventHelper.ClickElement("Recurring");

            //Select  repeatedonce
            EventHelper.Select("RepeatonceinEveryInterval", "3");

            //Select Repeated type
            EventHelper.Select("RepeteonceineveryType", "Weekly");

            //enter on Utility
            EventHelper.TypeText("RepeteUtility", "2016-01-21");

            //click onchecbox of weekdays
            EventHelper.ClickElement("CheckboxMonday");

            //Enter description
            //EventHelper.TypeText("", "new opointment created with opportunity");
            
            //Click On Save
            EventHelper.ClickElement("Clickonsave");
            













        }
    }
}