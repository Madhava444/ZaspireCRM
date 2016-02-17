using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class NotesCustomViewUpdate : DriverTestCase
    {
        [TestMethod]
        public void notescustomviewupdate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var NotesCustomViewsHelper = new NotesCustomViewsHelper(GetWebDriver());

            //Variable

            var CustomView = "Test Custom View" + RandomNumber(1, 99);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Activities
            NotesCustomViewsHelper.ClickElement("ClickOnActivitiess");

            //Click on Notes
            NotesCustomViewsHelper.ClickElement("ClickOnNotes");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/notes");
            //NotesCustomViewsHelper.WaitForWorkAround(7000);

            //Click on Custom Views
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Click on Edit
            NotesCustomViewsHelper.ClickElement("ClickOnEdit");

            //Enter Custom View Name
            NotesCustomViewsHelper.TypeText("EnterCustomViewName", CustomView);

            //Select Result per Page
            NotesCustomViewsHelper.Select("SelectResultPerPage", "20");

            //Select Sort By
            NotesCustomViewsHelper.Select("SelectSortBy", "Modified");

            //Select Owner
            NotesCustomViewsHelper.Select("SelectOwner", "madhava");

            //Select Related To
            NotesCustomViewsHelper.Select("SelectRelatedTo", "Opportunities");

            //Select Category
            NotesCustomViewsHelper.Select("SelectCategory", "34163");

            //Select Created By
            NotesCustomViewsHelper.Select("SelectCreatedBy", "madhava");

            //Select Modified By
            NotesCustomViewsHelper.Select("SelectModifiedBy", "madhava");

            //Select Created Date
            NotesCustomViewsHelper.Select("SelectCreatedDate", "");

            //Select Modified Date
            NotesCustomViewsHelper.Select("SelectModifiedDate", "");


            //Select Additional Field1
            NotesCustomViewsHelper.Select("SelectAdditionalField1", "a.parent_name:string");

            //Select Operator1
            NotesCustomViewsHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value1
            NotesCustomViewsHelper.TypeText("EnterAdditionalValue1", "Opportunities");

            //Click On Add New Field 
            NotesCustomViewsHelper.ClickElement("ClickOnAddNewField");

            //Select Additional Field2
            NotesCustomViewsHelper.Select("SelectAdditionalField2", "a.name:string");

            //Select Operator2
            NotesCustomViewsHelper.Select("SelectOperator2", "cn");

            //Enter Additional Value2
            NotesCustomViewsHelper.TypeText("EnterAdditionalValue2", "Test Note");


            //Click On Save
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViewUpdateSave");
            NotesCustomViewsHelper.WaitForWorkAround(10000);


        }
    }
}