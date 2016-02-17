using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class CreateUserFromConsultant : DriverTestCase
    {
        [TestMethod]
        public void createuserfromconsultant()
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
            CreateNewUserHelper.ClickElement("UseAnExistingConsultantToCreateUser");

            //Select Employee Details

            // CreateNewUserHelper.Select("ConsultantList", "");
            // CreateNewUserHelper.TypeText("ConsultantLoginName", mail);
            CreateNewUserHelper.WaitForWorkAround(2000);

            CreateNewUserHelper.TypeText("ConsultantPassword", "Welcome");
            CreateNewUserHelper.Select("ConsultantDepartments", "37");

            //Auto Generated Password and Do Not Send
            //   CreateNewUserHelper.ClickElement("ConsultantClickOnDoNotSendActivationE-Mail");
            CreateNewUserHelper.Select("ConsultantRole", "7");
            CreateNewUserHelper.Select("ConsultantTeam", "15");
            CreateNewUserHelper.WaitForWorkAround(2000);


            ///  **************  SELECT ACESS PROFILE *********************


            CreateNewUserHelper.ClickElement("ConsultantAdminUser");
            CreateNewUserHelper.ClickElement("ConsultantAdminUser9");
            CreateNewUserHelper.ClickElement("ConsultantCopyAdminUser");
            CreateNewUserHelper.ClickElement("ConsultantCopyAdmin1");
            CreateNewUserHelper.ClickElement("ConsultantCopySalesUser");
            CreateNewUserHelper.ClickElement("ConsultantGenericUser");
            CreateNewUserHelper.ClickElement("ConsultantSalesUsers");
            CreateNewUserHelper.ClickElement("ConsultantTest");
            CreateNewUserHelper.ClickElement("ConsultantTestCopy");
            CreateNewUserHelper.ClickElement("ConsultantTestSalesUser1");
            CreateNewUserHelper.ClickElement("ConsultantTestUser99");


            //#######################    CLICK ON SAVE BUTTON   ########################

            // CreateNewUserHelper.ClickElement("ClickOnSaveButton");
            CreateNewUserHelper.WaitForWorkAround(5000);

        }
    }
}
