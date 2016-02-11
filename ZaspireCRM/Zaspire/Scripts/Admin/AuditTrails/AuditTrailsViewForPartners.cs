using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForPartners : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforpartners()
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
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "Partners");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Partners
            AuditTrailsIndexHelper.ClickElement("ClickOnPartners");


//##########################  PARTNER DETAILS  ###########################

            //Click On Address Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartAddDetails");

            //Click On Contact Address Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartConAddDetails");

            //Click On Contact Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartConDetails");

            //Click On Emails Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartEmail");

            //Click On Phone Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartPhoneDetails");

            //Click On SocialLink Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartSocialLink");

            //Click On Active Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartActive");

            //Click On Code Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartCode");

            //Click On Company Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartCompany");

            //Click On Pacebook URL Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartPacebookURL");

            //Click On Linkedin URL Check Box
            AuditTrailsIndexHelper.ClickElement("ClickONPartLinkedinURL");

            //Click On Manager Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartManager");

            //Click On Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartName");

            //Click On Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartOwner");

            //Click On Permissions Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartPermissions");

            //Click On Twitter URL Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartTwitterURL");

            //Click On Title Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnLeadTitle");

            //Click On Website Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnPartWebsite");


            //Click On Partners Save
            AuditTrailsIndexHelper.ClickElement("ClickOnPartSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

        }
    }
}