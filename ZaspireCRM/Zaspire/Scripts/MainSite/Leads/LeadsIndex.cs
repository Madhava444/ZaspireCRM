using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsIndex : DriverTestCase
    {
        [TestMethod]
        public void leadsindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsIndexHelper = new LeadsIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            LeadsIndexHelper.ClickElement("ClickOnLeads");
            LeadsIndexHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsIndexHelper.WaitForWorkAround(7000);


            //Click on Filter By Groups
            LeadsIndexHelper.ClickElement("ClickOnFilterByGroups");

            //Click on Back to Leads
            LeadsIndexHelper.ClickElement("ClickOnBackToLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Select Filter By Groups
            LeadsIndexHelper.Select("SelectFilterByGroups", "");

            //Click On Custom Views
            LeadsIndexHelper.ClickElement("ClickOnCustomViews");

            //Click on Back to Leads
            LeadsIndexHelper.ClickElement("ClickOnCustomViewsBack");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Click On Custom Views New
            LeadsIndexHelper.ClickElement("ClickOnCustomViewsNew");

            //Click on Back to Leads
            LeadsIndexHelper.ClickElement("ClickOnBackToLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Select Custom Views
            LeadsIndexHelper.Select("SelectCustomViews", "");

            //Select Default Views
            LeadsIndexHelper.Select("SelectDefaultViews", "My Leads");

            //Enter Tags
            LeadsIndexHelper.TypeText("EnterTags", "New");

            //Clock On Tags Search
            LeadsIndexHelper.ClickElement("ClockOnTagsSearch");

            //Clock On Tags Reset
            LeadsIndexHelper.ClickElement("ClockOnTagsReset");

            //Enter Filter Search
            LeadsIndexHelper.TypeText("EnterFilterSearch", "New");
            LeadsIndexHelper.WaitForWorkAround(10000);

            //Clock On Filter Reset
            LeadsIndexHelper.ClickElement("ClockOnFilterReset");

            //Clock On Master Check Box
            LeadsIndexHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Master Uncheck Box
            LeadsIndexHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Lead Name Link
            LeadsIndexHelper.ClickElement("FirstLeadNameLink");

            //Click on Back to Leads
            LeadsIndexHelper.ClickElement("ClickOnBackToLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Clock On Quick Look Mouse Over
            LeadsIndexHelper.MouseOver("locator");

            //Clock On Quick Look
            LeadsIndexHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look View
            LeadsIndexHelper.ClickElement("ClockOnQuickLookView");
            LeadsIndexHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            LeadsIndexHelper.ClickElement("ClickOnBackToLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Clock On Quick Look Mouse Over
            LeadsIndexHelper.MouseOver("locator");

            //Clock On Quick Look
            LeadsIndexHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Edit
            LeadsIndexHelper.ClickElement("ClockOnQuickLookEdit");
            LeadsIndexHelper.WaitForWorkAround(10000);

            //Click on Back to Leads
            LeadsIndexHelper.ClickElement("ClickOnBackToLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");

            //Clock On Quick Look Mouse Over
            LeadsIndexHelper.MouseOver("locator");

            //Clock On Quick Look
            LeadsIndexHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Delete
            LeadsIndexHelper.ClickElement("ClockOnQuickLookDelete");

            LeadsIndexHelper.AcceptAlert();
            LeadsIndexHelper.WaitForWorkAround(10000);


            //Select SelectPagination
            LeadsIndexHelper.Select("SelectPagination", "20");

            //Click on Next
            LeadsIndexHelper.ClickElement("ClickOnNext");

            //Click on Last
            LeadsIndexHelper.ClickElement("ClickOnLast");

            //Click on Previous
            LeadsIndexHelper.ClickElement("ClickOnprevious");

            //Click on First
            LeadsIndexHelper.ClickElement("ClickOnFirst");
            
        }
    }
}