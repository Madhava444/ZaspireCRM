using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactTrashViewPage : DriverTestCase
    {
        [TestMethod]
        public void contacttrashViewPage()
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
            //AddContactHelper AddAccountHelper = new AddContactHelper(GetWebDriver());
            TrashHelper TrashHelper = new TrashHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            TrashHelper.WaitForWorkAround(4000);

            //Click On Contact Tab
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            TrashHelper.WaitForWorkAround(4000);


            //Click to open client info
            //AddAccountHelper.ClickElement("ClickOnTrash");
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");
            TrashHelper.WaitForWorkAround(4000);

            TrashHelper.ClickElement("ClicOnTrashRecordViewPage");
            TrashHelper.WaitForWorkAround(4000);

            TrashHelper.ClickElement("ClickOnRestoreOption");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");
            TrashHelper.WaitForWorkAround(4000);

            TrashHelper.ClickElement("ClicOnTrashRecordViewPage");
            TrashHelper.WaitForWorkAround(4000);


            TrashHelper.ClickElement("ClickOnDeletesOption");

            TrashHelper.AcceptAlert();
            TrashHelper.WaitForWorkAround(4000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");
            TrashHelper.WaitForWorkAround(4000);

            TrashHelper.ClickElement("ClickOnBackButtons");

           

        }
    }
}