using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsIndex : DriverTestCase
    {
        [TestMethod]
        public void audittrailsindex()
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

            //Click on Reset
            AuditTrailsIndexHelper.ClickElement("ClickOnReset");

            //Select Pagination
            //AuditTrailsIndexHelper.Select("SelectPagination", "All");

            //Click On Calls
            AuditTrailsIndexHelper.ClickElement("ClickOnCalls");

            //Click On Cancel
            AuditTrailsIndexHelper.ClickElement("ClickOnCallCancel");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);


        }
    }
}