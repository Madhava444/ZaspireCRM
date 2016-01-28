using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;


namespace Zaspire.Scripts
{
    [TestClass]
    public class CallsTrashIndex : DriverTestCase
    {
        [TestMethod]
        public void TrashCallIndex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CallHelper = new CallHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

          // Click on Dashboard in menu
            CallHelper.ClickElement("ClickonActivities");

            //Click on Calls
            CallHelper.ClickElement("ClickOnCalls");

            //#############trash index###############

            //Click on Trash
            //addpartnerHelper.ClickElement("Trash");

            //Redirect to parertrash
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/calls/trash");
            //Enter text in filter
            CallHelper.TypeText("CallsTrashFilter", "Test");

            //Click on checkbox
            CallHelper.ClickElement("MasterCheckboxTrashCalls");

            //Moves over on bulk action
            CallHelper.MouseOver("Mouseovertrash");

            //Click on Delete partner
            CallHelper.ClickElement("RemovecallsForeever");

            //Click  on reset  button
            CallHelper.ClickElement("ResetTrash");

            // ------------------Restore Calls ------------------    

            //Enter text in filter
            CallHelper.TypeText("FilterTrash", "New");

            //Click on checkbox
            CallHelper.ClickElement("MasterCheckboxTrashCalls");

            //Moves over on bulk action
            CallHelper.MouseOver("Mouseovertrash");

            //click  on restore partner
            CallHelper.ClickElement("RestoreCalls");

            //click on Back  Button
            CallHelper.ClickElement("BackTrash");

            //Click on view record
            CallHelper.ClickElement("Trashcallsview");
        }
    }
}

