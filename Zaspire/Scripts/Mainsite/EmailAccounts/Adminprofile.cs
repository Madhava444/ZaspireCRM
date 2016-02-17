using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddMailtoLead2 : DriverTestCase
    {
        [TestMethod]
        public void AddmailtoLead2()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var EmailacccountsIndexPageActionsHelper = new EmailAcccountsIndexPageActionsHelper(GetWebDriver());
            var AddNewLeadHelper = new AddNewLeadHelper(GetWebDriver());

            //Variables
            var AccountName = "TestAccount" + RandomNumber(1, 9);
            var Signaturename = "TestSignature" + RandomNumber(1, 9);
            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var LeadCompany = "Test Company" + RandomNumber(1, 99);
            var LeadTitle = "Test Title" + RandomNumber(1, 99);
            var Email = "Test" + RandomNumber(1, 99) + "@gmail.com";
            var Number = "12345678" + RandomNumber(10, 99);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(2000);
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickonAddtolead3");

            

            
        }
    }
}