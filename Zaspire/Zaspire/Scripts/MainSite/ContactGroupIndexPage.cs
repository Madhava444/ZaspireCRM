using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactGroupIndexPage : DriverTestCase
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
            GroupTrashHelper GroupTrashHelper = new GroupTrashHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            GroupTrashHelper.WaitForWorkAround(4000);

            //Click On Contact Tab
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            GroupTrashHelper.WaitForWorkAround(7000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups");
            GroupTrashHelper.WaitForWorkAround(7000);

            //################### GROUPS INDEX PAGE ACTIONS #########################

           //Enter Search Filter Box 
            GroupTrashHelper.TypeText("EnterSearchFilterBox", "Test Group");
            GroupTrashHelper.WaitForWorkAround(3000);

            //Click On Filter Reset Button
            GroupTrashHelper.ClickElement("ClickOnFilterResetButton");
            GroupTrashHelper.WaitForWorkAround(2000);

            //Click on Groups Add New
            GroupTrashHelper.ClickElement("ClickOnGroupsAddNew");

            //GroupTrashHelper.ClickElement("ClickOnBackToAccountGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups");
            GroupTrashHelper.WaitForWorkAround(7000);

            //*************Bulk Actions **************

            GroupTrashHelper.TypeText("EnterSearchFilterBox", "Test Group");

            GroupTrashHelper.ClickElement("CheckMasterCheckBox");

            //Click On Mouse Over
            GroupTrashHelper.MouseHover03("locator");

            //Click On Delete Lead Groups
            GroupTrashHelper.ClickElement("ClickOnDeleteAccountGroups");


            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(3000);

            //*************************Record Level QuickLinks *****************************
           
            //Click On Mouse Over
            GroupTrashHelper.MouseHover04("locator");

            //Click On Quick Link
            GroupTrashHelper.ClickElement("ClickOnQuickLink");

            //Click On View
            GroupTrashHelper.ClickElement("ClickOnView");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/view/11");
            //GroupTrashHelper.WaitForWorkAround(7000);

            GroupTrashHelper.ClickElement("ClickOnBackButtonsOption");

            //Click On Mouse Over
            GroupTrashHelper.MouseHover04("locator");

            //Click On Quick Link
            GroupTrashHelper.ClickElement("ClickOnQuickLink");


            //Click On Edit
            GroupTrashHelper.ClickElement("ClickOnEdit");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/edit/11");
            //GroupTrashHelper.WaitForWorkAround(7000);

            GroupTrashHelper.ClickElement("ClickOnSaveButtonOption");

            //Click On Mouse Over
            GroupTrashHelper.MouseHover04("locator");

            //Click On Quick Link
            GroupTrashHelper.ClickElement("ClickOnQuickLink");


            //Click On Delete
            GroupTrashHelper.ClickElement("ClickOnDelete");

            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(3000);


        }
    }
}