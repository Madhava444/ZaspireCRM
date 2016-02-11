using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class AccessProfilesIndex : DriverTestCase
    {
        [TestMethod]
        public void accessprofilesindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AccessProfilesIndexHelper = new AccessProfilesIndexHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            //MouseOver
            AccessProfilesIndexHelper.MouseOver("locator");

            //Click on Admin
            AccessProfilesIndexHelper.ClickElement("ClickOnAdmin");
            AccessProfilesIndexHelper.WaitForWorkAround(10000);

            //Click on Access Profiles
            //AccessProfilesIndexHelper.ClickElement("ClickOnAccessProfiles");
            //AccessProfilesIndexHelper.WaitForWorkAround(10000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/access_profiles");
            AccessProfilesIndexHelper.WaitForWorkAround(10000);
            
            //Click on Add New
            AccessProfilesIndexHelper.ClickElement("ClickOnAddNew");

            //Click on Cancel
            AccessProfilesIndexHelper.ClickElement("ClickOnAddNewCancel");

            //Enter Filter Search Box
            AccessProfilesIndexHelper.TypeText("EnterFilterSearchBox", "Test");

            //Click on Reset
            AccessProfilesIndexHelper.ClickElement("ClickOnReset");

            //Click on Pagination
            //AccessProfilesIndexHelper.Select("SelectPagination", "20");

            //Click on Edit
            AccessProfilesIndexHelper.ClickElement("ClickOnEdit");

            //Click on Cancel
            AccessProfilesIndexHelper.ClickElement("ClickOnEditCancel");

            //Click on Copy
            AccessProfilesIndexHelper.ClickElement("ClickOnCopy");

            //Click on Cancel
            AccessProfilesIndexHelper.ClickElement("ClickOnCopycancel");

            //Click on First Record
            AccessProfilesIndexHelper.ClickElement("ClickOnFirstRecord");

            //Click on Back
            AccessProfilesIndexHelper.ClickElement("ClickOnViewBack");
            AccessProfilesIndexHelper.WaitForWorkAround(10000);




        }
    }
}