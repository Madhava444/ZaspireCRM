using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class PicklistActiveInactive : DriverTestCase
    {
        [TestMethod]
        public void picklistactiveinactive()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var PicklistsIndexHelper = new PicklistsIndexHelper(GetWebDriver());

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            //MouseOver
            PicklistsIndexHelper.MouseOver("locator");

            //Click on Admin
            PicklistsIndexHelper.ClickElement("ClickOnAdmin");
            PicklistsIndexHelper.WaitForWorkAround(10000);

            //Click on Picklists
            //PicklistsIndexHelper.ClickElement("ClickOnPicklists");
            //PicklistsIndexHelper.WaitForWorkAround(10000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/pick-lists");
            PicklistsIndexHelper.WaitForWorkAround(10000);

            //Click On First Picklist Name
            PicklistsIndexHelper.ClickElement("ClickOnFirstPicklist");

            //Click On Inactive
            PicklistsIndexHelper.ClickElement("ClickOnActiveInactive");

            //Click On Active
            PicklistsIndexHelper.ClickElement("ClickOnActiveInactive");
            PicklistsIndexHelper.WaitForWorkAround(10000);



        }
    }
}