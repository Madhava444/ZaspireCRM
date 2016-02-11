using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class AddConsultantUser : DriverTestCase
    {
        [TestMethod]
        public void Addconsultantuser()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

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


            // ################################# CREATE CONSULTANT USER   #############################################



            //Select Create USer
            CreateNewUserHelper.ClickElement("ClickOnAddNew");
            CreateNewUserHelper.ClickElement("ClickOnConsultantUser");

            //Select Consultant Details

            CreateNewUserHelper.Select("ConsultantSalutation", "Mr");
            CreateNewUserHelper.TypeText("ConsultantFirstName", "John");
            CreateNewUserHelper.TypeText("ConsultantMiddleName", "K");
            CreateNewUserHelper.TypeText("ConsultantLastName", "peter");
            CreateNewUserHelper.TypeText("ConsultantLoginName", "peter@gmail.com");
            CreateNewUserHelper.Select("Owner", "59");
            CreateNewUserHelper.Select("Manager", "59");
            CreateNewUserHelper.WaitForWorkAround(2000);


            ///  **************  CADIDATE DETAILS   *********************

            CreateNewUserHelper.Select("CandidateList", "1195");
            CreateNewUserHelper.TypeText("ConsultantContactEmail", mail);
            CreateNewUserHelper.Select("ConsultantPhoneType", "Cell");
            CreateNewUserHelper.TypeText("ConsultantPhoneNumber", "5689236598");
            CreateNewUserHelper.ClickElement("ConsultantDoNotCall");
            CreateNewUserHelper.Select("ConsultantAddressType", "Corporate");
            CreateNewUserHelper.TypeText("ConsultantAddress1", "301 ibmbldng");
            CreateNewUserHelper.TypeText("ConsultantAddress2", "James Street");
            CreateNewUserHelper.TypeText("ConsultantCity", "Tampa");
            CreateNewUserHelper.Select("ConsultantState", "FL");
            CreateNewUserHelper.Select("ConsultantCountry", "USA");
            CreateNewUserHelper.TypeText("ConsultantZipcode", "33647");
            CreateNewUserHelper.Select("ConsultantDepartments", "27");
            CreateNewUserHelper.Select("ConsultantRole", "10");
            CreateNewUserHelper.Select("ConsultantTeam", "26");
            //  CreateNewUserHelper.Select("ConsultantProfilePic", "");


            ///  **************  SELECT ACESS PROFILE *********************


            CreateNewUserHelper.ClickElement("ConsultantAdminUser");
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

            //   CreateNewUserHelper.ClickElement("ClickOnSaveButton");
            CreateNewUserHelper.WaitForWorkAround(5000);

        }
    }
}
