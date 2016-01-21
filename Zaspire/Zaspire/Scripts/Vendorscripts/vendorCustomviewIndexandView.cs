using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class vendorCustomviewIndexandView : DriverTestCase
    {
        [TestMethod]
        public void Addcampaign()
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
            VendorHelper.ClickElement("vendors");

            //Click on Index
            VendorHelper.ClickElement("customview");

            //Click on view
            VendorHelper.ClickElement("CustomviewView");

            //Click on edit
            VendorHelper.ClickElement("CustomviewEdit");

            //Clcik on cancel
            VendorHelper.ClickElement("CancelCustomview");

            //select in dropdown
            VendorHelper.Select("Selectdropdown", "PRAKASH");


            //Clcik on Set as default
            VendorHelper.ClickElement("CustomviewSetasdefault");

            //Clcik on Unset as default
            VendorHelper.ClickElement("CustomviewUnsetdefault");


            //Clcik on Delete
            VendorHelper.ClickElement("DeleteCustomview");

            //Click on Index
            VendorHelper.ClickElement("customview");

            //Enter in filter
            VendorHelper.TypeText("Filtercustomview", "custom");

            //Click on Reset
            VendorHelper.ClickElement("Resetcustomview");


            //Click on new button
            VendorHelper.ClickElement("Newbutton");


            //Enter text in save view as
            VendorHelper.TypeText("saveviewas", "custom1");

            //Click on Save button
            VendorHelper.ClickElement("CancelCustomview");


            //Click on delete button
            VendorHelper.ClickElement("DeleteCustomview");

            //Clic on back button
            //VendorHelper.ClickElement("Backtovendors");

        }
    }
}
