using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class BulkActionsForLeadsJobPositions : DriverTestCase
    {
        [TestMethod]
        public void bulkactionsforleadsjobpositions()
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



//####################  ADD JOB POSITION  ######################

            
            //Click On Add Job Position
            LeadsJobPositionsHelper.ClickElement("ClickOnAddJobPosition");

            //Enter Job Title
            LeadsJobPositionsHelper.TypeText("EnterJobTitle", JavaDeveloper);

            //Select Career Level
            LeadsJobPositionsHelper.Select("SelectCareerLevel", "Lead Role");

            //Enter Experience Years
            LeadsJobPositionsHelper.TypeText("EnterExperienceYears", "4");

            //Enter Experience Months
            LeadsJobPositionsHelper.TypeText("EnterExperienceMonths", "7");

            //Enter Job Position Url
            LeadsJobPositionsHelper.TypeText("EnterJobPositionUrl", "www.jobposition.com");

            //Select Education
            LeadsJobPositionsHelper.Select("SelectEducation", "M.Tech");

            //Click On Job Type & Compensation Expand button
            LeadsJobPositionsHelper.ClickElement("ClickOnExpand1");

            //Select Job Type
            LeadsJobPositionsHelper.Select("SelectJobType", "Full Time");

            //Click On Job Location Expand button
            LeadsJobPositionsHelper.ClickElement("ClickOnExpand2");

            //Enter Job City
            LeadsJobPositionsHelper.TypeText("EnterJobCity", "Test City");

            //Select Job State
            LeadsJobPositionsHelper.Select("SelectJobState", "DC");

            //Select Job Country
            LeadsJobPositionsHelper.Select("SelectJobCountry", "USA");

            //Enter Job zip code
            LeadsJobPositionsHelper.TypeText("EnterZipCode", "25896");

            //Click On Add Locations
            LeadsJobPositionsHelper.ClickElement("ClickOnAddLocation");

            //Enter Job City
            LeadsJobPositionsHelper.TypeText("EnterJobCity1", "Test City1");

            //Select Job State
            LeadsJobPositionsHelper.Select("SelectJobState1", "ID");

            //Select Job Country
            LeadsJobPositionsHelper.Select("SelectJobCountry1", "USA");

            //Enter Job zip code
            LeadsJobPositionsHelper.TypeText("EnterZipCode1", "54786");


            //Click On Save
            LeadsJobPositionsHelper.ClickElement("ClickOnSave");
            LeadsJobPositionsHelper.WaitForWorkAround(10000);




//################  JOB POSITIONS BULK UPDATE  ###############################


            //Click On Job Positions tab
            LeadsJobPositionsHelper.ClickElement("ClickOnJobPositionstab");
            LeadsJobPositionsHelper.WaitForWorkAround(4000);

            //Click On Master Check Box
            LeadsJobPositionsHelper.ClickElement("SelectMasterCheckBox");

            //Click On Bulk Actions
            LeadsJobPositionsHelper.ClickElement("ClickOnBulkActions");

            //Click On Bulk Update
            LeadsJobPositionsHelper.ClickElement("ClickOnBulkUpdate");

            //Select Status
            LeadsJobPositionsHelper.Select("SelectStatus", "Assigned");

            //Select Priority
            LeadsJobPositionsHelper.Select("SelectPriority", "High");

            //Select Category
            LeadsJobPositionsHelper.Select("SelectCategory", "Advertising");

            //Select Owner
            LeadsJobPositionsHelper.Select("SelectOwner", "17");

            //Select Manager
            LeadsJobPositionsHelper.Select("SelectManager", "17");


            //Click On Update
            LeadsJobPositionsHelper.ClickElement("ClickOnUpdate");

            LeadsJobPositionsHelper.AcceptAlert();
            LeadsJobPositionsHelper.WaitForWorkAround(10000);



//################  JOB POSITIONS BULK DELETE  ###############################


            //Click On Job Positions tab
            LeadsJobPositionsHelper.ClickElement("ClickOnJobPositionstab");
            LeadsJobPositionsHelper.WaitForWorkAround(4000);

            //Click On Master Check Box
            LeadsJobPositionsHelper.ClickElement("SelectMasterCheckBox");

            //Click On Bulk Actions
            LeadsJobPositionsHelper.ClickElement("ClickOnBulkActions");

            //Click On Bulk Delete
            LeadsJobPositionsHelper.ClickElement("ClickOnBulkDelete");

            LeadsJobPositionsHelper.AcceptAlert();
            LeadsJobPositionsHelper.WaitForWorkAround(10000);



        }
    }
}