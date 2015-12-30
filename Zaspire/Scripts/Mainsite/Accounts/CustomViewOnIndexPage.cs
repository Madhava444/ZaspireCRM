using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class CustomViewOnIndexPage : DriverTestCase
    {
        [TestMethod]
        public void customviewpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            AddAccountHelper AddAccountHelper = new AddAccountHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            AddAccountHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);


            //Select Custom View
            AddAccountHelper.Select("SelectCustomView", "1");

            //Click On Set As Default Custom View
            AddAccountHelper.ClickElement("ClickOnSetAsDefault");
            AddAccountHelper.WaitForWorkAround(10000);

            //Click On Unset Default Custom View
            AddAccountHelper.ClickElement("ClickOnUnsetAsDefault");
            AddAccountHelper.WaitForWorkAround(10000);

            //Clock On Edit Custom View
            AddAccountHelper.ClickElement("ClickonEditLink");

            //Clock On Edit Custom View cancel button
            AddAccountHelper.ClickElement("CancelOption");


            //Select Custom View
            AddAccountHelper.Select("SelectCustomView", "1");

            //Clock On New Custom View
            AddAccountHelper.ClickElement("ClickOnNewOption");

            //Clock On New Custom View cancel button
            AddAccountHelper.ClickElement("ClickOnCancelOption");

            //Select Custom View
            AddAccountHelper.Select("SelectCustomView", "1");

            //Clock On Delete Custom View
            AddAccountHelper.ClickElement("ClickOnDeleteOption");


            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(10000);

        }
    }
}