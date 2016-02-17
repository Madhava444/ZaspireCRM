using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class NotesCustomViewActions : DriverTestCase
    {
        [TestMethod]
        public void notescustomviewactions()
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

            
//#########################  CREATE CUSTOM VIEW #################################


            //Click on Custom Views
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Click on New Button
            NotesCustomViewsHelper.ClickElement("ClickOnNewButton");

            //Enter Custom View Name
            NotesCustomViewsHelper.TypeText("EnterCustomViewName", CustomView);

            //Select Result per Page
            NotesCustomViewsHelper.Select("SelectResultPerPage", "20");

            //Select Sort By
            NotesCustomViewsHelper.Select("SelectSortBy", "Modified");

            //Select Owner
            NotesCustomViewsHelper.Select("SelectOwner", "Ranjith");

            //Select Related To
            NotesCustomViewsHelper.Select("SelectRelatedTo", "Accounts");

            //Select Category
            NotesCustomViewsHelper.Select("SelectCategory", "12186");

            //Select Created By
            NotesCustomViewsHelper.Select("SelectCreatedBy", "Ranjith");

            //Select Modified By
            NotesCustomViewsHelper.Select("SelectModifiedBy", "Ranjith");

            //Select Created Date
            NotesCustomViewsHelper.Select("SelectCreatedDate", "2016-2-17");

            //Select Modified Date
            NotesCustomViewsHelper.Select("SelectModifiedDate", "2016-2-18");


            //Select Additional Field1
            NotesCustomViewsHelper.Select("SelectAdditionalField1", "a.parent_name:string");

            //Select Operator1
            NotesCustomViewsHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value1
            NotesCustomViewsHelper.TypeText("EnterAdditionalValue1", "Accounts");

            //Click On Add New Field 
            NotesCustomViewsHelper.ClickElement("ClickOnAddNewField");

            //Select Additional Field2
            NotesCustomViewsHelper.Select("SelectAdditionalField2", "a.name:string");

            //Select Operator2
            NotesCustomViewsHelper.Select("SelectOperator2", "cn");

            //Enter Additional Value2
            NotesCustomViewsHelper.TypeText("EnterAdditionalValue2", "Test Note");


            //Click On Save
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViewNewSave");
            NotesCustomViewsHelper.WaitForWorkAround(10000);



//######################  CUSTOM VIEW ACTIONS   #################################


            
                       
            //Click On Set As Default Custom View
            NotesCustomViewsHelper.ClickElement("ClickOnSetAsDefault");
            NotesCustomViewsHelper.WaitForWorkAround(10000);

            //Click On Unset Default Custom View
            NotesCustomViewsHelper.ClickElement("ClickOnUnsetDefault");
            NotesCustomViewsHelper.WaitForWorkAround(10000);

            //Clock On Edit Custom View
            NotesCustomViewsHelper.ClickElement("ClickOnEditLink");

            //Clock On Edit Custom View cancel button
            NotesCustomViewsHelper.ClickElement("ClickOnEditCancel");


            //Click on Custom Views Dropdown
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViewsDropdown");
            NotesCustomViewsHelper.WaitForWorkAround(5000);

            //Enter Search Custom Views Name
            NotesCustomViewsHelper.TypeText("EnterSearchCustomViewsName", CustomView);
            NotesCustomViewsHelper.WaitForWorkAround(5000);

            //Click on Custom Views Dropdown
            NotesCustomViewsHelper.ClickElement("ClickOnFirstCustomViewName");
            NotesCustomViewsHelper.WaitForWorkAround(10000);

            
            //Clock On New Custom View
            NotesCustomViewsHelper.ClickElement("ClickOnNew");

            //Clock On New Custom View cancel button
            NotesCustomViewsHelper.ClickElement("ClickOnNewCancel");


            //Click on Custom Views Dropdown
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViewsDropdown");
            NotesCustomViewsHelper.WaitForWorkAround(5000);

            //Enter Search Custom Views Name
            NotesCustomViewsHelper.TypeText("EnterSearchCustomViewsName", CustomView);
            NotesCustomViewsHelper.WaitForWorkAround(5000);

            //Click on Custom Views Dropdown
            NotesCustomViewsHelper.ClickElement("ClickOnFirstCustomViewName");
            NotesCustomViewsHelper.WaitForWorkAround(10000);


            //Clock On Delete Custom View
            NotesCustomViewsHelper.ClickElement("ClickOnDeleteLink");


            NotesCustomViewsHelper.AcceptAlert();
            NotesCustomViewsHelper.WaitForWorkAround(10000);


        }
    }
}