using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class VendorIndex : DriverTestCase
    {
        [TestMethod]
        public void Vendorindex()
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


            //Click On Quick Look Mouse Over
            VendorHelper.Mouseover1("locator");
            VendorHelper.WaitForWorkAround(1000);

            //Click On Quick Look
            VendorHelper.ClickElement("ToolActioncall");

            //Click On Quick Look View
            VendorHelper.ClickElement("ToolViewCall");
            VendorHelper.WaitForWorkAround(1000);

            //Click on Back to Calls
            //VendorHelper.ClickElement("CallBack");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/vendors");
            VendorHelper.WaitForWorkAround(1000);

            //Click On Quick Look Mouse Over
            VendorHelper.Mouseover1("locator");
            
            //Click On Quick Look
            VendorHelper.ClickElement("ToolActioncall");

            //Click On Quick Look Edit
            VendorHelper.ClickElement("ToolEditCall");
            VendorHelper.WaitForWorkAround(1000);

            //Click on Cancel to Calls
            //VendorHelper.ClickElement("SelectCancel");

            //VendorHelper().Navigate().GoToUrl("http://zaspire.com/infoaspire/vendors");

            //Click On Quick Look Mouse Over
            VendorHelper.Mouseover1("locator");

            //Click On Quick Look
            VendorHelper.ClickElement("ToolActioncall");

            //Clicok On Quick Look Delete
            VendorHelper.ClickElement("ToolDeleteCall");

            VendorHelper.WaitForWorkAround(10000);


            //Click on ExportCSV
            //VendorHelper.ClickElement("VendorExportCSV");

            //Click on ExportPdf
            //VendorHelper.ClickElement("VendorExportPDF");




        }
    }
}



