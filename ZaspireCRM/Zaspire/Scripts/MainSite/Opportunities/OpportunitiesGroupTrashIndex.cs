using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesGroupTrashIndex : DriverTestCase
    {
        [TestMethod]
        public void opportunitiesgrouptrashindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesGroupTrashIndexHelper = new OpportunitiesGroupTrashIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Opportunities
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click on Trash
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnTrash");
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click on Group Trash
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnGroupTrash");
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click On Back Button
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnBack");

            //Click On Back To Opportunities Group Trash
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnBackToGroupTrash");
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click On Opportunity Group View
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnOpportunityGroupView");

            //Click On Back To Opportunities Group Trash
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnBackToGroupTrash");

            //Enter Filter Search
            OpportunitiesGroupTrashIndexHelper.TypeText("EnterFilterSearch", "Test");
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(7000);

            //Click On Reset Button
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnReset");

            //Click On MouseHover
            OpportunitiesGroupTrashIndexHelper.MouseHover("locator");

            //Click On Delete Forever
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnDeleteForever");

            OpportunitiesGroupTrashIndexHelper.AcceptAlert();
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(5000);

            //Click On MouseHover
            OpportunitiesGroupTrashIndexHelper.MouseHover("locator");

            //Click On Restore Leads
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnRestoreOpportunities");

            OpportunitiesGroupTrashIndexHelper.AcceptAlert();
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(5000);

            //Click On Master Check Box
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Master Uncheck Box
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Mouseover
            OpportunitiesGroupTrashIndexHelper.MouseOver("locator");

            //Click On Quick Link
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On Delete
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnDelete");

            OpportunitiesGroupTrashIndexHelper.AcceptAlert();
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click On Mouseover
            OpportunitiesGroupTrashIndexHelper.MouseOver("locator");

            //Click On Quick Link
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On Restore
            OpportunitiesGroupTrashIndexHelper.ClickElement("ClickOnRestore");

            OpportunitiesGroupTrashIndexHelper.AcceptAlert();
            OpportunitiesGroupTrashIndexHelper.WaitForWorkAround(10000);

            
            
        }
    }
}

