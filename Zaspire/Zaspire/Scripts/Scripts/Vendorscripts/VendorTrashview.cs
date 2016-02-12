using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class VendorsTrashView : DriverTestCase
    {
        [TestMethod]
        public void TrashVendorsview()
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

            //#############trash index###############

            //Click on Trash
            //VendorHelper.ClickElement("Trash");

            //Redirect to logout
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/vendors/trash");

            //Click on view record
            VendorHelper.ClickElement("TrashVendorview");

            //Clcik on activity tab
            VendorHelper.ClickElement("Activitiestab");

            //Click on Timline
            //VendorHelper.ClickElement("Timelinetab");


            //Click on contact
            VendorHelper.ClickElement("Contacttab");

            //Click on leads
            VendorHelper.ClickElement("Relatedleadstab");

            // Click on accounts
            VendorHelper.ClickElement("Relatedaccounts");
            
            // Click on View record
            VendorHelper.ClickElement("TrashVendorview");
            
            //Click on ViewTrashRestore
            VendorHelper.ClickElement("ViewTrashRestore");

            //Click on ViewTrashDelete
            VendorHelper.ClickElement("ViewTrashDelete");

        }
    }
}