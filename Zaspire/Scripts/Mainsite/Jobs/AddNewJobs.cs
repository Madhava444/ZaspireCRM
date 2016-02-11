using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddNewJobs : DriverTestCase
    {
        [TestMethod]
        public void addnewJob()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewjobsHelper = new AddNewjobsHelper(GetWebDriver());

            //Variable
            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var CompanyName = "Test Company" + RandomNumber(1, 99);
            var CandidateTitle = "Test Title" + RandomNumber(1, 99);
            var JOBTitle = "jOB Title" + RandomNumber(1, 99);
            var contactEmail = "Test" + RandomNumber(1, 99) + "@gmail.com";
           

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddNewjobsHelper.ClickElement("ClickonJobs");

            //().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/addnew");
           // AddNewjobsHelper.WaitForWorkAround(7000);


            //#################### CREATE A LEAD   #####################################

            //Create on Lead
            AddNewjobsHelper.ClickElement("Clickonnewbutton");


            //################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Status
            AddNewjobsHelper.Select("Source", "Email");

            //Select Category
            AddNewjobsHelper.Select("Catergory", "27909");

            //Select Priority
            AddNewjobsHelper.Select("priority", "High");



            //Select Source
            AddNewjobsHelper.Select("Source", "Email");

            //Select Owner  
            AddNewjobsHelper.Select("Owner", "101");

            //Select Manager
            AddNewjobsHelper.Select("Manager", "101");

            //####################### Job Profile  #############################

            //Select Partner
           // AddNewjobsHelper.Select("relatedTo" , "16");


            //Click Mergebutton
            //AddNewjobsHelper.ClickElement("Assignrecord");


            //Select Record on Pop-up
            //AddNewjobsHelper.ClickElement("SelectRecord");

            //EnterCompany
            AddNewjobsHelper.TypeText("Company", CompanyName);

           // Click Hide company
            AddNewjobsHelper.ClickElement("Hidecompany");

            //Enter Job Title
            AddNewjobsHelper.TypeText("Title", JOBTitle);

            //Enter No of postioins
            AddNewjobsHelper.TypeText("Noofpositions", "20");

            //Enter Referencecode
            AddNewjobsHelper.TypeText("Referencecode", "501");

            //Enter Company Name
            AddNewjobsHelper.TypeText("Listingdate", "2016-01-26");

            //Enter Lead Title Name
            AddNewjobsHelper.Select("Industry", "Advertising");

            //Enter Department Name
            AddNewjobsHelper.TypeText("CompanyWebsite", "www.samplesite.com");

            //Enter Lead Title Name
            AddNewjobsHelper.Select("Education", "M.Tech");

            //Enter Website
            AddNewjobsHelper.Select("CareerLevel", "Lead Role");

            //Enter No Of Employees
            AddNewjobsHelper.TypeText("PositionURL", "www.samplepostion/manager.com");

            //Enter Website
            AddNewjobsHelper.Select("WorkShift", "Flexible");

            //Select Industry
            AddNewjobsHelper.TypeText("RequiredExpinyears", "5");

            //Enter Annual Revenue
            AddNewjobsHelper.TypeText("RequiredExpinmonths", "8");



            //############################# Job Type & Compensation    #################################


            //Select Address Type
            AddNewjobsHelper.Select("JobType", "Not Specified");

            //#############################  <!-- Job Location-->   #################################
            //Enter Address Line1
            AddNewjobsHelper.TypeText("City", "Boston");

            //Select Address Type
            AddNewjobsHelper.Select("State", "CO");

            //Enter Address Line1
            AddNewjobsHelper.Select("Country", "USA");
            
            //Enter Address Line2
            AddNewjobsHelper.TypeText("Zipcode", "12345");


   //############################# Desired Skills & Certifications    #################################


            //Select Contact Salutation
            AddNewjobsHelper.TypeText("Skillname", "Java");

            //Select Contact Phone Type
            AddNewjobsHelper.Select("Skilltype", "Programming");

            //Enter Contact First Name
            AddNewjobsHelper.TypeText("Expyears", "5");

            //Enter Contact Middle Name
            AddNewjobsHelper.TypeText("Expmonths", "4");
            AddNewjobsHelper.WaitForWorkAround(3000);

        //#####################  Contact info--> ###################

            //Expand contacttab
            //AddNewjobsHelper.ClickElement("Contacttabexpand");
            //Expand the contact tag manually while running the scripts


            //Select State
            AddNewjobsHelper.Select("USalutation"  , "Mr" );

            //Select County
            AddNewjobsHelper.TypeText("UFirstname", FirstName);
            
            //Enter Zip Code
            AddNewjobsHelper.TypeText("ULastname", "LastName");

            //Enter Zip Code
            AddNewjobsHelper.TypeText("Email", contactEmail);

            //Enter City
            AddNewjobsHelper.TypeText("Phone", "9856236598");

            //Select Address Type
            AddNewjobsHelper.TypeText("Addressline1", "Streeno90");

            //Select Address Type
            AddNewjobsHelper.TypeText("Addressline2", "Roadno56");

            //Enter Address Line1
            AddNewjobsHelper.TypeText("CCity", "Boston");

            //Select Address Type
            AddNewjobsHelper.Select("CState", "CO");

            //Enter Address Line1
            AddNewjobsHelper.Select("CCountry", "USA");

            //Enter Address Line2
            AddNewjobsHelper.TypeText("CZipcode", "12345");


            //Save Candidate
            AddNewjobsHelper.ClickElement("ClickOnSave");




      }
    }
}

