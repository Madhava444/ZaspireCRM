using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EventIndex : DriverTestCase
    {
        [TestMethod]
        public void EventHome()
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


            //#########################Create Partner######################################

            //Select default view
            EventHelper.Select("EventDfaultView", "Recently Added");

            //Select Custom view
            EventHelper.Select("SelectCustomview", "82");


            //Enter text in filter
            EventHelper.TypeText("EventFilter", "Task");

            //check master checkbox
            EventHelper.ClickElement("EventMasterCheckbox");

           // Select result per page options
            EventHelper.MouseHover("EventBulkAction");

            // Select result per page options
            EventHelper.ClickElement("EventBulkUpdate");

            //Select status
            EventHelper.Select("BulkStatus", "In Progress");

            //Select Category
            EventHelper.Select("BulkCategory", "12503");

            //SelectPriority
            EventHelper.Select("BulkPriority", "Low");

            //Select Owner
            EventHelper.Select("BulkOwner", "17");

            //Click on Update
            EventHelper.ClickElement("Updatebutton");  
            
            //Click on PartnerFilter Reset
            EventHelper.ClickElement("EventReset");

            // Click on record
            EventHelper.ClickElement("EventView");

        }
    }
}

