using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForJobs : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforjobs()
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
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "Jobs");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Jobs
            AuditTrailsIndexHelper.ClickElement("ClickOnJobs");

//##################  JOBS CONTACT DETAILS  ######################

            //Click On Address Line1 Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobAddressLine1");

            //Click On Address Line2 Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobAddressLine2");

            //Click On City Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobCity");

            //Click On Country Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobCountry");

            //Click On Emails Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobEmail");

            //Click On First Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobFirstName");

            //Click On Last Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobLastName");

            //Click On Phone Number Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobPhoneNumber");

            //Click On Salutation Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobSalutation");

            //Click On State Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobState");

            //Click On ZipCode Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobZipCode");

            //Click On Address Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobAddDetails");

            //Click On Company Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobCompany");
            
            //Click On Industry Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobIndustry");

            //Click On Listing End Date Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobListEndDate");

            //Click On Positions Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobPositions");

            //Click On Reference Code Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobReferenceCode");

            //Click On Salary Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobSalary");

//##################  JOBS DETAILS  ######################

            //Click On Career Level Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobCareerLevel");

            //Click On Domain Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobDomain");

            //Click On Education Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobEducation");

            //Click On Priority Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobPriority");

            //Click On Title Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobTitle");

            //Click On Website Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobWebsite");

            //Click On Work Shift Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobWorkShift");

            //Click On Description Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobDescription");

//##################  INTERNAL FIELDS  ######################
            
            //Click On Category Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobCategory");

            //Click On Manager Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobManager");

            //Click On Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobOwner");

            //Click On Source Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobSource");

            //Click On Status Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobStatus");

//##################  JOB GROUP DETAILS  ######################

            //Click On Group Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobGroupDetails");

//##################  JOB SKILL SUMMARY  ######################

            //Click On Key Skills Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobKeySkills");

            //Click On Skills Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnJobSkillsDetails");


            //Click On Jobs Save
            AuditTrailsIndexHelper.ClickElement("ClickOnJobsSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);


        }
    }
}