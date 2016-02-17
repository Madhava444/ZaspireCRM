using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddCustomviewVendorss : DriverTestCase
    {
        [TestMethod]
        public void AddcustomviewVendors()
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
            
            //Variable

            var Saveviewas = "custom" + RandomNumber(1, 99);
            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            VendorHelper.ClickElement("vendors");


            //#########################Create Partner######################################

            //Click on custom view
            VendorHelper.ClickElement("customview");

            //Click On Create
            VendorHelper.ClickElement("Newbutton");

            //Enter text
            VendorHelper.TypeText("Saveviewas", Saveviewas);

            //Select dropdown list
            //VendorHelper.Select("Sortby", "Name");

            //Select dropdown list
            VendorHelper.Select("Owner1", "Kavitha");

            //Select dropdown list
            VendorHelper.Select("Manager1", "Shravani");

            //Select dropdown list
            VendorHelper.Select("Createdby", "Kavitha");

            //Select dropdown list
            VendorHelper.Select("Modifiedby", "Kavitha");

            //Select dropdown list
            VendorHelper.Select("Createdtype", "eq");

            //Enter text
            VendorHelper.TypeText("Createdtext", "kavitha");

            //Select dropdown list
            VendorHelper.Select("Modifytype", "eq");

            //Enter text
            VendorHelper.TypeText("Modifytext", "kavitha");

            //Enter text
            VendorHelper.TypeText("Nemeadditioanal", "a.name:string");

            //Select dropdown list
            VendorHelper.TypeText("Nametype", "eq");

            //Enter text
            VendorHelper.Select("Nametext", "Kavitha");

            //Click on save
            VendorHelper.ClickElement("Save");

            
        }
    }
}


