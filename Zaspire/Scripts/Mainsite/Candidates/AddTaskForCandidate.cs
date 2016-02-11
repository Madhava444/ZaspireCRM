using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddTaskForCandidates : DriverTestCase
    {
        [TestMethod]
        public void addtaskforcandidates()
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

            var TaskSubject = "Test Task" + RandomNumber(1, 99);
            var TaskLocation = "Test City" + RandomNumber(1, 99);
            

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
            //AddEventsForLeadHelper.ClickElement("MoveHover");

            AddEventsForcandidateHelper.ClickElement("ClickOn");


//################### ADD TASK  #########################


            //Click on Add Task
            AddEventsForcandidateHelper.ClickElement("ClickOnAddTask");

            //Select Event Type
            AddEventsForcandidateHelper.Select("SelectEventType", "Task");

            //Enter Event Location
            AddEventsForcandidateHelper.TypeText("EnterEventLocation", TaskLocation);

            //Enter Event Subject
            AddEventsForcandidateHelper.TypeText("EnterEventSubject", TaskSubject);
            

            //Enter Event Start Date
            AddEventsForcandidateHelper.TypeText("SelectEventStartDate", "2015-12-07");

            //Click On Start Time
            //AddEventsForcandidateHelper.ClickElement("SelectStartTime");

            //Click On Starting Time
            //AddEventsForcandidateHelper.ClickElement("ClickOnHours");

            //Click On Starting Time
            //AddEventsForcandidateHelper.ClickElement("ClickOnMinutes");

            //Enter Event Due Date
            AddEventsForcandidateHelper.TypeText("SelectEventDueDate", "2015-12-08");

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