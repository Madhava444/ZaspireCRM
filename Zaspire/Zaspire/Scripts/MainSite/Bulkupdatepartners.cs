using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class BulkupdatePartner : DriverTestCase
    {
        [TestMethod]
        public void Bulkupdatepartner()
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
            addpartnerHelper.TypeText("Filter", "new");
            addpartnerHelper.WaitForWorkAround(3000);

            //Click on Master Check box
            addpartnerHelper.ClickElement("ClickOnMasterCheckBox");
            addpartnerHelper.WaitForWorkAround(3000);

            //Click on Bulk action
            addpartnerHelper.MouseOver("Locator");


            //Click on bulkupdate
            addpartnerHelper.ClickElement("Bulkupdate");
            addpartnerHelper.WaitForWorkAround(3000);


            //Select Owner
            addpartnerHelper.Select("Owner1","17");

            //Select Maneger
            addpartnerHelper.Select("Manager1","28");

            // Click on Updatebutton
            addpartnerHelper.ClickElement("update");











        }
    }
}