using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class GroupsIndexPage : DriverTestCase
    {
        [TestMethod]
        public void groupsindexpage()
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

            //Click to open client info
            //AddAccountHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups");
            AddAccountHelper.WaitForWorkAround(7000);

            //################### GROUPS INDEX PAGE ACTIONS #########################


            //Click on Groups Add New
            AddAccountHelper.ClickElement("ClickOnGroupsAddNew");

            //Click on Back To Lead Groups Index page
            AddAccountHelper.ClickElement("ClickOnBackToAccountGroups");

           //Enter Search Filter Box 
            AddAccountHelper.TypeText("EnterSearchFilterBox", "Test Group");
            AddAccountHelper.WaitForWorkAround(7000);

            //Click On Filter Reset Button
            AddAccountHelper.ClickElement("ClickOnFilterResetButton");
            AddAccountHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            AddAccountHelper.MouseOver11("locator");

            //Click On Delete Lead Groups
            AddAccountHelper.ClickElement("ClickOnDeleteAccountGroups");

            //Check Master Check Box
            AddAccountHelper.ClickElement("CheckMasterCheckBox");


            //Click On Mouse Over
            AddAccountHelper.MouseOver12("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnQuickLink");

            //Click On View
            AddAccountHelper.ClickElement("ClickOnView");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/view/11");
            AddAccountHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            AddAccountHelper.MouseOver12("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnQuickLink");


            //Click On Edit
            AddAccountHelper.ClickElement("ClickOnEdit");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/edit/11");
            AddAccountHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            AddAccountHelper.MouseOver12("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnQuickLink");


            //Click On Delete
            AddAccountHelper.ClickElement("ClickOnDelete");

            //Click On First Group Name
            AddAccountHelper.ClickElement("ClickOnFirstGroupName");

            //Click on Back To Lead Groups Index page
            AddAccountHelper.ClickElement("ClickOnBackToAccountGroups");


        }
    }
}