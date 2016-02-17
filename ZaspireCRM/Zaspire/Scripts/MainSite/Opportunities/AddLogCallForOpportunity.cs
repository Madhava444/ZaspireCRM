using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddLogCallForOpportunity : DriverTestCase
    {
        [TestMethod]
        public void addlogcallforopportunity()
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

            var CallSubject = "Test Call" + RandomNumber(1, 99);


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


            
//#################### ADD LOG CALL   #####################################



            //Click On Log Call
            AddEventsForOpportunityHelper.ClickElement("ClickOnAddCall");

            //Enter Call Subject
            AddEventsForOpportunityHelper.TypeText("EnterCallSubject", CallSubject);

            //Select Call Type
            AddEventsForOpportunityHelper.Select("SelectCallType", "Inbounds");

            //Enter Call Date
            AddEventsForOpportunityHelper.TypeText("EnterCallDate", "2016-02-15");

            //Select Call From
            //AddEventsForOpportunityHelper.Select("SelectCallFrom", "");

            //Select Call To
            //AddEventsForOpportunityHelper.Select("SelectCallTo", "");

            //Enter Call From Number
            AddEventsForOpportunityHelper.TypeText("EnterCallFromNumber", "8713120369");

            //Enter Call To Number
            AddEventsForOpportunityHelper.TypeText("EnterCallToNumber", "9856512369");

            //Enter Call Hours
            AddEventsForOpportunityHelper.TypeText("EnterCallHours", "00");

            //Enter Call Minutes
            AddEventsForOpportunityHelper.TypeText("EnterCallMins", "25");

            //Enter Call Secs
            AddEventsForOpportunityHelper.TypeText("EnterCallSecs", "45");

            //Click on Description Link
            AddEventsForOpportunityHelper.ClickElement("ClickOnDescriptionLink");

            //Enter Call Description
            AddEventsForOpportunityHelper.TypeText("EnterCallDescription", "This is Log Call Description");
            

            
            //Click On Save
            AddEventsForOpportunityHelper.ClickElement("ClickOnSaveLogCall");
            AddEventsForOpportunityHelper.WaitForWorkAround(7000);



        }
    }
}