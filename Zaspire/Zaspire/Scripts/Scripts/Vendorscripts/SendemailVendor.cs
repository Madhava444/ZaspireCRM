using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class sendemailtoVendor : DriverTestCase
    {
        [TestMethod]
        public void SendemailtoVendor()
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


            //############################ Send Email ##########################################



            //Click On record
            VendorHelper.ClickElement("VendorView");

            //Click on Moreaction
            VendorHelper.MouseOver2("locater");


            //Click on Send Email
            VendorHelper.ClickElement("VendorSendEmail");

            //Click On Employees Link
            VendorHelper.ClickElement("ClickOnEmployeesLink");
            
            //Click On To Address Check Box
            VendorHelper.ClickElement("ToAddressCheckBox");

            //Click On CC Address Check Box
            VendorHelper.ClickElement("CCAddressCheckBox");

            //Click On BCC Address Check Box
            VendorHelper.ClickElement("BCCAddressCheckBox");

            //Click On Add Email Address Button
            VendorHelper.ClickElement("ClickOnAddEmailAddress");

            //Click on Send Email Button
            VendorHelper.ClickElement("ClickOnSendEmailButton");
            VendorHelper.WaitForWorkAround(10000);


        }
    }
}