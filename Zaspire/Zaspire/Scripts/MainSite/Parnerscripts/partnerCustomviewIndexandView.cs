using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class PartnerCustomviewIndexandView : DriverTestCase
    {
        [TestMethod]
        public void Addpartner()
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

            //Click on Index
            addpartnerHelper.ClickElement("customview");

            //Click on view
            addpartnerHelper.ClickElement("CustomviewView");

            //Click on edit
            addpartnerHelper.ClickElement("CustomviewEdit");

            //Clcik on cancel
            addpartnerHelper.ClickElement("CancelCustomview");

            //select in dropdown
            addpartnerHelper.Select("Selectdropdown", "30");


            //Clcik on Set as default
            addpartnerHelper.ClickElement("CustomviewSetasdefault");

            //Clcik on Unset as default
            addpartnerHelper.ClickElement("CustomviewUnsetdefault");


            //Clcik on Delete
            addpartnerHelper.ClickElement("CustomviewDelete");

            //Click on Index
            addpartnerHelper.ClickElement("customview");

            //Enter in filter
            addpartnerHelper.TypeText("Filtercustomview", "custom");

            //Click on Reset
            addpartnerHelper.ClickElement("Resetcustomview");


            //Click on new button
            addpartnerHelper.ClickElement("Newbutton");


            //Enter text in save view as
            //addpartnerHelper.TypeText("saveviewas", "new");

            //Click on Save button
            addpartnerHelper.ClickElement("CancelCustomview");


            //Click on delete button
            addpartnerHelper.ClickElement("CustomviewDelete");

            addpartnerHelper.AcceptAlert();
            addpartnerHelper.WaitForWorkAround(5000);

            //Click on back button
            //addpartnerHelper.ClickElement("Backtopartners");

        }
    }
}
