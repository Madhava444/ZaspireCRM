using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class SendEmailForOpportunityView : DriverTestCase
    {
        [TestMethod]
        public void sendemailforopportunityview()
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



//################### SEND EMAIL  #########################


            //Click on Send Email
            AddEventsForOpportunityHelper.ClickElement("ClickOnSendEmail");

            //Click On Employees Link
            AddEventsForOpportunityHelper.ClickElement("ClickOnEmployeesLink");

            //Click On To Address Check Box
            AddEventsForOpportunityHelper.ClickElement("ToAddressCheckBox");

            //Click On CC Address Check Box
            AddEventsForOpportunityHelper.ClickElement("CCAddressCheckBox");

            //Click On BCC Address Check Box
            AddEventsForOpportunityHelper.ClickElement("BCCAddressCheckBox");

            //Click On Add Email Address Button
            AddEventsForOpportunityHelper.ClickElement("ClickOnAddEmailAddress");

            //Click on Send Email Button
            AddEventsForOpportunityHelper.ClickElement("ClickOnSendEmailButton");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);
            

        }
    }
}
