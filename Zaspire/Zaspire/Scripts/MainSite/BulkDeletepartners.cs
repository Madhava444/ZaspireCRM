using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class BulkDeletePartner : DriverTestCase
    {
        [TestMethod]
        public void BulkDeletepartner()
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

            //Typetext  filter
            addpartnerHelper.TypeText("Filter", "AL");
            addpartnerHelper.WaitForWorkAround(3000);

            //Click on Master Check box
            addpartnerHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Bulk action
            addpartnerHelper.MouseOver("Locator");


            //Click on bulkupdate
            addpartnerHelper.ClickElement("Bulkdelete");

            addpartnerHelper.AcceptAlert();
            addpartnerHelper.WaitForWorkAround(5000);












        }
    }
}
