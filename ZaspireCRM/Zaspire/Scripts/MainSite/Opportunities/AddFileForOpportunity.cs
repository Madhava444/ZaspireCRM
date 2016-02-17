using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddFileForOpportunity : DriverTestCase
    {
        [TestMethod]
        public void addfileforopportunity()
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

            var FileName = "Test File" + RandomNumber(1, 99);
                      

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForOpportunityHelper.ClickElement("ClickOnOpportunities");
            AddEventsForOpportunityHelper.WaitForWorkAround(7000);


            //Open Opportunity
            AddEventsForOpportunityHelper.ClickElement("FirstOpportunityNameLink");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);

            //Click on Move over
            AddEventsForOpportunityHelper.MouseOver("locator");
            AddEventsForOpportunityHelper.WaitForWorkAround(5000);


//################### ADD FILE  #########################


            //Click on Add File
            AddEventsForOpportunityHelper.ClickElement("ClickOnAddFile");

            //Enter Note Subject
            AddEventsForOpportunityHelper.TypeText("EnterFileName", FileName);

            //Select Category
            AddEventsForOpportunityHelper.Select("SelectCategory", "12552");

            //Upload File            
            AddEventsForOpportunityHelper.Upload1("//*[@id='AttachmentFiles']");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);

            //Enter File Description
            AddEventsForOpportunityHelper.TypeText("EnterFileDescription", "This is File Description");

            //Click On Save
            AddEventsForOpportunityHelper.ClickElement("ClickOnSaveFile");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);


            
        }
    }
}

