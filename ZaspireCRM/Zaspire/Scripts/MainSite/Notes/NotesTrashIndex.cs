using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite.Notes
{
    [TestClass]
    public class NotesTrashIndex : DriverTestCase
    {
        [TestMethod]
        public void notestrashindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var NotesTrashIndexHelper = new NotesTrashIndexHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Activities
            NotesTrashIndexHelper.ClickElement("ClickOnActivities");

            //Click on Notes
            NotesTrashIndexHelper.ClickElement("ClickOnNotes");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/notes");
            //NotesTrashIndexHelper.WaitForWorkAround(7000);


            //Click on Trash
            NotesTrashIndexHelper.ClickElement("ClickOnTrash");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/notes/trash");
            //NotesTrashIndexHelper.WaitForWorkAround(7000);

            //Click on Trash
            NotesTrashIndexHelper.ClickElement("ClickOnBack");

            //Click on Trash
            NotesTrashIndexHelper.ClickElement("ClickOnTrash");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/notes/trash");
            //NotesTrashIndexHelper.WaitForWorkAround(7000);

            //Enter Filter Search Box
            NotesTrashIndexHelper.TypeText("EnterSearchBox", "Test");
            NotesTrashIndexHelper.WaitForWorkAround(10000);

            //Click on Reset
            NotesTrashIndexHelper.ClickElement("ClickOnReset");

 
            //Mouse Over1
            NotesTrashIndexHelper.MouseOver1("locator1");

            //Click On Delete Forever
            NotesTrashIndexHelper.ClickElement("ClickOnDeleteForever");

            NotesTrashIndexHelper.AcceptAlert();
            NotesTrashIndexHelper.WaitForWorkAround(10000);


            //Mouse Over1
            NotesTrashIndexHelper.MouseOver1("locator1");

            //Click On Restore Notes
            NotesTrashIndexHelper.ClickElement("ClickOnRestoreNotes");

            NotesTrashIndexHelper.AcceptAlert();
            NotesTrashIndexHelper.WaitForWorkAround(10000);


            //Click On Check Master Check Box
            NotesTrashIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Uncheck Master Check Box
            NotesTrashIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On First Record
            NotesTrashIndexHelper.ClickElement("ClickOnFirstRecord");

            //Mouse Over
            NotesTrashIndexHelper.MouseOver("locator");

            //Click On Quick Link
            NotesTrashIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On Delete
            NotesTrashIndexHelper.ClickElement("ClickOnDelete");

            NotesTrashIndexHelper.AcceptAlert();
            NotesTrashIndexHelper.WaitForWorkAround(10000);

            //Mouse Over
            NotesTrashIndexHelper.MouseOver("locator");

            //Click On Quick Link
            NotesTrashIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On Restore
            NotesTrashIndexHelper.ClickElement("ClickOnRestore");
            NotesTrashIndexHelper.WaitForWorkAround(10000);

            
            //Select Pegination
            NotesTrashIndexHelper.Select("SelectPegination", "10");

            //Click on Next
            NotesTrashIndexHelper.ClickElement("ClickOnNext");

            //Click on Last
            NotesTrashIndexHelper.ClickElement("ClickOnLast");

            //Click on Previous
            NotesTrashIndexHelper.ClickElement("ClickOnprevious");

            //Click on First
            NotesTrashIndexHelper.ClickElement("ClickOnFirst");









        }
    }
}