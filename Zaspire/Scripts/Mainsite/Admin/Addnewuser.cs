using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class AddNewUser : DriverTestCase
    {
        [TestMethod]
        public void addnewuser()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewUserHelper = new AddNewUserHelper(GetWebDriver());
           // var addContactHelper = new AddContactHelper(GetWebDriver());

            //Variable
            var mail = "Test" + RandomNumber(1, 99) + "@yopmail.com";
            //var numb = "0123456789" + RandomNumber(0, 9);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);
            AddNewUserHelper.WaitForWorkAround(5000);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/users");
            AddNewUserHelper.WaitForWorkAround(5000);
            //Click on Admin in Top menu
            // ***** Note Below 2 lines : Made Comment as They are working instead we using directly the web Url  ******
           // AddNewUserHelper.ClickElement("ClickOnUsersTab");
           // AddNewUserHelper.WaitForWorkAround(2000);


            // ################################# CREATE A USER   #############################################



            //Select Create USer
            AddNewUserHelper.ClickElement("ClickOnAddNew");
            AddNewUserHelper.ClickElement("ClickOnCreateUser");

            /*Select Employee Details
            AddNewUserHelper.Select("EmploymentType", "Full Time");
            AddNewUserHelper.TypeText("LoginEmail", mail);
            AddNewUserHelper.WaitForWorkAround(2000);
            AddNewUserHelper.Select("Salutation", "Mrs");

            //Enter First Name
            AddNewUserHelper.TypeText("FirstName", "John");

            //Enter Middle Name
            AddNewUserHelper.TypeText("MiddleName", "K");

            //Enter Last Name
            AddNewUserHelper.TypeText("LastName", "peter");

            //Department
            //AddNewUserHelper.Select("Departments", "36");

            //Auto Generated Password and Do Not Send
            AddNewUserHelper.ClickElement("ClickOnAutogeneratepassword");
            AddNewUserHelper.ClickElement("ClickOnDoNotSendActivationE-Mail");
            
            //AddNewUserHelper.Select("Role", "8");
           // AddNewUserHelper.Select("Team", "");
            AddNewUserHelper.WaitForWorkAround(2000);
            

            ///  **************  CONTACT INFORMATION   *********************
            
          AddNewUserHelper.TypeText("ContactEmail",mail);
            AddNewUserHelper.Select("PhoneType", "Cell");
            AddNewUserHelper.TypeText("PhoneNumber", "(789) 541-2549");
            // AddNewUserHelper.ClickElement("Primary");
            AddNewUserHelper.ClickElement("DoNotCall");
            AddNewUserHelper.Select("AddressType", "Corporate");
            AddNewUserHelper.TypeText("AddressLine1", "301 ibmbldng");
            AddNewUserHelper.TypeText("AddressLine2", "James Street");

            AddNewUserHelper.TypeText("City", "Ohio ");
            AddNewUserHelper.Select("State", "AK");
            AddNewUserHelper.Select("Country", "USA");
            AddNewUserHelper.TypeText("Zipcode", "14589");
            
                
            ///  **************  SELECT ACESS PROFILE *********************

           
            AddNewUserHelper.ClickElement("AdminUser");
           // AddNewUserHelper.ClickElement("AdminUser");
            //AddNewUserHelper.ClickElement("CopyAdminUser");

           // AddNewUserHelper.ClickElement("CopyAdmin1");
           // AddNewUserHelper.ClickElement("CopySalesUser");
           // AddNewUserHelper.ClickElement("GenericUser");
           // AddNewUserHelper.ClickElement("SalesUsers");

          //  AddNewUserHelper.ClickElement("Test");
          //  AddNewUserHelper.ClickElement("TestCopy");
          //  AddNewUserHelper.ClickElement("TestSalesUser1");
          //  AddNewUserHelper.ClickElement("TestUser99");*/


            //#######################    CLICK ON SAVE BUTTON   ########################

            AddNewUserHelper.ClickElement("ClickOnSaveButton");
            

        }
    }
}