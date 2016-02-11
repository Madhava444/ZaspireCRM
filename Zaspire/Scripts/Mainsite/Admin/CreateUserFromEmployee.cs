using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class CreateUserFromEmployee : DriverTestCase
    {
        [TestMethod]
        public void createuserfromemployee()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CreateNewUserHelper = new AddNewUserHelper(GetWebDriver());
            // var addContactHelper = new AddContactHelper(GetWebDriver());

            //Variable
            var mail = "Test" + RandomNumber(1, 99) + "@yopmail.com";
            //var numb = "0123456789" + RandomNumber(0, 9);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);
            CreateNewUserHelper.WaitForWorkAround(5000);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/users");
            CreateNewUserHelper.WaitForWorkAround(5000);
            //Click on Admin in Top menu
            // ***** Note Below 2 lines : Made Comment as They are working instead we using directly the web Url  ******
            // AddNewUserHelper.ClickElement("ClickOnUsersTab");
            // AddNewUserHelper.WaitForWorkAround(2000);


            // ################################# CREATE A USER   #############################################



            //Select Create USer
            CreateNewUserHelper.ClickElement("ClickOnAddNew");
            CreateNewUserHelper.ClickElement("UseAnExistingEmployeeToCreateUser");

            //Select Employee Details
            //     CreateNewUserHelper.Select("EmploymentUserType", "Contract");
            CreateNewUserHelper.Select("EmployeeList", "92");
            // CreateNewUserHelper.TypeText("EmployeeLoginEmail", mail);
            CreateNewUserHelper.WaitForWorkAround(2000);

            CreateNewUserHelper.TypeText("EmployeePassword", "Welcome");
            CreateNewUserHelper.Select("EmployeeDepartments", "37");

            //Auto Generated Password and Do Not Send
            CreateNewUserHelper.ClickElement("ClickOnDoNotSendActivationE-Mail");
            CreateNewUserHelper.Select("EmployeeRole", "7");
            CreateNewUserHelper.Select("EmployeeTeam", "15");
            CreateNewUserHelper.WaitForWorkAround(2000);


            ///  **************  SELECT ACESS PROFILE *********************


            CreateNewUserHelper.ClickElement("EmployeeAdminUser");
            CreateNewUserHelper.ClickElement("EmployeeAdminUser9");
            CreateNewUserHelper.ClickElement("EmployeeCopyAdminUser");
            CreateNewUserHelper.ClickElement("EmployeeCopyAdmin1");
            CreateNewUserHelper.ClickElement("EmployeeCopySalesUser");
            CreateNewUserHelper.ClickElement("EmployeeGenericUser");
            CreateNewUserHelper.ClickElement("EmployeeSalesUsers");
            CreateNewUserHelper.ClickElement("EmployeeTest");
            CreateNewUserHelper.ClickElement("EmployeeTestCopy");
            CreateNewUserHelper.ClickElement("EmployeeTestSalesUser1");
            CreateNewUserHelper.ClickElement("EmployeeTestUser99");


            //#######################    CLICK ON SAVE BUTTON   ########################

            // CreateNewUserHelper.ClickElement("ClickOnSaveButton");
            CreateNewUserHelper.WaitForWorkAround(5000);

        }
    }
}
