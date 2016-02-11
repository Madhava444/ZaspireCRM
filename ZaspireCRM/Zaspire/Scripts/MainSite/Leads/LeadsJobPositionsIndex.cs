using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class LeadsJobPositionsIndex : DriverTestCase
    {
        [TestMethod]
        public void leadsjobpostionsindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            LeadsJobPositionsHelper LeadsJobPositionsHelper = new LeadsJobPositionsHelper(GetWebDriver());


            //Variable
            var JavaDeveloper = "Java Developer" + RandomNumber(1, 99);
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            LeadsJobPositionsHelper.ClickElement("ClickOnLeads");
            LeadsJobPositionsHelper.WaitForWorkAround(4000);


            //Click on Lead
            LeadsJobPositionsHelper.ClickElement("FirstLeadNameLink");
            LeadsJobPositionsHelper.WaitForWorkAround(4000);

            //Click On Job Positions tab
            LeadsJobPositionsHelper.ClickElement("ClickOnJobPositionstab");
            LeadsJobPositionsHelper.WaitForWorkAround(4000);

            //Click On Add Job Position
            LeadsJobPositionsHelper.ClickElement("ClickOnAddJobPosition");

            //Click On Add Job Position Cancel button
            LeadsJobPositionsHelper.ClickElement("ClickOnCancel");

            //Enter Keyword Search
            LeadsJobPositionsHelper.TypeText("EnterKeywordSearch", JavaDeveloper);
            LeadsJobPositionsHelper.WaitForWorkAround(8000);

            //Click On Reset button
            LeadsJobPositionsHelper.ClickElement("ClickOnReset");

            //Click On Check Master Check Box
            LeadsJobPositionsHelper.ClickElement("SelectMasterCheckBox");

            //Click On Uncheck Master Check Box
            LeadsJobPositionsHelper.ClickElement("SelectMasterCheckBox");

            //Click On First Job Position Link
            LeadsJobPositionsHelper.ClickElement("ClickOnFirstJobLink");

            //Click On Quick Link
            LeadsJobPositionsHelper.ClickElement("ClickOnQuickLink");

            //Click On Job Position Edit
            LeadsJobPositionsHelper.ClickElement("ClickOnJobEdit");

            //Click On Quick Link
            LeadsJobPositionsHelper.ClickElement("ClickOnQuickLink");

            //Click On Job Position View
            LeadsJobPositionsHelper.ClickElement("ClickOnJobView");


            
        }
    }
}