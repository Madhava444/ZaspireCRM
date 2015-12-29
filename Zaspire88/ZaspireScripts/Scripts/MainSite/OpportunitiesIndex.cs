using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesIndex : DriverTestCase
    {
        [TestMethod]
        public void opportunitiesindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesIndexHelper = new OpportunitiesIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            OpportunitiesIndexHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesIndexHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities");
            //OpportunitiesIndexHelper.WaitForWorkAround(7000);


            //Click on Filter By Groups
            OpportunitiesIndexHelper.ClickElement("ClickOnFilterByGroups");

            //Click On Back To Opportunities
            //OpportunitiesIndexHelper.ClickElement("ClickOnBackToOpportunities");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities");

            //Select Filter By Groups
            OpportunitiesIndexHelper.Select("SelectFilterByGroups", "");

            //Click On Custom Views
            OpportunitiesIndexHelper.ClickElement("ClickOnCustomViews");

            //Click on Back to Opportunities
            //OpportunitiesIndexHelper.ClickElement("ClickOnBackToOpportunities");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities");

            //Click On Custom Views New
            OpportunitiesIndexHelper.ClickElement("ClickOnCustomViewsNew");

            //Click on Back to Opportunities
            //OpportunitiesIndexHelper.ClickElement("ClickOnBackToOpportunities");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities");

            //Select Custom Views
            OpportunitiesIndexHelper.Select("SelectCustomViews", "");

            //Select Default Views
            OpportunitiesIndexHelper.Select("SelectDefaultViews", "My Opportunities");

            //Enter Tags
            OpportunitiesIndexHelper.TypeText("EnterTags", "New");

            //Clock On Tags Search
            OpportunitiesIndexHelper.ClickElement("ClockOnTagsSearch");

            //Clock On Tags Reset
            OpportunitiesIndexHelper.ClickElement("ClockOnTagsReset");

            //Enter Filter Search
            OpportunitiesIndexHelper.TypeText("EnterFilterSearch", "New");
            OpportunitiesIndexHelper.WaitForWorkAround(10000);

            //Clock On Filter Reset
            OpportunitiesIndexHelper.ClickElement("ClockOnFilterReset");

            //Clock On Master Check Box
            OpportunitiesIndexHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Master Uncheck Box
            OpportunitiesIndexHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Lead Name Link
            OpportunitiesIndexHelper.ClickElement("FirstOpportunityNameLink");

            //Click on Back to Opportunities
            //OpportunitiesIndexHelper.ClickElement("ClickOnBackToOpportunities");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities");

            //Clock On Quick Look Mouse Over
            OpportunitiesIndexHelper.MouseOver("locator");

            //Clock On Quick Look
            OpportunitiesIndexHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look View
            OpportunitiesIndexHelper.ClickElement("ClockOnQuickLookView");
            OpportunitiesIndexHelper.WaitForWorkAround(10000);

            //Click on Back to Opportunities
            //OpportunitiesIndexHelper.ClickElement("ClickOnBackToOpportunities");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities");

            //Clock On Quick Look Mouse Over
            OpportunitiesIndexHelper.MouseOver("locator");

            //Clock On Quick Look
            OpportunitiesIndexHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Edit
            OpportunitiesIndexHelper.ClickElement("ClockOnQuickLookEdit");
            OpportunitiesIndexHelper.WaitForWorkAround(10000);

            //Click on Back to Opportunities
            //OpportunitiesIndexHelper.ClickElement("ClickOnBackToOpportunities");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities");

            //Clock On Quick Look Mouse Over
            OpportunitiesIndexHelper.MouseOver("locator");

            //Clock On Quick Look
            OpportunitiesIndexHelper.ClickElement("ClockOnQuickLook");

            //Clock On Quick Look Delete
            OpportunitiesIndexHelper.ClickElement("ClockOnQuickLookDelete");

            OpportunitiesIndexHelper.AcceptAlert();
            OpportunitiesIndexHelper.WaitForWorkAround(10000);








        }
    }
}