using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateCustomViewsCreate : DriverTestCase
    {
        [TestMethod]
        public void Candidatecustomviewscreate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CandidateCustomViewsCreateHelper = new CandidateCustomViewsCreateHelper(GetWebDriver());


            //Variable

            var CandidatecustomView = "Candidate Custom View" + RandomNumber(1, 99);



            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            CandidateCustomViewsCreateHelper.ClickElement("ClickOnCandidates");
            CandidateCustomViewsCreateHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //LeadsCustomViewsCreateHelper.WaitForWorkAround(7000);

            

            //Click on Add New
            CandidateCustomViewsCreateHelper.ClickElement("ClickOnAddNew");


//################### CREATE A CUSTOM VIEW #########################


            //Enter Custom View Name
            CandidateCustomViewsCreateHelper.TypeText("EnterCustomViewName", CandidatecustomView);

            //Select Sort By
            CandidateCustomViewsCreateHelper.Select("SelectSortBy", "Modified");


//################### ADD SEARCH CRITERIA FIELDS #########################
            
            //Select Owner
            CandidateCustomViewsCreateHelper.Select("SelectOwner", "Stephen");

            //Select Manager
            CandidateCustomViewsCreateHelper.Select("SelectManager", "Stephen");

            //Select Status
            CandidateCustomViewsCreateHelper.Select("SelectStatus", "Available");

            //Select Source
            //CandidateCustomViewsCreateHelper.Select("SelectSource", "Email");

            //Select Category
            //CandidateCustomViewsCreateHelper.Select("SelectCategory", "Testing");

            //Select Created By
            CandidateCustomViewsCreateHelper.Select("SelectCreatedBy", "Stephen");

            //Select Modified By
            CandidateCustomViewsCreateHelper.Select("SelectModifiedBy", "Stephen");

            //Select Partner
            //CandidateCustomViewsCreateHelper.Select("SelectPartner", "aspire");

            //Select Group
            //.Select("SelectGroup", "16");
            //CandidateCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Created Date
            CandidateCustomViewsCreateHelper.TypeText("EnterCreated", "2015-11-16");
            CandidateCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Modified Date
            CandidateCustomViewsCreateHelper.TypeText("EnterModified", "2015-11-17");
            CandidateCustomViewsCreateHelper.WaitForWorkAround(5000);



//################### ADD ADDITIONAL CRITERIA FIELDS #########################


            //Select Additional Field
            CandidateCustomViewsCreateHelper.Select("SelectAdditionalField1", "a.title:string");

            //Select Operator
            CandidateCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            CandidateCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Test");

            //Click On Add New Field
            CandidateCustomViewsCreateHelper.ClickElement("ClickOnAddNewField");

            //Select Additional Field
            CandidateCustomViewsCreateHelper.Select("SelectAdditionalField1", "a.city:string");

            //Select Operator
            CandidateCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            CandidateCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Michigan");



            //Click on Leads
            CandidateCustomViewsCreateHelper.ClickElement("ClickOnSave");
            CandidateCustomViewsCreateHelper.WaitForWorkAround(10000);




        }
    }
}