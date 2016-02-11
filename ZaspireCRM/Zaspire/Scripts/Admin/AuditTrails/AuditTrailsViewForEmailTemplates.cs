using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForEmailTemplates : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforemailtemplates()
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
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "E-Mail Templates");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Email Templates
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailTemplates");


//##########################  EMAIL TEMPLATES DETAILS  ###########################

            //Click On Category Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailCategory");

            //Click On Description Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailDescription");

            //Click On Email Header Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailHeaderName");

            //Click On Email Template Subject Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailTemplateSubject");

            //Click On Manager Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailManager");

            //Click On Message Body Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailMessageBody");

            //Click On Message Footer Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailMessageFooter");

            //Click On Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailName");

            //Click On Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailOwner");

            //Click On Permissions Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailPermissions");

            //Click On Related To Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailRelatedTo");

            //Click On Status Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailStatus");

            //Click On User Group Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailUserGroup");


            //Click On Email Templates Save
            AuditTrailsIndexHelper.ClickElement("ClickOnEmailSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

        }
    }
}