using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsBulkAddToGroup : DriverTestCase
    {
        [TestMethod]
        public void Jobsbulkaddtogroup()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewJobsHelper = new AddNewjobsHelper(GetWebDriver());
            var JobsBulkActionsHelper = new JobsBulkActionsHelper(GetWebDriver());
        
            
            //Variable

            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var CandidateTitle = "Test Candidate" + RandomNumber(1, 99);
            var CandidateCompany = "Test Company" + RandomNumber(1, 99);
            var Email = "Candidatemeail" + RandomNumber(1, 99) + "@hotmail.com";
            var JOBTitle = "Jobtitle" + RandomNumber(1, 99);
            var Remail = "Referenceemail" + RandomNumber(1, 99) + "@hotmail.com";
            var Groupname = "TestGroup" + RandomNumber(1, 99);

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            AddNewJobsHelper.ClickElement("ClickonCandidate");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates/addnew");
            AddNewJobsHelper.WaitForWorkAround(7000);




            //################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Status
            AddNewJobsHelper.Select("Source", "Internal");

            //Select Source
            AddNewJobsHelper.Select("Status", "Confirmed");

            //Select Owner  
            AddNewJobsHelper.Select("Owner", "101");

            //Select Manager
            AddNewJobsHelper.Select("Manager", "101");

            //Select Partner
            AddNewJobsHelper.ClickElement("Hotlist");


            //Select Partner
            // AddNewJobsHelper.ClickElement("Blocklist");


            //####################### LEAD DETAILS  #############################

            //EnterTitle
            AddNewJobsHelper.TypeText("Title", CandidateTitle);

            //Select Salutation
            AddNewJobsHelper.Select("Salutation", "Mr");

            //Enter First Name
            AddNewJobsHelper.TypeText("Firstname", FirstName);

            //Enter Middle Name
            AddNewJobsHelper.TypeText("Lastname", "Mark");

            //Enter Last Name
            AddNewJobsHelper.Select("Education", "M.Tech");

            //Enter Company Name
            AddNewJobsHelper.TypeText("Totlaexpyears", "5");

            //Enter Company Name
            AddNewJobsHelper.TypeText("Totlaexpyears", "6");

            //Enter Lead Title Name
            AddNewJobsHelper.Select("Visatype", "GreenCard");

            //Enter Department Name
            AddNewJobsHelper.TypeText("Visaexpdate", "2016-01-15");

            //Enter Lead Title Name
            AddNewJobsHelper.Select("Jobtype", "Not Specified");

            //Enter Website
            AddNewJobsHelper.TypeText("Phone", "9986562352");

            //Enter No Of Employees
            AddNewJobsHelper.TypeText("Email", Email);

            //Select Industry
            AddNewJobsHelper.TypeText("Addressline1", "Addressline1");

            //Enter Annual Revenue
            AddNewJobsHelper.TypeText("Addressline2", "Addressline2");



            //############################# Job profile    #################################


            //Select Address Type
            AddNewJobsHelper.Select("Country", "USA");

            //Select Address Type
            AddNewJobsHelper.Select("State", "AR");

            //Enter Address Line1
            AddNewJobsHelper.TypeText("City", "Boston");
            //Enter Address Line2
            AddNewJobsHelper.TypeText("Zipcode", "12345");


            //############################# work Experience    #################################


            //Enter City
            AddNewJobsHelper.TypeText("Company", CandidateCompany);

            //Select State
            AddNewJobsHelper.ClickElement("currentlyworking");

            //Select County
            AddNewJobsHelper.TypeText("JobTitle", JOBTitle);
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Zip Code
            AddNewJobsHelper.Select("Careerlevel", "Team Lead");

            //Enter Zip Code
            AddNewJobsHelper.Select("Industry", "Advertising");

            //Enter City
            AddNewJobsHelper.TypeText("CityW", "Michigan");

            //Select Address Type
            AddNewJobsHelper.Select("CountrWy", "USA");

            //Select Address Type
            AddNewJobsHelper.Select("StateW", "AR");


            //Enter Address Line2
            AddNewJobsHelper.ClickElement("AddRemarklinkW");



            //##################   SKILL INFORMATION  #############################


            //Select Contact Salutation
            AddNewJobsHelper.TypeText("Skillname", "Java");

            //Select Contact Phone Type
            AddNewJobsHelper.Select("Skilltype", "Programming");

            //Enter Contact First Name
            AddNewJobsHelper.TypeText("Expyears", "5");

            //Enter Contact Middle Name
            AddNewJobsHelper.TypeText("Expmonths", "4");


            //##################  JOb preference #############################

            //Select Contact Email Type
            AddNewJobsHelper.Select("Travel", "25");

            //Select Contact Email Type
            AddNewJobsHelper.Select("Careerlevel", "Management");

            //Select Contact Email Type
            AddNewJobsHelper.Select("Industry1", "Art & Design");

            //Select Contact Email Type
            AddNewJobsHelper.Select("Jobtype1", "Not Specified");


            //Enter Zip Code
            AddNewJobsHelper.Select("Industry", "Advertising");

            //Enter City
            AddNewJobsHelper.TypeText("Cityj", "Michigan");

            //Select Address Type
            AddNewJobsHelper.Select("Countryj", "USA");

            //Select Address Type
            AddNewJobsHelper.Select("Statej", "AL");

            //#################################  Reference #############################



            //Enter Contact Phone Number
            AddNewJobsHelper.TypeText("RName", "Williams");

            //Enter Contact Phone Number
            AddNewJobsHelper.TypeText("RDesignation", "Manager");

            //Enter Contact Phone Number
            AddNewJobsHelper.TypeText("RCampanyname", "Polaris");

            //Enter Contact Phone Number
            AddNewJobsHelper.TypeText("RPhone", Number);

            //Enter Contact Phone Number
            AddNewJobsHelper.TypeText("REmail", Remail);

            //Save Candidate
            AddNewJobsHelper.ClickElement("ClickOnSave");


            //###################  LEADS ADD TO CAMPAIGN   #########################


            //Click on Bulk Update
            JobsBulkActionsHelper.TypeText("SearchCandidateCompany", "Test Candidate");
            JobsBulkActionsHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            JobsBulkActionsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            JobsBulkActionsHelper.MouseOver("Locator");


            //Click on Bulk Update
            JobsBulkActionsHelper.ClickElement("ClickOnAddToGroup");
            JobsBulkActionsHelper.WaitForWorkAround(4000);

            //Create New group
            JobsBulkActionsHelper.TypeText("AddGroup", Groupname);


            //Select Lead Group
            // JobsBulkActionsHelper.Select("SelectGroup", "10");

            //Enter Add New Lead Group Name
            // JobsBulkActionsHelper.TypeText("SelectGroup", "Test Group");

            //Click On Add Leads
            JobsBulkActionsHelper.ClickElement("ClickOnUpdategroup");

            JobsBulkActionsHelper.AcceptAlert();
            JobsBulkActionsHelper.WaitForWorkAround(10000);


        }
    }
}
