using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class CustomViewPage : DriverTestCase
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

            AddAccountHelper.ClickElement("ClickCustomViewLink");

            AddAccountHelper.ClickElement("ClickonFirstRecord");
            AddAccountHelper.WaitForWorkAround(4000);

      //############################### Edit Link###############

            AddAccountHelper.ClickElement("ClickonEditLink");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts");


      // $$$$$$$$$$$$$$$$$$$$$$$$$$ New Link #####################

            AddAccountHelper.Select("SelectCustomView", "31");

            AddAccountHelper.ClickElement("ClickOnNewOption");

            AddAccountHelper.ClickElement("ClickOnCancelOption");

     // @@@@@@@@@@@@@@@@@@@@@@@@@@@ Set Default Link #####################

            AddAccountHelper.Select("SelectCustomView", "31");

            AddAccountHelper.ClickElement("ClickOnSetAsDefault");

           // AddAccountHelper.ClickElement("ClickOnUnsetAsDefault");


     //$$$$$$$$$$$$$$$$$$$$$$$$$$$$ Delete Option $$$$$$$$$$$$$$$$$$$

            //AddAccountHelper.Select("SelectCustomView", "31");

            AddAccountHelper.ClickElement("ClickOnDeleteOption");

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(7000);

        }
    }
}

