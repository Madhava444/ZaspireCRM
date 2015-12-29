using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsViewPage : DriverTestCase
    {
        [TestMethod]
        public void leadsviewpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsViewPageHelper = new LeadsViewPageHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            LeadsViewPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsViewPageHelper.WaitForWorkAround(7000);


            //Open Lead
            LeadsViewPageHelper.ClickElement("FirstLeadNameLink");
            
            //Click on Job Positions tab
            LeadsViewPageHelper.ClickElement("ClickOnJobPositionstab");

            //Click on Activities tab
            LeadsViewPageHelper.ClickElement("ClickOnActivitiestab");

            //Click on Contact Info tab
            LeadsViewPageHelper.ClickElement("ClickOnContactInfotab");

            //Click on Campaigns tab
            LeadsViewPageHelper.ClickElement("ClickOnCampaignstab");

            //Click on Description tab
            LeadsViewPageHelper.ClickElement("ClickOnDescriptiontab");

            //Click on Timeline tab
            LeadsViewPageHelper.ClickElement("ClickOnTimeLinetab");




        }
    }
}