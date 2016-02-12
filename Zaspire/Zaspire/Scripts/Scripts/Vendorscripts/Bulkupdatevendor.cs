using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class BulkupdateVendor : DriverTestCase
    {
        [TestMethod]
        public void Vendorbulkupdate()
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

            //################# Bulkupdate #######################

            //Enter text in filter
            VendorHelper.TypeText("VendorFilter", "ID");

            //Click on mastercheckboxs
            VendorHelper.ClickElement("VendorMastercheckbox");

            //MouseHover on bulk actions
            VendorHelper.MouseHover("Locator");

            // Click on bulkupdate
            VendorHelper.ClickElement("VendorBulkupdate");


            //Select Owner
            VendorHelper.Select("Vendorowners", "19");

            //Select Maneger
            VendorHelper.Select("VendorManager", "28");

            // Click on Updatebutton
            VendorHelper.ClickElement("VendorUpdate");



        }
    }
}
