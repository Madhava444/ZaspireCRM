using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class IndexPage : DriverTestCase
    {
        [TestMethod]
        public void indexpage()
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

            //Click on Clients in Topmenu
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.TypeText("SearchByStatus", "New");

            addcontacHelper.ClickElement("ClickOnResetButton");

            //####################### Add New ###########################

            addcontacHelper.ClickElement("ClickOnAddNewButton");
            addcontacHelper.WaitForWorkAround(5000);

           //####################### Import Button ###################
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.MouseHover10("Locator");
            addcontacHelper.WaitForWorkAround(3000);

            //################## Filter By Tags ############
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);


            addcontacHelper.ClickElement("TagsClickOnResteButton");

            addcontacHelper.TypeText("FilterByTag", "New");


            addcontacHelper.ClickElement("Search");
            addcontacHelper.WaitForWorkAround(10000);

            //############# Custom View Link ##############

            

            addcontacHelper.ClickElement("ClickOnCustomViewLink");
            
            //Custom View Add New Link

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.ClickElement("ClickOnCustomViewAddNewLink");

            //Select Custom View drop down option

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.Select("CustomViewDropDown", "48");

            //################### Filter By Group ###########

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.ClickElement("ClickOnFilterByGroup");

            //Group By Drop down
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.Select("FilterByGroup", "group");

            //##################### Default View ###############

            addcontacHelper.Select("DefaultView", "AllContacts");
            addcontacHelper.WaitForWorkAround(4000);

            //My Contact
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.Select("DefaultView","MyContact");
            addcontacHelper.WaitForWorkAround(4000);

            //My Team Contact
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.Select("DefaultView","MyTeamContact");
            addcontacHelper.WaitForWorkAround(2000);

            //Recently Modified
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.Select("DefaultView","RecentlyModified");
            addcontacHelper.WaitForWorkAround(2000);

            //Recently Added
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.Select("DefaultView","RecentlyAdded");
            addcontacHelper.WaitForWorkAround(2000);

            //Recently Viewed
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.Select("DefaultView","RecentlyViewed");
            addcontacHelper.WaitForWorkAround(2000);


        //################## Quick Links ###########################

            addcontacHelper.MouseHover9("Locator");

            addcontacHelper.ClickElement("ClickOnQuickLinks");
            addcontacHelper.WaitForWorkAround(1000);

            addcontacHelper.ClickElement("ClickOnViewButton");
            addcontacHelper.WaitForWorkAround(4000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            //Quick Links_ Edit Button
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            

            addcontacHelper.ClickElement("ClickOnQuickLinks");
            addcontacHelper.WaitForWorkAround(1000);

            addcontacHelper.MouseHover9("Locator");

            addcontacHelper.ClickElement("ClickOnRecordEditButton");
            addcontacHelper.WaitForWorkAround(3000);

            addcontacHelper.ClickElement("ClickOnSaveButton");

            addcontacHelper.ClickElement("ContactsLink");
            addcontacHelper.WaitForWorkAround(2000);

         
            //Quick Links_Delete Button
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            

            addcontacHelper.ClickElement("ClickOnQuickLinks");
            addcontacHelper.WaitForWorkAround(1000);

            addcontacHelper.MouseHover9("Locator");

            addcontacHelper.ClickElement("ClickOnDeleteButton");
            addcontacHelper.WaitForWorkAround(3000);

            addcontacHelper.AcceptAlert();
            addcontacHelper.WaitForWorkAround(5000);

        }
    }
}