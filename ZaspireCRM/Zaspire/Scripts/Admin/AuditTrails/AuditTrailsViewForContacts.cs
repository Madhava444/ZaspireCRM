using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForContacts : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforcontacts()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AuditTrailsIndexHelper = new AuditTrailsIndexHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            //MouseOver
            AuditTrailsIndexHelper.MouseOver("locator");

            //Click on Admin
            AuditTrailsIndexHelper.ClickElement("ClickOnAdmin");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click on Audit Trails
            AuditTrailsIndexHelper.ClickElement("ClickOnAuditTrails");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Enter Filter Box
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "Contacts");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Contacts
            AuditTrailsIndexHelper.ClickElement("ClickOnContacts");


//##########################  CONTACT DETAILS  ###########################

            //Click On Address Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConAddDetails");

            //Click On Emails Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConEmail");

            //Click On Phone Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConPhoneDetails");

            //Click On About Contact Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConAboutContact");

            //Click On Birth Date Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConBirthDate");

            //Click On Company Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConCompany");

            //Click On Last Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConLastName");

            //Click On Department Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConDepartment");

            //Click On Salutation Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConSalutation");

            //Click On Title Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConTitle");
            

//############################  CONTACT INTERNAL FIELDS  #####################

            //Click On Category Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConCategory");

            //Click On Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConOwner");

            //Click On Source Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConSource");

            //Click On Status Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnConStatus");


            //Click On Contacts Save
            AuditTrailsIndexHelper.ClickElement("ClickOnConSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

        }
    }
}