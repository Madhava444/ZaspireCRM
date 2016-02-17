using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddNoteForOpportunity : DriverTestCase
    {
        [TestMethod]
        public void addnoteforopportunity()
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

            var NoteSubject = "Test Note" + RandomNumber(1, 99);
                      

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            AddEventsForOpportunityHelper.ClickElement("ClickOnOpportunities");

            //Open Opportunity
            AddEventsForOpportunityHelper.ClickElement("FirstOpportunityNameLink");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);

            //Click on Move over
            AddEventsForOpportunityHelper.MouseOver("locator");
            AddEventsForOpportunityHelper.WaitForWorkAround(5000);


//################### ADD NOTE  #########################


            //Click on Add Note
            AddEventsForOpportunityHelper.ClickElement("ClickOnAddNote");

            //Enter Note Subject
            AddEventsForOpportunityHelper.TypeText("EnterNoteSubject", NoteSubject);

            //Enter Note Description
            AddEventsForOpportunityHelper.TypeText("EnterNoteDescription", "This is Note Description");

            //Upload File            
            AddEventsForOpportunityHelper.Upload1("//*[@id='Attachment0Files']");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);
            

            //Click On Save
            AddEventsForOpportunityHelper.ClickElement("ClickOnSaveNote");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);


            
        }
    }
}
