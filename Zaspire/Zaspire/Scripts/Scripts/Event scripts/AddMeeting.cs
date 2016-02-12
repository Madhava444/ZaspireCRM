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
    public class AddNewMeeting : DriverTestCase
    {
        [TestMethod]
        public void addnewmeeting()
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

            var Subject = "Test Meeting" + RandomNumber(1, 99);


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


            //#################### CREATE A MEETING   #####################################

            //Create on Task
            //EventHelper.ClickElement("ClickOnAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/events/addnew");



            //################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Related To
            EventHelper.Select("SelectRelatedTo", "20");

            //Click On Merge Button
            EventHelper.ClickElement("SelectMergeRecords");

            //Select Related To Record
            EventHelper.ClickElement("SelectRelatedname");


            //Select Event Category
            EventHelper.Select("EventCategory", "12502");

            //Select Event Priority
            EventHelper.Select("EventPriority", "Hot");

            //Select Owner  
            EventHelper.Select("EventAssignedUser", "102");

            //Select Event Type
            EventHelper.Select("SelectEventType", "Meeting");

            //Select Event Status
            EventHelper.Select("SelectEventStatus", "On Hold");

            //Enter Event Subject
            EventHelper.TypeText("EnterSubject", Subject);

            //Enter Event Location
            EventHelper.TypeText("EnterEventLocation", "Test for City");

            //Enter Event Start Date
            EventHelper.TypeText("SelectEventStartDate", "2016-01-25");

            //Click On Start Time
            EventHelper.ClickElement("Selectstarttime");

            //Enter Event Due Date
            EventHelper.TypeText("SelectEventEndDate", "2016-01-26");

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
            EventHelper.Select("RepeatonceinEveryInterval", "5");

            //Select Repeated type
            EventHelper.Select("RepeteonceineveryType", "Weekly");

            //enter on Utility
            EventHelper.TypeText("RepeteUtility", "2016-01-22");

            //click onchecbox of weekdays
            EventHelper.ClickElement("CheckboxWeday");

            //Enter description
            //EventHelper.TypeText("", "new opointment created with opportunity");

            //Select Contact 
            EventHelper.Select("EventinviteeContact", "Contacts");

            //Enter Firstname
            EventHelper.TypeText("InviteeFirstname", "");

            //Enter Lastname
            EventHelper.TypeText("InviteeLastname", "");

            //EnterEmails id
            EventHelper.TypeText("InviteeEmail", "");

            //Click on Search
            EventHelper.ClickElement("InviteeSearch");

            //Click on Add Record
            EventHelper.ClickElement("AddInvitee");
            
                //Click On Save
            EventHelper.ClickElement("Clickonsave");
           














        }
    }
}