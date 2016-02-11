using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForCampaigns : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforcampaigns()
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
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "Campaigns");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Campaigns
            AuditTrailsIndexHelper.ClickElement("ClickOnCampaigns");


//##########################  CAMPAIGNS DETAILS  ###########################

            //Click On About Campaign Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamAboutCampaign");

            //Click On Actual Cost Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamActualCost");

            //Click On Campagn URL Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamCampagnURL");

            //Click On End Date Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamEndDate");

            //Click On Estimated Cost Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamEstimatedCost");

            //Click On Expected Response Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamExpectedResponse");

            //Click On Expected Revenue Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamExpectedRevenue");

            //Click On Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamName");

            //Click On Start Date Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamStartDate");

            //Click On Targeted Num Check Box
            AuditTrailsIndexHelper.ClickElement("ClickONCamTargetedNum");


//############################  CAMPAIGNS INTERNAL FIELDS  #####################

            //Click On Category Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamCategory");

            //Click On Manager Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamManager");

            //Click On Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamOwner");

            //Click On Statue Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamStatus");

            //Click On Type Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCamType");


            //Click On Campaigns Save
            AuditTrailsIndexHelper.ClickElement("ClickOnCamSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

        }
    }
}