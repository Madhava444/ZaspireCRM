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
        public void Addfilevendor()
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
            VendorHelper.MouseOver2("locator");

            //Click on Add file
            VendorHelper.ClickElement("VendorAddFile");

            //Select Add File
            VendorHelper.TypeText("Name","newvendor");

            //Select Category
            VendorHelper.TypeText("Category", "12402");



            //Upload File 
            VendorHelper.upload1("//*[@id='AttachmentFiles']");

            //Enter description
            VendorHelper.TypeText("Description", "This is a file to vendor ");

            //Click on Save button
            VendorHelper.ClickElement("FileSave");

        }
    }
}

