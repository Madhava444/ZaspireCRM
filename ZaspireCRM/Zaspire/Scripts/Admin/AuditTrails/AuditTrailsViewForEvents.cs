using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForEvents : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforevents()
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
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "Events");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Events
            AuditTrailsIndexHelper.ClickElement("ClickOnEvents");


//##########################  EVENTS DETAILS  ###########################

            //Click On Created Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventCreated");

            //Click On Deleted Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventDeleted");

            //Click On Description Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventDescription");

            //Click On Duration Hours Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventDurationHours");

            //Click On Duration Minutes Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventDurationMinutes");

            //Click On End Time Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventEndTime");

            //Click On Host URL Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventHostURL");

            //Click On Location Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventLocation");

            //Click On Modified Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventModified");

            //Click On Parent Status Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventParentStatus");

            //Click On Permissions Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventPermissions");

            //Click On Related To Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventRelatedTo");

            //Click On Remainder Time Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventRemainderTime");

            //Click On Repeat Until Check Box
            AuditTrailsIndexHelper.ClickElement("ClickONEventRepeatUntil");

            //Click On Start Time Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventStartTime");

            //Click On Subject Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventSubject");

            //Click On Type Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventType");


//############################  EVENTS INTERNAL FIELDS  #####################

            //Click On Category Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventCategory");

            //Click On Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventOwner");

            //Click On Priority Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventPriority");

            //Click On Status Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnEventStatus");


            //Click On Events Save
            AuditTrailsIndexHelper.ClickElement("ClickOnEventSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

        }
    }
}