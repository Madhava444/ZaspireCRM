using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class ParntnerIndex : DriverTestCase
    {
        [TestMethod]
        public void PartnerIndex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var addpartnerHelper = new PartnerHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            addpartnerHelper.ClickElement("partners");


            //#########################Create Partner######################################

            //Select default view
            addpartnerHelper.Select("DefaultView", "Recently Added");

            //Select Custom view
            addpartnerHelper.Select("CustomView", "112");
     

            //Enter text in filter
            addpartnerHelper.TypeText("Filter", "Partner");

            //Click on PartnerFilter Reset
            addpartnerHelper.ClickElement("Reset");

             // Select result per page options
            addpartnerHelper.Select("Recordsperpage","20");


            //Click On Quick Look Mouse Over
            addpartnerHelper.Mouseover1("locator");
            addpartnerHelper.WaitForWorkAround(10000);

            //Click On Quick Look
            addpartnerHelper.ClickElement("ToolActionPartners");

            //Click On Quick Look View
            addpartnerHelper.ClickElement("ToolViewPartners");
            addpartnerHelper.WaitForWorkAround(5000);

            //Click on Back to partners
            addpartnerHelper.ClickElement("Backtopartners");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/partners");
            //addpartnerHelper.WaitForWorkAround(1000);

            //Click On Quick Look Mouse Over
            addpartnerHelper.Mouseover1("locator");
            addpartnerHelper.WaitForWorkAround(1000);

            //Click On Quick Look
            addpartnerHelper.ClickElement("ToolActionPartners");

            //Click On Quick Look Edit
            addpartnerHelper.ClickElement("ToolEditPartners");
            addpartnerHelper.WaitForWorkAround(10000);

            //Click on Cancel to Calls
            addpartnerHelper.ClickElement("EditCancel");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/partners");

            //Click On Quick Look Mouse Over
            addpartnerHelper.Mouseover1("locator");

            //Click On Quick Look
            addpartnerHelper.ClickElement("ToolActionPartners");

            //Clicok On Quick Look Delete
            addpartnerHelper.ClickElement("ToolDeletePartners");

            addpartnerHelper.AcceptAlert();
            addpartnerHelper.WaitForWorkAround(1000);


            // Click on record
            addpartnerHelper.ClickElement("PartnerView");





        }
    }
}

