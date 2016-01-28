using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;


namespace Zaspire.Scripts
{
    [TestClass]
    public class EventTrashIndex : DriverTestCase
    {
        [TestMethod]
        public void TrasheventIndex()
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

            //Click on Events
            EventHelper.ClickElement("Selectevents");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/events");
            //EventHelper.WaitForWorkAround(7000);

            //#############trash index###############

            //Click on Trash
            //EventHelper.ClickElement("Trash");

            //Redirect to parertrash
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/events/trash");
            //Enter text in filter
           /* EventHelper.TypeText("EventTrashFilter", "New");

            //Click on checkbox
            EventHelper.ClickElement("MasterCheckboxTrashEvent");

            //Moves over on bulk action
            EventHelper.MouseHover("MouseHovertrash");

            //Click on Delete partner
            EventHelper.ClickElement("RemoveEventForeever");

            //Click  on reset  button
            EventHelper.ClickElement("ResetTrash");*/

            // ------------------Restore partner ------------------    

            //Enter text in filter
            EventHelper.TypeText("EventTrashFilter", "task");

            //Click on checkbox
            EventHelper.ClickElement("MasterCheckboxTrashEvent");

            //Moves over on bulk action
            EventHelper.MouseHover("MouseHovertrash");

            //click  on restore partner
            EventHelper.ClickElement("RestoreEvent");

            //click on Back  Button
            EventHelper.ClickElement("BackTrash");

            //Click on view record
            EventHelper.ClickElement("TrashEventview");
        }
    }
}

