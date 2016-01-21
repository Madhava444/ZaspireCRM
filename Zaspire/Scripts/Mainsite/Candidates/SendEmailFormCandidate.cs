using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class SendEmailFormCandidate : DriverTestCase
    {
        [TestMethod]
        public void sendemailforcandidate()
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

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForcandidateHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //AddEventsForcandidateHelper.WaitForWorkAround(7000);


            //Open Lead
            AddEventsForcandidateHelper.ClickElement("FirstLeadNameLink");

            //Click on Move over
            AddEventsForcandidateHelper.ClickElement("MoveHover");
            AddEventsForcandidateHelper.WaitForWorkAround(5000);



//################### SEND EMAIL  #########################


            //Click on Send Email
            AddEventsForcandidateHelper.ClickElement("ClickOnSendEmail");

            //Click On Employees Link
            AddEventsForcandidateHelper.ClickElement("ClickOnEmployeesLink");

            //Click On To Address Check Box
            AddEventsForcandidateHelper.ClickElement("ToAddressCheckBox");

            //Click On CC Address Check Box
            AddEventsForcandidateHelper.ClickElement("CCAddressCheckBox");

            //Click On BCC Address Check Box
            AddEventsForcandidateHelper.ClickElement("BCCAddressCheckBox");

            //Click On Add Email Address Button
            AddEventsForcandidateHelper.ClickElement("ClickOnAddEmailAddress");

            //Click on Send Email Button
            AddEventsForcandidateHelper.ClickElement("ClickOnSendEmailButton");
            AddEventsForcandidateHelper.WaitForWorkAround(10000);
            

        }
    }
}