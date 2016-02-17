using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class NotesCustomViewsIndex : DriverTestCase
    {
        [TestMethod]
        public void notescustomviewsindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var NotesCustomViewsHelper = new NotesCustomViewsHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Activities
            NotesCustomViewsHelper.ClickElement("ClickOnActivitiess");

            //Click on Notes
            NotesCustomViewsHelper.ClickElement("ClickOnNotes");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/notes");
            //NotesCustomViewsHelper.WaitForWorkAround(7000);

            //Click on Custom Views
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Click on Back Button
            NotesCustomViewsHelper.ClickElement("ClickOnBackButton");

            //Click on Custom Views
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Enter Search Box
            NotesCustomViewsHelper.TypeText("EnterSearchBox", "Test");
            NotesCustomViewsHelper.WaitForWorkAround(10000);

            //Click on Check Master Check Box
            NotesCustomViewsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Delete Button
            NotesCustomViewsHelper.ClickElement("ClickOnDeleteButton");

            NotesCustomViewsHelper.AcceptAlert();
            NotesCustomViewsHelper.WaitForWorkAround(10000);

            //Click on New Button
            NotesCustomViewsHelper.ClickElement("ClickOnNewButton");

            //Click on New Back
            NotesCustomViewsHelper.ClickElement("ClickOnNewBack");

            //Click on Custom Views
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Enter Search Box
            NotesCustomViewsHelper.TypeText("EnterSearchBox", "Test");
            NotesCustomViewsHelper.WaitForWorkAround(10000);

            //Click on Reset
            NotesCustomViewsHelper.ClickElement("ClickOnReset");

            //Select Pagination
            NotesCustomViewsHelper.ClickElement("SelectPagination");

            //Click on Check Master Check Box
            NotesCustomViewsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Uncheck Master Check Box
            NotesCustomViewsHelper.ClickElement("ClickOnMasterCheckBox");


            //Click on First Record
            NotesCustomViewsHelper.ClickElement("ClickOnFirstRecord");

            //Click on Custom Views
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViews");


            //Click on Edit
            NotesCustomViewsHelper.ClickElement("ClickOnEdit");

            //Click on Edit Back
            NotesCustomViewsHelper.ClickElement("ClickOnEditBack");

            //Click on Custom Views
            NotesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Click on Delete
            NotesCustomViewsHelper.ClickElement("ClickOnDelete");

            NotesCustomViewsHelper.AcceptAlert();
            NotesCustomViewsHelper.WaitForWorkAround(10000);

            //Click on Permissions
            NotesCustomViewsHelper.ClickElement("ClickOnPermissions");

            //Click on Permissions Check1
            NotesCustomViewsHelper.ClickElement("ClickOnPermissionsCheck1");

            //Click on Permissions Check2
            NotesCustomViewsHelper.ClickElement("ClickOnPermissionsCheck2");

            //Click on Permissions Check3
            NotesCustomViewsHelper.ClickElement("ClickOnPermissionsCheck3");

            //Click on Permissions Save
            NotesCustomViewsHelper.ClickElement("ClickOnPermissionsSave");


        


        }
    }
}