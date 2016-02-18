using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EditTask : DriverTestCase
    {
        [TestMethod]
        public void Editeventtask()
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

            var Subject = "Test Task" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Events
            EventHelper.ClickElement("Selectevents");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/events");
            //EventHelper.WaitForWorkAround(7000);


            //#################### EDIT A Task   #####################################

            //Create on Task
            EventHelper.ClickElement("EventView");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/events/update/244");

            //Click on Edit 
            //EventHelper.ClickElement("EventEdit");

          

            //Select Related To
            EventHelper.Select("SelectRelatedTo", "11");

            //Click On Merge Button
            EventHelper.ClickElement("SelectMergeRecords");

            //Select Related To Record
            EventHelper.ClickElement("SelectRelatedname");


            //Select Event Category
            EventHelper.Select("EventCategory", "12503");

            //Select Event Priority
            EventHelper.Select("EventPriority", "Hot");

            //Select Owner  
            EventHelper.Select("EventAssignedUser", "82");

            //Select Event Type
            EventHelper.Select("SelectEventType", "Task");

            //Select Event Status
            EventHelper.Select("SelectEventStatus", "In Progress");

            //Enter Event Subject
            EventHelper.TypeText("EnterSubject", Subject);

            //Enter Event Location
            EventHelper.TypeText("EnterEventLocation", "Test City");

            //Enter Event Start Date
            EventHelper.TypeText("SelectEventStartDate", "2016-01-22");

            //Click On Start Time
            EventHelper.ClickElement("Selectstarttime");

            //Enter Event Due Date
            EventHelper.TypeText("SelectEventEndDate", "2016-01-25");

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
            EventHelper.ClickElement("EditEmailPopup");

            //Select Email Reminder Time
            EventHelper.ClickElement("SelectemailReminderTime");


            //Click on Recurring checkbox
            EventHelper.ClickElement("Recurryupdate");

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
            EventHelper.ClickElement("EditEmailPopup");
            EventHelper.WaitForWorkAround(7000);

            //Click on Save
            EventHelper.ClickElement("EditSave");












        }
    }
}