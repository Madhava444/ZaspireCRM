using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;


namespace Zaspire.Scripts
{
    [TestClass]
    public class VendorsTrashIndex : DriverTestCase
    {
        [TestMethod]
        public void TrashVendorIndex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var VendorHelper = new VendorHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            VendorHelper.ClickElement("Vendor");
            VendorHelper.WaitForWorkAround(3000);

            //#############trash index###############

            //Click on Trash
            //VendorHelper.ClickElement("Trash");

            //Redirect to parertrash
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/vendors/trash");
            //Enter text in filter
            VendorHelper.TypeText("VendorTrashFilter", "New");

            //Click on checkbox
            VendorHelper.ClickElement("MasterCheckboxTrashVendor");

            //Moves over on bulk action
            VendorHelper.MouseOver("locator1");

            //Click on Delete partner
            VendorHelper.ClickElement("RemoveVendorForeever");

            //Click  on reset  button
            VendorHelper.ClickElement("ResetTrash");

            // ------------------Restore vendor ------------------    

            //Enter text in filter
            VendorHelper.TypeText("FilterTrash", "New");

            //Click on checkbox
            VendorHelper.ClickElement("MasterCheckboxTrashVendors");

            //Moves over on bulk action
            VendorHelper.MouseOver("locator1");

            //click  on restore partner
            VendorHelper.ClickElement("RestoreVendors");

            //click on Back  Button
            VendorHelper.ClickElement("VendorBackTrash");

            //Click on view record
            VendorHelper.ClickElement("TrashVendorview");
        }
    }
}

