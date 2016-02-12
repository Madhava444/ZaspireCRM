using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class CallsTrashView : DriverTestCase
    {
        [TestMethod]
        public void TrashCallsview()
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
            //CallHelper.ClickElement("Trash");

            //Redirect to logout
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/calls/trash");

            //Click on view record
            CallHelper.ClickElement("TrashCallsview");

            //Clcik on activity tab
            CallHelper.ClickElement("ViewTrashRestore");
            CallHelper.AcceptAlert();


            //Click on view record
            CallHelper.ClickElement("TrashCallsview");

            //Click on Timline
            CallHelper.ClickElement("ViewTrashDelete");
            CallHelper.AcceptAlert();

        }
    }
}