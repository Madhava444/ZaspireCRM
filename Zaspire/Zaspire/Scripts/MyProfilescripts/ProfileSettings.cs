using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts
{
    [TestClass]
    public class MyprofileSettings : DriverTestCase
    {
        [TestMethod]
        public void Profilesettings()
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
            AdminMyProfileHelper.Select("NameFormate", "@f, @l");

            //Select  Primary contact
            AdminMyProfileHelper.Select("TimeZone", "America/Asuncion");

            //Enter Description
            AdminMyProfileHelper.Select("DateFormate", "d-m-Y");

            //Click on save Button
            AdminMyProfileHelper.Select("TimeFormate", "H:i");

            //Enter Description
            AdminMyProfileHelper.Select("DecimalFormate", "0");

           
            //Enter Description
            AdminMyProfileHelper.Select("Decimalseperator", "'");

            //Click on save Button
            AdminMyProfileHelper.TypeText("ExportDelimitor","new");

            //Click on save Button
            AdminMyProfileHelper.Select("PhoneFormate", "999-999-9999");

            //Click on save Button
            AdminMyProfileHelper.ClickElement("SettingSave");

        }
    }
}