using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactImports : DriverTestCase
    {
        [TestMethod]
        public void contactimports()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            var SaveViewas = "CustomView" + RandomNumber(20, 99);

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            ContactImportHelper ContactImportHelper = new ContactImportHelper(GetWebDriver());
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            ContactImportHelper.WaitForWorkAround(4000);

            //Click On Contact Tab
            //ContactImportHelper.ClickElement("ClickContactsTab");
            //ContactImportHelper.WaitForWorkAround(4000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            ContactImportHelper.WaitForWorkAround(7000);

            //########### Import functionality ######

            //ContactImportHelper.ClickElement("ClickOnImporCreatetButton");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/import");
            ContactImportHelper.WaitForWorkAround(7000);

            

            ContactImportHelper.ClickElement("ClickOnDownloadOption");

            ContactImportHelper.ClickElement("ClickOnSelectFile");

            ContactImportHelper.ClickElement("ClickOnImportOption");
            
            //ContactImportHelper.ClickElement("ClickOnSave");

            // $$$$$$$$$$$$$ Import Wizard Page $$$$$$$$$$$$$$$$$$

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/import");
            ContactImportHelper.WaitForWorkAround(7000);

            ContactImportHelper.ClickElement("ClickOnSelectFile");

            ContactImportHelper.ClickElement("ClickOnImportOption");

            ContactImportHelper.ClickElement("ClickOnSave");
            ContactImportHelper.WaitForWorkAround(15000);

            // @@@@@@@@@@@@@@@@@@@@@@ Cancel Button @@@@@@@@@@@@@@@@@@@@

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/import");
            ContactImportHelper.WaitForWorkAround(7000);

            ContactImportHelper.ClickElement("ClickOnSelectFile");

            ContactImportHelper.ClickElement("ClickOnImportButton");

            ContactImportHelper.ClickElement("CancelButton");

            //******************************* Import Cancel Option *************************************
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/import");
            ContactImportHelper.WaitForWorkAround(7000);

            ContactImportHelper.ClickElement("ClickOnSelectFile");

            ContactImportHelper.ClickElement("ClickOnCancelOption");

        }
    }
}