using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsManageTags : DriverTestCase
    {
        [TestMethod]
        public void jobsmanagetags()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var jobsViewPageHelper = new  JobsViewPageHelper(GetWebDriver());

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            jobsViewPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/jobs");
            //jobsViewPageHelper.WaitForWorkAround(7000);


            //Open Lead
            jobsViewPageHelper.ClickElement("FirstLeadNameLink");


            //################### MANAGE TAGS  #########################


            //Click on Manage Tags
            jobsViewPageHelper.ClickElement("ClickOnManageTags");


            //################### YOUR TAGS  #########################


            //Enter Your Tag Name
            jobsViewPageHelper.TypeText("EnterYourTagName", "Testtag");

            //Click on Save
            jobsViewPageHelper.ClickElement("ClickOnYourTagSave");
            jobsViewPageHelper.WaitForWorkAround(10000);


            //################### MANAGE TAGS SYSTEM GENERATED TAGS #########################


            //Click on Manage Tags
            jobsViewPageHelper.ClickElement("ClickOnManageTags");

            //Click on System Generated Tags
            jobsViewPageHelper.ClickElement("ClickOnSystemGeneratedTags");

            //Click on System Generated Tags Edit
            jobsViewPageHelper.ClickElement("ClickOnTagsEdit");

            //Uncheck State
            jobsViewPageHelper.ClickElement("UncheckState");

            //Uncheck Department
            jobsViewPageHelper.ClickElement("UncheckDepartment");

            //Click On Recreate button
            jobsViewPageHelper.ClickElement("ClickOnRecreate");
            jobsViewPageHelper.WaitForWorkAround(10000);


            //################### MANAGE TAGS DELETE  #########################


            //Click on Manage Tags
            jobsViewPageHelper.ClickElement("ClickOnManageTags");

            //Click on System Generated Tags
            jobsViewPageHelper.ClickElement("ClickOnSystemGeneratedTags");

            //Click on System Generated Tags Delete
            jobsViewPageHelper.ClickElement("ClickOnTagsDelete");
            jobsViewPageHelper.WaitForWorkAround(10000);


            //################### TAGS SEARCH  #########################


            //Click on Tag Name
            jobsViewPageHelper.ClickElement("ClickOnTagsName");
            jobsViewPageHelper.WaitForWorkAround(10000);




        }
    }
}
