using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class NotesIndex : DriverTestCase
    {
        [TestMethod]
        public void notesindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var NotesIndexHelper = new NotesIndexHelper(GetWebDriver());

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Activities
            NotesIndexHelper.ClickElement("ClickOnActivitiess");

            //Click on Notes
            NotesIndexHelper.ClickElement("ClickOnNotes");

            //Click on AddNew
            NotesIndexHelper.ClickElement("ClickOnAddNew");

            //Click on AddNew Cancel Button
            NotesIndexHelper.ClickElement("ClickOnAddNewCancel");

            //Click on Custom Views
            NotesIndexHelper.ClickElement("ClickOnCustomViews");

            //Click on Custom Views Back
            NotesIndexHelper.ClickElement("ClickOnCustomViewsBack");

            //Click on Custom Views New
            NotesIndexHelper.ClickElement("ClickOnCustomViewsNew");

            //Click on Custom Views New Back
            NotesIndexHelper.ClickElement("ClickOnCustomViewsNewBack");

            //Enter Search Box
            NotesIndexHelper.TypeText("EnterSearchBox", "Test");
            NotesIndexHelper.WaitForWorkAround(10000);

            //Click on Reset Button
            NotesIndexHelper.ClickElement("ClickOnReset");

            //Click on Check Master Check Box
            NotesIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Uncheck Master Check Box
            NotesIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on First Record
            NotesIndexHelper.ClickElement("ClickOnFirstRecord");

            //Click on First Record Back
            NotesIndexHelper.ClickElement("ClickOnFirstRecordBack");
            
            //Record MouseOver
            NotesIndexHelper.MouseOver("locator");

            //Click on Quick Link
            NotesIndexHelper.ClickElement("ClickOnQuickLink");

            //Click on View
            NotesIndexHelper.ClickElement("ClickOnView");

            //Click on First Record View Back 
            NotesIndexHelper.ClickElement("ClickOnFirstRecordBack");

            //Record MouseOver
            NotesIndexHelper.MouseOver("locator");

            //Click on Quick Link
            NotesIndexHelper.ClickElement("ClickOnQuickLink");

            //Click on Edit
            NotesIndexHelper.ClickElement("ClickOnEdit");

            //Click on Edit Back
            NotesIndexHelper.ClickElement("ClickOnEditBack");

            //Record MouseOver
            NotesIndexHelper.MouseOver("locator");

            //Click on Quick Link
            NotesIndexHelper.ClickElement("ClickOnQuickLink");

            //Click on Delete
            NotesIndexHelper.ClickElement("ClickOnDelete");

            NotesIndexHelper.AcceptAlert();
            NotesIndexHelper.WaitForWorkAround(10000);


            //Mouse Over
            NotesIndexHelper.MouseOver1("locator1");

            //Click on Bulk Update
            NotesIndexHelper.ClickElement("ClickOnBulkUpdate");

            NotesIndexHelper.AcceptAlert();
            NotesIndexHelper.WaitForWorkAround(5000);

            //Mouse Over
            NotesIndexHelper.MouseOver1("locator1");

            //Click on Bulk Delete
            NotesIndexHelper.ClickElement("ClickOnBulkDelete");

            NotesIndexHelper.AcceptAlert();
            NotesIndexHelper.WaitForWorkAround(5000);



            //Select SelectPagination
            NotesIndexHelper.Select("SelectPagination", "20");

            //Click on Next
            NotesIndexHelper.ClickElement("ClickOnNext");

            //Click on Last
            NotesIndexHelper.ClickElement("ClickOnLast");

            //Click on Previous
            NotesIndexHelper.ClickElement("ClickOnprevious");

            //Click on First
            NotesIndexHelper.ClickElement("ClickOnFirst");



        }
    }
}