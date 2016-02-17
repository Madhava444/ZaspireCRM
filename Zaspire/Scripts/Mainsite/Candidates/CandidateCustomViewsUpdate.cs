using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateCustomViewsUpdate : DriverTestCase
    {
        [TestMethod]
        public void candidateCustomViewsUpdate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateCustomViewsCreateHelper = new CandidateCustomViewsCreateHelper(GetWebDriver());


            //Variable

            var CandidatecustomView = "Candidate Custom View" + RandomNumber(1, 99);



            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            //Click on Leads
            candidateCustomViewsCreateHelper.ClickElement("ClickOnCandidates");
           



            //Click on Add New
            candidateCustomViewsCreateHelper.ClickElement("ClickOnAddNew");


            //################### CREATE A CUSTOM VIEW #########################


            //Enter Custom View Name
            candidateCustomViewsCreateHelper.TypeText("EnterCustomViewName", CandidatecustomView);

            //Select Sort By
            candidateCustomViewsCreateHelper.Select("SelectSortBy", "Modified");


            //################### ADD SEARCH CRITERIA FIELDS #########################

            //Select Owner
            candidateCustomViewsCreateHelper.Select("SelectOwner", "Stephen");

            //Select Manager
            candidateCustomViewsCreateHelper.Select("SelectManager", "Stephen");

            //Select Status
            candidateCustomViewsCreateHelper.Select("SelectStatus", "Available");

            //Select Source
            //CandidateCustomViewsCreateHelper.Select("SelectSource", "Email");

            //Select Category
            //CandidateCustomViewsCreateHelper.Select("SelectCategory", "Testing");

            //Select Created By
            candidateCustomViewsCreateHelper.Select("SelectCreatedBy", "Stephen");

            //Select Modified By
            candidateCustomViewsCreateHelper.Select("SelectModifiedBy", "Stephen");

            //Select Partner
            //CandidateCustomViewsCreateHelper.Select("SelectPartner", "aspire");

            //Select Group
            //.Select("SelectGroup", "16");
            //CandidateCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Created Date
            candidateCustomViewsCreateHelper.TypeText("EnterCreated", "2015-11-16");
            candidateCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Modified Date
            candidateCustomViewsCreateHelper.TypeText("EnterModified", "2015-11-17");
            candidateCustomViewsCreateHelper.WaitForWorkAround(5000);



            //################### ADD ADDITIONAL CRITERIA FIELDS #########################


            //Select Additional Field
            candidateCustomViewsCreateHelper.Select("SelectAdditionalField1", "a.title:string");

            //Select Operator
            candidateCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            candidateCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Test");

            //Click On Add New Field
            candidateCustomViewsCreateHelper.ClickElement("ClickOnAddNewField");

            //Select Additional Field
            candidateCustomViewsCreateHelper.Select("SelectAdditionalField1", "a.city:string");

            //Select Operator
            candidateCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            candidateCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Michigan");



            //Click on Leads
            candidateCustomViewsCreateHelper.ClickElement("ClickOnSave");
            candidateCustomViewsCreateHelper.WaitForWorkAround(10000);



            
           
            //Click on Edit
            candidateCustomViewsCreateHelper.ClickElement("ClickOnEdit");


            //Select Sort By
            candidateCustomViewsCreateHelper.Select("SelectSortBy", "Email");



            //Select Status
            candidateCustomViewsCreateHelper.Select("SelectStatus", "Submitted");


            //Click on Leads
            candidateCustomViewsCreateHelper.ClickElement("ClickOnSave");
            candidateCustomViewsCreateHelper.WaitForWorkAround(10000);











        }
    }
}