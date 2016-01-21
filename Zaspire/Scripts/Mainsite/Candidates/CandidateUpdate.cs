using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateUpdate : DriverTestCase
    {
        [TestMethod]
        public void candidateupdate()
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

            //Variable

            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var CandidateTitle = "Title" + RandomNumber(1, 99);
            var CandidateCompany = "Test Company" + RandomNumber(1, 99);
            var JOBTitle = "Test Title" + RandomNumber(1, 99);
            var Email = "Test" + RandomNumber(1, 99) + "@gmail.com";
            var Number = "12345678" + RandomNumber(10, 99);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddNewcandidateHelper.ClickElement("ClickonCandidate");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //AddNewcandidateHelper.WaitForWorkAround(7000);


//#################### UPDATE LEAD   #####################################

            //Open Lead
            AddNewcandidateHelper.ClickElement("ClickonCandidate");

            //Click on Candidate
            AddNewcandidateHelper.ClickElement("ClickCandidate");

            //Go to candidat updatepage
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates/update/7007");

            //Click On Edit link
            //AddNewcandidateHelper.ClickElement("ClickOnEditLink");


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
            AddNewcandidateHelper.TypeText("Email", "abc@gmail.com");

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
            AddNewcandidateHelper.TypeText("From"  , "2010-5-20");

            //Select State
            AddNewcandidateHelper.TypeText("To"  , "2015-12-31");


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
            //AddNewcandidateHelper.ClickElement("AddRemarklinkW");



            //##################   SKILL INFORMATION  #############################


            //Select Contact Salutation
            AddNewcandidateHelper.TypeText("Skillname", "C#.Net");

            //Select Contact Phone Type
            AddNewcandidateHelper.Select("Skilltype", "Certification");

            //Enter Contact First Name
            AddNewcandidateHelper.TypeText("Expyears", "4");

            //Enter Contact Middle Name
            AddNewcandidateHelper.TypeText("Expmonths", "6");


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
            AddNewcandidateHelper.TypeText("Cityj", "Michigan");

            //Select Address Type
            AddNewcandidateHelper.Select("Countryj", "USA");

            //Select Address Type
            AddNewcandidateHelper.Select("Statej", "AL");

            //#################################  Reference #############################



            //Enter Contact Phone Number
            AddNewcandidateHelper.TypeText("RName", "James");

            //Enter Contact Phone Number
            AddNewcandidateHelper.TypeText("RDesignation", "Teamlead");

            //Enter Contact Phone Number
            AddNewcandidateHelper.TypeText("RCampanyname", "Novartis");

            //Enter Contact Phone Number
            AddNewcandidateHelper.TypeText("RPhone", Number);

            //Enter Contact Phone Number
            AddNewcandidateHelper.TypeText("REmail", "james123@gmail.com");

            //Save Candidate
            AddNewcandidateHelper.ClickElement("ClickOnSave"); 
            AddNewcandidateHelper.WaitForWorkAround(10000);


        }
    }
}
