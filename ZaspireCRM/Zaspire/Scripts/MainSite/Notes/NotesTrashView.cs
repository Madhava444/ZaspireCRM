using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite.Notes
{
    [TestClass]
    public class NotesTrashView : DriverTestCase
    {
        [TestMethod]
        public void notestrashview()
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

            //Click On First Record
            NotesTrashIndexHelper.ClickElement("ClickOnFirstRecord");

            //Click on Trash
            NotesTrashIndexHelper.ClickElement("ClickOnBack");

            //Click On First Record
            NotesTrashIndexHelper.ClickElement("ClickOnFirstRecord");

            //Click On Restore
            NotesTrashIndexHelper.ClickElement("ClickOnViewRestore");

            //Click On First Record
            NotesTrashIndexHelper.ClickElement("ClickOnFirstRecord");

            //Click On Delete
            NotesTrashIndexHelper.ClickElement("ClickOnViewDelete");
            NotesTrashIndexHelper.WaitForWorkAround(10000);









        }
    }
}