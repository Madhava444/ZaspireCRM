using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesCustomViewsCreate : DriverTestCase
    {
        [TestMethod]
        public void opportunitiescustomviewscreate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesCustomViewsCreateHelper = new OpportunitiesCustomViewsCreateHelper(GetWebDriver());


            //Variable

            var OpportunityCustomView = "Opportunity Custom View" + RandomNumber(1, 99);



            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Opportunities
            OpportunitiesCustomViewsCreateHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesCustomViewsCreateHelper.WaitForWorkAround(10000);

            //Click on Opportunities Custom Views
            OpportunitiesCustomViewsCreateHelper.ClickElement("ClickOnCustomViews");
            OpportunitiesCustomViewsCreateHelper.WaitForWorkAround(10000);

            //Click on Add New
            OpportunitiesCustomViewsCreateHelper.ClickElement("ClickOnAddNew");


//################### CREATE A CUSTOM VIEW #########################


            //Enter Custom View Name
            OpportunitiesCustomViewsCreateHelper.TypeText("EnterCustomViewName", OpportunityCustomView);

            //Select Sort By
            OpportunitiesCustomViewsCreateHelper.Select("SelectSortBy", "Modified");


//################### ADD SEARCH CRITERIA FIELDS #########################
            
            //Select Owner
            OpportunitiesCustomViewsCreateHelper.Select("SelectOwner", "Ranjith");

            //Select Manager
            OpportunitiesCustomViewsCreateHelper.Select("SelectManager", "Ranjith");

            //Select Status
            OpportunitiesCustomViewsCreateHelper.Select("SelectStatus", "New");

            //Select Source
            OpportunitiesCustomViewsCreateHelper.Select("SelectSource", "Email");

            //Select Category
            OpportunitiesCustomViewsCreateHelper.Select("SelectCategory", "Testing");

            //Select Created By
            OpportunitiesCustomViewsCreateHelper.Select("SelectCreatedBy", "Ranjith");

            //Select Modified By
            OpportunitiesCustomViewsCreateHelper.Select("SelectModifiedBy", "Ranjith");

            //Select Group
            OpportunitiesCustomViewsCreateHelper.Select("SelectGroup", "15");
            OpportunitiesCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Created Date
            OpportunitiesCustomViewsCreateHelper.Select("EnterCreated", "2015-1-16");
            OpportunitiesCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Modified Date
            OpportunitiesCustomViewsCreateHelper.Select("EnterModified", "2015-1-17");
            OpportunitiesCustomViewsCreateHelper.WaitForWorkAround(5000);



//################### ADD ADDITIONAL CRITERIA FIELDS #########################


            //Select Additional Field
            OpportunitiesCustomViewsCreateHelper.Select("SelectAdditionalField1", "d.city:string");

            //Select Operator
            OpportunitiesCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            OpportunitiesCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Test");

            //Click On Add New Field
            OpportunitiesCustomViewsCreateHelper.ClickElement("ClickOnAddNewField");

            //Select Additional Field
            OpportunitiesCustomViewsCreateHelper.Select("SelectAdditionalField1", "a.industry:string");

            //Select Operator
            OpportunitiesCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            OpportunitiesCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Dept");



            //Click on Opportunities
            OpportunitiesCustomViewsCreateHelper.ClickElement("ClickOnSave");
            OpportunitiesCustomViewsCreateHelper.WaitForWorkAround(10000);




        }
    }
}
