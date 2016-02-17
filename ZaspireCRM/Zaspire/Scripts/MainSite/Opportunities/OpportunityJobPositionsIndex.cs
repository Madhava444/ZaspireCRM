using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class OpportunityJobPositionsIndex : DriverTestCase
    {
        [TestMethod]
        public void opportunityjobpostionsindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            OpportunityJobPositionsHelper OpportunityJobPositionsHelper = new OpportunityJobPositionsHelper(GetWebDriver());


            //Variable
            var JavaDeveloper = "Java Developer" + RandomNumber(1, 99);
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            OpportunityJobPositionsHelper.ClickElement("ClickOnOpportunities");
            OpportunityJobPositionsHelper.WaitForWorkAround(4000);


            //Click on Opportunit
            OpportunityJobPositionsHelper.ClickElement("FirstOpportunityNameLink");
            OpportunityJobPositionsHelper.WaitForWorkAround(4000);

            //Click On Job Positions tab
            OpportunityJobPositionsHelper.ClickElement("ClickOnJobPositionstab");
            OpportunityJobPositionsHelper.WaitForWorkAround(4000);

            //Click On Add Job Position
            OpportunityJobPositionsHelper.ClickElement("ClickOnAddJobPosition");

            //Click On Add Job Position Cancel button
            OpportunityJobPositionsHelper.ClickElement("ClickOnCancel");

            //Enter Keyword Search
            OpportunityJobPositionsHelper.TypeText("EnterKeywordSearch", JavaDeveloper);
            OpportunityJobPositionsHelper.WaitForWorkAround(8000);

            //Click On Reset button
            OpportunityJobPositionsHelper.ClickElement("ClickOnReset");

            //Click On Check Master Check Box
            OpportunityJobPositionsHelper.ClickElement("SelectMasterCheckBox");

            //Click On Uncheck Master Check Box
            OpportunityJobPositionsHelper.ClickElement("SelectMasterCheckBox");

            //Click On First Job Position Link
            OpportunityJobPositionsHelper.ClickElement("ClickOnFirstJobLink");

            //Click On Quick Link
            OpportunityJobPositionsHelper.ClickElement("ClickOnQuickLink");

            //Click On Job Position Edit
            OpportunityJobPositionsHelper.ClickElement("ClickOnJobEdit");

            //Click On Quick Link
            OpportunityJobPositionsHelper.ClickElement("ClickOnQuickLink");

            //Click On Job Position View
            OpportunityJobPositionsHelper.ClickElement("ClickOnJobView");


            
        }
    }
}
