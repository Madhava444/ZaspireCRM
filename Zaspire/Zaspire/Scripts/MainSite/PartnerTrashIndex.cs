using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts
{
    [TestClass]
    public class ParntnersTrashIndex : DriverTestCase
    {
        [TestMethod]
        public void TrashPartnerIndex()
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
            addpartnerHelper.WaitForWorkAround(3000);

            //#############trash index###############

            //Click on Trash
            //addpartnerHelper.ClickElement("Trash");

            //Redirect to parertrash
            GetWebDriver().Navigate().GoToUrl("http://www.zaspire.com/infoaspire/partners/trash");
            //Enter text in filter
            addpartnerHelper.TypeText("PartnerTrashFilter", "New");

            //Click on checkbox
            addpartnerHelper.ClickElement("MasterCheckboxTrashpartner");

            //Moves over on bulk action
            addpartnerHelper.MouseOver("locator1");

            //Click on Delete partner
            addpartnerHelper.ClickElement("RemovePartnerForeever");

            //Click  on reset  button
            addpartnerHelper.ClickElement("ResetTrash");

            // ------------------Restore partner ------------------    

            //Enter text in filter
            addpartnerHelper.TypeText("FilterTrash", "New");

            //Click on checkbox
            addpartnerHelper.ClickElement("MasterCheckboxTrashpartner");

            //Moves over on bulk action
            addpartnerHelper.MouseOver("locator1");

            //click  on restore partner
            addpartnerHelper.ClickElement("RestorePartner");

            //click on Back  Button
            addpartnerHelper.ClickElement("BackTrash");

            //Click on view record
            addpartnerHelper.ClickElement("TrashPartnerview");
        }
    }
}

