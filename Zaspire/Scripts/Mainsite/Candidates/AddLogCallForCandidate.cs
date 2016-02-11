using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddLogCallForCandidate : DriverTestCase
    {
        [TestMethod]
        public void addlogcallforcandidate()
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

            var CallSubject = "Test Call" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForcandidateHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //AddEventsForLeadHelper.WaitForWorkAround(7000);


            //Open Lead
            AddEventsForcandidateHelper.ClickElement("FirstLeadNameLink");

            //Click on Move over
            AddEventsForcandidateHelper.ClickElement("MoveHover");
            AddEventsForcandidateHelper.WaitForWorkAround(10000);


            
//#################### ADD LOG CALL   #####################################



            //Click On Log Call
            AddEventsForcandidateHelper.ClickElement("ClickOnAddCall");

            //Enter Call Subject
            AddEventsForcandidateHelper.TypeText("EnterCallSubject", CallSubject);

            //Select Call Type
            AddEventsForcandidateHelper.Select("SelectCallType", "Inbound");

            //Enter Call Date
            AddEventsForcandidateHelper.TypeText("EnterCallDate", "");

            //Select Call From
            //AddEventsForLeadHelper.Select("SelectCallFrom", "");

            //Select Call To
            //AddEventsForLeadHelper.Select("SelectCallTo", "");

            //Enter Call From Number
            AddEventsForcandidateHelper.TypeText("EnterCallFromNumber", "8713120369");

            //Enter Call To Number
            AddEventsForcandidateHelper.TypeText("EnterCallToNumber", "9856512369");

            //Enter Call Hours
            AddEventsForcandidateHelper.TypeText("EnterCallHours", "00");

            //Enter Call Minutes
            AddEventsForcandidateHelper.TypeText("EnterCallMins", "25");

            //Enter Call Secs
            AddEventsForcandidateHelper.TypeText("EnterCallSecs", "45");

            //Click on Description Link
            AddEventsForcandidateHelper.ClickElement("ClickOnDescriptionLink");

            //Enter Call Description
            AddEventsForcandidateHelper.TypeText("EnterCallDescription", "This is Log Call Description");
            

            
            //Click On Save
            AddEventsForcandidateHelper.ClickElement("ClickOnSaveLogCall");
            AddEventsForcandidateHelper.WaitForWorkAround(7000);



        }
    }
}