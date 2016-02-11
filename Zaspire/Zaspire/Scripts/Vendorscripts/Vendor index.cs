﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class VendorIndex : DriverTestCase
    {
        [TestMethod]
        public void Vendor()
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

            //################################ Index ################################

            //Click on Default view
            VendorHelper.Select("VendorDefaultview", "Recently Modified");

            //Clickon Vendorcustomviewlist
            VendorHelper.Select("Vendorcustomviewlist", "26");

            //Enter text in filter
            VendorHelper.TypeText("VendorFilter", "New");

            //Click on reset button
            VendorHelper.ClickElement("VendorReset");

            //Click on ExportCSV
            //VendorHelper.ClickElement("VendorExportCSV");

            //Click on ExportPdf
            //VendorHelper.ClickElement("VendorExportPDF");




        }
    }
}


