using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class CustomViewIndex : DriverTestCase
    {
        [TestMethod]
        public void customviewindex()
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
            //AddContactHelper AddAccountHelper = new AddContactHelper(GetWebDriver());
            CustomContactHelper CustomContactHelper = new CustomContactHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);


            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            CustomContactHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            //CustomContacontactHelper.ClickElement("ClickContactsTab");
            //CustomContacontactHelper.WaitForWorkAround(4000);
            
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            CustomContactHelper.WaitForWorkAround(7000);


            //Select Custom View
            CustomContactHelper.Select("SelectCustomView", "48");

            //Click On Set As Default Custom View
            CustomContactHelper.ClickElement("ClickOnSetAsDefault");
            CustomContactHelper.WaitForWorkAround(10000);

            //Click On Unset Default Custom View
            CustomContactHelper.ClickElement("ClickOnUnsetAsDefault");
            CustomContactHelper.WaitForWorkAround(10000);

            //Clock On Edit Custom View
            CustomContactHelper.ClickElement("ClickonEditLink");

            //Clock On Edit Custom View cancel button
            CustomContactHelper.ClickElement("CancelOption");


            //Select Custom View
            CustomContactHelper.Select("SelectCustomView", "48");

            //Clock On New Custom View
            CustomContactHelper.ClickElement("ClickOnNewOption");

            //Clock On New Custom View cancel button
            CustomContactHelper.ClickElement("ClickOnCancelOption");

            //Select Custom View
            CustomContactHelper.Select("SelectCustomView", "48");

            //Clock On Delete Custom View
            CustomContactHelper.ClickElement("ClickOnDeleteOption");

           CustomContactHelper.AcceptAlert();
            CustomContactHelper.WaitForWorkAround(10000);

        }
    }
}