using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite

    {
        [TestClass]
        public class EmailTemplateTrashViewPage : DriverTestCase
        {
            [TestMethod]
            public void emailtemplatetrashviewpage()
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

               EmailTemplatesHelper.ClickElement("ClickOnTrashButton");

               EmailTemplatesHelper.ClickElement("ClickOnFirsttTrashRecord");


               EmailTemplatesHelper.ClickElement("ClickOnRestoreButtonns");

               EmailTemplatesHelper.AcceptAlert();
               EmailTemplatesHelper.WaitForWorkAround(4000);

               EmailTemplatesHelper.ClickElement("ClickOnFirsttTtrashRecords");

               EmailTemplatesHelper.ClickElement("ClickOnDeleteButtonns");

               EmailTemplatesHelper.AcceptAlert();
               EmailTemplatesHelper.WaitForWorkAround(4000);


            }
        }
}