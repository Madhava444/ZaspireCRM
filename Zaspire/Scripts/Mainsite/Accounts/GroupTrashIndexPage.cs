using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class GroupTrashIndexPage : DriverTestCase
    {
        [TestMethod]
        public void trashindexpage()
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


            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);



            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/trash");
            AddAccountHelper.WaitForWorkAround(3000);

            //AddAccountHelper.ClickElement("ClickOnGroupTrashOption");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/trash");
            AddAccountHelper.WaitForWorkAround(3000);

            AddAccountHelper.ClickElement("ClickOnBackButton");

            //######################## Delete forever functionality @@@@@@@@@@@@@@@@@@@

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/trash");
            AddAccountHelper.WaitForWorkAround(3000);

            AddAccountHelper.TypeText("SearchByGroupName", "AccountGroup1");

            AddAccountHelper.ClickElement("SelectMasterCheckBox");

            AddAccountHelper.MouseHover2("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnBulkActions");

            //Click On View
            AddAccountHelper.ClickElement("ClickOnDeleteForever");

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(5000);

            // ############################ Restore functionaliy @@@@@@@@@@@@@@@@@@@@@@@@@
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/trash");
            AddAccountHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/trash");
            AddAccountHelper.WaitForWorkAround(3000);

            AddAccountHelper.TypeText("SearchByZipCode", "56987");

            AddAccountHelper.ClickElement("SelectMasterCheckBox");

            AddAccountHelper.MouseHover2("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnBulkActions");

            AddAccountHelper.ClickElement("ClickOnRestoreGroups");

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(5000);

          //######################## Record level Quick links @@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            //############## Delete forever @@@@@@@@@

            AddAccountHelper.MouseHover3("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnQuickLink");

            AddAccountHelper.ClickElement("ClickOnDeleteForever");

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(5000);

            //############### Restore Option @@@@@@@@@

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/trash");
            AddAccountHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/trash");
            AddAccountHelper.WaitForWorkAround(3000);
            
            AddAccountHelper.MouseHover3("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnQuickLink");

            AddAccountHelper.ClickElement("ClickOnRestore");

            // ################### Group Trash View Page @@@@@@@@@@@@@@@@@@@@@@@

            AddAccountHelper.ClickElement("ClickOnRecord");

        }
    }
}