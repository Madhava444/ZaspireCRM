using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactGroupCreatePage : DriverTestCase
    {
        [TestMethod]
        public void contactgroupcreatepage()
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
            GroupTrashHelper.WaitForWorkAround(3000);

            //AddAccountHelper.ClickElement("ClickOnGroupTrashOption");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups");
            GroupTrashHelper.WaitForWorkAround(3000);

            GroupTrashHelper.ClickElement("ClickOnAddNewButtons");

            GroupTrashHelper.TypeText("Name", "NewContactGroup1");

            GroupTrashHelper.TypeText("City", "Kentucky");

            GroupTrashHelper.Select("State", "AR");

            GroupTrashHelper.Select("Country", "USA");

            GroupTrashHelper.TypeText("ZipCode", "60601");

            //GroupTrashHelper.TypeText("Description", "This is sample Group creation");

            GroupTrashHelper.ClickElement("ClickOnSaveButtonsOption");

            // ***********Cancel Functionality************

            GroupTrashHelper.ClickElement("ClickOnAddNewButtons");

            GroupTrashHelper.ClickElement("ClickOnCancelsOption");

            // ############ Permission Functionality ################

            GroupTrashHelper.ClickElement("ClickOnAddNewButtons");

            GroupTrashHelper.ClickElement("ClickOnPermissionButton");

            GroupTrashHelper.ClickElement("EnableTheCheckBoxes");

            GroupTrashHelper.ClickElement("ClickOnCancelsOptions");




        }
    }
}