using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForLeads : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforleads()
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
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "Leads");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Leads
            AuditTrailsIndexHelper.ClickElement("ClickOnLeads");


//##########################  LEAD CONTACT DETAILS  ###########################

            //Click On Address Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadAddressDetails");

            //Click On Contact Address Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadContactAddDetails");

            //Click On Contact Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadContactDetails");

            //Click On Emails Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadEmails");

            //Click On Phone Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadPhoneDetails");

            //Click On SocialLink Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadSocialLink");


//############################  LEAD DETAILS  ##########################

            //Click On Company Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadCompany");

            //Click On Department Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadDepartment");

            //Click On First Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadFirstName");

            //Click On Industry Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadIndustry");

            //Click On Last Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadLastName");

            //Click On Middle Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadMiddleName");

            //Click On Salutation Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadSalutation");

            
//#######################  LEAD OTHER  #########################

            //Click On Annual Revenue Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadAnnualRevenue");

            //Click On Lead Group Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadGroup");

            //Click On No Of Employees Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadNoOfEmp");

            //Click On Title Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadTitle");

            //Click On Website Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadWebsite");


//############################  LEAD INTERNAL FIELDS  #####################

            //Click On Category Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadCategory");

            //Click On Manager Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadManager");

            //Click On Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadOwner");

            //Click On Partner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadPartner");

            //Click On Source Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadSource");

            //Click On Status Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadStatus");


            //Click On Leads Save
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadsSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

        }
    }
}