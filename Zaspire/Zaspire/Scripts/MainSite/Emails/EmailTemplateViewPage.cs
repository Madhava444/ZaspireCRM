using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite

    {
        [TestClass]
        public class EmailTemplateViewPage : DriverTestCase
        {
            [TestMethod]
            public void emailtemplateviewpage()
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

               EmailTemplatesHelper.ClickElement("ClickOnFirstRecords");

                //Edit Functionality

               EmailTemplatesHelper.ClickElement("ClickEditOptionss");

               EmailTemplatesHelper.ClickElement("ClickOnSaveOptionns");

                //New functionality
               EmailTemplatesHelper.ClickElement("ClickOnNewbuttonns");

               EmailTemplatesHelper.ClickElement("ClickOnCancelbuttons");

                //Copy functionality
               EmailTemplatesHelper.ClickElement("ClickOnCopyButtons");

               EmailTemplatesHelper.AcceptAlert();
               EmailTemplatesHelper.WaitForWorkAround(4000);

                //Delete functionality
               EmailTemplatesHelper.ClickElement("ClickOnDeleteButtons");

               EmailTemplatesHelper.AcceptAlert();
               EmailTemplatesHelper.WaitForWorkAround(4000);






            }
        }
}