using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class OpportunityAddJobPositions : DriverTestCase
    {
        [TestMethod]
        public void opportunityaddjobpostions()
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


            //Click on Opportunity
            OpportunityJobPositionsHelper.ClickElement("FirstOpportunityNameLink");
            OpportunityJobPositionsHelper.WaitForWorkAround(4000);

            //Click On Job Positions tab
            OpportunityJobPositionsHelper.ClickElement("ClickOnJobPositionstab");
            OpportunityJobPositionsHelper.WaitForWorkAround(4000);

            //Click On Add Job Position
            OpportunityJobPositionsHelper.ClickElement("ClickOnAddJobPosition");

            //Enter Job Title
            OpportunityJobPositionsHelper.TypeText("EnterJobTitle", JavaDeveloper);

            //Select Career Level
            OpportunityJobPositionsHelper.Select("SelectCareerLevel", "Lead Role");

            //Enter Experience Years
            OpportunityJobPositionsHelper.TypeText("EnterExperienceYears", "4");

            //Enter Experience Months
            OpportunityJobPositionsHelper.TypeText("EnterExperienceMonths", "7");

            //Enter Job Position Url
            OpportunityJobPositionsHelper.TypeText("EnterJobPositionUrl", "www.jobposition.com");

            //Select Education
            OpportunityJobPositionsHelper.Select("SelectEducation", "M.Tech");

            //Click On Job Type & Compensation Expand button
            OpportunityJobPositionsHelper.ClickElement("ClickOnExpand1");
            
            //Select Job Type
            OpportunityJobPositionsHelper.Select("SelectJobType", "Full Time");

            //Click On Job Location Expand button
            OpportunityJobPositionsHelper.ClickElement("ClickOnExpand2");

            //Enter Job City
            OpportunityJobPositionsHelper.TypeText("EnterJobCity", "Test City");

            //Select Job State
            OpportunityJobPositionsHelper.Select("SelectJobState", "DC");

            //Select Job Country
            OpportunityJobPositionsHelper.Select("SelectJobCountry", "USA");

            //Enter Job zip code
            OpportunityJobPositionsHelper.TypeText("EnterZipCode", "25896");

            //Click On Add Locations
            OpportunityJobPositionsHelper.ClickElement("ClickOnAddLocation");

            //Enter Job City
            OpportunityJobPositionsHelper.TypeText("EnterJobCity1", "Test City1");

            //Select Job State
            OpportunityJobPositionsHelper.Select("SelectJobState1", "ID");

            //Select Job Country
            OpportunityJobPositionsHelper.Select("SelectJobCountry1", "USA");

            //Enter Job zip code
            OpportunityJobPositionsHelper.TypeText("EnterZipCode1", "54786");

            
            //Click On Save
            OpportunityJobPositionsHelper.ClickElement("ClickOnSave");
            OpportunityJobPositionsHelper.WaitForWorkAround(10000);

            
        }
    }
}
