using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EmployeeView : DriverTestCase
    {
        [TestMethod]
        public void employeeview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewEmployeeHelper = new AddNewEmployeeHelper(GetWebDriver());
            var EmployeesIndexHelper = new EmployeesIndexHelper(GetWebDriver());
            
            //Variable
            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var Email = "Test" + RandomNumber(1, 99) + "@gmail.com";

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            
            //Click on Employees
            AddNewEmployeeHelper.ClickElement("ClickOnEmployees");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees");
            //AddNewLeadHelper.WaitForWorkAround(7000);



//#################### CREATE A EMPLOYEE   #####################################

                        

            //Create on Employee
            AddNewEmployeeHelper.ClickElement("ClickOnEmployeeAddNew");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees/addnew");



//#################### EMPLOYEE DETAILS  #####################################


            //Select Salutation
            AddNewEmployeeHelper.Select("SelectSalutation", "Mr");
            
            //Enter First Name
            AddNewEmployeeHelper.TypeText("EnterFirstName", FirstName);

            //Enter Middle Name
            AddNewEmployeeHelper.TypeText("EnterMiddleName", "");

            //Enter Last Name
            AddNewEmployeeHelper.TypeText("EnterLastName", LastName);

            //Select Employee Type
            AddNewEmployeeHelper.Select("SelectEmployeeType", "Full Time");

            //Enter Contact Email
            AddNewEmployeeHelper.TypeText("EnterContactEmail", "test@gmail.com");

            //Select Phone Type
            AddNewEmployeeHelper.Select("SelectPhoneType", "Home");

            //Enter Phone Number
            AddNewEmployeeHelper.TypeText("EnterPhoneNumber", "7845956321");
            


//############################# EMPLOYEE ADDRESS   #################################


            //Select Address Type
            AddNewEmployeeHelper.Select("SelectAddressType", "Location");

            //Enter Address Line1
            AddNewEmployeeHelper.TypeText("EnterAddressLine1", "Test Addressline1");

            //Enter Address Line2
            AddNewEmployeeHelper.TypeText("EnterAddressLine2", "Test Addressline2");

            //Enter City
            AddNewEmployeeHelper.TypeText("EnterCity", "Test City");

            //Select State
            AddNewEmployeeHelper.Select("SelectState", "DC");

            //Select County
            AddNewEmployeeHelper.Select("SelectCountry", "USA");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Zip Code
            AddNewEmployeeHelper.TypeText("EnterZipCode", "82452");


//##################   DEPARTMENT, ROLE & TEAM  #############################


            //Select Department
            //AddNewEmployeeHelper.Select("SelectDepartment", "");

            //Select Role
            //AddNewEmployeeHelper.Select("SelectRole", "");
            
            //Select Team
            //AddNewEmployeeHelper.Select("SelectTeam", "");

            
//######################  SAVE EMPLOYEE  ###########################

            //Click on Save
            AddNewEmployeeHelper.ClickElement("ClickOnSave");
            AddNewEmployeeHelper.WaitForWorkAround(10000);



//######################  EMPLOYEE VIEW  ###########################


            //Enter Filter Search Box
            EmployeesIndexHelper.TypeText("EnterFilterSearch", FirstName);
            EmployeesIndexHelper.WaitForWorkAround(10000);

            //Click on Employee View
            EmployeesIndexHelper.ClickElement("ClickOnFirstEmployeeNameLink");

            //Click on Back
            EmployeesIndexHelper.ClickElement("ClickOnEmployeeViewBack");

            //Click on Employee View
            EmployeesIndexHelper.ClickElement("ClickOnFirstEmployeeNameLink");

            
            //Click on Email Link
            EmployeesIndexHelper.ClickElement("ClickOnEmailLink");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees");
            EmployeesIndexHelper.WaitForWorkAround(7000);

            //Click on Employee View
            EmployeesIndexHelper.ClickElement("ClickOnFirstEmployeeNameLink");

            //Click on Assigned Count tab
            EmployeesIndexHelper.ClickElement("ClickOnAssignedCount");

            //Click on Responsible Accounts tab
            EmployeesIndexHelper.ClickElement("ClickOnResponsibleAccounts");

            //Click on Responsible Accounts Filter Box
            EmployeesIndexHelper.ClickElement("AccountsFilterBox");

            //Click on Responsible Accounts Reset
            EmployeesIndexHelper.ClickElement("AccountsReset");

            //Click on Responsible Leads tab
            EmployeesIndexHelper.ClickElement("ClickOnResponsibleLeads");

            //Click on Responsible Leads Filter Box
            EmployeesIndexHelper.ClickElement("LeadsFilterBox");

            //Click on Responsible Leads Reset
            EmployeesIndexHelper.ClickElement("LeadsReset");


            //Click on Responsible Contacts tab
            EmployeesIndexHelper.ClickElement("ClickOnResponsibleContacts");

            //Click on Responsible Contacts Filter Box
            EmployeesIndexHelper.ClickElement("ContactsFilterBox");

            //Click on Responsible Contacts Reset
            EmployeesIndexHelper.ClickElement("ContactsReset");


            //Click on Responsible Opportunities tab
            EmployeesIndexHelper.ClickElement("ClickOnResponsibleOpportunities");

            //Click on Responsible Opportunities Filter Box
            EmployeesIndexHelper.ClickElement("OpportunitiesFilterBox");

            //Click on Responsible 
            EmployeesIndexHelper.ClickElement("OpportunitiesReset");


            //Click on Edit
            EmployeesIndexHelper.ClickElement("ClickOnEmployeeViewEdit");

            //Click on Edit Back
            EmployeesIndexHelper.ClickElement("ClickOnEditBack");

            //Click on Delete
            EmployeesIndexHelper.ClickElement("ClickOnEmployeeViewDelete");

            EmployeesIndexHelper.AcceptAlert();
            EmployeesIndexHelper.WaitForWorkAround(10000);




        }
    }
}
