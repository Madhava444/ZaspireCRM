using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsCustomViewActions : DriverTestCase
    {
        [TestMethod]
        public void leadscustomviewactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsCustomViewActionsHelper = new LeadsCustomViewActionsHelper(GetWebDriver());
            var LeadsCustomViewsCreateHelper = new LeadsCustomViewsCreateHelper(GetWebDriver());

            //Variable
            var LeadCustomView = "Lead Custom View" + RandomNumber(1, 99);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            LeadsCustomViewActionsHelper.ClickElement("ClickOnLeads");
            LeadsCustomViewActionsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsCustomViewActionsHelper.WaitForWorkAround(7000);

            
//################### CREATE A CUSTOM VIEW #########################


            //Click on Leads Custom Views
            LeadsCustomViewsCreateHelper.ClickElement("ClickOnCustomViews");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(10000);

            //Click on Add New
            LeadsCustomViewsCreateHelper.ClickElement("ClickOnAddNew");

            
            //Enter Custom View Name
            LeadsCustomViewsCreateHelper.TypeText("EnterCustomViewName", LeadCustomView);

            //Select Sort By
            LeadsCustomViewsCreateHelper.Select("SelectSortBy", "Modified");


            //################### ADD SEARCH CRITERIA FIELDS #########################

            //Select Owner
            LeadsCustomViewsCreateHelper.Select("SelectOwner", "Ranjith");

            //Select Manager
            LeadsCustomViewsCreateHelper.Select("SelectManager", "Ranjith");

            //Select Status
            LeadsCustomViewsCreateHelper.Select("SelectStatus", "New");

            //Select Source
            LeadsCustomViewsCreateHelper.Select("SelectSource", "Email");

            //Select Category
            LeadsCustomViewsCreateHelper.Select("SelectCategory", "Testing");

            //Select Created By
            LeadsCustomViewsCreateHelper.Select("SelectCreatedBy", "Ranjith");

            //Select Modified By
            LeadsCustomViewsCreateHelper.Select("SelectModifiedBy", "Ranjith");

            //Select Partner
            LeadsCustomViewsCreateHelper.Select("SelectPartner", "aspire");

            //Select Group
            LeadsCustomViewsCreateHelper.Select("SelectGroup", "16");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Created Date
            LeadsCustomViewsCreateHelper.Select("EnterCreated", "2016-2-16");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(5000);

            //Enter Modified Date
            LeadsCustomViewsCreateHelper.Select("EnterModified", "2016-2-17");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(5000);



            //################### ADD ADDITIONAL CRITERIA FIELDS #########################


            //Select Additional Field
            LeadsCustomViewsCreateHelper.Select("SelectAdditionalField1", "d.city:string");

            //Select Operator
            LeadsCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            LeadsCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Test");

            //Click On Add New Field
            LeadsCustomViewsCreateHelper.ClickElement("ClickOnAddNewField");

            //Select Additional Field
            LeadsCustomViewsCreateHelper.Select("SelectAdditionalField1", "a.industry:string");

            //Select Operator
            LeadsCustomViewsCreateHelper.Select("SelectOperator1", "cn");

            //Enter Additional Value
            LeadsCustomViewsCreateHelper.TypeText("EnterAdditionalValue1", "Dept");



            //Click on Save
            LeadsCustomViewsCreateHelper.ClickElement("ClickOnSave");
            LeadsCustomViewsCreateHelper.WaitForWorkAround(10000);
            
            //Click On Set As Default Custom View
            LeadsCustomViewActionsHelper.ClickElement("ClickOnSetAsDefault");
            LeadsCustomViewActionsHelper.WaitForWorkAround(10000);

            //Click On Unset Default Custom View
            LeadsCustomViewActionsHelper.ClickElement("ClickOnUnsetDefault");
            LeadsCustomViewActionsHelper.WaitForWorkAround(10000);

            //Clock On Edit Custom View
            LeadsCustomViewActionsHelper.ClickElement("ClickOnEdit");

            //Clock On Edit Custom View cancel button
            LeadsCustomViewActionsHelper.ClickElement("ClickOnEditCancel");


            //Click on Custom Views Dropdown
            LeadsCustomViewActionsHelper.ClickElement("ClickOnCustomViewsDropdown");
            LeadsCustomViewActionsHelper.WaitForWorkAround(5000);

            //Enter Search Custom Views Name
            LeadsCustomViewActionsHelper.TypeText("EnterSearchCustomViewsName", LeadCustomView);
            LeadsCustomViewActionsHelper.WaitForWorkAround(5000);

            //Click On First Custom View Name
            LeadsCustomViewActionsHelper.ClickElement("ClickOnFirstCustomViewName");
            LeadsCustomViewActionsHelper.WaitForWorkAround(10000);


            //Clock On New Custom View
            LeadsCustomViewActionsHelper.ClickElement("ClickOnNew");

            //Clock On New Custom View cancel button
            LeadsCustomViewActionsHelper.ClickElement("ClickOnNewCancel");


            //Click on Custom Views Dropdown
            LeadsCustomViewActionsHelper.ClickElement("ClickOnCustomViewsDropdown");
            LeadsCustomViewActionsHelper.WaitForWorkAround(5000);

            //Enter Search Custom Views Name
            LeadsCustomViewActionsHelper.TypeText("EnterSearchCustomViewsName", LeadCustomView);
            LeadsCustomViewActionsHelper.WaitForWorkAround(5000);

            //Click On First Custom View Name
            LeadsCustomViewActionsHelper.ClickElement("ClickOnFirstCustomViewName");
            LeadsCustomViewActionsHelper.WaitForWorkAround(10000);


            
            //Clock On Delete Custom View
            LeadsCustomViewActionsHelper.ClickElement("ClickOnDelete");
            

            LeadsCustomViewActionsHelper.AcceptAlert();
            LeadsCustomViewActionsHelper.WaitForWorkAround(10000);


        }
    }
}