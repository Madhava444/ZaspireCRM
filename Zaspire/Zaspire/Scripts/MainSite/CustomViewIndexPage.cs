using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class CustomViewIndexPage : DriverTestCase
    {
        [TestMethod]
        public void customviewindexpage()
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

            AddAccountHelper.TypeText("EnterInFilterTextbox", "Ranjith");

            AddAccountHelper.ClickElement("ClickOnResetButton");

            //@#!@#@#@#@#@@#@#@#@#@# Delete @#@#@#@@#@#@#@#

            AddAccountHelper.TypeText("TypeFilterTextbox", "Test");
            

            AddAccountHelper.WaitForWorkAround(1000);

            AddAccountHelper.ClickElement("SelectCheckbox");

            AddAccountHelper.ClickElement("ClickOnDeleteButton");
            AddAccountHelper.AcceptAlert();

            AddAccountHelper.WaitForWorkAround(3000);

            // &&&&&&&&&&&&&&&& Create Page@##@#@#@##@

            AddAccountHelper.ClickElement("ClickOnCustomNew");

            AddAccountHelper.TypeText("SaveViewas", "Test");
            AddAccountHelper.WaitForWorkAround(2000);

            AddAccountHelper.ClickElement("ClickOnOrder");

            AddAccountHelper.Select("Owner", "Ranjith");

            AddAccountHelper.ClickElement("ClickSaveButton");
            AddAccountHelper.WaitForWorkAround(10000);

            //#$@#$@#$@#$@#$@#$@$#@$ New @#$@#$@$@@#@$#@#

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/advance_search");

            AddAccountHelper.ClickElement("ClickOnCancelButton");

            //###@@#@#@@@@@@ Edit functionality@@@@$@$$$$$$$$$$$$$$

            AddAccountHelper.ClickElement("ClickCustomViewLink");

            AddAccountHelper.ClickElement("ClickOnEditButton");

            AddAccountHelper.ClickElement("ClickOnCancelButton");

            //$#$#$#$#$#$#$#  Permission functionality@#@#$@$@#$@#@#$
            AddAccountHelper.ClickElement("ClickCustomViewLink");
            AddAccountHelper.ClickElement("ClickOnPermissionButton");

            AddAccountHelper.ClickElement("ClickOnSaveOption");

            // @#$#@$@#$@#$@#$#@$@#$#@ Delete functionality @#$#@$#@$@
            AddAccountHelper.ClickElement("ClickOnDeleteOption");

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(5000);


        }
    }
}