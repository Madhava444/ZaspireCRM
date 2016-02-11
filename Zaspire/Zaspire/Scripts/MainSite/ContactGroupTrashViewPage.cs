using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactGroupTrashViewPage : DriverTestCase
    {
        [TestMethod]
        public void grouptrashviewpage()
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

            //Contact Page
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            GroupTrashHelper.WaitForWorkAround(3000);

            //Contact Trash
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            // Contact Group Trash
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            
            //#################View Page Back Button option#####################

            GroupTrashHelper.TypeText("SearchByGroupName", "New123");

            GroupTrashHelper.ClickElement("ClickOnFirstRecordOption");
            GroupTrashHelper.WaitForWorkAround(2000);

            //GroupTrashHelper.ClickElement("ClickOnBackButtonOption");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/trash");
            GroupTrashHelper.WaitForWorkAround(3000);

            //################# Restore Option ###############################

            GroupTrashHelper.TypeText("SearchByGroupName", "New123");

            GroupTrashHelper.ClickElement("ClickOnFirstRecordOption");
            GroupTrashHelper.WaitForWorkAround(2000);

            GroupTrashHelper.ClickElement("ClickOnRestoreButtonOptions");

            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(3000);

            //######################### Delete Option ##################
            GroupTrashHelper.TypeText("SearchByGroupName", "group1");

            GroupTrashHelper.ClickElement("ClickOnFirstRecordOption");
            GroupTrashHelper.WaitForWorkAround(2000);

            GroupTrashHelper.ClickElement("ClcikOnDeleteButtonOption");

            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(3000);

        }
    }
}