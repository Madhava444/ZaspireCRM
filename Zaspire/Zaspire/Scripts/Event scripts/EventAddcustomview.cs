using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddCustomviewEvent : DriverTestCase
    {
        [TestMethod]
        public void AddcustomviewEvents()
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
            
            //Variable

            var Saveviewas = "custom" + RandomNumber(1, 99);
            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            EventHelper.ClickElement("Selectevents");


            //#########################Create Partner######################################

            //Click on custom view
            EventHelper.ClickElement("Customviewnew");

            //Click On Create
            //EventHelper.ClickElement("Newbutton");

            //Enter text
            EventHelper.TypeText("Eventsaveviewas", Saveviewas);

            //Select dropdown list
            //EventHelper.Select("Sortby", "Name");

            //Select dropdown list
            //EventHelper.Select("Owner", "Ranjith");

            //Select dropdown list
            EventHelper.Select("CustomRelatedTo", "Accounts");

            //Select dropdown list
            EventHelper.Select("CustomStatus", "In Progress");

            //Select dropdown list
            EventHelper.Select("CustomCategory", "12503");

            //Select dropdown list
            EventHelper.Select("CustomCreatedby", "Ranjith");

            //Enter text
            EventHelper.Select("CustomModifiedby", "Ranjith");

            //Select dropdown list
            EventHelper.Select("CustomPriority", "Medium");

            //Enter text
            //EventHelper.Select("type", "eq");

            // Enter Created text
            EventHelper.TypeText("Createdtext", "Ranjith");
            
            //select modified type
            //EventHelper.Select("type", "eq");

            //Enter modified text
            EventHelper.TypeText("Modifytext", "Kavitha");

            //Enter text
            EventHelper.Select("Nemeadditioanal","a.name:string");

            //Select dropdown list
            //EventHelper.TypeText("type", "eq");

            //Enter text
            EventHelper.TypeText("Nametext", "Ranjith");

            //Click on save
            EventHelper.ClickElement("CustomSave");

            
        }
    }
}


