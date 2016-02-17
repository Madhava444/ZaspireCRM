using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddAppointmentForOpportunity : DriverTestCase
    {
        [TestMethod]
        public void addappointmentforopportunity()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddEventsForOpportunityHelper = new AddEventsForOpportunityHelper(GetWebDriver());

            //Variable

            var AppointmentSubject = "Test Appointment" + RandomNumber(1, 99);
            var AppointmentLocation = "Test City" + RandomNumber(1, 99);
           

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            AddEventsForOpportunityHelper.ClickElement("ClickOnOpportunities");
            AddEventsForOpportunityHelper.WaitForWorkAround(7000);


            //Open Opportunity
            AddEventsForOpportunityHelper.ClickElement("FirstOpportunityNameLink");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);

            //Click on Move over
            AddEventsForOpportunityHelper.MouseOver("locator");
            AddEventsForOpportunityHelper.WaitForWorkAround(5000);


//################### ADD APPOINTMENT  #########################


            //Click on Add Appointment
            AddEventsForOpportunityHelper.ClickElement("ClickOnAddAppointment");

            //Select Event Type
            //AddEventsForOpportunityHelper.Select("SelectEventType", "Appointment");

            //Enter Event Location
            AddEventsForOpportunityHelper.TypeText("EnterEventLocation", AppointmentLocation);

            //Enter Event Subject
            AddEventsForOpportunityHelper.TypeText("EnterEventSubject", AppointmentSubject);
            

            //Enter Event Start Date
            AddEventsForOpportunityHelper.TypeText("SelectEventStartDate", "2016-02-09");

            //Click On Start Time
            //AddEventsForOpportunityHelper.ClickElement("SelectStartTime");

            //Click On Starting Time
            //AddEventsForOpportunityHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //AddEventsForOpportunityHelper.ClickElement("ClickOnMinutes");

            //Enter Event Due Date
            AddEventsForOpportunityHelper.TypeText("SelectEventDueDate", "2016-02-09");

            //Click On End Time
            //AddEventsForOpportunityHelper.ClickElement("SelectEndTime");

            //Click On Starting Time
            //AddEventsForOpportunityHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //AddEventsForOpportunityHelper.ClickElement("ClickOnMinutes");

            //Click On Check Reminder Check Box
            //AddEventsForOpportunityHelper.ClickElement("CheckReminder");

            //Select Reminder Time
            //AddEventsForOpportunityHelper.ClickElement("SelectReminderTime");

            //Click On Check Email Check Box
            //AddEventsForOpportunityHelper.ClickElement("CheckEmail");

            //Select Email Reminder Time
            //AddEventsForOpportunityHelper.ClickElement("CheckRecurringEvent");

            
            //Click On Save
            AddEventsForOpportunityHelper.ClickElement("ClickOnSave");
            AddEventsForOpportunityHelper.WaitForWorkAround(7000);


        }
    }
}