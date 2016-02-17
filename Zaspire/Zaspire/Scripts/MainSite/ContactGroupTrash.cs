using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactGroupTrash : DriverTestCase
    {
        [TestMethod]
        public void contactgrouptrash()
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

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

         /*  // GroupTrashHelper.ClickElement("ClickOnBackButton");

            // Back Button functionality
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            //####################### Search Filter Option ############################

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            GroupTrashHelper.TypeText("SearchFilter", "new");
            GroupTrashHelper.WaitForWorkAround(5000);

            GroupTrashHelper.ClickElement("ClickOnResetButton");


            //######################## Delete forever functionality @@@@@@@@@@@@@@@@@@@

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            GroupTrashHelper.TypeText("SearchByGroupName", "AccountGroup1");

            GroupTrashHelper.ClickElement("SelectMasterCheckBox");

            GroupTrashHelper.MouseHover01("locator");

            //Click On View
            GroupTrashHelper.ClickElement("ClickOnDeleteForever");

            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(5000);

            // ############################ Restore functionaliy @@@@@@@@@@@@@@@@@@@@@@@@@
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            GroupTrashHelper.TypeText("SearchByZipCode", "56987");

            GroupTrashHelper.ClickElement("SelectMasterCheckBox");

            GroupTrashHelper.MouseHover01("locator");

          
            GroupTrashHelper.ClickElement("ClickOnRestoreGroups");

            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(7000);*/

          //######################## Record level Quick links @@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            //############## Delete forever @@@@@@@@@

            GroupTrashHelper.MouseHover02("Locator");
            
            //Click On Quick Link
            GroupTrashHelper.ClickElement("ClickOnQuickLink");
            GroupTrashHelper.WaitForWorkAround(3000);

            GroupTrashHelper.ClickElement("ClickOnDeleteForever");

            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(5000);

            //############### Restore Option @@@@@@@@@

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            GroupTrashHelper.MouseHover02("Locator");

            //Click On Quick Link
            GroupTrashHelper.ClickElement("ClickOnQuickLink");

            GroupTrashHelper.ClickElement("ClickOnRestore");

            // ################### Group Trash View Page @@@@@@@@@@@@@@@@@@@@@@@

            GroupTrashHelper.ClickElement("ClickOnTrashRecord");

        }
    }
}