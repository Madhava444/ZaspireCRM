using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class CandidateBulkUpdate : DriverTestCase
    {
        [TestMethod]
        public void candidateBulkUpdate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewcandidateHelper = new AddNewCandidateHelper(GetWebDriver());
            var CandidateBulkActionsHelper = new CandidateBulkActionsHelper(GetWebDriver());
        
            
            //Variable

            //Variable
            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var CandidateCompany = "Test Company" + RandomNumber(1, 99);
            var CandidateTitle = "Test Candidate" + RandomNumber(1, 99);
            var JOBTitle = "jOB Title" + RandomNumber(1, 99);
            var Email = "Test" + RandomNumber(1, 99) + "@yahoo.com";
            var Number = "12345678" + RandomNumber(10, 99);
            var Remail = "Remail"  + RandomNumber(1, 99) + "@gmail.com";

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddNewcandidateHelper.ClickElement("ClickonCandidate");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates/addnew");
            AddNewcandidateHelper.WaitForWorkAround(7000);


            //#################### CREATE A LEAD   #####################################

            //Create on Lead
            //AddNewcandidateHelper.ClickElement("ClickOnLeadAddNew");


            //################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Status
            AddNewcandidateHelper.Select("Source", "Internal");

            //Select Source
            AddNewcandidateHelper.Select("Status", "Confirmed");

            //Select Owner  
            AddNewcandidateHelper.Select("Owner", "101");

            //Select Manager
            AddNewcandidateHelper.Select("Manager", "101");

            //Select Partner
            AddNewcandidateHelper.ClickElement("Hotlist");


            //Select Partner
            //AddNewcandidateHelper.ClickElement("Blocklist");


            //####################### LEAD DETAILS  #############################

            //EnterTitle
            AddNewcandidateHelper.TypeText("Title", CandidateTitle);

            //Select Salutation
            AddNewcandidateHelper.Select("Salutation", "Mr");

            //Enter First Name
            AddNewcandidateHelper.TypeText("Firstname", FirstName);

            //Enter Middle Name
            AddNewcandidateHelper.TypeText("Lastname", "Mark");

            //Enter Last Name
            AddNewcandidateHelper.Select("Education", "M.Tech");

            //Enter Company Name
            AddNewcandidateHelper.TypeText("Totlaexpyears", "5");

            //Enter Company Name
            AddNewcandidateHelper.TypeText("Totlaexpyears", "6");

            //Enter Lead Title Name
            AddNewcandidateHelper.Select("Visatype", "GreenCard");

            //Enter Department Name
            AddNewcandidateHelper.TypeText("Visaexpdate", "2016-01-15");

            //Enter Lead Title Name
            AddNewcandidateHelper.Select("Jobtype", "Not Specified");

            //Enter Website
            AddNewcandidateHelper.TypeText("Phone", "9986562352");

            //Enter No Of Employees
            AddNewcandidateHelper.TypeText("Email", Email);

            //Select Industry
            AddNewcandidateHelper.TypeText("Addressline1", "Addressline1");

            //Enter Annual Revenue
            AddNewcandidateHelper.TypeText("Addressline2", "Addressline2");



            //############################# Job profile    #################################


            //Select Address Type
            AddNewcandidateHelper.Select("Country", "USA");

            //Select Address Type
            AddNewcandidateHelper.Select("State", "AR");

            //Enter Address Line1
            AddNewcandidateHelper.TypeText("City", "Boston");
            //Enter Address Line2
            AddNewcandidateHelper.TypeText("Zipcode", "12345");


            //############################# work Experience    #################################


            //Enter City
            AddNewcandidateHelper.TypeText("Company", CandidateCompany);

            //Select State
            AddNewcandidateHelper.ClickElement("currentlyworking");

            //Select County
            AddNewcandidateHelper.TypeText("JobTitle", JOBTitle);
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Zip Code
            AddNewcandidateHelper.Select("Careerlevel", "Team Lead");

            //Enter Zip Code
            AddNewcandidateHelper.Select("Industry", "Advertising");

            //Enter City
            AddNewcandidateHelper.TypeText("CityW", "Michigan");

            //Select Address Type
            AddNewcandidateHelper.Select("CountrWy", "USA");

            //Select Address Type
            AddNewcandidateHelper.Select("StateW", "AR");


            //Enter Address Line2
            AddNewcandidateHelper.ClickElement("AddRemarklinkW");



            //##################   SKILL INFORMATION  #############################


            //Select Contact Salutation
            AddNewcandidateHelper.TypeText("Skillname", ".Net");

            //Select Contact Phone Type
            AddNewcandidateHelper.Select("Skilltype", "Certification");

            //Enter Contact First Name
            AddNewcandidateHelper.TypeText("Expyears", "5");

            //Enter Contact Middle Name
            AddNewcandidateHelper.TypeText("Expmonths", "4");


            //##################  JOb preference #############################

            //Select Contact Email Type
            AddNewcandidateHelper.Select("Travel", "25");

            //Select Contact Email Type
            AddNewcandidateHelper.Select("Careerlevel", "Management");

            //Select Contact Email Type
            AddNewcandidateHelper.Select("Industry1", "Art & Design");

            //Select Contact Email Type
            AddNewcandidateHelper.Select("Jobtype1", "Not Specified");


            //Enter Zip Code
            AddNewcandidateHelper.Select("Industry", "Advertising");

            //Enter City
            AddNewcandidateHelper.TypeText("Cityj", "Boston");

            //Select Address Type
            AddNewcandidateHelper.Select("Countryj", "USA");

            //Select Address Type
            AddNewcandidateHelper.Select("Statej", "AL");

            //#################################  Reference #############################



            //Enter Contact Phone Number
            AddNewcandidateHelper.TypeText("RName", "Milinda");

            //Enter Contact Phone Number
            AddNewcandidateHelper.TypeText("RDesignation", "Technicalassistant");

            //Enter Contact Phone Number
            AddNewcandidateHelper.TypeText("RCampanyname", "Lava");

            //Enter Contact Phone Number
            AddNewcandidateHelper.TypeText("RPhone", Number);

            //Enter Contact Phone Number
            AddNewcandidateHelper.TypeText("REmail", Remail);

            //Save Candidate
            AddNewcandidateHelper.ClickElement("ClickOnSave");



//################### LEAD BULK UPDATE  #########################

            
            //Click on Bulk Update
            CandidateBulkActionsHelper.TypeText("SearchCandidateCompany", "Test Candidate");
            CandidateBulkActionsHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            CandidateBulkActionsHelper.ClickElement("ClickOnMasterCheckBox");
            
            //Click on Move over
            CandidateBulkActionsHelper.MouseOver("Locator");
            

            //Click on Bulk Update
            CandidateBulkActionsHelper.ClickElement("ClickOnBulkUpdate");
            CandidateBulkActionsHelper.WaitForWorkAround(4000);

            //Select Status
            CandidateBulkActionsHelper.Select("SelectStatus", "Available");

            //Select Source
            CandidateBulkActionsHelper.Select("SelectSource", "Internal");

            
            //Select Owner
            //CandidateBulkActionsHelper.Select("SelectOwner", "57");

            //Select Manager
            //CandidateBulkActionsHelper.Select("SelectManager", "58");

            //Click on Update
            CandidateBulkActionsHelper.ClickElement("ClickOnUpdate");
            CandidateBulkActionsHelper.WaitForWorkAround(4000);

            CandidateBulkActionsHelper.AcceptAlert();
            CandidateBulkActionsHelper.WaitForWorkAround(10000);


        }
    }
}