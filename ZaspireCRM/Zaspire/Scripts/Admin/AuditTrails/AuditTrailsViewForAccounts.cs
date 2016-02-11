using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForAccounts : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforaccounts()
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
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "Accounts");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Accounts
            AuditTrailsIndexHelper.ClickElement("ClickOnAccounts");


//###########################  ACCOUNTS DETAILS  #####################

            //Click On Company Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccCompany");

            //Click On Description Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccDescription");

            //Click On Email Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccEmail");

            //Click On Industry Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccIndustry");

            //Click On Legal Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccLegalName");

            //Click On No Of Employees Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccNoOfEmp");

            //Click On Rating Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccRating");

            //Click On Department Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnDepartment");

            //Click On SIC Code Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccSICCode");

            //Click On Ticker Symbol Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccTickerSymbol");

            //Click On Time Zone Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccTimeZone");

            //Click On Website Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccWebsite");

            //Click On Address Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccAddDetails");

            //Click On Contact Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccContactDetails");

            //Click On Contact Email Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccContactEmail");

            //Click On Phone Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccPhoneDetails");

            //Click On Social Link Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccSocialLink");


//###########################  ACCOUNTS INTERNAL FIELDS  #####################

            //Click On Category Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccCategory");

            //Click On Manager Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccManager");

            //Click On Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccOwner");

            //Click On Partner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccPartner");

            //Click On Source Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccSource");

            //Click On Status Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnAccStatus");


            //Click On Accounts Save
            AuditTrailsIndexHelper.ClickElement("ClickOnAccSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

        }
    }
}