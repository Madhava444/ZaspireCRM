using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts
{
    [TestClass]
    public class MyprofileEdit : DriverTestCase
    {
        [TestMethod]
        public void ProfileEdit()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username3");
            password = oXMLData.getData("settings/Credentials", "password3");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AdminMyProfileHelper = new AdminMyProfileHelper(GetWebDriver());

            //Variable

            var Name = "AdminProfile" + RandomNumber(1, 99);
            

                        //Login with valid username and password
                        Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Mouse over on Profile
            AdminMyProfileHelper.Mouseover("locator");

            //click on admin
            AdminMyProfileHelper.ClickElement("ClickonAdmin");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            //Click on Department
            AdminMyProfileHelper.ClickElement("AdminProfile");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/department");


            //Click on add new
            AdminMyProfileHelper.ClickElement("Edit");

            //enter name
            AdminMyProfileHelper.Select("Salutation", "Mrs");

            //Select  Primary contact
            AdminMyProfileHelper.TypeText("FirstName", "kavitha");

            //Enter Description
            AdminMyProfileHelper.TypeText("MiddleName", "reddy");

            //Click on save Button
            AdminMyProfileHelper.TypeText("LastName", "kedika");

            //Enter Description
            AdminMyProfileHelper.TypeText("Birthdate", "11-05-1986");

           
            //Enter Description
            AdminMyProfileHelper.upload1("//*[@id='EmployeeProfileImage']");

            //Click on save Button
            AdminMyProfileHelper.Select("PhoneType", "Cell");

            //Click on save Button
            AdminMyProfileHelper.TypeText("PhoneNumber", "1233456789");

            //Click on save Button
            AdminMyProfileHelper.ClickElement("Primaryradiobutton");

            //Click on add new
            AdminMyProfileHelper.ClickElement("DoNotCall");

            //enter name
            AdminMyProfileHelper.Select("Emailtype", "E-Mail");

            //Select  Primary contact
            AdminMyProfileHelper.TypeText("Emailadress", "asds@gmail.com");

            //Enter Description
            AdminMyProfileHelper.ClickElement("EmailPrimary");

            //Click on save Button
            AdminMyProfileHelper.ClickElement("EmailOptedout");

            //Enter Description
            AdminMyProfileHelper.Select("AddressType", "Shipping");


            //Enter Description
            AdminMyProfileHelper.TypeText("AddressLine1", "New Road");

            //Click on save Button
            AdminMyProfileHelper.TypeText("AddressLine2", "roadno23");

            //Click on save Button
            AdminMyProfileHelper.TypeText("City", "AL");

            //Click on save Button
            AdminMyProfileHelper.TypeText("State","Aloka");
            
            //Click on save Button
            AdminMyProfileHelper.Select("Country", "USA");

            //Click on save Button
            AdminMyProfileHelper.TypeText("Zipcode", "1112");

            //Click on save Button
            AdminMyProfileHelper.ClickElement("Donotsolic");

            //Click on save Button
            AdminMyProfileHelper.ClickElement("EDitSave");
        }
    }
}