using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EventCustomviewIndexandView : DriverTestCase
    {
        [TestMethod]
        public void EventCustomview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var EventHelper = new EventHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);
   
            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            EventHelper.ClickElement("Selectevents");

            //Click on Index
            EventHelper.ClickElement("EventCustomView");

            //Click on view
            EventHelper.ClickElement("CustomviewView");

            //Click on edit
            EventHelper.ClickElement("CustomviewEdit");

            //Clcik on cancel
            EventHelper.ClickElement("CancelCustomview");

            //select in dropdown
            EventHelper.Select("Selectdropdown", "30");


            //Clcik on Set as default
            EventHelper.ClickElement("CustomviewSetasdefault");

            //Clcik on Unset as default
            EventHelper.ClickElement("CustomviewUnsetdefault");


            //Clcik on Delete
            EventHelper.ClickElement("CustomviewDelete");

            //Click on Index
            EventHelper.ClickElement("customview");

            //Enter in filter
            EventHelper.TypeText("Filtercustomview", "custom");

            //Click on Reset
            EventHelper.ClickElement("Resetcustomview");


            //Click on new button
            EventHelper.ClickElement("Newbutton");


            //Click on Save button
            EventHelper.ClickElement("CancelCustomview");


            //Click on delete button
            EventHelper.ClickElement("CustomviewDelete");

            EventHelper.AcceptAlert();
            EventHelper.WaitForWorkAround(5000);

            //Click on back button
            //EventHelper.ClickElement("EventCustomviewBack");

        }
    }
}
