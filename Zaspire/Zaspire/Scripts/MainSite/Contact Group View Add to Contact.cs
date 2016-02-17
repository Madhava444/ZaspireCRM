using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactGroupViewAddtoContact : DriverTestCase
    {
        [TestMethod]
        public void contactgroupviewaddcontact()
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

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            GroupTrashHelper.WaitForWorkAround(7000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups");
            GroupTrashHelper.WaitForWorkAround(7000);

            //*********************** View Page ************************

            GroupTrashHelper.TypeText("FilerSearchBoxx", "new Group 1156");

            GroupTrashHelper.ClickElement("ClickOnFirstRecord");

            //GroupTrashHelper.ClickElement("ClickOnAddContactsButton");
            //GroupTrashHelper.WaitForWorkAround(2000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/addcontacts/12");
            GroupTrashHelper.WaitForWorkAround(7000);

            // *********************** Add Contacts Page **************

            GroupTrashHelper.TypeText("FilterSearchBySource", "Email");
            GroupTrashHelper.WaitForWorkAround(2000);

            GroupTrashHelper.ClickElement("ClickOnResetFunction");
            GroupTrashHelper.WaitForWorkAround(2000);

           
            //GroupTrashHelper.TypeText("FilterSearchBySource", "Email");


            GroupTrashHelper.ClickElement("ClickOnMastersCheckbox");

            GroupTrashHelper.ClickElement("ClickOnAddtoGroupOption");
            GroupTrashHelper.WaitForWorkAround(5000);

            //GroupTrashHelper.ClickElement("ClickOnBacksOption");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups");
            GroupTrashHelper.WaitForWorkAround(7000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/view/12");
            GroupTrashHelper.WaitForWorkAround(7000);

            //GroupTrashHelper.ClickElement("ClickOnAddtoContactOption");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/addcontacts/12");
            GroupTrashHelper.WaitForWorkAround(7000);

            GroupTrashHelper.Select("RecordsPerPage", "20");


            //***************** Cancel Option ********************

            GroupTrashHelper.TypeText("FilerSearchBox", "new Group 1156");

            GroupTrashHelper.ClickElement("ClickOnFirstRecord");

            GroupTrashHelper.ClickElement("ClickOnAddContactsButton");

            GroupTrashHelper.ClickElement("ClickOnCancellOption");

            //*************** Custom View ************************

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/addcontacts/12");
            GroupTrashHelper.WaitForWorkAround(7000);

            GroupTrashHelper.Select("CustomView", "113");
            GroupTrashHelper.WaitForWorkAround(5000);

           

        }
    }
}