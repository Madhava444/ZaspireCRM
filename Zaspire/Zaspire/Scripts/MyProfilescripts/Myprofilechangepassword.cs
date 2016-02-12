using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts
{
    [TestClass]
    public class MyprofileChangepassword : DriverTestCase
    {
        [TestMethod]
        public void Profilechangepassword()
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
            AdminMyProfileHelper.ClickElement("Profilesettingstab");

            //enter name
            AdminMyProfileHelper.ClickElement("ProfileDetails");

            //Select  Primary contact
            AdminMyProfileHelper.ClickElement("Profileactivity");

            //Enter Description
            AdminMyProfileHelper.ClickElement("Edit");

            //Click on save Button
            AdminMyProfileHelper.ClickElement("EditCancel");

            //Enter Description
            AdminMyProfileHelper.ClickElement("Changepassword");

            //Click on save Button
            AdminMyProfileHelper.TypeText("NamePassword","aspirecrm");

            //Enter Description
            AdminMyProfileHelper.TypeText("ConformPassword", "aspirecrm");

            //Click on save Button
            AdminMyProfileHelper.ClickElement("SavePassword");

            //Click on save Button
            AdminMyProfileHelper.ClickElement("EmailLink");
        }
    }
}