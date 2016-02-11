using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForCalls : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforcalls()
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
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "Calls");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Calls
            AuditTrailsIndexHelper.ClickElement("ClickOnCalls");

            //Click On Call Date Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCallDateCheckBox");

            //Click On Call End Date Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCallEndDateCheckBox");

            //Click On Call From Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCallFromCheckBox");

            //Click On Call To Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCallToCheckBox");

            //Click On Call Category Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCallCategoryCheckBox");

            //Click On Description Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnDescriptionCheckBox");

            //Click On Call Duration Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCallDurationCheckBox");

            //Click On Start Time Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnStartTimeCheckBox");

            //Click On Call Subject Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCallSubjectCheckBox");

            //Click On Type Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnTypeCheckBox");

            //Click On Call Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnCallOwnerCheckBox");

            //Click On Calls Save
            AuditTrailsIndexHelper.ClickElement("ClickOnCallSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);


        }
    }
}