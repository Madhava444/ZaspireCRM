using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddAppointmentForCandidate : DriverTestCase
    {
        [TestMethod]
        public void addappointmentforcandidate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddEventsForcandidateHelper = new AddEventsForCandidateHelper(GetWebDriver());

            //Variable

            var AppointmentSubject = "Test Appointment" + RandomNumber(1, 99);
            var AppointmentLocation = "Test City" + RandomNumber(1, 99);
           

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForcandidateHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //AddEventsForLeadHelper.WaitForWorkAround(7000);


            //Open Lead
            AddEventsForcandidateHelper.ClickElement("FirstLeadNameLink");

            //Click on Move over
            AddEventsForcandidateHelper.ClickElement("MoveHover");
            AddEventsForcandidateHelper.WaitForWorkAround(10000);


//################### CLASSIFICATIONS & OWNERSHIP  #########################


            //Click on Add Appointment
            AddEventsForcandidateHelper.ClickElement("ClickOnAddAppointment");

            //Select Event Type
            AddEventsForcandidateHelper.Select("SelectEventType", "Appointment");

            //Enter Event Location
            AddEventsForcandidateHelper.TypeText("EnterEventLocation", AppointmentLocation);

            //Enter Event Subject
            AddEventsForcandidateHelper.TypeText("EnterEventSubject", AppointmentSubject);
            

            //Enter Event Start Date
            AddEventsForcandidateHelper.TypeText("SelectEventStartDate", "2015-12-09");

            //Click On Start Time
            //AddEventsForcandidateHelper.ClickElement("SelectStartTime");

            //Click On Starting Time
            //AddEventsForcandidateHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //AddEventsForcandidateHelper.ClickElement("ClickOnMinutes");

            //Enter Event Due Date
            AddEventsForcandidateHelper.TypeText("SelectEventDueDate", "2015-12-09");

            //Click On End Time
            //AddEventsForcandidateHelper.ClickElement("SelectEndTime");

            //Click On Starting Time
            //AddEventsForcandidateHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //AddEventsForcandidateHelper.ClickElement("ClickOnMinutes");

            //Click On Check Reminder Check Box
            //AddEventsForcandidateHelper.ClickElement("CheckReminder");

            //Select Reminder Time
            //AddEventsForcandidateHelper.ClickElement("SelectReminderTime");

            //Click On Check Email Check Box
            //AddEventsForcandidateHelper.ClickElement("CheckEmail");

            //Select Email Reminder Time
            //AddEventsForcandidateHelper.ClickElement("CheckRecurringEvent");






            //Click On Save
            AddEventsForcandidateHelper.ClickElement("ClickOnSave");
            AddEventsForcandidateHelper.WaitForWorkAround(7000);


        }
    }
}