using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunityManageTags : DriverTestCase
    {
        [TestMethod]
        public void opportunitymanagetags()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunityViewPageHelper = new OpportunityViewPageHelper(GetWebDriver());

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            OpportunityViewPageHelper.ClickElement("ClickOnOpportunities");

            //Open Opportunity
            OpportunityViewPageHelper.ClickElement("FirstOpportunityNameLink");


//################### MANAGE TAGS  #########################


            //Click on Manage Tags
            OpportunityViewPageHelper.ClickElement("ClickOnManageTags");


//################### YOUR TAGS  #########################


            //Enter Your Tag Name
            OpportunityViewPageHelper.TypeText("EnterYourTagName", "Testtag");

            //Click on Save
            OpportunityViewPageHelper.ClickElement("ClickOnYourTagSave");
            OpportunityViewPageHelper.WaitForWorkAround(10000);


//################### MANAGE TAGS SYSTEM GENERATED TAGS #########################


            //Click on Manage Tags
            OpportunityViewPageHelper.ClickElement("ClickOnManageTags");

            //Click on System Generated Tags
            OpportunityViewPageHelper.ClickElement("ClickOnSystemGeneratedTags");

            //Click on System Generated Tags Edit
            OpportunityViewPageHelper.ClickElement("ClickOnTagsEdit");

            //Uncheck State
            OpportunityViewPageHelper.ClickElement("UncheckState");

            //Uncheck Department
            OpportunityViewPageHelper.ClickElement("UncheckDepartment");

            //Click On Recreate button
            OpportunityViewPageHelper.ClickElement("ClickOnRecreate");
            OpportunityViewPageHelper.WaitForWorkAround(10000);


//################### MANAGE TAGS DELETE  #########################


            //Click on Manage Tags
            OpportunityViewPageHelper.ClickElement("ClickOnManageTags");

            //Click on System Generated Tags
            OpportunityViewPageHelper.ClickElement("ClickOnSystemGeneratedTags");

            //Click on System Generated Tags Delete
            OpportunityViewPageHelper.ClickElement("ClickOnTagsDelete");
            OpportunityViewPageHelper.WaitForWorkAround(10000);


//################### TAGS SEARCH  #########################


            //Click on Tag Name
            OpportunityViewPageHelper.ClickElement("ClickOnTagsName");
            OpportunityViewPageHelper.WaitForWorkAround(10000);




        }
    }
}