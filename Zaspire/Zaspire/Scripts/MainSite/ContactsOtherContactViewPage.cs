using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactsOtherContactViewPage : DriverTestCase
    {
        [TestMethod]
        public void contactothercontactviewpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var addcontacHelper = new AddContactHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);
            addcontacHelper.WaitForWorkAround(10000);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/allcontacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.TypeText("SearchByStatus", "New");

            addcontacHelper.ClickElement("ClickOnSelectedRecord");

            //######################## View Page ################################

           //*****Back Button
            addcontacHelper.ClickElement("ClickOnBackButtonOption");


            //******Edit Button Option
            addcontacHelper.TypeText("SearchByStatus", "New");

            addcontacHelper.ClickElement("ClickOnSelectedRecord");

            addcontacHelper.ClickElement("ClickOnEditButton");

            addcontacHelper.ClickElement("ClickOnUpdateButton");

            addcontacHelper.AcceptAlert();
            addcontacHelper.WaitForWorkAround(2000);

            //********Related To Link
            addcontacHelper.ClickElement("ClickOnRelatedToLink");
        }
    }
}