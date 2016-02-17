using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesGroupView : DriverTestCase
    {
        [TestMethod]
        public void opportunitiesgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesGroupViewHelper = new OpportunitiesGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            OpportunitiesGroupViewHelper.ClickElement("ClickOnOpportunities");
            
            //Click On Groups
            OpportunitiesGroupViewHelper.ClickElement("ClickOnGroups");

            //Open Group
            OpportunitiesGroupViewHelper.ClickElement("FirstOpportunityGroupNameLink");

            
//################### GROUPS VIEW PAGE ACTIONS  #########################


            //Click on Add New
            OpportunitiesGroupViewHelper.ClickElement("ClickOnAddNew");

            //Click On Add New To Groups
            OpportunitiesGroupViewHelper.ClickElement("ClickOnAddNewToGroups");

            //Click on Edit
            OpportunitiesGroupViewHelper.ClickElement("ClickOnEdit");

            //Click On Edit To Groups
            OpportunitiesGroupViewHelper.ClickElement("ClickOnEditToGroups");

            //Click on Back
            OpportunitiesGroupViewHelper.ClickElement("ClickOnBack");

            //Click On Groups
            OpportunitiesGroupViewHelper.ClickElement("ClickOnGroups");
            OpportunitiesGroupViewHelper.WaitForWorkAround(7000);

            //Click on More Actions
            OpportunitiesGroupViewHelper.MouseOver("locator");

            //Click on Delete
            OpportunitiesGroupViewHelper.ClickElement("ClickOnDelete");
            
            OpportunitiesGroupViewHelper.AcceptAlert();
            OpportunitiesGroupViewHelper.WaitForWorkAround(10000);


//################### OPPORTUNITIES SEARCH FOR GROUP VIEW PAGE  #########################


            //Enter Opportunities Search Box
            OpportunitiesGroupViewHelper.TypeText("EnterOpportunitiesSearchBox", "Test Opportunities");

            //Click On Opportunities Reset Button
            OpportunitiesGroupViewHelper.ClickElement("ClickOnOpportunitiesReset");





        }
    }
}
