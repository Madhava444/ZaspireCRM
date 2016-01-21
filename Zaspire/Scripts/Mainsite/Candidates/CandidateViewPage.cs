using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateViewPage : DriverTestCase
    {
        [TestMethod]
        public void candidateviewpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateviewpageHelper = new CanidateViewPageHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            candidateviewpageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //candidateviewpageHelper.WaitForWorkAround(7000);


            //Open Lead
            candidateviewpageHelper.ClickElement("FirstLeadNameLink");
            
            //Click on Job Positions tab
            candidateviewpageHelper.ClickElement("ClickOnJobPositionstab");

            //Click on Activities tab
            candidateviewpageHelper.ClickElement("ClickOnActivitiestab");

            //Click on Contact Info tab
            candidateviewpageHelper.ClickElement("ClickOnContactInfotab");

            //Click on Campaigns tab
            candidateviewpageHelper.ClickElement("ClickOnCampaignstab");

            //Click on Description tab
            candidateviewpageHelper.ClickElement("ClickOnDescriptiontab");

            //Click on Timeline tab
            candidateviewpageHelper.ClickElement("ClickOnTimeLinetab");




        }
    }
}