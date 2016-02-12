using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite

    {
        [TestClass]
        public class EmailTemplateTrashInboxPage : DriverTestCase
        {
            [TestMethod]
            public void emailtemplatetrashinboxpage()
            {
                string[] username = null;
                string[] password = null;

                XMLParse oXMLData = new XMLParse();
                oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

                username = oXMLData.getData("settings/Credentials", "username");
                password = oXMLData.getData("settings/Credentials", "password");

                //Initializing the objects
                LoginHelper loginHelper = new LoginHelper(GetWebDriver());
                EmailTemplatesHelper EmailTemplatesHelper = new EmailTemplatesHelper(GetWebDriver());


                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                EmailTemplatesHelper.WaitForWorkAround(4000);

                EmailTemplatesHelper.ClickElement("ClickOnActivitiestab");
                EmailTemplatesHelper.WaitForWorkAround(4000);

               GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/emailtemplates");
               EmailTemplatesHelper.WaitForWorkAround(4000);

               //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/emailtemplates/trash");
              // EmailTemplatesHelper.WaitForWorkAround(4000);

               EmailTemplatesHelper.ClickElement("ClickOnTrashButton");

               EmailTemplatesHelper.Select("RecordssPerPagee", "20");

               EmailTemplatesHelper.TypeText("SearchhFilterboxx", "Leads");

               EmailTemplatesHelper.ClickElement("ClickOnResetsbuttonn");

              
                //Delete and Restore Icons
                EmailTemplatesHelper.ClickElement("ClickOnDeleteIcon");

               EmailTemplatesHelper.AcceptAlert();
               EmailTemplatesHelper.WaitForWorkAround(4000);

               EmailTemplatesHelper.ClickElement("ClickOnRestoreIcon");

              // EmailTemplatesHelper.AcceptAlert();
              // EmailTemplatesHelper.WaitForWorkAround(4000);

                //View Page
               EmailTemplatesHelper.ClickElement("ClickOnFirstTrashRecord");

               EmailTemplatesHelper.ClickElement("ClickOnBackkbuttonn");

                //Bulk Actions--Delete Forever

               EmailTemplatesHelper.TypeText("SearchhFilterboxx", "Campaing details");

               EmailTemplatesHelper.MouseOver021("Locators");

               EmailTemplatesHelper.ClickElement("ClickOnDeleteForeverOption");

               EmailTemplatesHelper.AcceptAlert();
               EmailTemplatesHelper.WaitForWorkAround(3000);

                //Bulk Actions --Restore Template
               EmailTemplatesHelper.TypeText("SearchhFilterboxx", "Application details");

               EmailTemplatesHelper.MouseOver021("Locators");

               EmailTemplatesHelper.ClickElement("ClickOnRestoreTemplateOption");

               EmailTemplatesHelper.AcceptAlert();
               EmailTemplatesHelper.WaitForWorkAround(3000);

            }
        }
}
