using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class VendorView : DriverTestCase
    {
        [TestMethod]
        public void Vendorview()
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

            //##########################View page########################

            //Click on vendor record
            VendorHelper.ClickElement("VendorView");

            //Clcik on activity tab
            VendorHelper.ClickElement("VendorActivity");

            //Click on Timline
            //VendorHelper.ClickElement("VendorTimeline");


            //Click on contact
            VendorHelper.ClickElement("VendorContactinfo");

            //Click on leads
            VendorHelper.ClickElement("Vendorleadsrelated");

            // Click on accounts
            VendorHelper.ClickElement("VendorAccountsrelated");

          //Click on Owner inline edit
            VendorHelper.ClickElement("VendorOwner");

            //Select owner from list
            VendorHelper.Select("Ownerlist", "17");

            //Click on save button
            VendorHelper.ClickElement("SaveOwner");

            //Click on manage inline edit
            VendorHelper.ClickElement("VendorManager");

            //Select from manager list 
            VendorHelper.Select("Managerlist", "28");

            //Click on save manager
            VendorHelper.ClickElement("SaveManager");

            // Click on new button
            VendorHelper.ClickElement("VendorNew");
        
            //Click on cancel from add newVendor
             VendorHelper.ClickElement("VendorCancel");

            // Click on edit button
            VendorHelper.ClickElement("VendorEdit");

            //click on edit save
            VendorHelper.ClickElement("EditSave");

            // Click on back button
             VendorHelper.ClickElement("VendorBack");
        }
    }
}
