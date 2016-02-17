using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsCustomViewsCreate : DriverTestCase
    {
        [TestMethod]
        public void Jobscustomviewscreate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var JobsCustomViewsCreateHelper = new JobsCustomViewsCreateHelper(GetWebDriver());


            //Variable

            var JobscustomView = "Jobs Custom View" + RandomNumber(1, 99);



            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            JobsCustomViewsCreateHelper.ClickElement("Clickonjobs2");
            JobsCustomViewsCreateHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/jobs");
            //LeadsCustomViewsCreateHelper.WaitForWorkAround(7000);


            //Click on custom view link
            JobsCustomViewsCreateHelper.ClickElement("ClickOnCustomViews");
            JobsCustomViewsCreateHelper.WaitForWorkAround(3000);



            //Click on Add New
            JobsCustomViewsCreateHelper.ClickElement("ClickOnAddNew");


            //################### CREATE A CUSTOM VIEW #########################


            //Enter Custom View Name
            JobsCustomViewsCreateHelper.TypeText("EnterCustomViewName", JobscustomView);
            JobsCustomViewsCreateHelper.WaitForWorkAround(2000);

            //Select Sort By
            JobsCustomViewsCreateHelper.Select("SelectSortBy", "Status");


            //################### ADD SEARCH CRITERIA FIELDS #########################

            //Select Owner
            JobsCustomViewsCreateHelper.Select("SelectOwner", "Stephen");

            //Select Manager
            JobsCustomViewsCreateHelper.Select("SelectManager", "Stephen");

            //Select Status
            JobsCustomViewsCreateHelper.Select("SelectStatus", "New");

            //Select Source
            JobsCustomViewsCreateHelper.Select("SelectPriority", "High");

            //Select Category
            JobsCustomViewsCreateHelper.Select("SelectCareerlevel", "Lead Role");

            //Select Created By
            JobsCustomViewsCreateHelper.Select("SelectCreatedby", "Stephen");

            //Select Modified By
            JobsCustomViewsCreateHelper.Select("SelectModifiedby", "Stephen");

            //Select Partner
            JobsCustomViewsCreateHelper.Select("Selectworkshift", "Regular");

            //Select Group
            JobsCustomViewsCreateHelper.Select("SelectGroup", "12");
            

            //Enter Created Date
            //JobsCustomViewsCreateHelper.TypeText("SelectCreated", "2016-01-16");
            //JobsCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Modified Date
           // JobsCustomViewsCreateHelper.TypeText("SelectModified", "2016-01-16");
           // JobsCustomViewsCreateHelper.WaitForWorkAround(5000);



            //################### ADD ADDITIONAL CRITERIA FIELDS #########################


            //Select Additional Field
            JobsCustomViewsCreateHelper.Select("SelectAdditionalField1", "a.title:string");

            //Select Operator
            JobsCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            JobsCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Company");

            //Click On Add New Field
            JobsCustomViewsCreateHelper.ClickElement("ClickOnAddNewField");

            //Select Additional Field
            JobsCustomViewsCreateHelper.Select("SelectAdditionalField2", "a.country:string");

            //Select Operator
            JobsCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            JobsCustomViewsCreateHelper.TypeText("EnterAdditionalValue2", "USA");



            //Click on save
            JobsCustomViewsCreateHelper.ClickElement("ClickOnSave");
            JobsCustomViewsCreateHelper.WaitForWorkAround(10000);




        }
    }
}
