using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsUpdate : DriverTestCase
    {
        [TestMethod]
        public void jobsupdate()
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
            var jobsbulkactionshelper = new JobsBulkActionsHelper(GetWebDriver());
            var jobsIndexPageActionsHelper = new JobsIndexPageActionsHelper(GetWebDriver());


            //Variable

            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var JobTitle = "Title" + RandomNumber(1, 99);
            var JobsCompany = "Test Company" + RandomNumber(1, 99);
            var JOBTitle = "Test Title" + RandomNumber(1, 99);
            var contactEmail = "Test" + RandomNumber(1, 99) + "@gmail.com";
            var Number = "12345678" + RandomNumber(10, 99);
            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddNewjobsHelper.ClickElement("ClickonJobs");

            //Click on First job
            jobsIndexPageActionsHelper.MouseOver("locators");

            //Clock On Quick Look
            jobsIndexPageActionsHelper.ClickElement("ClickOnQuickLook");

            //Clock On Quick Look Edit
            jobsIndexPageActionsHelper.ClickElement("ClickOnQuickLookEdit");
            jobsIndexPageActionsHelper.WaitForWorkAround(10000);
            

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/addnew");
            //AddNewjobsHelper.WaitForWorkAround(7000);

            //Select Status
            AddNewjobsHelper.Select("Status", "In Progress");

            //Select Category
            AddNewjobsHelper.Select("Catergory", "27918");

            //Select Priority
            AddNewjobsHelper.Select("priority", "Medium");



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
            AddNewjobsHelper.TypeText("Company", JobsCompany);

            // Click Hide company
            //AddNewjobsHelper.ClickElement("Hidecompany");

            //Enter Job Title
            AddNewjobsHelper.TypeText("Title", JOBTitle);

            //Enter No of postioins
            AddNewjobsHelper.TypeText("Noofpositions", "10");

            //Enter Referencecode
            AddNewjobsHelper.TypeText("Referencecode", "52563");

            //Enter Company Name
            AddNewjobsHelper.TypeText("Listingdate", "2016-01-28");

            //Enter Lead Title Name
            AddNewjobsHelper.Select("Industry", "Aerospace & Defense");

            //Enter Department Name
            AddNewjobsHelper.TypeText("CompanyWebsite", "www.testsiteupdte.com");

            //Enter Lead Title Name
            AddNewjobsHelper.Select("Education", "B.Tech");

            //Enter Website
            AddNewjobsHelper.Select("CareerLevel", "Management");

            //Enter No Of Employees
            AddNewjobsHelper.TypeText("PositionURL", "www.testupdtejob/manager.com");

            //Enter Website
            AddNewjobsHelper.Select("WorkShift", "Morning");

            //Select Industry
            AddNewjobsHelper.TypeText("RequiredExpinyears", "6");

            //Enter Annual Revenue
            AddNewjobsHelper.TypeText("RequiredExpinmonths", "0");



            //############################# Job Type & Compensation    #################################


            //Select Address Type
            AddNewjobsHelper.Select("JobType", "Not Specified");

            //#############################  <!-- Job Location-->   #################################
            //Enter Address Line1
            AddNewjobsHelper.TypeText("City", "Michigan");

            //Select Address Type
            AddNewjobsHelper.Select("State", "AL");

            //Enter Address Line1
            AddNewjobsHelper.Select("Country", "USA");

            //Enter Address Line2
            AddNewjobsHelper.TypeText("Zipcode", "96323");


            //############################# Desired Skills & Certifications    #################################


            //Select Contact Salutation
            AddNewjobsHelper.TypeText("Skillname", "PHP");

            //Select Contact Phone Type
            AddNewjobsHelper.Select("Skilltype", "Programming");

            //Enter Contact First Name
            AddNewjobsHelper.TypeText("Expyears", "6");

            //Enter Contact Middle Name
            AddNewjobsHelper.TypeText("Expmonths", "4");
            AddNewjobsHelper.WaitForWorkAround(3000);

            //#####################  Contact info--> ###################

            //Expand contacttab
            //AddNewjobsHelper.ClickElement("Contacttabexpand");

            

            //Select State
            AddNewjobsHelper.Select("USalutation", "Mr");

            //Select County
            AddNewjobsHelper.TypeText("UFirstname", FirstName);

            //Enter Zip Code
            AddNewjobsHelper.TypeText("ULastname", "Fedrick");

            //Enter Zip Code
            AddNewjobsHelper.TypeText("Email", contactEmail);

            //Enter City
            AddNewjobsHelper.TypeText("UpdatePhone", "9856238956");

            //Select Address Type
            AddNewjobsHelper.TypeText("Addressline1", "Oldlancer");

            //Select Address Type
            AddNewjobsHelper.TypeText("Addressline2", "Nearapollo");

            //Enter Address Line1
            AddNewjobsHelper.TypeText("CCity", "Losangles");

            //Select Address Type
            AddNewjobsHelper.Select("CState", "CO");

            //Enter Address Line1
            AddNewjobsHelper.Select("CCountry", "USA");

            //Enter Address Line2
            AddNewjobsHelper.TypeText("CZipcode", "02136");


            //Save Candidate
            AddNewjobsHelper.ClickElement("ClickOnUpdateSave");

            VerifyTitle("Job updated successfully.");
            


        }
    }
}

