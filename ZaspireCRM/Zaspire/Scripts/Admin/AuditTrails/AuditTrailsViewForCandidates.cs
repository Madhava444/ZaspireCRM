using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForCandidates : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforcandidates()
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
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "Candidates");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Candidates
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidates");


//##################  CANDIDATE PREFFERED LOCATIONS  ######################

            //Click On Preffered City Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidatePreCity");

            //Click On Preffered State Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidatePreState");


//##################  CANDIDATE PROFILE  ######################

            //Click On Education Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateEducation");

            //Click On Career Lavel Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateCareerLavel");

            //Click On Industry Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateIndustry");

            //Click On Skills Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateSkillsDetails");

            //Click On Total Experiance Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateTotalExp");

            //Click On Visa Expiry Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateVisaExpiry");

            //Click On Visa Type Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateVisaType");


//##################  CANDIDATES REFFERENCE DETAILS  ######################

            //Click On Refference Company Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateCompanyName");

            //Click On Refference Email Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateRefEmail");

            //Click On Refference Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateRefName");


//##################  CANDIDATE DETAILS  ######################

            //Click On Address Line1 Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateAddressLine1");

            //Click On Address Line2 Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateAddressLine2");

            //Click On City Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateCity");

            //Click On Company Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateCompany");

            //Click On Country Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateCountry");

            //Click On Emails Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateEmail");

            //Click On First Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateFirstName");

            //Click On Hot Block Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateHotBlock");

            //Click On Job Title Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateJobTitle");

            //Click On Last Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateLastName");

            //Click On Phone Number Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidatePhoneNumber");

            //Click On Prefered Travel Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidatePreferedTravel");

            //Click On Salutation Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateSalutation");

            //Click On State Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateState");

            //Click On Title Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateTitle");

            //Click On ZipCode Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateZipCode");
      
            
//##################  INTERNAL FIELDS  ######################

            
            //Click On Manager Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateManager");

            //Click On Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateOwner");

            //Click On Source Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateSource");

            //Click On Status Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCandidateStatus");


            //Click On Candidates Save
            AuditTrailsIndexHelper.ClickElement("ClickOnJobsSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);


        }
    }
}