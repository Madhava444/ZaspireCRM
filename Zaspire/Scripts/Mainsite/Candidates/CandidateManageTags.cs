using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateManageTags : DriverTestCase
    {
        [TestMethod]
        public void Candidatesmanagetags()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateViewPageHelper = new  CanidateViewPageHelper(GetWebDriver());

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            candidateViewPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //candidateViewPageHelper.WaitForWorkAround(7000);


            //Open Lead
            candidateViewPageHelper.ClickElement("FirstLeadNameLink");


//################### MANAGE TAGS  #########################


            //Click on Manage Tags
            candidateViewPageHelper.ClickElement("ClickOnManageTags");


//################### YOUR TAGS  #########################


            //Enter Your Tag Name
            candidateViewPageHelper.TypeText("EnterYourTagName", "Testtag");

            //Click on Save
            candidateViewPageHelper.ClickElement("ClickOnYourTagSave");
            candidateViewPageHelper.WaitForWorkAround(10000);


//################### MANAGE TAGS SYSTEM GENERATED TAGS #########################


            //Click on Manage Tags
            candidateViewPageHelper.ClickElement("ClickOnManageTags");

            //Click on System Generated Tags
            candidateViewPageHelper.ClickElement("ClickOnSystemGeneratedTags");

            //Click on System Generated Tags Edit
            candidateViewPageHelper.ClickElement("ClickOnTagsEdit");

            //Uncheck State
            candidateViewPageHelper.ClickElement("UncheckState");

            //Uncheck Department
            candidateViewPageHelper.ClickElement("UncheckDepartment");

            //Click On Recreate button
            candidateViewPageHelper.ClickElement("ClickOnRecreate");
            candidateViewPageHelper.WaitForWorkAround(10000);


//################### MANAGE TAGS DELETE  #########################


            //Click on Manage Tags
            candidateViewPageHelper.ClickElement("ClickOnManageTags");

            //Click on System Generated Tags
            candidateViewPageHelper.ClickElement("ClickOnSystemGeneratedTags");

            //Click on System Generated Tags Delete
            candidateViewPageHelper.ClickElement("ClickOnTagsDelete");
            candidateViewPageHelper.WaitForWorkAround(10000);


//################### TAGS SEARCH  #########################


            //Click on Tag Name
            candidateViewPageHelper.ClickElement("ClickOnTagsName");
            candidateViewPageHelper.WaitForWorkAround(10000);




        }
    }
}