using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class addfileVendor : DriverTestCase
    {
        [TestMethod]
        public void AddfilePartner()
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


            //############################ Add File ##########################################



            //Click On record
            VendorHelper.ClickElement("VendorView");

            //Click on Moreaction
            VendorHelper.MouseOver("Locator");

            //Select Add File
            VendorHelper.ClickElement("From");

            //Enter Name
            VendorHelper.TypeText("To", "new1");

            //Select Category
            VendorHelper.Select("Subject", "mail for  vendorr");

            //Upload File 
            String filename = GetPath() + "C:\\Users\\Public\\Pictures\\Sample Pictures\\image\\Tulips.jpeg";
            VendorHelper.Upload("SelectFile", filename);
            VendorHelper.WaitForWorkAround(10000);

            //Enter description
            VendorHelper.TypeText("Description", "This is a file to vendor ");

            //Click on Save button
            VendorHelper.ClickElement("Save");

        }
    }
}

