using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class EmailInboxpage : DriverTestCase
    {
        [TestMethod]
        public void emailinboxpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            EmailHelper EmailHelper = new EmailHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            EmailHelper.WaitForWorkAround(4000);

            EmailHelper.ClickElement("ClickOnActivitiestab");

            EmailHelper.ClickElement("ClickOnEmailbutton");

            //Email selections

            EmailHelper.Select("EmailSelections", "my");

            //Inbox view page

     /*       EmailHelper.TypeText("SearchFilter", "Harrison");

            EmailHelper.ClickElement("ClickOnFirstEmail");

            EmailHelper.ClickElement("ClickOnbackbuttons");

            // Delete functionality

            EmailHelper.TypeText("SearchFilter", "New email");
            EmailHelper.WaitForWorkAround(2000);

            EmailHelper.ClickElement("ClickOnFirstCheckbox");

            EmailHelper.MouseHover011("Locator");

            EmailHelper.ClickElement("ClickOnTrashButton");

            EmailHelper.AcceptAlert();
            EmailHelper.WaitForWorkAround(5000); */


            // Email Create New Label

            EmailHelper.TypeText("SearchFilter", "test mail");
            EmailHelper.WaitForWorkAround(5000);

            EmailHelper.ClickElement("ClickOnFirstCheckbox1");
            EmailHelper.WaitForWorkAround(5000);

            EmailHelper.MouseHover012("Locators");
            EmailHelper.WaitForWorkAround(3000);

             EmailHelper.ClickElement("ClickOnCreateLabel");
            EmailHelper.WaitForWorkAround(3000);

            EmailHelper.TypeText("Name", "Folder1");
            EmailHelper.WaitForWorkAround(2000);

            EmailHelper.ClickElement("ClickOnMoveOption");
            EmailHelper.WaitForWorkAround(3000);

            // Push to Archive folder

            EmailHelper.TypeText("SearchFilter", "company8");

            EmailHelper.ClickElement("ClickOnFirstCheckbox2");

            EmailHelper.MouseHover012("Locators");

            EmailHelper.ClickElement("ClickOnArchivefolder");


        }
    }
}