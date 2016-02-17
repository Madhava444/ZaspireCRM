using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesTrashIndex : DriverTestCase
    {
        [TestMethod]
        public void opportunitiestrashindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesTrashIndexPageHelper = new OpportunitiesTrashIndexPageHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Opportunities
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesTrashIndexPageHelper.WaitForWorkAround(10000);

            //Click on Trash
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnTrash");
            OpportunitiesTrashIndexPageHelper.WaitForWorkAround(10000);

            //Click On Back Button
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnBack");

            //Click On Back To Opportunities Trash
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnBackToOpportunitiesTrash");

            //Click On Group Trash Button
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnGroupTrash");

            //Click On Back To Opportunities Trash
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnBackToOpportunitiesTrash");

            //Click On Opportunity View
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnOpportunityView");

            //Click On Back To Opportunities Trash
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnBackToOpportunitiesTrash");

            //Enter Filter Search
            OpportunitiesTrashIndexPageHelper.TypeText("EnterFilterSearch", "Test");
            OpportunitiesTrashIndexPageHelper.WaitForWorkAround(7000);

            //Click On Reset Button
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnReset");

            //Click On MouseHover
            OpportunitiesTrashIndexPageHelper.MouseHover("locator");

            //Click On Delete Forever
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnDeleteForever");

            OpportunitiesTrashIndexPageHelper.AcceptAlert();
            OpportunitiesTrashIndexPageHelper.WaitForWorkAround(5000);

            //Click On MouseHover
            OpportunitiesTrashIndexPageHelper.MouseHover("locator");

            //Click On Restore Opportunities
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnRestoreOpportunities");

            OpportunitiesTrashIndexPageHelper.AcceptAlert();
            OpportunitiesTrashIndexPageHelper.WaitForWorkAround(5000);

            //Click On Master Check Box
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Master Uncheck Box
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Mouseover
            OpportunitiesTrashIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnQuickLink");

            //Click On Delete
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnDelete");

            OpportunitiesTrashIndexPageHelper.AcceptAlert();
            OpportunitiesTrashIndexPageHelper.WaitForWorkAround(10000);

            //Click On Mouseover
            OpportunitiesTrashIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnQuickLink");

            //Click On Restore
            OpportunitiesTrashIndexPageHelper.ClickElement("ClickOnRestore");

            OpportunitiesTrashIndexPageHelper.AcceptAlert();
            OpportunitiesTrashIndexPageHelper.WaitForWorkAround(10000);

            
            
        }
    }
}
