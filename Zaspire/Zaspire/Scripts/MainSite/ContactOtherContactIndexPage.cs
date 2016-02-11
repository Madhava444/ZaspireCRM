using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactOtherContactIndexPage : DriverTestCase
    {
        [TestMethod]
        public void contactothercontactindexpage()
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

            //################## Search Functionality #########################

            addcontacHelper.TypeText("SearchByStatus", "New");

            addcontacHelper.ClickElement("ClickOnResetButton");

            addcontacHelper.TypeText("SearchByStatus", "New");

           

            //######################### Export Button ##########################

            addcontacHelper.ClickElement("ClickOnCsvbutton");

            addcontacHelper.ClickElement("ClickOnpdfbutton");

            //######################### Filter By Modules ########################
            
            
            addcontacHelper.Select("FilterByModule", "AllContacts");
            addcontacHelper.WaitForWorkAround(4000);

            //Leads Module
            addcontacHelper.Select("FilterByModule", "Leads");
            addcontacHelper.WaitForWorkAround(4000);

            //Accounts Module
            addcontacHelper.Select("FilterByModule", "Accounts");
            addcontacHelper.WaitForWorkAround(4000);

            //Opportunities Module
            addcontacHelper.Select("FilterByModule", "Opportunities");
            addcontacHelper.WaitForWorkAround(4000);

            //Partners Module
            addcontacHelper.Select("FilterByModule", "Partners");
            addcontacHelper.WaitForWorkAround(4000);

            //************ Records Per Page ***********************

            addcontacHelper.Select("RecordPerPage", "50");

            //############## View Page #####################

            addcontacHelper.TypeText("SearchByStatus", "New");

            addcontacHelper.ClickElement("ClickOnSelectedRecord");

           
        }
    }
}