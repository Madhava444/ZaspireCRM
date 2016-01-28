using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EventTrashView : DriverTestCase
    {
        [TestMethod]
        public void EventTrashview()
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

            //#############trash index###############

            //Click on Trash
            //ssEventHelper.ClickElement("Trash");

            //Redirect to logout
            GetWebDriver().Navigate().GoToUrl("http://www.zaspire.com/infoaspire/events/trash");

            //Click on view record
            EventHelper.ClickElement("TrashEventview");

            //Clcik on Restore
            EventHelper.ClickElement("ViewTrashRestore");

            //Click on Delete
            EventHelper.ClickElement("ViewTrashDelete");


            //Click on Back
            EventHelper.ClickElement("ViewTrashBack");

            
        }
    }
}