using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactImportIndex : DriverTestCase
    {
        [TestMethod]
        public void contactimportindex()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            
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

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            ContactImportHelper.WaitForWorkAround(7000);

            //########### Import functionality ######

            //ContactImportHelper.ClickElement("ClickOnImporCreatetButton");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            ContactImportHelper.WaitForWorkAround(7000);


            ContactImportHelper.Select("RecordsPerPage", "20");

            ContactImportHelper.TypeText("FilterTextbox", "Contacts5000");
            ContactImportHelper.WaitForWorkAround(5000);

            ContactImportHelper.ClickElement("ClickOnReset");

            ContactImportHelper.ClickElement("ClickOnFileIcon");

            ContactImportHelper.ClickElement("ClickOnDeletesIcon");
            ContactImportHelper.AcceptAlert();

            //############################# Import New ##################################

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/import");
            ContactImportHelper.WaitForWorkAround(7000);

            ContactImportHelper.ClickElement("ClickonCancelButton");

            //**************************** View Page ************************************

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/imports");
            ContactImportHelper.WaitForWorkAround(7000);

            ContactImportHelper.TypeText("FilterTextbox", "Contacts5000");

            ContactImportHelper.ClickElement("ClickOnFirstImportView");


        }
    }
}